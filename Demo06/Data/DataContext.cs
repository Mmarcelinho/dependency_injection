namespace Demo06.Data;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options){}

    public DbSet<Tarefa> Tarefa { get; set; }
    
    }
