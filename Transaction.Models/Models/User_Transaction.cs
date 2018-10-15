using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction.Models.Models
{
    [Table("User_Transactions")]
    public class User_Transaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string User_Name { set; get; }

        [MaxLength(50)]
        public string User_Password { set; get; }

        [Required]
        [MaxLength(50)]
        public string User_Email { set; get; }
        [Required]
        [MaxLength(50)]
        public string User_City { set; get; }
        [MaxLength(50)]
        [Required]
        public string User_Town { set; get; }
        [MaxLength(50)]
        public string Type_Commodity { set; get; }
        [Required]
        [MaxLength(50)]
        public string Telephone_Number { get; set; }
        public virtual IEnumerable<Contact> Contacts { get; set; }
    }
}
