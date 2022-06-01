using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dndun_solution.Data.Base;
using dndun_solution.Models;

namespace dndun_solution.Data.Services
{
    public class PackageService : EntityBaseRepository<Package>, IPackageService
    {
        public PackageService(AppDbContext context) : base(context)
        {
        }
}
}