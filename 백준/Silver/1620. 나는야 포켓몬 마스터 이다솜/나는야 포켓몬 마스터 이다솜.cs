using System;
using System.Collections.Generic;

namespace CodingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            var firstLineParts = firstLine.Split(' ');

            int N = int.Parse(firstLineParts[0]);
            int M = int.Parse(firstLineParts[1]);

            Dictionary<string, int> pokedex = new Dictionary<string, int>();
            Dictionary<int, string> pokedexIndex = new Dictionary<int, string>();

            for(int i = 1; i <= N; i++)
            {
                string pokemonName = Console.ReadLine();
                pokedex.Add(pokemonName, i);
                pokedexIndex.Add(i, pokemonName);
            }

            for(int i = 0; i < M; i++)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out int index))
                {
                    if (pokedexIndex.TryGetValue(index, out string pokemonName))
                    {
                        Console.WriteLine(pokemonName);
                    }
                    else
                    {
                        Console.WriteLine("해당 번호의 포켓몬이 없습니다.");
                    }
                }
                else
                {
                    // 포켓몬 이름에 해당하는 인덱스 출력
                    if (pokedex.TryGetValue(input, out int pokemonIndex))
                    {
                        Console.WriteLine(pokemonIndex);
                    }
                    else
                    {
                        Console.WriteLine("해당 이름의 포켓몬이 없습니다.");
                    }
                }
            }
        }
    }
}