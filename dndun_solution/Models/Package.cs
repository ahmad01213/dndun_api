using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dndun_solution.Data.Base;

namespace dndun_solution.Models
{
    public class Package : IEntityBase
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public int? Months { get; set; }
        public double? Price { get; set; }
        public string? Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Package()
        {
            CreatedAt = DateTime.UtcNow.AddHours(3);
            Status = "ACTIVE";
        }
    }
}