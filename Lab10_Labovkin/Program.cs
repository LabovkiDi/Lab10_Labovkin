using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Labovkin
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle angle = new Angle(160, 55, 15); /*создание экземпляра объекта класса*/
            Console.WriteLine(angle.ToRadians());
            Console.ReadLine();
        }
    }
    public class Angle /*определение класса*/
    {
        private int grad; /*закрытое поле класса*/
        public int Grad  /*свойство, проверка корректонсти ввода данных*/
        {
            set
            {
                if (value >= 0 && value <= 360)
                {

                    grad = value;
                }
                else
                {
                    Console.WriteLine("Градусы в пределах от 0 до 360");
                }
            }
            get
            {
                return grad;
            }

        }
        private int min; 
        public int Min 
        {
            set
            {
                if (value >= 0 && value <= 60)
                {

                    min = value;
                }
                else
                {
                    Console.WriteLine("Минуты в пределах от 0 до 60");
                }
            }
            get
            {
                return min;
            }

        }
        private int sec; 
        public int Sec 
        {
            set
            {
                if (value >= 0 && value <= 60)
                {

                    sec = value;
                }
                else
                {
                    Console.WriteLine("Секунды в пределах от 0 до 60");
                }
            }
            get
            {
                return sec;
            }
        }
        public Angle(int grad, int min, int sec) /*конструктор класса*/
        {
            //устанавливаем значения полей
            Grad = grad;
            Min = min;
            Sec = sec;
        }
        public double ToRadians()
        {
            return (Grad + Min / 60 + Sec / 3600) * Math.PI / 180;
        }
    }
}
