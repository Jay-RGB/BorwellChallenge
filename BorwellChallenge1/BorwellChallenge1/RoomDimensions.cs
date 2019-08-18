using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorwellChallenge1
{
    class RoomDimensions
    {
        private decimal lengthA;
        private decimal lengthB;
        private decimal lengthC;
        private decimal lengthD;
        private decimal height;
        private decimal diameter;
        private decimal voidSpaceHeight;
        private decimal voidSpaceWidth;
        private decimal floorArea;
        private decimal roomVolume;
        private decimal paintRequired;

        public decimal getLengthA()
        {
            return lengthA;
        }
        public void setLengthA(decimal input)
        {
            lengthA = input;
        }
        public decimal getLengthB()
        {
            return lengthB;
        }
        public void setLengthB(decimal input)
        {
            lengthB = input;
        }
        public decimal getLengthC()
        {
            return lengthC;
        }
        public void setLengthC(decimal input)
        {
            lengthC = input;
        }
        public decimal getLengthD()
        {
            return lengthD;
        }
        public void setLengthD(decimal input)
        {
            lengthD = input;
        }
        public decimal getHeight()
        {
            return height;
        }
        public void setHeight(decimal input)
        {
            height = input;
        }
        public decimal getDiameter()
        {
            return diameter;
        }
        public void setDiameter(decimal input)
        {
            diameter = input;
        }
        public decimal getVoidSpaceHeight()
        {
            return voidSpaceHeight;
        }
        public void setVoidSpaceHeight(decimal input)
        {
            voidSpaceHeight = input;
        }
        public decimal getVoidSpaceWidth()
        {
            return voidSpaceWidth;
        }
        public void setVoidSpaceWidth(decimal input)
        {
            voidSpaceWidth = input;
        }
        public decimal getFloorArea()
        {
            return floorArea;
        }
        public void setFloorArea(decimal input)
        {
            floorArea = input;
        }
        public decimal getRoomVolume()
        {
            return roomVolume;
        }
        public void setRoomVolume(decimal input)
        {
            roomVolume = input;
        }
        public decimal getPaintRequired()
        {
            return paintRequired;
        }
        public void setPaintRequired(decimal input)
        {
            paintRequired = input;
        }
    }
}
