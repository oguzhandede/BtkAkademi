﻿using System.ComponentModel.DataAnnotations;

namespace BtkAkademi.Models
{
    public class Candidate
    {
        [Required(ErrorMessage ="E-mail is required")]
        public string? Email { get; set; } = String.Empty;

		[Required(ErrorMessage = "FirstName is required")]
		public string? FirstName { get; set; } = String.Empty;

		[Required(ErrorMessage = "LastName is required")]
		public string? LastName { get; set; } = String.Empty;
        
        public string? FullName => $"{FirstName} {LastName?.ToUpper()}";


        public int? Age { get; set; }

		[Required(ErrorMessage = "LastName is required")]
		public string? SelectedCourse { get; set; } = String.Empty;
        public DateTime? ApplyAt { get; set; }
        
        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }
    }
}
