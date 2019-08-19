using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorwellChallenge1
{
    class RoomDimensions
    {
        static decimal lengthA;
        static decimal lengthB;
        static decimal lengthC;
        static decimal lengthD;
        static decimal height;
        static decimal diameter;
        static decimal floorArea;
        static decimal roomVolume;
        static decimal paintRequired;

        public static decimal getLengthA()
        {
            return lengthA;
        }
        public static void setLengthA(decimal input)
        {
            lengthA = input;
        }
        public static decimal getLengthB()
        {
            return lengthB;
        }
        public static void setLengthB(decimal input)
        {
            lengthB = input;
        }
        public static decimal getLengthC()
        {
            return lengthC;
        }
        public static void setLengthC(decimal input)
        {
            lengthC = input;
        }
        public static decimal getLengthD()
        {
            return lengthD;
        }
        public static void setLengthD(decimal input)
        {
            lengthD = input;
        }
        public static decimal getHeight()
        {
            return height;
        }
        public static void setHeight(decimal input)
        {
            height = input;
        }
        public static decimal getDiameter()
        {
            return diameter;
        }
        public static void setDiameter(decimal input)
        {
            diameter = input;
        }
        public static decimal getFloorArea()
        {
            return floorArea;
        }
        public static void setFloorArea(decimal input)
        {
            floorArea = input;
        }
        public static decimal getRoomVolume()
        {
            return roomVolume;
        }
        public static void setRoomVolume(decimal input)
        {
            roomVolume = input;
        }
        public static decimal getPaintRequired()
        {
            return paintRequired;
        }
        public static void setPaintRequired(decimal input)
        {
            paintRequired = input;
        }
    }
}
