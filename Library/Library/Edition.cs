using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
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

        public Edition(string name, string authors, int cost, int yearPublication, string publishingHouse, long inventoryNumber, EditionStatus status)
        {
            Name = name;
            Authors = authors;
            Cost = cost;
            YearPublication = yearPublication;
            PublishingHouse = publishingHouse;
            InventoryNumber = inventoryNumber;
            Status = status;
        }

        public virtual string[] GetInfo()
        {
            var info = new string[3];
            info[0] = ToString();
            info[1] = $"Год публикации: {PublishingHouse}, дата публикации: {YearPublication}";

            string status;
            if (Status == EditionStatus.Home)
                status = "выдана на дом";
            else if (Status == EditionStatus.ReadingRoom)
                status = "в читательном зале";
            else
                status = "в хранилище";

            info[2] = $"Стоимость: {Cost}. Статус издания: {status}";
            return info;

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
