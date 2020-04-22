using System;
using System.Collections.Generic;
using System.Text;
using GardenCommunityAccounting.Models;

namespace GardenCommunityAccounting
{
    public static class DocumentFactory
    {
        public static IDocument GetDocumentByType(Guid documentType)
        {
            return new ElectricBillDocument();
        }
    }
}
