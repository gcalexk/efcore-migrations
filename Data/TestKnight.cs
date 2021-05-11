using System.ComponentModel.DataAnnotations;
using Elemental.Components.Forms;

namespace efcore_bl.Data
{
    public class TestKnight
    {
        [Key]
        [AeFormIgnore]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Quest { get; set; }

        // [MaxLength(20)]
        // public string FavColour { get; set; }
    }
}