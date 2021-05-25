using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
        /*У тілі класу створити два поля, що описують довжини сторін double side1, side2.
        Створити користувальницький конструктор Rectangle(double side1, double side2), в тілі якого поля side1 і side2 ініціалізовуються значеннями аргументів.
        Створити два методи, що обчислюють площу прямокутника - double AreaCalculator () і периметр прямокутника - double PerimeterCalculator ().
        Створити дві властивості double Area і double Perimeter з одним методом доступу get, який перевіряє чи існує значення у відповідних полях, 
        і виводить на консоль повідомлення, якщо результату немає.
        Написати програму, яка приймає від користувача довжини двох сторін прямокутника і виводить на екран периметр і площу.*/
    class Rectangle
    {
        private double side1;
        private double side2;
        private double area;
        private double perimeter; 

        public double Area
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Wrong Value");
                }
                area = value;
            }
            get
            {
                return area;
            }
        }
        public double Perimeter
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Wrong Value");
                }
                perimeter = value;
            }
            get
            {
                return perimeter;
            }
        }
    }
}
