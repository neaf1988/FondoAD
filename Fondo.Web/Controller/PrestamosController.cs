using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fondo.DAL;
using Fondo.Domain;

namespace Fondo.Web
{
    public class PrestamosController : Controller
    {
        private readonly IPrestamoRepository _prestamoRepository;
        private readonly IPersonaRepository _personaRepository;

        private readonly IParametrosRepository _parametrosRepository;
        private readonly AutoMapper.IMapper _mapper;

        public PrestamosController(IPrestamoRepository prestamoRepository, IPersonaRepository personaRepository, IParametrosRepository parametrosRepository)
        {
            _prestamoRepository = prestamoRepository;
            _personaRepository = personaRepository;
            _parametrosRepository = parametrosRepository;
            var m = new AutoMapper.MapperConfiguration(c =>
            {
                c.CreateMap<Model.PrestamoMVC, DTO.PrestamoDTO>();
            });
            _mapper = m.CreateMapper();
        }

        // GET: Prestamos
        public IActionResult Index()
        {
            ViewData["controller"] = "Prestamos";
            ViewData["action"] = "";
            var anhoParametrizado = _parametrosRepository.Get(x => x.Nombre.Equals("año")).FirstOrDefault();
            var prestamos = _prestamoRepository.Get(x=>x.Fecha.Year == Convert.ToInt32(anhoParametrizado.Valor1), new string[] { "Persona" });
            var search = ParseToListMVC(prestamos);
            return View(search);
        }

        // GET: Prestamos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ViewData["controller"] = "Prestamos";
            ViewData["action"] = "Detalles";
            if (id == null)
            {
                return NotFound();
            }

            var prestamo = await _prestamoRepository.GetByIdAsync(x=>x.Id==id,new string[] { "Persona" });
            if (prestamo == null)
            {
                return NotFound();
            }

            return View(ParseToMVC(prestamo));
        }

        // GET: Prestamos/Create
        public IActionResult Create()
        {
            ViewData["controller"] = "Prestamos";
            ViewData["action"] = "Nuevo";
            
            ViewData["personas"] = new SelectList(_personaRepository.getActivos(), "Key", "Value");
            ViewData["intereses"] = new SelectList(_prestamoRepository.GetInteresSelectList(), "Key", "Value");
            ViewData["hoy"] = System.DateTime.Now.ToShortDateString();
            return View();
        }

        // POST: Prestamos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PersonaId,Valor,Interes,Fecha,FechaRegistro")] Model.PrestamoMVC prestamo)
        {

            ViewData["controller"] = "Prestamos";
            ViewData["action"] = "Nuevo";

            var prestamoActivo =_prestamoRepository.GetPrestamoActivoPersona(prestamo.PersonaId);
            if(null != prestamoActivo)
            {
                ModelState.AddModelError(string.Empty, "Ya existe un prestamo vigente para el usuario seleccionado");
            }
            if (FechaValidator(prestamo.Fecha))
            {
                ModelState.AddModelError("Fecha", "La fecha seleccionada no pertenece al año parametrizado");
            }
            if (ModelState.IsValid)
            {
                await _prestamoRepository.CreateAsync(ParseToDTO(prestamo));
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdPersona"] = new SelectList(_prestamoRepository.GetAll(), "IdPersona", "Apellidos", prestamo.PersonaId);
            return View(prestamo);
        }

        // GET: Prestamos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["controller"] = "Prestamos";
            ViewData["action"] = "Editar";
            if (id == null)
            {
                return NotFound();
            }

            var prestamo = await _prestamoRepository.GetByIdAsync(id.Value);
            if (prestamo == null)
            {
                return NotFound();
            }
            ViewData["personas"] = new SelectList(_personaRepository.getActivos(), "Key", "Value", prestamo.PersonaId);
            return View(ParseToMVC(prestamo));
        }

