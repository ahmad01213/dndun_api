using dndun_solution.Data.Base;
namespace dndun_solution.Models
{
	public class Post: IEntityBase
	{

        public int? Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Photo { get; set; }
        public string? Sound { get; set; }
        public double? Views { get; set; }
        public string? Type { get; set; }
        public string? Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Post() {
            CreatedAt = DateTime.UtcNow.AddHours(3);
            Views = 0;
            Status = "ACTIVE";
        }
    }
}