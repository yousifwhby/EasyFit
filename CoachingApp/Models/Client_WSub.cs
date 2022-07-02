﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CoachingApp.Models
{
    [Table("Client_WSub")]
    public partial class Client_WSub
    {
        [Key]
        public int clientID { get; set; }
        public int coachID { get; set; }
        [Key]
        public int subID { get; set; }
        public bool? accept { get; set; }
        public int? rating { get; set; }
        [Key]
        [Column(TypeName = "date")]
        public DateTime startDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime acceptDate { get; set; }
        [Unicode(false)]
        public string comment { get; set; }

        [ForeignKey("clientID")]
        [InverseProperty("Client_WSubs")]
        public virtual Client client { get; set; }
        [ForeignKey("subID")]
        [InverseProperty("Client_WSubs")]
        public virtual Workout_Subscription sub { get; set; }
    }
}