        // POST: Prestamos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PersonaId,Valor,Interes,Fecha,FechaRegistro")] Model.PrestamoMVC prestamo)
        {
            ViewData["controller"] = "Prestamos";
            ViewData["action"] = "Editar";
            
            if (id != prestamo.Id)
            {
                return NotFound();
            }
            if (FechaValidator(prestamo.Fecha))
            {
                ModelState.AddModelError("Fecha", "La fecha seleccionada no pertenece al año parametrizado");
            }
            if (ModelState.IsValid)
            {
                try
                {
                    
                    await _prestamoRepository.UpdateAsync(ParseToDTO(prestamo));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrestamoExists(prestamo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdPersona"] = new SelectList(_personaRepository.GetAll(), "IdPersona", "Apellidos", prestamo.PersonaId);
            return View(prestamo);
        }

        // GET: Prestamos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            ViewData["controller"] = "Prestamos";
            ViewData["action"] = "Eliminar";
            if (id == null)
            {
                return NotFound();
            }

            var prestamo = await _prestamoRepository.GetByIdAsync(x => x.Id == id, new string[] { "Persona" });
            if (prestamo == null)
            {
                return NotFound();
            }

            return View(ParseToMVC(prestamo));
        }

        // POST: Prestamos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            ViewData["controller"] = "Prestamos";
            ViewData["action"] = "Eliminar";
            await _prestamoRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
        /// <summary>
        /// Get the taxes pacted from the loan
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("prestamos/prestamoPactado/{id}")]
        public JsonResult PrestamoPactado(int id)
        {
            var interes = _prestamoRepository.GetInteresPactado(id);
            return new JsonResult(interes);
        }

        public IActionResult Search(string id)
        {
            ViewData["controller"] = "Prestamos";
            ViewData["action"] = "Buscar";

            var anhoParametrizado = _parametrosRepository.Get(x => x.Nombre.Equals("año")).FirstOrDefault();
            var prestamosList = _prestamoRepository.Get(x => x.Fecha.Year == Convert.ToInt32(anhoParametrizado.Valor1), new string[] { "Persona" });
            prestamosList = prestamosList.Where(x => x.Persona.Apellidos.ToLower().Contains(id.ToLower()) || x.Persona.Cedula.Contains(id) || x.Persona.Nombres.ToLower().Contains(id.ToLower())
            || x.Persona.CorreoElectronico.ToLower().Contains(id.ToLower()) || x.Persona.Banco.ToLower().Contains(id.ToLower()));
            var search = ParseToListMVC(prestamosList);
            return View(search.ToList());
        }

        #region Privates
        private bool PrestamoExists(int id)
        {
            return _prestamoRepository.Get(x => x.Id == id).Count() > 0;
        }

        private Model.PrestamoMVC ParseToMVC(DTO.PrestamoDTO dto)
        {
            return _mapper.Map<DTO.PrestamoDTO, Model.PrestamoMVC>(dto);
        }

        private DTO.PrestamoDTO ParseToDTO(Model.PrestamoMVC mvc)
        {
            return _mapper.Map<Model.PrestamoMVC, DTO.PrestamoDTO>(mvc);
        }

        private IEnumerable<Model.PrestamoMVC> ParseToListMVC(IEnumerable<DTO.PrestamoDTO> dto)
        {
            return _mapper.Map<IEnumerable<DTO.PrestamoDTO>, IEnumerable<Model.PrestamoMVC>>(dto);
        }

        private IQueryable<DTO.PrestamoDTO> ParseToListDTO(IQueryable<Model.PrestamoMVC> mvc)
        {
            return _mapper.Map<IQueryable<Model.PrestamoMVC>, IQueryable<DTO.PrestamoDTO>>(mvc);
        }
        /// <summary>
        /// Validate whether date is't in the same of the date configured
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        private bool FechaValidator(DateTime fecha)
        {
            var anhoParametrizado = _parametrosRepository.Get(x => x.Nombre.Equals("año")).FirstOrDefault();
            return fecha.Year == Convert.ToInt32(anhoParametrizado.Valor1);
        }
        #endregion
    }
}
