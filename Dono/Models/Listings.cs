using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dono.Models
{   
    public class Listings
    {
        public int Id { get; set;}

        [Required(ErrorMessage = "Please enter a short title for your donation")]
        [Display(Name = "Title")]
        [StringLength(100)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please describe your donation")]
        [Display(Name = "Description")]
        public string Body { get; set; }

        [Display(Name = "Image Name")]
        public string ImageName { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Please upload an image of your donation")]
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }

        //Setting the date and time that the listing was created
        private DateTime? dateCreated;
        public DateTime DatePosted
        {
            get { return dateCreated ?? DateTime.Now; }
            set { dateCreated = value; }
        }
        [Required(ErrorMessage = "Please add your adress")]
        [Display(Name = "Location")]
        public string Location { get; set; }
        [Display(Name = "User ID")]
        public string UserId { get; set; }

    }
}
