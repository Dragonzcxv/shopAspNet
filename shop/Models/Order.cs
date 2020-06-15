using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Models
{
    public class Order
    {

        [BindNever]
        public int Id { get; set; }

        [Display(Name = "Введите имя") ]
        [StringLength(15, ErrorMessage = "Имя может содержать максимум 15 символов!")]
        [Required(ErrorMessage = "Имя не может быть пустым")]
        public string Name { get; set; }

        [Display(Name = "Введите фамилие")]
        [StringLength(15, ErrorMessage = "Фамилие может содержать максимум 15 символов!")]
        [Required(ErrorMessage = "фамилие не может быть пустым")]
        public string Surname { get; set; }

        [Display(Name = "Адрес")]
        [StringLength(50)]
        [Required(ErrorMessage = "Адрес не может быть пустым")]
        public string Adress { get; set; }

        [Display(Name = "Введите телефон")]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Телефон не может быть пустым")]
        public string Phone { get; set; }

        [Display(Name = "Введите email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(30)]
        [Required(ErrorMessage = "Email  не может быть пустым")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

    }
}
