using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SonOfCod.Models
{
    [Table("Subscriptions")]

    public class Subscription
    {
        [Key]
        public int SubscriptionId { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType("Number")]
        public int Age { get; set; }
        [Required]
        public string Favorite { get; set; }        
    }
}
