using Fondo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fondo.Domain
{
    public interface IPrestamoRepository : IGenericRepository<DAL.Prestamo,DTO.PrestamoDTO>
    {
        List<KeyValuePair<string, string>> GetPersonasSelectList(IEnumerable<DTO.PersonaDTO> personas);
        List<KeyValuePair<string, string>> GetInteresSelectList();
        string GetInteresPactado(int personaId);
        List<KeyValuePair<string, string>> GetPersonasPrestamoActivoSelectList();
        /// <summary>
        /// Get the active Loan from an user
        /// </summary>
        /// <param name="personaId">Customer that has the active loan</param>
        /// <returns></returns>
        DTO.PrestamoDTO GetPrestamoActivoPersona(int personaId);
    }
}
