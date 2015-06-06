using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Pond.Web.Areas.Admin.Models
{
    public class ServiceCategory
    {
        public virtual int ServiceCategoryId { get; set; }
        [Required]
        [Display(Name = "Name")]
        public virtual string Name { get; set; }

        [Required]
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public virtual string Description { get; set; }
    }
}