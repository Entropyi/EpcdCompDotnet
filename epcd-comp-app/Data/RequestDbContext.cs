using epcd_comp_app.Models;
using Microsoft.EntityFrameworkCore;

namespace epcd_comp_app.Data;

public class RequestDbContext : DbContext
{
    public RequestDbContext(DbContextOptions<RequestDbContext> options)
        :base(options)
    {
        
    }


    public DbSet<RequestModel> Requests { get; set; }
}