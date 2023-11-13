namespace Demo02.Data;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {}

        public DbSet<Tarefa> Tarefa { get; set; }
    }
