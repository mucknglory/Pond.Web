using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Pond.Web.Areas.Admin.Models
{
    public class Service
    {
        public virtual int ServiceId { get; set; }
        public virtual int ServiceProviderId { get; set; }
        public virtual int ServiceCategoryId { get; set; }
        [Required]
        [Display(Name = "Service Name")]
        public virtual string Name { get; set; }

        [Required]
        [Display(Name = "Service Name")]
        [DataType(DataType.MultilineText)]
        public virtual string Description { get; set; }
        public virtual int Rating { get; set; }
        public virtual ServiceProvider ServiceProvider { get; set; }

        public virtual ServiceCategory ServiceCategory { get; set; }
    }

}