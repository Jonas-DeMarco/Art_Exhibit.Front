using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Front.Application.DTOs
{
    public class CreateOffreDTO
    {
        public int Bidder_Id { get; set; }
        public int Enchere_Id { get; set; }
        public DateTime Timestamp { get; set; }
        public float Price { get; set; }
    }
}
