using System;
using System.Collections.Generic;
using System.IO;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            // 백준 1543
            // 영어로 이루어진 문서에 어떤 단어가 총 몇 번 등장하는지 세는 함수
            // 중복은 제외해서 센다.
            // 인덱스 범위만큼 체크

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            string documnet = sr.ReadLine();
            string searchWord = sr.ReadLine();

            int checkIndex = 0;
            int searchCnt = 0;

            while (checkIndex <= documnet.Length - searchWord.Length)
            {
                if (documnet.Substring(checkIndex, searchWord.Length) == searchWord)
                {
                    searchCnt++;
                    checkIndex += searchWord.Length;
                }
                else
                {
                    checkIndex++;
                }
            }

                
            sw.Write(searchCnt);
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}