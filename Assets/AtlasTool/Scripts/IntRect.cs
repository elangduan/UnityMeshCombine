﻿
namespace Elang.Tools
{
    public struct IntRect
    {
        public int x;
        public int y;

        public int width;
        public int height;

        public IntRect(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public static bool operator ==(IntRect rect1, IntRect rect2)
        {
            return rect1.x == rect2.x && 
                   rect1.y == rect2.y && 
                   rect1.width == rect2.width && 
                   rect1.height == rect2.height;
        }

        public static bool operator !=(IntRect rect1, IntRect rect2)
        {
            return rect1.x != rect2.x ||
                   rect1.y != rect2.y ||
                   rect1.width != rect2.width ||
                   rect1.height != rect2.height;
        }

        public override bool Equals(object obj)
        {
            IntRect otherRect = (IntRect)obj;

            return x == otherRect.x &&
                   y == otherRect.y &&
                   width == otherRect.width &&
                   height == otherRect.height;
        }

        public static IntRect zero = new IntRect(0, 0, 0, 0);
    }

    public struct IntVector2
    {
        public int x;
        public int y;

        public IntVector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}