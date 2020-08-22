using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_4._3
{
    class Player : IPlayable, IRecodable
    {
        public void Play()
        { Console.WriteLine("Проигрование"); }
        void IPlayable.Pause()
        { Console.WriteLine("Пауза проигрования"); }
        void IPlayable.Stop()
        { Console.WriteLine("Остановка проигрования"); }
        public void Record()
        { Console.WriteLine("Запись"); }
        void IRecodable.Pause()
        { Console.WriteLine("Пауза записи"); }
        void IRecodable.Stop()
        { Console.WriteLine("Остановка записи"); }
    }
}
