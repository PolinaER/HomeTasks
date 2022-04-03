using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ScienceEdition : Edition
    {
        public string Science;
        public string Annotation;

        public ScienceEdition(string name, string authors, int cost, int yearPublication, string publishingHouse, long inventoryNumber, EditionStatus status, string science, string annotation) : base(name, authors, cost, yearPublication, publishingHouse, inventoryNumber, status)
        {
            Science = science;
            Annotation = annotation;
        }

        public override string[] GetInfo()
        {
            base.GetInfo();
            var inf = new string[2];
            inf[0] = $"Аннотация: {Annotation}";
            inf[1] = $"Научная область: {Science}";
            return inf;
        }
    }
}
