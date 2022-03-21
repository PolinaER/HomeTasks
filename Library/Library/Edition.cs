using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    ///Поля/свойства(точка означает, что данное свойство следует передавать в конструктор через параметр):
    ///•название
    ///•список авторов; 
    ///•год издания; 
    ///•издательство; 
    ///•инвентарный номер(только для чтения); 
    ///статус(в хранилище, выдана в читальный зал, выдана на дом — использовать перечисление); 
    ///цена.

    public class Edition
    {
        public string Name;
        public string Authors;

        int yearPublication;
        public int YearPublication
        {
            get { return yearPublication; }
            set 
            {
                if (value <= DateTime.Now.Year)
                    yearPublication = value; 
                else
                    throw new ArgumentOutOfRangeException("Неверный год издания!");
            }
        }
        public string PublishingHouse;
        public readonly long InventoryNumber;
        public EditionStatus Status;

        int cost;
        public int Cost
        {
            get { return cost; }
            set
            {
                if (value > 0)
                    cost = value; 
                else
                    throw new ArgumentException("Отрицательная цена!");
            }
        }

        public Edition(string name, string authors, int yearPublication, string publishingHouse, long inventoryNumber)
        {
            Name = name;
            Authors = authors;
            YearPublication = yearPublication;
            PublishingHouse = publishingHouse;
            InventoryNumber = inventoryNumber;
        }

        public override string ToString()
        {
            return $"{Authors}: {Name}, инвентарный номер: {InventoryNumber}";
        }

        public void GetStatus()
        {
            Console.WriteLine(this);
            var status = "";
            switch (Status)
            {
                case EditionStatus.Home:
                    status = "выдана на дом";
                    break;
                case EditionStatus.ReadingRoom:
                    status = "в читательном зале";
                    break;
                case EditionStatus.Storage:
                    status = "в хранилище";
                    break;
            }
            Console.WriteLine($"В данный момент книга {status}");
        }
    }
}
