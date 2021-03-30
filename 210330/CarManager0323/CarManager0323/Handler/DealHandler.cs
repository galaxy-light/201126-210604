using CarManager0323.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0330.Handler
{
    class DealHandler
    {
        List<Deal> dealList = new List<Deal>();

        public DealHandler()
        {
            dealList.Add(new Deal("0000", null, null, null)); // 임의의 값을 지정
        }

        public List<Deal> GetDealList()
        {
            return dealList; // get와 동일
        }

        public void dealListClear()
        {
            dealList[0].Car = null;
            dealList[0].Customer = null;
            dealList[0].Seller = null;
            dealList[0].De_dat = "0000";         
        }
    }
}
