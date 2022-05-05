using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.AutoMap.Test.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { set; get; }
        public string DisplayName { set; get; }
        public string LastModifiedBy { set; get; }
    }
}
