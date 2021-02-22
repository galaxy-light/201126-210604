using ConsoleApp2.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.randdata
{
    class RandomData
    {
        public void randData()
        {           
            string[] name = { "홍길동", "김길동", "이길동", "박길동", "최길동"};
            string[] tel = { "010-1111-1111", "010-2222-2222", "010-3333-3333", "010-4444-4444", "010-5555-5555" };
            string[] address = { "서울시 동구 1동", "인천시 동구 1동", "대전시 동구 1동", "대구시 동구 1동", "부산시 동구 1동"};
            string[] email = { "hong@naver.com", "kim@naver.com", "lee@naver.com", "park@naver.com", "choi@naver.com" };

        }

        Random r;

        public RandomData(Random r)
        {
            this.r = r;
        }


        
    }
}
