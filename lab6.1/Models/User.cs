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
        [UIHint("EmailAddress")]
        [Required(ErrorMessage ="Поле обов'язково повинно бути заповнене")]
        //[Remote("CheckName", "Home", ErrorMessage = "Name is not valid.")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некоректний адрес")]
        public string Email { get; set; }
        [Display(Name ="Повне Ім'я")]
        [Required(ErrorMessage = "Поле обов'язково повинно бути заповнене")]
        public string FullName { get; set; }
        [Display(Name ="Ім'я для форумів")]
        [Required(ErrorMessage = "Поле обов'язково повинно бути заповнене")]
        public string ForumName { get; set; }
        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        [UIHint("Password")]
        [Required(ErrorMessage = "Поле обов'язково повинно бути заповнене")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{6,12}$", ErrorMessage = "Некоректний пароль (Aa-Zz and 0-9 and spezial char)")]
        [StringLength(12, MinimumLength = 6, ErrorMessage = "Довжина рядка повинна бути від 6 до 12 символів")]
        public string Password { get; set; }
        [Display(Name = "Password Confirm")]
        [System.Web.Mvc.Compare("Password", ErrorMessage = "Пароли не співпадають")]
        [DataType(DataType.Password)]
        [UIHint("Password")]
        [Required(ErrorMessage = "Поле обов'язково повинно бути заповнене")]
        public string PasswordConfirm { get; set; }
        [Display(Name ="Стать")]
        public bool Sex { get; set; }
        [Display(Name = "Рік народження")]
        //[DataType(DataType.Date)]
        [Range(1700, 2000, ErrorMessage = "Неприпустимий рік")]
        public int YearOfBirth { get; set; }
        [Display(Name = "Освіта")]
        public string Education { get; set; }
        [Display(Name = "Місце проживання")]
        public string Location { get; set; }
        [Display(Name = "Чому ви вибрали саме нас")]
        [DataType(DataType.MultilineText)]
        [UIHint("MultilineText")]
        public string Abouth { get; set; }
        [Display(Name = " Я згоден зі всіма правилами")]
        [UIHint("Boolean")]
        [Required(ErrorMessage = "Поле обов'язково повинно бути заповнене")]
        public bool IConfirmed { get; set; }
    }
}