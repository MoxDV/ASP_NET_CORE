using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class GuestResponse {
        [Required(ErrorMessage = "Пожалуйста, введите свое имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите ваш Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Не правильно введен Email адрес")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите свой телефон")]
        [Phone(ErrorMessage = "Не правильно введен номер телефона")]
        public string Phone { get; set; }
        
        [Required(ErrorMessage = "Пожалуйста, укажите, примете ли участие")]
        public bool? WillAttend { get; set; }
    }
}
