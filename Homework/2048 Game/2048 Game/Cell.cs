using System;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2048_Game
{
    class Cell
    {
        public int Value { get; set; }


        private Point _location;

        public Point Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }


        public Cell(Point location)
        {
            Value = 0;
            _location = location;
        }
    }
}
