using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MarketShop.Domain.Entities
{
    public class ServiceItem : EntityBase 
    {
        [Required(ErrorMessage = "Заполните название услуги")]
        
        [Display(Name = "Название услуги")]
        public override string Title { get; set; } 

        [Display(Name = "Краткое описание услуги")]
        public override string Subtitle { get; set; } 

        [Display(Name = "Поное описание услуги")]
        public override string Text { get; set; } 
    }
}
