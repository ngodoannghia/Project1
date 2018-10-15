using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction.Models.Models
{
    [Table("Delivers")]
    public class Deliver
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Deliver_Name { get; set; }
        [MaxLength(50)]
        public string Deliver_Password { get; set; }
        [Required]
        [MaxLength(50)]
        public string Deliver_Email { get; set; }
        [Required]
        public string Deliver_City { get; set; }
        [Required]
        public string Deliver_Town { get; set; }
        [Required]
        public string Telephone_Number { get; set; }

        public int Deliver_Salary { get; set; }

        public virtual IEnumerable<Contact> Contacts { get; set; }
    }
}
