using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressTest0222.util
{
    // 랜덤 메서드를 따로 빼는 이유는 재활용하기 위해
    // 객체가 아무리 많이 생성되어도 한 번만 관리하겠다
    class RandData
    {
        // static을 쓴 배열이 너무 크면 over static이 되기 때문에 큰 배열에는 사용X
        // const : 하나의 변수에만 사용 가능 (상수 변수)
        // readonly : 배열에 사용 가능 (배열 상수)

        static string[] name = { "홍길동", "김길동", "이길동", "박길동", "최길동" };
        static string[] tel = { "010-1111-1111", "010-2222-2222", "010-2222-3333", "010-2222-4444", "010-2222-5555" };
        static string[] address = { "대구시 동구 신암동", "광주시 동구 신암동", "서울시 동구 신암동", "대전시 동구 신암동", "부산시 동구 신암동" };
        static string[] email = { "hong@naver.com", "kim@naver.com", "lee@naver.com", "park@naver.com", "choi@naver.com" };

        readonly Random r;

        // 객체(RandData)가 생성되어질 때 매개 변수(Random r)도 같이 생성
        public RandData(Random r) // 매개 변수가 있는 생성자 -> 반드시 외부에서 정보를 받아서 인스턴스 변수에 던져줘야 함
        {
            this.r = r;
        }

        public string getName() // Random r : 매개 변수 -> 삭제(자동으로 생성되기 때문에)
        {
            return name[r.Next(0, 5)];
        }

        public string getTel()
        {
            return tel[r.Next(0, 5)];
        }

        public string getAddress()
        {
            return address[r.Next(0, 5)];
        }

        public string getEmail()
        {
            return email[r.Next(0, 5)];
        }

        /* public void randData()
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                addrList.Add(new Student(name[r.Next(0, 5)], tel[r.Next(0, 5)], address[r.Next(0, 5)], email[r.Next(0, 5)]));
            }
        }*/

        public string getId() // Random r : 외부에서 받는 정보 -> 삭제
        {
            // Random r = new Random();
            string rdata = "abcdefghijkmnopqrstuvwxyz0123456789ABCDEFGHJKLMNOPQRSTUVWXYZ~!@#$%^&*?"; // 구분이 안되는 것은 삭제
            StringBuilder rs = new StringBuilder();
            for (int i = 0; i < 7; i++)
            {
                rs.Append(rdata[(int)(r.NextDouble() * rdata.Length)]);
            }
            //Console.WriteLine("id: " + rs.ToString());
            return rs.ToString();
        }
    }
}
