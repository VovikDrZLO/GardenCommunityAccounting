using System;
using System.Collections.Generic;
using System.Text;

namespace GardenCommunityAccounting
{
    public interface IDocument
    {
        IDocument Create();
        bool Delete();
        bool Save();
    }
}
