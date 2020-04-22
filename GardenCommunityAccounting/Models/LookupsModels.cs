using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GardenCommunityAccounting.Models
{
    public class Street
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }        
    }    

    public class DocumentType
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsIncome { get; set; }
        public bool IsOutcome { get; set; }
    }

    public class SpecialPayType
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }    
}
