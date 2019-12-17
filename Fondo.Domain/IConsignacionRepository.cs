using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fondo.DTO;

namespace Fondo.Domain
{
    public interface IConsignacionRepository : IGenericRepository<DAL.Consignacion,DTO.ConsignacionDTO>
    {
        IEnumerable<ConsignacionDTO> GetConsignaciones(int anho, string[] includes = null);
        /// <summary>
        /// Validate if the amount is smaller of the previous consignations or the loan
        /// </summary>
        /// <param name="consignacion"></param>
        /// <param name="prestamoActivo"></param>
        /// <returns></returns>
        bool MontoValido(double? consignacion, PrestamoDTO prestamoActivo);
    }
}
