using TaskManagerMVC.Enums;

namespace TaskManagerMVC.Entities
{
    public class TaskEntity
    {
        public int ID { get; set; }
        public string Titulo { get; set; } = String.Empty;
        public string Assunto { get; set; } = String.Empty;
        public string Descricao { get; set; } = String.Empty;
        public Prioridade Prioridade { get; set; } = Prioridade.Media;
    }
}
