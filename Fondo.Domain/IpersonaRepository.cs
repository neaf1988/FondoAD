using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fondo.Domain
{
    public interface IPersonaRepository : IGenericRepository<DAL.Persona,DTO.PersonaDTO>
    {
        List<KeyValuePair<string, string>> getQuincenaSelectList();
        List<KeyValuePair<string, string>> getFondoActivos();
        List<KeyValuePair<string, string>> getActivos();
        


    }
}
