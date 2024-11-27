using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCenter.Infrastructure.Exceptions
{
    public class ClientRepository
    {
        private readonly PetHealthCenterDbContext _context;
        public ClientRepository(PetHealthCenterDbContext context)
        {
            _context = context;
        }
       
    }
}
