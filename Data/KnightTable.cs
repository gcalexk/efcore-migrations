using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace efcore_bl.Data
{
    public class KnightTable
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        [Required]
        public string Shape { get; set; }

        public int MaxSeats { get; set; }

        public List<TestKnight> Knights { get; set;}

    }
}