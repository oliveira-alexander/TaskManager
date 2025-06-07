using TaskManagerMVC.Enums;

namespace TaskManagerMVC.DTOs
{
    public class TaskCreateDTO
    {
        public string Titulo { get; set; } = String.Empty;
        public string Assunto { get; set; } = String.Empty;
        public string Descricao { get; set; } = String.Empty;
        public Prioridade Prioridade { get; set; } = Prioridade.Media;
    }
}
