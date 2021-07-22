using System;

namespace stack_heap
{
    class Program
    {
        static void Main(string[] args)
        {
            State state1 = new State();
            State state2 = new State();

            Country country1 = new Country();
            Country country2 = new Country();

            state1.country1 = new Country();
            state1.country2 = new Country();



            state1.x = 5;
            state1.y = 8;
            state2 = state1;
            state2.x++;
            state2.y++;
            Console.WriteLine($"state1.x={state1.x}\nstate2.x={state2.x}\nstate1.y={state1.y}\nstate2.y={state2.y}\n\n");

            country1.x1 = 12;
            country1.y1 = 18;
            country2 = country1;
            country2.x1++;
            country2.y1++;
            Console.WriteLine($"country1.x1={country1.x1}\ncountry2.x1={country2.x1}\ncountry1.y1={country1.y1}\ncountry2.y1={country2.y1}\n\n");

            state1.country1.x1 = 25;
            state1.country1.y1 = 34;
            state1.country2 = state1.country1;
            state1.country2.x1++;
            state1.country2.y1++;
            Console.WriteLine($"state1.country1.x1={state1.country1.x1}\nstate1.country2.x1={state1.country2.x1}\nstate1.country1.y1={state1.country1.y1}\nstate1.country2.y1={state1.country2.y1}\n\n");
        }

        struct State
        {
            public int x;
            public int y;
            public Country country1;
            public Country country2;
        }
        class Country
        {
            public int x1;
            public int y1;
        }
    }
}
