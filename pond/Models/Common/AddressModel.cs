using System.Collections.Generic;
using System.Web.Mvc;

namespace Nop.Web.Models.Common
{
    public partial class AddressModel
    //public partial class AddressModel : BaseNopEntityModel
    {
        public AddressModel()
        {
            //AvailableCountries = new List<SelectListItem>();
            //AvailableStates = new List<SelectListItem>();
            //CustomAddressAttributes = new List<AddressAttributeModel>();
        }

        public string HouseNumber { get; set; }
        public string HouseName { get; set; }
        public string StreetName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int? StateProvinceId { get; set; }
        public string StateProvinceName { get; set; }
        public int? CountryId { get; set; }
        public string CountryName { get; set; }

        public string ZipPostalCode { get; set; }

            public IList<SelectListItem> AvailableCountries { get; set; }
            public IList<SelectListItem> AvailableStates { get; set; }


            //public string FormattedCustomAddressAttributes { get; set; }
            //public IList<AddressAttributeModel> CustomAddressAttributes { get; set; }

    }
}