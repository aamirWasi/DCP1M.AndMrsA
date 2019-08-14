using System;
namespace DCP1M.AndMrsA
{
    public class DCP569JerseyNumber10
    {
        static void Main()
        {
            uint T = uint.Parse(Console.ReadLine());
            for (uint t = 0; t < T; t++)
            {
                uint player = uint.Parse(Console.ReadLine());
                uint max = 0;
                string name = string.Empty;
                for (uint p = 1; p <= player; p++)
                {
                    string line = Console.ReadLine();
                    var space = line.Split(' ');
                    string playerName = space[0];
                    bool isTrue = playerName.Length < 3 ? true : false;
                    uint experiencedYear = uint.Parse(space[1]);
                    if (isTrue)
                    {
                        if (max < experiencedYear)
                        {
                            max = experiencedYear;
                            name = playerName;
                        } 
                    }
                }
                Console.WriteLine($"{name}");
            }
        }
    } 
}
