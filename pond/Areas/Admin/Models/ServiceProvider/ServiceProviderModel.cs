using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pond.Web.Areas.Admin.Models
{
    public enum TelephoneTypes
    {
        homeLandline = 1,
        workLandline,
        homeMobile,
        workMobile
    }
    public class ServiceProvider
    {
        [ScaffoldColumn(false)]
        public virtual string ServiceProviderId { get; set; }

        [Required]
        [Display(Name = "Organization Name")]
        [DataType(DataType.Text)]
        [StringLength(255,ErrorMessage ="Please enter a maximum of 255 characters")]
        public virtual string Name { get; set; }

        [DataType(DataType.MultilineText)]
        public virtual string Description { get; set; }

        [Required]
        [Display(Name = "Primary Category")]
        public virtual ServiceCategory ServiceCategory { get; set; }

        [Display(Name = "Work Telephone Number")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public virtual string Telephone1 { get; set; }

        [ScaffoldColumn(false)]
        public virtual TelephoneTypes? Telephone1Type { get; set; }

        [Display(Name = "Mobile Telephone Number")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public virtual string Telephone2 { get; set; }

        [ScaffoldColumn(false)]
        public virtual TelephoneTypes? Telephone2Type { get; set; }

        [Display(Name = "Website Address")]
        [DataType(DataType.Url)]
        public virtual string URL { get; set; }

        [Range(0,5,ErrorMessage="Must be a number between 1 and 5")]
        public virtual int Rating { get; set; }

        [Editable(false)]
        public virtual List<Service> Services { get; set; }

    }

}
