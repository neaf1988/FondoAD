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
    public class PersonasController : Controller
    {
       
        private readonly IPersonaRepository _personaRepository;
        private readonly AutoMapper.IMapper _mapper;

        public PersonasController(IPersonaRepository personaRepository)
        {
           

            _personaRepository = personaRepository;
            var m = new AutoMapper.MapperConfiguration(c =>
            {
                c.CreateMap<Model.PersonaMVC, DTO.PersonaDTO>();
            });
            _mapper = m.CreateMapper();
        }

        // GET: Personas
        public IActionResult Index()
        {
            ViewData["controller"] = "Personas";
            ViewData["action"] = "";
            var search = ParseToListMVC(_personaRepository.GetAll());
            return View(search.ToList());
        }

        // GET: Personas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ViewData["controller"] = "Personas";
            ViewData["action"] = "Detalles";
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _personaRepository.GetByIdAsync(x=>x.Id == id.Value, new string[] { "Prestamos","Consignaciones" });
            if (persona == null)
            {
                return NotFound();
            }

            ViewBag.totalAhorrado = persona.Consignaciones.Where(x => x.TipoConsignacion == 2).Sum(x => x.Valor);
            
            ViewBag.prestamo = persona.Prestamos.Where(x => !x.Finalizado).Select(x => x.Valor).FirstOrDefault();
            ViewBag.abonado = persona.Consignaciones.Where(x => x.TipoConsignacion == 1).Sum(x => x.Valor);
            ViewBag.saldo = ViewBag.prestamo - ViewBag.abonado;
            ViewBag.montoAhorro = string.Format("{0:c}", persona.MontoAhorro);

            return View(ParseToMVC(persona));
        }

        // GET: Personas/Create
        public IActionResult Create()
        {
            
            ViewData["Quincenas"] = new SelectList(_personaRepository.getQuincenaSelectList(), "Key", "Value");
            ViewData["controller"] = "Personas";
            ViewData["action"] = "Nuevo";
            return View();
        }

        // POST: Personas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Cedula,Nombres,Apellidos,Telefono,Direccion,CorreoElectronico,Activo,Banco,NumeroCuenta,MontoAhorro,Afiliado,FechaNacimiento,Quincena")] Model.PersonaMVC persona)
        {
            ViewData["Quincenas"] = new SelectList(_personaRepository.getQuincenaSelectList(), "Key", "Value");
            ViewData["controller"] = "Personas";
            ViewData["action"] = "Nuevo";
            if (ModelState.IsValid)
            {
                await _personaRepository.CreateAsync(ParseToDTO(persona));
                return RedirectToAction(nameof(Index));
            }
            return View(persona);
        }

        // GET: Personas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["Quincenas"] = new SelectList(_personaRepository.getQuincenaSelectList(), "Key", "Value");
            ViewData["controller"] = "Personas";
            ViewData["action"] = "Editar";
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _personaRepository.GetByIdAsync(id.Value);
            if (persona == null)
            {
                return NotFound();
            }
            return View(ParseToMVC(persona));
        }

        // POST: Personas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Cedula,Nombres,Apellidos,Telefono,Direccion,CorreoElectronico,Activo,Banco,NumeroCuenta,MontoAhorro,Afiliado,FechaNacimiento,Quincena")] Model.PersonaMVC persona)
        {
            ViewData["Quincenas"] = new SelectList(_personaRepository.getQuincenaSelectList(), "Key", "Value");
            ViewData["controller"] = "Personas";
            ViewData["action"] = "Editar";
            if (id != persona.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _personaRepository.UpdateAsync(ParseToDTO(persona));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonaExists(persona.Id))
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
            return View(persona);
        }

        // GET: Personas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            ViewData["controller"] = "Personas";
            ViewData["action"] = "Eliminar";
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _personaRepository.GetByIdAsync(id.Value);
            if (persona == null)
            {
                return NotFound();
            }

            return View(ParseToMVC(persona));
        }

        // POST: Personas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            ViewData["controller"] = "Personas";
            ViewData["action"] = "Eliminar";
            await _personaRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Search(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return RedirectToAction("Index");
            }
            ViewData["controller"] = "Personas";
            ViewData["action"] = "Buscar";
           
            var personasList = _personaRepository.Get(x => x.Apellidos.ToLower().Contains(id.ToLower()) || x.Cedula.Contains(id) || x.Nombres.ToLower().Contains(id.ToLower())
            || x.CorreoElectronico.ToLower().Contains(id.ToLower()) || x.Banco.ToLower().Contains(id.ToLower()));
            var search = ParseToListMVC(personasList);
            return View(search.ToList());
        }

        #region Privates
        private bool PersonaExists(int id)
        {
            return _personaRepository.Get(x => x.Id == id).Count() > 0;
        }

        private Model.PersonaMVC ParseToMVC(DTO.PersonaDTO dto)
        {
            return _mapper.Map<DTO.PersonaDTO, Model.PersonaMVC>(dto);
        }

        private DTO.PersonaDTO ParseToDTO(Model.PersonaMVC mvc)
        {
            return _mapper.Map<Model.PersonaMVC, DTO.PersonaDTO>(mvc);
        }

        private IEnumerable<Model.PersonaMVC> ParseToListMVC(IEnumerable<DTO.PersonaDTO> dto)
        {
            return _mapper.Map<IEnumerable<DTO.PersonaDTO>, IEnumerable<Model.PersonaMVC>>(dto);
        }

        private IQueryable<DTO.PersonaDTO> ParseToListDTO(IQueryable<Model.PersonaMVC> mvc)
        {
            return _mapper.Map<IQueryable<Model.PersonaMVC>, IQueryable<DTO.PersonaDTO>>(mvc);
        }
        #endregion
        
    }
}
