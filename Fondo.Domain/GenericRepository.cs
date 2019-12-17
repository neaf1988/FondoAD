using Fondo.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fondo.Domain
{
    public class GenericRepository<TEntity, TEntityDTO> : IGenericRepository<TEntity, TEntityDTO> where TEntity : class where TEntityDTO : class
    {
        private DbContextOptions<FondoContext> _contextOptions;
        private AutoMapper.IMapper _mapper;

        public GenericRepository(DbContextOptions<FondoContext> contextOptions)
        {
            _contextOptions = contextOptions;
            var m = new AutoMapper.MapperConfiguration(c =>
            {
                c.CreateMap<TEntity, TEntityDTO>();
            });
            _mapper = m.CreateMapper();


        }

        public async Task CreateAsync(TEntityDTO entity)
        {
            using (var _dbContext = new FondoContext(_contextOptions))
            {
                await _dbContext.Set<TEntity>().AddAsync(_mapper.Map<TEntityDTO, TEntity>(entity));
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            using (var _dbContext = new FondoContext(_contextOptions))
            {
                var entity = await GetByIdAsync(id);
                if (null == entity)
                {
                    throw new Exception("Element not found, can't delete");
                }
                _dbContext.Set<TEntity>().Remove(_mapper.Map<TEntityDTO, TEntity>(entity));
                await _dbContext.SaveChangesAsync();
            }
        }

        public IEnumerable<TEntityDTO> GetAll(string[] includes = null)
        {
            using (var _dbContext = new FondoContext(_contextOptions))
            {
                IEnumerable<TEntityDTO> returnable = null;
                try
                {
                    var search = _dbContext.Set<TEntity>().AsNoTracking();

                    if (null != includes)
                    {
                        foreach (var item in includes)
                        {
                            search = search.Include<TEntity>(item);
                        }
                    }
                    returnable = _mapper.Map<IEnumerable<TEntity>, IEnumerable<TEntityDTO>>(search.AsEnumerable());
                }
                catch (AutoMapper.AutoMapperMappingException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return returnable;


            }

        }

        public async Task<TEntityDTO> GetByIdAsync(int id)
        {
            using (var _dbContext = new FondoContext(_contextOptions))
            {
                var search = await _dbContext.Set<TEntity>().FindAsync(id);
                return _mapper.Map<TEntity, TEntityDTO>(search);
            }
        }

        public async Task<TEntityDTO> GetByIdAsync(System.Linq.Expressions.Expression<System.Func<TEntity, bool>> filter, string[] includes = null)
        {
            using (var _dbContext = new FondoContext(_contextOptions))
            {
                var _filter = filter;
                var search = _dbContext.Set<TEntity>().AsNoTracking();

                if (null != includes)
                {
                    foreach (var item in includes)
                    {
                        search = search.Include(item);
                    }

                }
                var returnable = _mapper.Map<TEntity, TEntityDTO>(await search.FirstOrDefaultAsync(_filter));
                return returnable;
            }
        }


        public async Task UpdateAsync(TEntityDTO entity)
        {
            using (var _dbContext = new FondoContext(_contextOptions))
            {

                _dbContext.Set<TEntity>().Update(_mapper.Map<TEntityDTO, TEntity>(entity));
                await _dbContext.SaveChangesAsync();
            }
        }

        public IEnumerable<TEntityDTO> Get(Func<TEntity, bool> filter, string[] includes = null)
        {
            using (var _dbContext = new FondoContext(_contextOptions))
            {
                var _filter = filter;

                if (null != includes)
                {
                    var search = _dbContext.Set<TEntity>().AsNoTracking();
                    

                    foreach (var item in includes)
                    {
                        search = search.Include<TEntity>(item);
                    }
                    var xSearch = search.Where(_filter);

                    return _mapper.Map<IEnumerable<TEntity>, IEnumerable<TEntityDTO>>(xSearch.AsEnumerable());
                }
                else
                {
                    var search = _dbContext.Set<TEntity>().AsNoTracking().Where(_filter);
                    return _mapper.Map<IEnumerable<TEntity>, IEnumerable<TEntityDTO>>(search);
                }




            }
        }


    }
}
