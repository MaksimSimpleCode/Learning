using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        
        [Display(Name="Имя")]
        [StringLength(15)]
        [Required(ErrorMessage = "Длинна имени не более 15")]
        public string Name { get; set; }

        [Display(Name = "Фамилия")]
        [StringLength(15)]
        [Required(ErrorMessage = "Длинна фамилии не более 15")]
        public string SurName { get; set; }

        [Display(Name = "Адрес")]
        [StringLength(15)]
        [Required(ErrorMessage = "Длинна адреса не более 15")]
        public string Adress { get; set; }

        [Display(Name = "Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10)]
        [Required(ErrorMessage = "Длинна номера не более 10")]
        public string Phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [MinLength(10)]
        [Required(ErrorMessage = "Длинна Email не более 10")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
