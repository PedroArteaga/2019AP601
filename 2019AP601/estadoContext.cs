using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using prestasmosApi.Models;

namespace  _2019AP601
{
    public class estadoContext : DbContext
    {
        public estadoContext(DbContextOptions<estadoContext> options) : base(options)
        {            
        }

        public DbSet<equipos> estado {get; set;}
    }
}