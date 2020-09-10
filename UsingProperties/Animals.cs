using System;
using System.Collections.Generic;
using System.Text;

namespace UsingProperties
{
    class Animals
    {
        public string Name;
        public string Type;
        public string Sound;
        public string Consume;
        public string Produce;
        public string Located;
        private string size;

        public Animals(string aName, string aType, string aSound, string aConsume, string aProduce, string aLocated, string aSize)
        {
            Name = aName;
            Type = aType;
            Sound = aSound;
            Consume = aConsume;
            Produce = aProduce;
            Located = aLocated;
            Size = aSize;
        }

        public string Size
        {
            get { return size; }
            set {
                if (value == "tiny" || value == "small" || value == "medium" || value == "big")
                {
                    size = value;
                }
                else
                {
                    size = "Invalid size";
                }
                
            }
        }
    }
}
