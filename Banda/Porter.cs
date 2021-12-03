using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banda
{
    /*Класс Porter реализует методы носильщика(полицейского).
     * Имеет состояния true - полицейский, false - бандит.
     * Во время оповещения об ограблении при состоянии поцейского арестовывает всех.
     */
    class Porter : IGangMember
    {
        public IRingleader _ringleader { get; set; }
        public string Name { get; set; } = "Носильщик";
        private bool rat;

        public Porter(IRingleader ringleader, bool rat)
        {
            _ringleader = ringleader;
            this.rat = rat;
        }

        public void Ready(IRingleader ringleader)
        {
            if ((ringleader as Ringleader).State == 1)
            {
                if (rat)
                {
                    Console.WriteLine("Полиция! Вы арестованы!");
                    _ringleader.Wasted();
                }
                else
                {
                    _ringleader.BandaReady(this);
                }
            }
        }
    }
}
