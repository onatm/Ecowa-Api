using System.ComponentModel.DataAnnotations;

namespace Ecowa.Model
{
    public class CategoryViewModel
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
