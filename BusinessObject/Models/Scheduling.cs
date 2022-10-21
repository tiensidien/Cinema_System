﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Scheduling
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int? RoomId { get; set; }
        public int? CinemaId { get; set; }
        public int? FilmId { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public bool? Active { get; set; }

        public virtual Cinema Cinema { get; set; }
        public virtual FilmInCinema FilmInCinema { get; set; }
        public virtual Room Room { get; set; }
    }
}