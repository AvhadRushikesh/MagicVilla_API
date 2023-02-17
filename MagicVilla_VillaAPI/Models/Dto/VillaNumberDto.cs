using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla_VillaAPI.Models.Dto
{
    // Get Single VillaNumber HTTPGet/id Method for getting single record using id is required
    public class VillaNumberDto
    {
        [Required]
        public int VillaNo { get; set; }
        [Required]
        public int VillaId { get; set; }
        public string SpecialDetails { get; set; }
        public VillaDto Villa { get; set; }
    }
}
