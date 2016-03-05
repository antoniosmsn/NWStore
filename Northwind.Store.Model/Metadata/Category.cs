using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Northwind.Store.Model.Resource;

namespace Northwind.Store.Model
{
    [MetadataType(typeof(CategoryMetadata))]
    public partial class Category
    {
        public class CategoryMetadata
        {
            [Required(ErrorMessageResourceType = typeof(GeneralMessages), ErrorMessageResourceName = "CategoryNameRequired")]
            [StringLength(15, MinimumLength = 3, ErrorMessageResourceType = typeof(GeneralMessages), ErrorMessageResourceName = "CategoryNameLength")]
            [Display(Name = "CategoryNameTitle", ResourceType = typeof(GeneralMessages))]
            public string CategoryName { get; set; }


            [Required(ErrorMessageResourceType = typeof(GeneralMessages), ErrorMessageResourceName = "CategoryDescriptionRequired")]
            [MinLength(30, ErrorMessageResourceType = typeof(GeneralMessages), ErrorMessageResourceName = "CategoryDescriptionLength")]
            [Display(Name = "CategoryDescriptionTitle", ResourceType = typeof(GeneralMessages))]
            public string Description { get; set; }
        }
    }
}
