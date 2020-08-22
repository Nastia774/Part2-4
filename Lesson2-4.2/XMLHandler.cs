using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_4._2
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        { Console.WriteLine("Открыт документ типа XML"); }
        public override void Create()
        { Console.WriteLine("Создан документ типа XML"); }
        public override void Change()
        { Console.WriteLine("Изменен документ типа XML"); }
        public override void Save()
        { Console.WriteLine("Сохранен документ типа XML"); }
    }
}
