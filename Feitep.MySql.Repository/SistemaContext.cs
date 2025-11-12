namespace Feitep.MySql.Repository;

using Feitep.MySql.Models;
using Microsoft.EntityFrameworkCore;
public class SistemaContext : DbContext
{
public DbSet<Cliente>? Clientes { get; set; }
}
