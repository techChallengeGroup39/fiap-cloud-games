namespace Core.Entity
{
    public class EntityBase
    {
        public Guid Guid { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public required string CriadoPor { get; set; }
        public  string? ModificadoPor { get; set; }
        public int Status { get; set; } = 0;
    }
}
