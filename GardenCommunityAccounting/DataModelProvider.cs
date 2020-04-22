using GardenCommunityAccounting.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GardenCommunityAccounting
{
    public static class DataModelProvider
    {
        private static Dictionary<Guid, Type> ModelsDict = new Dictionary<Guid, Type>
        {
            {new Guid("0F4400DD-DD58-405D-AE7E-34FD0693BD15"), typeof(SpecialPay)},
            {new Guid("64501DC6-695C-4F29-AB13-5481A529C228"), typeof(ElectricBill)},
            {new Guid("6AC1C44F-2DB3-4A54-9BD7-FC3DC40BCDB1"), typeof(LandTax)}
        };
        public static DbSet<object> GetModel(Guid DocumentType, ApplicationContext Cont)            
        {
            throw new NotImplementedException();
        }
    }
}
