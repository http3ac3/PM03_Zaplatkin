using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM03_Zaplatkin
{
    class Trip
    {
        private string duration;
        private decimal price;
        private int tourGroupSize;

        public string GetDuration()
        {
            return this.duration;
        }

        public void SetDuration(string duration)
        {
            if (duration.Length == 0)
            {
                throw new Exception("Информация о продолжительности поездки должна быть заполнена!");
            }
            this.duration = duration;
        }

        public decimal GetPrice()
        {
            return this.price;
        }

        public void SetPrice(decimal price)
        {
            if (price <= 0)
            {
                throw new Exception("Цена поездки не может быть меньше или равна нулю!");
            }
            this.price = price;
        }

        public int GetTourGroupSize()
        {
            return this.tourGroupSize;
        }

        public void SetTourGroupSize(int tourGroupSize)
        {
            if (tourGroupSize <= 0)
            {
                throw new Exception("Размер туристической группы не может быть меньше или равен нулю!");
            }
            this.tourGroupSize = tourGroupSize;
        }

        public override string ToString()
        {
            return "Продолжительность поездки: " + this.duration + 
                   ", Цена поездки: " + this.price +
                   ", Размер туристической группы: " + this.tourGroupSize;
        }
    }
}
