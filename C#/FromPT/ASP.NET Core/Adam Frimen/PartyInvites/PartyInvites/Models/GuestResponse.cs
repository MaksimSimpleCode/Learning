using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Пожалуйста, введите свое имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите свой Email")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage = "Пожалуйста, введите валидный Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите свой номер телефона")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Пожалуйста, уточните, будете ли вы присутствовать")]
        public bool? WillAttend { get; set; }
    }
}
