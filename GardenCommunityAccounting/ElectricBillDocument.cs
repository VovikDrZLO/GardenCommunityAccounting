using GardenCommunityAccounting.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GardenCommunityAccounting
{
    public class ElectricBillDocument : IDocument
    {
        private ElectricBill CurrModel { get; set;}
        private Guid _type = new Guid("64501DC6-695C-4F29-AB13-5481A529C228");
        public ElectricBillDocument()
        {
            var CurrModelType = DataModelProvider.GetModel(_type);
            CurrModel = (ElectricBill)Activator.CreateInstance(CurrModelType);
        }
        public ElectricBillDocument(Guid Id)
        {
            var CurrModelType = DataModelProvider.GetModel(_type);
            CurrModel = (ElectricBill)Activator.CreateInstance(CurrModelType);
            using (ApplicationContext db = new ApplicationContext())
            {                
                var incomeDocType = db.DocumentTypes.Where(d => d.IsIncome);                                
            }
        }
        public IDocument Create()
        {
            CurrModel.Id = Guid.NewGuid();
            CurrModel.DocumentTypeId = _type;
            return this;
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }
}
