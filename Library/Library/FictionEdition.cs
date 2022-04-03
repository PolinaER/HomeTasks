using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class FictionEdition : Edition
    {
        public string Genre;
        public string Language;
        public FictionEditionType Type;
       
        public FictionEdition(string name, string authors, int cost, int yearPublication, string publishingHouse, long inventoryNumber, EditionStatus status, string genre, string language, FictionEditionType type) : base(name, authors, cost, yearPublication, publishingHouse, inventoryNumber, status)
        {
            Genre = genre;
            Language = language;
            Type = type;
        }

        public override string[] GetInfo()
        {
            base.GetInfo();
            var inf = new string[1];
            string type;
            if (Type == FictionEditionType.Poetry)
                type = "поэзия";
            else
                type = "проза";
            inf[0] = $"Язык произведения: {Language}, жанр: {Genre}, вид: {type}";
            return inf;
        }
    }
}
