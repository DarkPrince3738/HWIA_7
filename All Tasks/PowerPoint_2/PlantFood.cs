using System;
using System.Collections.Generic;
using System.Text;

namespace PowerPoint_2
{
    class PlantFood
    {
        private string id;
        private string name;
        private string type;
        private string weigth;
        private string color;

        public string Id
        {
            set
            {
                if (value.Length < 10 || value.Length > 30)
                {
                    throw new Exception("Wrong length");
                }
                id = value;
            }
            get
            {
                return id;
            }
        }

        public string Color
        {
            set
            {
                if (value != "grey" || value != "black" || value != "white")
                {
                    throw new Exception("Wrong color");
                }
                color = value;
            }
            get
            {
                return color;
            }
        }

        public string Type
        {
            set
            {
                if (value != "fruit" || value != "vegetable" || value != "berry")
                {
                    throw new Exception("Wrong type");
                }
                type = value;
            }
            get
            {
                return type;
            }
        }

        public string Weigth
        {
            set
            {
                if (value != "small" || value != "medium" || value != "big")
                {
                    throw new Exception("Wrong size");
                }
                weigth = value;
            }
            get
            {
                return weigth;
            }
        }

        public string GetFoodInfo()
        {
            return $"" +
                $"id - {Id}\n" +
                $"Name - {name}\n" +
                $"Type - {Type}\n";
        }

        private void ValidateColor(string color)
        {
            if (color != "grey" || color != "black" || color != "white")
            {
                throw new Exception("Wrong color");
            }
        }
    }
}