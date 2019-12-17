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
    public class ConsignacionesController : Controller
    {
        private readonly IConsignacionRepository _consignacionRepository;
        private readonly IPersonaRepository _personaRepository;
        private readonly IPrestamoRepository _prestamoRepository;
        private readonly IParametrosRepository _parametrosRepository;
        private readonly AutoMapper.IMapper _mapper;

        private const string _controller = "Consignaciones";

        public ConsignacionesController(IConsignacionRepository consignacionRepository, IPersonaRepository personaRepository, IPrestamoRepository prestamoRepository, IParametrosRepository parametrosRepository)
        {
            _consignacionRepository = consignacionRepository;
            _personaRepository = personaRepository;
            _prestamoRepository = prestamoRepository;
            _parametrosRepository = parametrosRepository;
            var m = new AutoMapper.MapperConfiguration(c =>
            {
                c.CreateMap<Model.ConsignacionMVC, DTO.ConsignacionDTO>();
            });
            _mapper = m.CreateMapper();


        }

        // GET: Consignaciones
        public IActionResult Index()
        {
            var anhoParametrizado = _parametrosRepository.Get(x => x.Nombre.Equals("año")).FirstOrDefault();
            var search = ParseToListMVC(_consignacionRepository.GetConsignaciones(Convert.ToInt32(anhoParametrizado.Valor1), new string[] { "Persona" }));
            ViewData["controller"] = _controller;
            ViewData["action"] = "";
            return View(search);
        }

        // GET: Consignaciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consignacion = await _consignacionRepository.GetByIdAsync(id.Value);
            if (consignacion == null)
            {
                return NotFound();
            }

            return View(ParseToMVC(consignacion));
        }

        // GET: Consignaciones/CreateSavings
        public IActionResult Create(int? id)
        {
            //id == 1 consignaciones prestamo
            //id == 2 consignaicones ahorro

            //Consignaicones prestmo
            //Personas con prestamos activas
            if (id == 1)
            {
                ViewData["personas"] = new SelectList(_prestamoRepository.GetPersonasPrestamoActivoSelectList(), "Key", "Value");

            }

            //Consignacion ahorro 
            //Personas activas y del fondo
            else
            {
                ViewData["personas"] = new SelectList(_personaRepository.getFondoActivos(), "Key", "Value");
            }

            var parametroAnho = _parametrosRepository.Get(x => x.Nombre.Equals("año")).FirstOrDefault();
            ViewData["controller"] = _controller;
            ViewData["action"] = "Nuevo";
            Model.ConsignacionMVC consignacion = new Model.ConsignacionMVC();
            consignacion.TipoConsignacion = Convert.ToByte(id.Value);
            consignacion.Fecha = DateTime.Today;
            consignacion.FechaRegistro = DateTime.Today;
            consignacion.Id = 0;
            return View(consignacion);
        }

        // POST: Consignaciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PersonaId,TipoConsignacion,Valor,Interes,Fecha,FechaStr,FechaRegistro,YearParameter")] Model.ConsignacionMVC consignacion)
        {
            if (!FechaValidator(consignacion.Fecha))
            {
                ModelState.AddModelError("Fecha", "La fecha seleccionada no pertenece al año parametrizado");
            }
            
            if (ModelState.IsValid)
            {
                consignacion.Id = 0;

                var prestamoActivo = _prestamoRepository.GetPrestamoActivoPersona(consignacion.PersonaId);
                consignacion.PrestamoId = prestamoActivo.Id;
                
                await _consignacionRepository.CreateAsync(_mapper.Map<Model.ConsignacionMVC, DTO.ConsignacionDTO>(consignacion));

                return RedirectToAction(nameof(Index));
            }
            if (consignacion.TipoConsignacion == 1)
            {
                ViewData["personas"] = new SelectList(_prestamoRepository.GetPersonasPrestamoActivoSelectList(), "Key", "Value");

            }
            //Consignacion ahorro 
            //Personas activas y del fondo
            else
            {
                ViewData["personas"] = new SelectList(_personaRepository.getFondoActivos(), "Key", "Value");
            }


            ViewData["controller"] = _controller;
            ViewData["action"] = "Nuevo";
            return View(consignacion);
        }

        

        // GET: Consignaciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consignacion = await _consignacionRepository.GetByIdAsync(id.Value);
            if (consignacion == null)
            {
                return NotFound();
            }
            if (consignacion.TipoConsignacion == 1)
            {
                ViewData["personas"] = new SelectList(_prestamoRepository.GetPersonasPrestamoActivoSelectList(), "Key", "Value");

            }
            //Consignacion ahorro 
            //Personas activas y del fondo
            else
            {
                ViewData["personas"] = new SelectList(_personaRepository.getFondoActivos(), "Key", "Value");
            }

            return View(ParseToMVC(consignacion));
        }

        // POST: Consignaciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdPersona,TipoConsignacion,Valor,Fecha,FechaRegistro")]  Model.ConsignacionMVC consignacion)
        {
            var prestamoActivo = _prestamoRepository.GetPrestamoActivoPersona(consignacion.PersonaId);
            if(consignacion.TipoConsignacion == 1)
            {
                if (null != prestamoActivo && prestamoActivo.Finalizado)
                {
                    ModelState.AddModelError("", "La consignación seleccionada no se puede editar porque el prestamo está finalizado");
                }
                else if (null == prestamoActivo)
                {
                    ModelState.AddModelError("", "La consignación no se puede editar por que no existe un prestamo vigente");
                }
                
            }
            if (id != consignacion.Id)
            {
                return NotFound();
            }
            if (FechaValidator(consignacion.Fecha))
            {
                ModelState.AddModelError("Fecha", "La fecha seleccionada no pertenece al año parametrizado");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _consignacionRepository.UpdateAsync(ParseToDTO(consignacion));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsignacionExists(consignacion.Id))
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
            if (consignacion.TipoConsignacion == 1)
            {
                ViewData["personas"] = new SelectList(_prestamoRepository.GetPersonasPrestamoActivoSelectList(), "Key", "Value");

            }
            //Consignacion ahorro 
            //Personas activas y del fondo
            else
            {
                ViewData["personas"] = new SelectList(_personaRepository.getFondoActivos(), "Key", "Value");
            }
            return View(consignacion);
        }

        // GET: Consignaciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consignacion = await _consignacionRepository.GetByIdAsync(x => x.Id == id, new string[] { "Persona" });
            if (consignacion == null)
            {
                return NotFound();
            }

            return View(ParseToMVC(consignacion));
        }

        // POST: Consignaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            await _consignacionRepository.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Get the ammount of the customer will save
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("consignaciones/montoAhorro/{id}")]
        public async Task<JsonResult> MontoAhorroAsync(int id)
        {
            var cliente = await _personaRepository.GetByIdAsync(id);
            var ahorro = cliente.MontoAhorro;
            return new JsonResult(ahorro);
        }

        /// <summary>
        /// Get all info of the loan including consignments
        /// </summary>
        /// <param name="id">the person id of the active loan</param>
        /// <returns></returns>
        [HttpGet]
        [Route("consignaciones/infoPrestamo/{id}")]
        public JsonResult GetInfoPrestamo(int id)
        {
            var prestamoActivo = _prestamoRepository.GetPrestamoActivoPersona(id);
            var consignaciones = _consignacionRepository.Get(x => x.PrestamoId == prestamoActivo.Id);
            var abonado = consignaciones.Where(x => x.TipoConsignacion == 1).Sum(x => x.Valor);
            var info = new
            {
                fecha = prestamoActivo.Fecha.ToString("yyyy-MM-dd"),
                prestamo = prestamoActivo.Valor,
                abonado,
                saldo = prestamoActivo.Valor - abonado,
                intereses = consignaciones.Where(x => x.TipoConsignacion == 1).Sum(x => x.Interes)
            };
            return new JsonResult(info);
        }

        [HttpGet]
        [Route("consignaciones/calculoInteres/{id}")]
        public JsonResult GetInteresPendiente(int id)
        {
            var prestamoActivo = _prestamoRepository.GetPrestamoActivoPersona(id);
            var consignaciones = _consignacionRepository.Get(x => x.PrestamoId == prestamoActivo.Id);
            var abonado = consignaciones.Where(x => x.TipoConsignacion == 1).Sum(x => x.Valor);
            var abonadoInteres = consignaciones.Where(x => x.TipoConsignacion == 1).Sum(x => x.Interes);

            DateTime ultimoPagoInteres = DateTime.Today;
            if(abonadoInteres.HasValue && abonadoInteres.Value >0)
            {
                ultimoPagoInteres = consignaciones.Where(x => x.Interes.HasValue && x.Interes.Value > 0).Max(x => x.Fecha);
            }

            var diffDias = ultimoPagoInteres - prestamoActivo.Fecha;
            var mesesPendientes = Math.Ceiling((double)(diffDias.Days / 30))-1;
            double? interesPendiente = 0;
            if (mesesPendientes > 0)
            {
                interesPendiente = (prestamoActivo.Valor - abonado) * (prestamoActivo.Interes / 100) * mesesPendientes;
            }
            
            return new JsonResult(interesPendiente);
        }

        public IActionResult Search(string id)
        {
            ViewData["controller"] = "Prestamos";
            ViewData["action"] = "Buscar";
            var anhoParametrizado = _parametrosRepository.Get(x => x.Nombre.Equals("año")).FirstOrDefault();
            var consignacionList = _consignacionRepository.GetConsignaciones(Convert.ToInt32(anhoParametrizado.Valor1), new string[] { "Persona" });
            consignacionList = consignacionList.Where(x => x.Persona.Apellidos.ToLower().Contains(id.ToLower()) || x.Persona.Cedula.Contains(id) || x.Persona.Nombres.ToLower().Contains(id.ToLower())
            || x.Persona.CorreoElectronico.ToLower().Contains(id.ToLower()) || x.Persona.Banco.ToLower().Contains(id.ToLower()));
            var search = ParseToListMVC(consignacionList);
            return View(search.ToList());
        }

        #region Privates
        private bool ConsignacionExists(int id)
        {
            return _consignacionRepository.Get(x => x.Id == id).Count() > 0;
        }

        private Model.ConsignacionMVC ParseToMVC(DTO.ConsignacionDTO dto)
        {
            return _mapper.Map<DTO.ConsignacionDTO, Model.ConsignacionMVC>(dto);
        }

        private DTO.ConsignacionDTO ParseToDTO(Model.ConsignacionMVC mvc)
        {
            return _mapper.Map<Model.ConsignacionMVC, DTO.ConsignacionDTO>(mvc);
        }

        private IEnumerable<Model.ConsignacionMVC> ParseToListMVC(IEnumerable<DTO.ConsignacionDTO> dto)
        {
            return _mapper.Map<IEnumerable<DTO.ConsignacionDTO>, IEnumerable<Model.ConsignacionMVC>>(dto);
        }

        private IQueryable<DTO.ConsignacionDTO> ParseToListDTO(IQueryable<Model.ConsignacionMVC> mvc)
        {
            return _mapper.Map<IQueryable<Model.ConsignacionMVC>, IQueryable<DTO.ConsignacionDTO>>(mvc);
        }
        /// <summary>
        /// Validate whether date is't in the same of the date configured
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        private bool FechaValidator(DateTime fecha)
        {
            var anhoParametrizado = _parametrosRepository.Get(x => x.Nombre.Equals("año")).FirstOrDefault();
            return fecha.Year == Convert.ToInt32( anhoParametrizado.Valor1);
        }
        #endregion

    }
}
