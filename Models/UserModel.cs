using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcCrudWithAdo.Models
{
    public class UserModel
    {
        [Display(Name = "User Id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [Display(Name ="User Name")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage ="Enter valid Email")]
        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "User Email")]
        public string Email{ get; set; }
        [Required(ErrorMessage = "Age is required")]
        [Display(Name = "User Age")]
        [Range(18,60,ErrorMessage ="Error must be between 18 to 60")]
        public int Age { get; set; }
    }
}