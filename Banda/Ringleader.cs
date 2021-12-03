using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banda
{
    /*Класс Ringleaader реализует методы главаря банды.
     * Имеет состояния 0 - бездействие, 1 - подготовка к ограблению, 2 - арестован.
     * Во время подготовки оповещает всех членов банды об ограблении и ожидает готовность всех членов банды.
     * При аресте оповещает всех об отмене ограбления.
     */
    class Ringleader : IRingleader
    {   
        public int State { get; set; } = 0;

        private int bandaReadyState = 0;

        private List<IGangMember> _gangMember = new List<IGangMember>();

        public void AddToBand(IGangMember member)
        {
            Console.WriteLine(member.Name + " присоединился к банде!");
            _gangMember.Add(member);
        }

        public void RemoveFromBand(IGangMember member)
        {
            Console.WriteLine(member.Name + " исключен из банды!");
            _gangMember.Remove(member);
        }

        public void Notify()
        {
            foreach (var member in _gangMember)
            {
                member.Ready(this);
            }
        }

        public void Planning()
        {
            State = 1;
            if (State == 1)
            {
                Console.WriteLine("Главарь идет грабить банк");
                Notify();
            }
            else
            {
                Console.WriteLine("Главарь не идет грабить банк");
            }
        }

        public void BandaReady(IGangMember member)
        {
            bandaReadyState++;
            Console.WriteLine(member.Name + " готов!");

            if (bandaReadyState == _gangMember.Count())
            {
                Console.WriteLine("Все готовы");
                Console.WriteLine("Ограбление совершенно!");
            }
        
        }

            public void Wasted()
        {
            State = 2;
            Console.WriteLine("Ограбление не состаится!");
            Notify();
        }
    }
}
