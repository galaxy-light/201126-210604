using CarManager0323.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0330.Handler
{
    class DealHandler // 객체 정보 관리
    {
        List<Deal> dealList = new List<Deal>();

        public DealHandler()
        {
            dealList.Add(new Deal("0000", null, null, null)); // 더미 값을 지정
        }

        public List<Deal> GetDealList() // getter와 동일한 메서드
        {
            return dealList;
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
