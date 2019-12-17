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
    public class ParametrosController : Controller
    {
        private readonly IParametrosRepository _parametrosRepository;
        private readonly AutoMapper.IMapper _mapper;

        public ParametrosController(IParametrosRepository parametrosRepository)
        {
            _parametrosRepository = parametrosRepository;
            var m = new AutoMapper.MapperConfiguration(c =>
            {
                c.CreateMap<Model.ParametrosMVC, DTO.DTOParametros>();
            });
            _mapper = m.CreateMapper();
        }

        // GET: Parametros
        public IActionResult Index()
        {
            ViewData["controller"] = "Parametros";
            ViewData["action"] = "";
            var search = ParseToListMVC(_parametrosRepository.GetAll());
            return View(search.ToList());
        }

        // GET: Parametros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ViewData["controller"] = "Parametros";
            ViewData["action"] = "Detalles";
            if (id == null)
            {
                return NotFound();
            }

            var parametro = await _parametrosRepository.GetByIdAsync(id.Value);
            if (parametro == null)
            {
                return NotFound();
            }

            return View(ParseToMVC(parametro));
        }

        // GET: Parametros/Create
        public IActionResult Create()
        {
            ViewData["controller"] = "Parametros";
            ViewData["action"] = "Nuevo";
            return View();
        }

        // POST: Parametros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Valor1,Valor2")] Fondo.Web.Model.ParametrosMVC parametros)

        {
            ViewData["controller"] = "Parametros";
            ViewData["action"] = "Nuevo";
            if (ModelState.IsValid)
            {
                await _parametrosRepository.CreateAsync(ParseToDTO(parametros));
                return RedirectToAction(nameof(Index));
            }
            return View(parametros);
        }

        // GET: Parametros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["controller"] = "Parametros";
            ViewData["action"] = "Editar";
            if (id == null)
            {
                return NotFound();
            }

            var parametros = await _parametrosRepository.GetByIdAsync(id.Value);
            if (parametros == null)
            {
                return NotFound();
            }
            return View(ParseToMVC(parametros));
        }

        // POST: Parametros/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Valor1,Valor2")] Model.ParametrosMVC parametros)
        {
            ViewData["controller"] = "Parametros";
            ViewData["action"] = "Editar";
            if (id != parametros.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _parametrosRepository.UpdateAsync(ParseToDTO(parametros));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParametrosExists(parametros.Id))
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
            return View(parametros);
        }

        // GET: Parametros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            ViewData["controller"] = "Parametros";
            ViewData["action"] = "Eliminar";
            if (id == null)
            {
                return NotFound();
            }

            var parametros = await _parametrosRepository.GetByIdAsync(id.Value);
            if (parametros == null)
            {
                return NotFound();
            }

            return View(ParseToMVC(parametros));
        }

        // POST: Parametros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            ViewData["controller"] = "Parametros";
            ViewData["action"] = "Eliminar";
            await _parametrosRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private bool ParametrosExists(int id)
        {
            return _parametrosRepository.Get(x => x.Id == id).Count() > 0;
        }

        private Model.ParametrosMVC ParseToMVC(DTO.DTOParametros dto)
        {
            return _mapper.Map<DTO.DTOParametros, Model.ParametrosMVC>(dto);
        }

        private DTO.DTOParametros ParseToDTO(Model.ParametrosMVC mvc)
        {
            return _mapper.Map<Model.ParametrosMVC, DTO.DTOParametros>(mvc);
        }

        private IEnumerable<Model.ParametrosMVC> ParseToListMVC(IEnumerable<DTO.DTOParametros> dto)
        {
            return _mapper.Map<IEnumerable<DTO.DTOParametros>, IEnumerable<Model.ParametrosMVC>>(dto);
        }

        private IQueryable<DTO.DTOParametros> ParseToListDTO(IQueryable<Model.ParametrosMVC> mvc)
        {
            return _mapper.Map<IQueryable<Model.ParametrosMVC>, IQueryable<DTO.DTOParametros>>(mvc);
        }

    }
}
