using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab6._1.Models
{
    public class User
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        
        [Required]
        public string Email { get; set; }
        [Display(Name ="Повне Ім'я")]
        [Required]
        public string FullName { get; set; }
        [Display(Name ="Ім'я для форумів")]
        [Required]
        public string ForumName { get; set; }
        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
        [Display(Name ="Стать")]
        public bool Sex { get; set; }
        [Display(Name = "Рік народження")]
        [DataType(DataType.Date)]
        public DateTime YearOfBirth { get; set; }
        [Display(Name = "Освіта")]
        public string Education { get; set; }
        [Display(Name = "Місце проживання")]
        public string Location { get; set; }
        [Display(Name = "Чому ви вибрали саме нас")]
        [DataType(DataType.MultilineText)]
        public string Abouth { get; set; }
        [Display(Name = " Я згоден зі всіа правилами")]
        [UIHint("Boolean")]
        [Required]
        public bool IConfirmed { get; set; }
    }
}