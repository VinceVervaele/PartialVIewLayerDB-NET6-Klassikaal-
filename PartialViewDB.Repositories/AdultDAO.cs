using Microsoft.EntityFrameworkCore;
using PartialViewDB.Models.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialViewDB.Repositories
{
    public class AdultDAO
    {
        private readonly StudentDbContext _dbContext;

        public AdultDAO()
        {
            _dbContext = new StudentDbContext();
        }

        public IEnumerable<Models.Entities.Adult>? GetAll()
        {
            //SQL "select * from Adult"

            try
            {
                return _dbContext.Adults.Include(a => a.Department).ToList();
            } 
            catch(Microsoft.Data.SqlClient.SqlException ex)
            {
                Debug.WriteLine("Didn't found db", ex.ToString());
                return null;
            }

            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
