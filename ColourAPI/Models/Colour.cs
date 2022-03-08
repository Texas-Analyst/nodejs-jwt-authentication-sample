using System;
using System.ComponentModel.DataAnnotations;

// Database-First approach --- this file was generated from the database
namespace ColourAPI.Models
{
    public class Colour
    {
        [Key]
        public int Id { get; set; }
        public string ColourName { get; set; }
        public Colour()
        { }
    }
}
