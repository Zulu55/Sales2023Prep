using Microsoft.EntityFrameworkCore;

namespace Sales.API.Helpers
{
    public static class HttpContextExtensions
    {
        public async static Task InsertPaginationParametersInResponse<T>(this HttpContext context, IQueryable<T> queryable, int numberRecordsToShow)
        {
            if (context is null) 
            { 
                throw new ArgumentNullException(nameof(context)); 
            }

            double count = await queryable.CountAsync();
            double pageTotal = Math.Ceiling(count / numberRecordsToShow);
            context.Response.Headers.Add("count", count.ToString());
            context.Response.Headers.Add("pageTotal", pageTotal.ToString());
        }
    }
}
