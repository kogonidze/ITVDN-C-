using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block
{
    class Block
    {
        private int side1, side2, side3, side4;

        public Block(int side1, int side2, int side3, int side4)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            this.side4 = side4;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }

            var block = obj as Block;

            return this.side1 == block.side1 && this.side2 == block.side2
                && this.side3 == block.side3 && this.side4 == block.side4;
        }

        public override int GetHashCode()
        {
            return side1 ^ side2 ^ side3 ^ side4;
        }

        public override string ToString()
        {
            return $"side1: {side1} side2: {side2} side3: {side3} side4: {side4}";
        }
    }
}
