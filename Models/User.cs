using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHussien_DatabaseSolution.Models
{
    public  class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }  
        public string Password { get; set; }
        public string Email { get; set; }   

        public int RoleId { get; set; }
        public virtual Role Role { get; set; }

        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public int UserInformationId { get; set; }
        public virtual UserInformation UserInformation { get; set; }
    }
}
