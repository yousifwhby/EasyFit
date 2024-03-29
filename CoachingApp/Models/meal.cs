﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CoachingApp.Models
{
    [Table("Meal")]
    public partial class Meal
    {
        public Meal()
        {
            Client_Meal_NSubs = new HashSet<Client_Meal_NSub>();
        }

        [Key]
        public int id { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string description { get; set; }
        public int coachID { get; set; }

        [ForeignKey("coachID")]
        [InverseProperty("Meals")]
        public virtual Coach coach { get; set; }
        [InverseProperty("meal")]
        public virtual ICollection<Client_Meal_NSub> Client_Meal_NSubs { get; set; }
    }
}