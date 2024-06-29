using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobs6Persistent.Models;
using System.ComponentModel.DataAnnotations;

namespace TechJobs6Persistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Job name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Job name must be between 3 and 50 characters")]
        public string JobName { get; set; }

        [Required(ErrorMessage = "Employer is required")]
        public int EmployerId { get; set; }
        
        public List<SelectListItem>? Employers { get; set; }

        public AddJobViewModel(List<Employer> employers)
        {
            Employers = new List<SelectListItem>();

            foreach (var employer in employers)
            {
                Employers.Add(
                    new SelectListItem
                    {
                        Value = employer.Id.ToString(),
                        Text = employer.Name
                    }
                ); ;

            }
        }
        
        public AddJobViewModel()
        {
        }
    }

}