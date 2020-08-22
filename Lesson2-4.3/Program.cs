using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_4._3
{
    class Program
    {
        static void Write(IPlayable playable, IRecodable recodable)
        {
            playable.Play();
            playable.Pause();
            playable.Stop();
            Console.WriteLine();
            recodable.Record();
            recodable.Pause();
            recodable.Stop();
        }
        static void Main(string[] args)
        {
            IPlayable playable = new Player();
            IRecodable recodable = new Player();

            Write(playable, recodable);

            Console.ReadKey();
        }
    }
}
