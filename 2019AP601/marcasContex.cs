using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using prestasmosApi.Models;

namespace  _2019AP601
{
    public class marcasContext : DbContext
    {
        public marcasContext(DbContextOptions<maracasContext> options) : base(options)
        {            
        }

        public DbSet<equipos> marcas {get; set;}
    }
}