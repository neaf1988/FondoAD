using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fondo.DAL;
using Fondo.DTO;
using Microsoft.EntityFrameworkCore;

namespace Fondo.Domain
{
    public class PrestamoRepository : GenericRepository<DAL.Prestamo, PrestamoDTO>, IPrestamoRepository
    {

        DbContextOptions<FondoContext> _contextOptions;
        private AutoMapper.IMapper _mapper;

        public PrestamoRepository(DbContextOptions<FondoContext> contextOptions) : base(contextOptions)
        {
            _contextOptions = contextOptions;
            var m = new AutoMapper.MapperConfiguration(c =>
            {
                c.CreateMap<Prestamo, PrestamoDTO>().ReverseMap();
                
                 //Ignoring the property of the destination type
                    //.ForMember(dest => dest., act => act.Ignore());
                
                
            });
            _mapper = m.CreateMapper();

            
        }

        public List<KeyValuePair<string, string>> GetPersonasSelectList(IEnumerable<PersonaDTO> personas)
        {

            var list = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>(key:"",value:"Seleccione ...")
            };
            foreach (var item in personas)
            {
                var kvp = new KeyValuePair<string, string>(item.Id.ToString(), string.Format("{0} {1}", item.Nombres, item.Apellidos));
                list.Add(kvp);
            }

            return list;
        }

        public List<KeyValuePair<string, string>> GetInteresSelectList()
        {
            var list = new List<KeyValuePair<string, string>>();
            using (var _dbContext = new FondoContext(_contextOptions))
            {
                var interesNoAfiliadoParam = _dbContext.Parametros.Where(x => x.Nombre == "Interes no afiliado").FirstOrDefault();
                var interesAfiliadoParam = _dbContext.Parametros.Where(x => x.Nombre == "Interes Afiliado").FirstOrDefault();
                list = new List<KeyValuePair<string, string>>(new List<KeyValuePair<string, string>>(){
                new KeyValuePair<string, string>(key:"",value:"Seleccione ..."),
                new KeyValuePair<string, string>(interesNoAfiliadoParam.Id.ToString(),string.Format("{0} ({1}%)",interesNoAfiliadoParam.Nombre,interesNoAfiliadoParam.Valor1)),
                new KeyValuePair<string, string>(interesAfiliadoParam.Id.ToString(),string.Format("{0} ({1}%)",interesAfiliadoParam.Nombre,interesAfiliadoParam.Valor1))
            });
            }
            return list;
        }

        public string GetInteresPactado(int personaId)
        {
            string interesPactado = "";
            using (var _dbContext = new FondoContext(_contextOptions))
            {

                bool personaAfiliado = _dbContext.Persona.Where(x => x.Id == personaId && x.Afiliado).Count() > 0;
                if (personaAfiliado)
                {
                    interesPactado = _dbContext.Parametros.Where(x => x.Nombre == "Interes Afiliado").FirstOrDefault().Valor1;
                }
                else
                {
                    interesPactado = _dbContext.Parametros.Where(x => x.Nombre == "Interes no afiliado").FirstOrDefault().Valor1;
                }
            }
            return interesPactado;
        }

        public List<KeyValuePair<string, string>> GetPersonasPrestamoActivoSelectList()
        {
            var list = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>(key:"",value:"Seleccione ...")
            };
            using (var _dbContext = new FondoContext(_contextOptions))
            {

                var prestamosActivos = _dbContext.Prestamo.AsNoTracking().Where(x => !x.Finalizado).Include(x => x.Persona).ToList();


                foreach (var item in prestamosActivos)
                {
                    list.Add(new KeyValuePair<string, string>(item.PersonaId.ToString(), string.Format("{0} {1}", item.Persona.Nombres, item.Persona.Apellidos)));
                }
            }

            return list;
        }
        /// <summary>
        /// Get the active Loan from an user
        /// </summary>
        /// <param name="personaId">Customer that has the active loan</param>
        /// <returns></returns>
        PrestamoDTO IPrestamoRepository.GetPrestamoActivoPersona(int personaId)
        {
            PrestamoDTO prestamo = null;
            using (var _dbContext = new FondoContext(_contextOptions))
            {

                var prestamoActivo = _dbContext.Prestamo.AsNoTracking().Where(x => !x.Finalizado && x.PersonaId == personaId).Include(x=>x.Consignaciones).FirstOrDefault();
                if (null != prestamoActivo)
                {
                    prestamo = _mapper.Map<Prestamo, PrestamoDTO>(prestamoActivo);
                }

            }
            return prestamo;
        }

       
    }
}
