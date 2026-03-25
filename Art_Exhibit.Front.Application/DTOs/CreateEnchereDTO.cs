using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Front.Application.DTOs
{
    public class CreateEnchereDTO
    {
        public DateTime Date_debut { get; set; } = DateTime.Now;
        public DateTime? Date_fin { get; set; }

        public int Oeuvreid { get; set; }
        public float Prix_reserve { get; set; }
        public float Incr_mini { get; set; }
        public int Duree_antisniping { get; set; }
    }
}
