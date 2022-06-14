﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CoachingApp.Models
{
    [Table("Nutrition_Subscription")]
    public partial class Nutrition_Subscription
    {
        public Nutrition_Subscription()
        {
            Client_Meal_NSubs = new HashSet<Client_Meal_NSub>();
            Client_NSubs = new HashSet<Client_NSub>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int? duration { get; set; }
        public int? price { get; set; }
        public int? coachID { get; set; }

        [ForeignKey("coachID")]
        [InverseProperty("Nutrition_Subscriptions")]
        public virtual Coach coach { get; set; }
        [InverseProperty("sub")]
        public virtual ICollection<Client_Meal_NSub> Client_Meal_NSubs { get; set; }
        [InverseProperty("sub")]
        public virtual ICollection<Client_NSub> Client_NSubs { get; set; }
    }
}