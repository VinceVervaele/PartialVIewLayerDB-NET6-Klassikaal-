using System;
using System.Collections.Generic;

namespace PartialViewDB.Models.Entities
{
    public partial class Departement
    {
        public Departement()
        {
            Adults = new HashSet<Adult>();
        }

        public int Id { get; set; }
        public string DepartementName { get; set; } = null!;

        public virtual ICollection<Adult> Adults { get; set; }
    }
}
