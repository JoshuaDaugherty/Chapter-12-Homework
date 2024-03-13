using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiling
{
    internal class ClassRoom
    {
        //Create a class Room
        class Room
        {
            //Member variable
            private string _name;
            private int _width;
            private int _length;
            private int _area;
            private int _boxes;
            //Parameterized constructor
            public Room(string name, int width, int length)
            {
                _name = name;
                _width = width;
                _length = length;
                _area = _width * _length;
                _boxes = _area / 12;
                if (_area - (12 * _boxes) != 0)
                {
                    _boxes += 2;
                }
                else
                {
                    _boxes += 1;
                }
            }
            //Method return a string of room details
            public string Display()
            {
                return _name + " (" + _width + "*" + _length + ") needs " + _boxes + " boxes";
            }
            //Accessors
            public string getName()
            {
                return _name;
            }
            public int getWidth()
            {
                return _width;
            }

            public int getLength()
            {
                return _length;
            }
            public int getArea()
            {
                return _area;
            }
            public int getBoxes()
            {
                return _boxes;
            }

           
        }
    }
}
