using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobs6Persistent.Models;
using System.ComponentModel.DataAnnotations;

namespace TechJobs6Persistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Name of Employer is required.")]
        [StringLength(30, MinimumLength =2, ErrorMessage ="Employer name should be between 2-30 characters.")]
        public string? Name { get; set;}

        [Required(ErrorMessage = "Location of Employer is required.")]
        [StringLength(50, MinimumLength =2, ErrorMessage ="Employer location should be between 2-50 characters.")]
        public string? Location { get; set;}

    }
}