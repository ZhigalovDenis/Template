namespace Template.DAL.Entitys
{
    public class Many
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int OneId { get; set; }
        public One? One { get; set; }
    }
}
