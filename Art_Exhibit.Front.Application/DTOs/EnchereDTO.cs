using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Front.Application.DTOs
{
    public class EnchereDTO
    {
        public int? Id { get; set; }
        public DateTime? Date_debut { get; set; }
        public DateTime? Date_fin { get; set; }

        public int? OeuvreId { get; set; }
        public float? Prix_reserve { get; set; }
        public float? Incr_mini { get; set; }
        public int? Duree_antisniping { get; set; }
    }
}
