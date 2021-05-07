using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class TicTacToe
    {
        //게임을 핸들링 하는 클래스
        int seq;
        public int Seq
        {
            get { return seq; }
            set { seq = value; }
        }
        int[] btnStatus = new int[9] { 3, 4, 5, 6, 7, 8, 9, 10, 11 };

        public bool WinnerCheck()
        {
            if (btnStatus[0] == btnStatus[1] && btnStatus[1] == btnStatus[2]) { return true; }
            if (btnStatus[0] == btnStatus[3] && btnStatus[3] == btnStatus[6]) { return true; }
            if (btnStatus[0] == btnStatus[4] && btnStatus[4] == btnStatus[8]) { return true; }
            if (btnStatus[1] == btnStatus[4] && btnStatus[4] == btnStatus[7]) { return true; }
            if (btnStatus[2] == btnStatus[4] && btnStatus[4] == btnStatus[6]) { return true; }
            if (btnStatus[2] == btnStatus[5] && btnStatus[5] == btnStatus[8]) { return true; }
            if (btnStatus[3] == btnStatus[4] && btnStatus[4] == btnStatus[5]) { return true; }
            if (btnStatus[6] == btnStatus[7] && btnStatus[7] == btnStatus[8]) { return true; }
            return false;
        }
         public void Mark(int index)
        {
            seq++;
            if (seq %2 ==1)
            {
                btnStatus[index] = 1;
            }
            else
            {
                btnStatus[index] = 2;
            }

        }
    }
}
