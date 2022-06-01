
using dndun_solution.Data.Base;
using dndun_solution.Models;
namespace dndun_solution.Data.Services
{
    public class PostService : EntityBaseRepository<Post>, IPostService
    {
        public PostService(AppDbContext context) : base(context)
        {
        }
}
}