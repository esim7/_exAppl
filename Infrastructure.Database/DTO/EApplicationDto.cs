using Domain.Models.Models;

namespace Infrastructure.Database.DTO
{
    public class EApplicationDto
    {
        public int Id { get; set; }
        public string Iin { get; set; }
        public int Score { get; set; }
        public Discipline Profile1 { get; set; }
        public Discipline Profile2 { get; set; }
        public College College { get; set; }
    }
}