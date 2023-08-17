using System.Linq.Expressions;
using Application.Interfaces;
using Domain.Interfaces;

namespace Application.Services;

public class BaseService<T, TDto, TR> : IBaseService<TDto>
    where T : class
    where TDto : class
    where TR : IBaseRepository<T>
{
    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public void Add(TDto obj)
    {
        throw new NotImplementedException();
    }

    public void Update(TDto obj)
    {
        throw new NotImplementedException();
    }

    public void Remove(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<TDto> GetAll(params string[] includes)
    {
        throw new NotImplementedException();
    }

    public int Count()
    {
        throw new NotImplementedException();
    }

    public void AddRange(List<TDto> obj)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(List<TDto> objs)
    {
        throw new NotImplementedException();
    }

    public void UpdateRange(IEnumerable<TDto> objs)
    {
        throw new NotImplementedException();
    }

    public IQueryable<TDto> GetByExpression(Expression<Func<TDto, bool>> expression, params string[] includes)
    {
        throw new NotImplementedException();
    }

    public TDto GetElementByExpression(Expression<Func<TDto, bool>> expression, params string[] includes)
    {
        throw new NotImplementedException();
    }
}