namespace Core.Input
{
    public class RoleUpdateInput
    {
        public Guid Guid { get; set; }
        public required string Nome { get; set; }
        public int Status { get; set; }
    }
}
