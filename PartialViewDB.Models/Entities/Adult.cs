using System;
using System.Collections.Generic;

namespace PartialViewDB.Models.Entities
{
    public partial class Adult
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime EnrollDate { get; set; }
        public int DepartmentId { get; set; }

        public virtual Departement Department { get; set; } = null!;
    }
}
