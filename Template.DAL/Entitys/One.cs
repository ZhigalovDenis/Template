namespace Template.DAL.Entitys
{
    public class One
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Many>? Manys { get; set; }
    }
}
