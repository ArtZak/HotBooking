using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Entities
{
    public class InspirationItem : EntityBase
    {
        [Required(ErrorMessage = "Type note name")]
        [Display(Name = "Note name")]
        public override string TitleEn { get; set; }

        [Display(Name = "Notes short description")]
        public override string SubtitleEn { get; set; }

        [Display(Name = "Notes long description")]
        public override string TextEn { get; set; }
    }
}
