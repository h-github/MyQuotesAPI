using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyQuotesAPI.Entities
{
  public class QuoteInfoContext : DbContext
  {
    public QuoteInfoContext(DbContextOptions<QuoteInfoContext> options)
      :base(options)
    {
      Database.EnsureCreated();
    }

    public DbSet<Quote> Quotes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("connectionString");
      base.OnConfiguring(optionsBuilder);
    }
  }
}
