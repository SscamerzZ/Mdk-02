using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class room
    {
        double roomLength;
        double roomWidth;

        public double RoomLength
        {
            get { return roomLength; } 
            set { roomLength = value; }
        }

        public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }

        public double RoomPerimeter()
        {
            return 2 * (RoomLength + RoomWidth);
        }

        public double RoomArea()
        {
            return roomLength * roomWidth;
        }

        public double PersonaArea(int np)
        {
            return RoomArea() / np;
        }
    }
}
