using System.ComponentModel.DataAnnotations;

namespace efcore_bl.Data
{
    public class UnusedObject
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }
    }
}