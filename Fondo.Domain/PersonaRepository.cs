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
    public class PersonaRepository : GenericRepository<Persona,PersonaDTO>, IPersonaRepository
    {
       

        public PersonaRepository(DbContextOptions<FondoContext> contextOptions) : base(contextOptions)
        {
            
           
        }

        public List<KeyValuePair<string, string>> getActivos()
        {
            var activos = Get(x => x.Activo);

            var list = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>(key:"",value:"Seleccione ...")
            };



            foreach (var item in activos)
            {
                var kvp = new KeyValuePair<string, string>(item.Id.ToString(), string.Format("{0} {1}", item.Nombres, item.Apellidos));
                list.Add(kvp);
            }

            return list;
        }

        public List<KeyValuePair<string, string>> getFondoActivos()
        {
            var fondoActivos = Get(x => x.Activo && x.Afiliado);

            var list = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>(key:"",value:"Seleccione ...")
            };



            foreach (var item in fondoActivos)
            {
                var kvp = new KeyValuePair<string, string>(item.Id.ToString(), string.Format("{0} {1}", item.Nombres, item.Apellidos));
                list.Add(kvp);
            }

            return list;
        }


        public List<KeyValuePair<string,string>> getQuincenaSelectList()
        {
            

            var list = new List<KeyValuePair<string, string>>(new List<KeyValuePair<string, string>>(){
                new KeyValuePair<string, string>(key:"",value:"Seleccione ..."),
                new KeyValuePair<string, string>("1","1ra Quincena"),
                new KeyValuePair<string, string>("2","2da Quincena")
            });

            return list;
        }

    }
}
