using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Northwind.Store.Model.Resource;

namespace Northwind.Store.Model
{
    [MetadataType(typeof(SupplierMetadata))]
    public partial class Supplier
    {
        public class SupplierMetadata
        {
            public int SupplierID { get; set; }

            [Required(ErrorMessageResourceType = typeof(GeneralMessages), ErrorMessageResourceName = "SupplierCompanyNameRequired")]
            [StringLength(40, MinimumLength = 2, ErrorMessageResourceType = typeof(GeneralMessages), ErrorMessageResourceName = "SupplierCompanyNameLength")]
            [Display(ResourceType = typeof(GeneralMessages), Name = "SupplierCompanyName")]
            public string CompanyName { get; set; }

            [Required(ErrorMessageResourceType = typeof(GeneralMessages), ErrorMessageResourceName = "SupplierContactNameRequired")]
            [StringLength(30, MinimumLength = 2, ErrorMessageResourceType = typeof(GeneralMessages), ErrorMessageResourceName = "SupplierContactNameLength")]
            [Display(ResourceType = typeof(GeneralMessages), Name = "SupplierContactName")]
            public string ContactName { get; set; }

            [Display(ResourceType = typeof(GeneralMessages), Name = "SupplierContactTitle")]
            public string ContactTitle { get; set; }

            [Required(ErrorMessageResourceType = typeof(GeneralMessages), ErrorMessageResourceName = "SupplierAddressRequired")]
            [Display(ResourceType = typeof(GeneralMessages), Name = "SupplierAddress")]
            public string Address { get; set; }

            [Required(ErrorMessageResourceType = typeof(GeneralMessages), ErrorMessageResourceName = "SupplierCityRequired")]
            [Display(ResourceType = typeof(GeneralMessages), Name = "SupplierCity")]
            public string City { get; set; }

            [Required(ErrorMessageResourceType = typeof(GeneralMessages), ErrorMessageResourceName = "SupplierRegionRequired")]
            [Display(ResourceType = typeof(GeneralMessages), Name = "SupplierRegion")]
            public string Region { get; set; }

            [Display(ResourceType = typeof(GeneralMessages), Name = "SupplierPostalCode")]
            public string PostalCode { get; set; }

            [Required(ErrorMessageResourceType = typeof(GeneralMessages), ErrorMessageResourceName = "SupplierCountryRequired")]
            [Display(ResourceType = typeof(GeneralMessages), Name = "SupplierCountry")]
            public string Country { get; set; }

            [Required(ErrorMessageResourceType = typeof(GeneralMessages), ErrorMessageResourceName = "SupplierPhoneRequired")]
            [Display(ResourceType = typeof(GeneralMessages), Name = "SupplierPhone")]
            public string Phone { get; set; }

            [Display(ResourceType = typeof(GeneralMessages), Name = "SupplierFax")]
            public string Fax { get; set; }

            [Display(ResourceType = typeof(GeneralMessages), Name = "SupplierHomePage")]
            public string HomePage { get; set; }
        }
    }
}
