﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CoachingApp.Models
{
    [Table("Speciality")]
    public partial class Speciality
    {
        public Speciality()
        {
            Coaches = new HashSet<Coach>();
        }

        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(200)]
        [Unicode(false)]
        public string name { get; set; }

        [InverseProperty("specialityNavigation")]
        public virtual ICollection<Coach> Coaches { get; set; }
    }
}