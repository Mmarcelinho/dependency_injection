namespace Demo06.Models;

    public class Tarefa
    {
        public Tarefa(string titulo, bool concluida)
        {
            this.Id = Guid.NewGuid();
            this.Titulo = titulo;
            this.DataCriacao = DateTime.Now;
            this.Concluida = concluida;
        }
        public Guid Id { get; set; }

        public string Titulo { get; set; } = string.Empty;

        public DateTime. DataCriacao { get; set; }

        public bool Concluida { get; set; }
    }