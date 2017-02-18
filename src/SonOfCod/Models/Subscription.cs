﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SonOfCod.Models
{
    public class Subscription
    {
        [Table("Subscriptions")]
        public class Product
        {
            [Key]
            public int SubscriptionId { get; set; }
            [Required]
            [EmailAddress]
            public string Email { get; set; }
            [Required]
            public int Age { get; set; }
            [Required]
            public string Favorite { get; set; }
        }
    }
}