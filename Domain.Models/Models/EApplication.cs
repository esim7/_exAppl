namespace Domain.Models.Models
{
    public class EApplication
    {
        public int Id { get; set; }
        public string Iin { get; set; }
        public int Score { get; set; }
        public Discipline Discipline1 { get; set; }
        public Discipline Discipline2 { get; set; }
        public College College { get; set; }
    }
}