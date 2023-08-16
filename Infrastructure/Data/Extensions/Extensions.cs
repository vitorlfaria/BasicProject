using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Extensions;

public static class Extensions
{
    public static IQueryable<T> Includes<T>(this IQueryable<T> query, params string[]? includes) where T : class
    {
        return includes == null ? query : includes.Aggregate(query, (current, include) => current.Include(include));
    }
}