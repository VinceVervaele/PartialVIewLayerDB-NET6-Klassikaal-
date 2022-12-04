using PartialViewDB.Models.Entities;
using PartialViewDB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialViewDB.Services
{
    public class AdultService
    {
        private AdultDAO adultDAO;

        public AdultService()
        {
            adultDAO = new AdultDAO();
        }

        public IEnumerable<Adult>? GetAll()
        {
            return adultDAO.GetAll();
        }
    }
}
