using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WameedhDataAccess;

namespace WammeedBuisness
{
    public class ClsBiItemStatistique
    {
        public static DataTable GetItemStatistique(int _BorrowingsID)
        {
            return ClsItemStatistiqueDatta.GetItemStatistique(_BorrowingsID);
        }
    }
}
