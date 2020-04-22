using System;
using System.Collections.Generic;
using System.Text;

namespace GardenCommunityAccounting
{
    public interface IDocumentModel
    {
        public Guid Id { get; set; }
        public string Number { get; set; }      
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public Guid DocumentTypeId { get; set; }        
        public DateTime Date { get; set; }
    }
}
