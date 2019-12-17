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
    public class ParametrosRepository : GenericRepository<DAL.Parametros,DTO.DTOParametros>,IParametrosRepository
    {
       

        public ParametrosRepository(DbContextOptions<FondoContext> contextOptions) : base(contextOptions)
        {
           
        }
  
    }
}
