using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Название страницы (заголовок)")]
        public override string TitleEn { get; set; } = "Информационная страница";

        [Display(Name = "Cодержание страницы")]
        public override string TextEn { get; set; } = "Содержание заполняется администратором";
    }
}
