﻿using ApotheekApp.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ApotheekApp.Domain.Models
{
    public class Allergy : IEntity
    {
        [Key]
        public int Id { get; set; }

        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}