using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using prenota.Models;

public class  Database : DbContext
{
    private readonly IDbContextOptions? _options;

    public Database() {}

    protected override void
                OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlite("Data Source=database.db");
    public DbSet<Utente> Utenti { get; set; }
    public string? Nome { get; set; }

}

