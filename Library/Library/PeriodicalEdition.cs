using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class PeriodicalEdition : Edition
    {
        int realisePeriod;
        public int RealisePeriod
        {
            get { return realisePeriod; }
            set
            {
                if (value > 0)
                    realisePeriod = value;
                else
                    throw new ArgumentException();
            }
            
        }
        public PeriodicalEditionType Type;
        public PeriodicalEdition(string name, string authors, int cost, int yearPublication, string publishingHouse, long inventoryNumber, EditionStatus status, int period, PeriodicalEditionType type) : base(name, authors, cost, yearPublication, publishingHouse, inventoryNumber, status)
        {
            RealisePeriod = period;
            Type = type;
        }

        public override string[] GetInfo()
        {
            base.GetInfo();
            var info = new string[1];
            string type;
            if (Type == PeriodicalEditionType.Newspaper)
                type = "газета";
            else
                type = "журнал";
            info[0] = $"Вид периодики: {type}, период выхода: {RealisePeriod}";
            return info;
        }
    }
}
