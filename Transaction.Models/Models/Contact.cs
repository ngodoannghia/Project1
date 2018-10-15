using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction.Models.Models
{
    [Table("Contacts")]
    public class Contact
    {
        [Key]
        [Column(Order =1)]
        public int User_Id { get; set; }
        [Key]
        [Column(Order =2)]
        public int Deliver_Id { get; set; }

        public DateTime DateTime_Transaction { get; set; }

        public decimal Price { get; set; }

        public int Distance { get; set; }
        [ForeignKey("User_Id")]
        public virtual User_Transaction User_Transaction { get; set; }
        [ForeignKey("Deliver_Id")]
        public virtual Deliver Deliver { get; set; }

    }
}
