using System;
using System.Collections.Generic;
using System.Text;

namespace PowerPoint_2
{
    class Vehicle
    {
        private string id;
        public string name;
        private string vehicleType;
        private string size;
        private string color;

        public string Id
        {
            set
            {
               if(value.Length < 10 || value.Length > 30)
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

        public string VehicleType
        {
            set
            {
                if (value != "motorbike" || value != "car" || value != "motorboat")
                {
                    throw new Exception("Wrong vehicle");
                }
                color = value;
            }
            get
            {
                return vehicleType;
            }
        }

        public string Size
        {
            set
            {
                if (value != "small" || value != "medium" || value != "big")
                {
                    throw new Exception("Wrong size");
                }
                size = value;
            }
            get
            {
                return size;
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
    }
}
