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
    public class ConsignacionRepository : GenericRepository<DAL.Consignacion,ConsignacionDTO>, IConsignacionRepository
    {

        DbContextOptions<FondoContext> _contextOptions;
        private AutoMapper.IMapper _mapper;

        public ConsignacionRepository(DbContextOptions<FondoContext> contextOptions) : base(contextOptions)
        {
            _contextOptions = contextOptions;
            var m = new AutoMapper.MapperConfiguration(c =>
            {
                c.CreateMap<DAL.Consignacion, ConsignacionDTO>();
            });
            _mapper = m.CreateMapper();
        }

        public bool MontoValido(double? consignacion, PrestamoDTO prestamoActivo)
        {
            bool isValido = false;
            var totalConsignado = prestamoActivo.Consignaciones.Sum(x => x.Valor.HasValue ? x.Valor : 0);
            var saldo = prestamoActivo.Valor - totalConsignado;
            if(consignacion <= saldo)
            {
                isValido = true;
            }
            return isValido;
        }

        IEnumerable<ConsignacionDTO> IConsignacionRepository.GetConsignaciones(int anhoParametrizado, string[] includes = null)
        {
            IEnumerable<ConsignacionDTO> returnable = null;
            using (var _dbContext = new FondoContext(_contextOptions))
            {
                var search = _dbContext.Consignacion.Where(x =>x.Fecha.Year == anhoParametrizado && ((x.Valor.HasValue && x.Valor.Value > 0) || (x.Interes.HasValue && x.Interes.Value > 0)));
                if (null != includes)
                {
                    foreach (var item in includes)
                    {
                        search = search.Include<Consignacion>(item);
                    }
                }
                returnable = _mapper.Map<IEnumerable<DAL.Consignacion>, IEnumerable<ConsignacionDTO>>(search.AsEnumerable());
            }
            return returnable;
        }
    }
}
