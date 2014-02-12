using System;
using System.Collections.Generic;
using System.Collections;

// Define a class BitArray64 to hold 64 bit values inside an ulong value. Implement IEnumerable<int> and Equals(…), 
// GetHashCode(), [], == and !=.

namespace BitArray
{
    class BitArray64 : IEnumerable<int>
    {
        private readonly ulong value;
        public int[] ValueBits
        {
            get
            {
                return this.ConvertValueToBits();
            }
        }

        public BitArray64(ulong inputValue = 0)
        {
            this.value = inputValue;
        }

        private int[] ConvertValueToBits()
        {
            ulong tempValue = this.value;
            int index = 63;
            int[] bits = new int[64];

            while (tempValue > 0)
            {
                bits[index] = (int)tempValue % 2;
                tempValue = tempValue / 2;
                index--;
            }

            Array.Reverse(bits);

            return bits;
        }

        public IEnumerator<int> GetEnumerator()
        {
            int[] bits = this.ConvertValueToBits();
            Array.Reverse(bits);

            for (int i = 0; i < bits.Length; i++)
            {
                yield return bits[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            BitArray64 compareValue = obj as BitArray64;

            if ((object)compareValue == null)
            {
                return false;
            }

            return this.Equals(compareValue);
        }

        public bool Equals(BitArray64 value)
        {
            if (ReferenceEquals(null, value))
            {
                return false;
            }
            if (ReferenceEquals(this, value))
            {
                return true;
            }
            return this.value == value.value;
        }

        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new System.IndexOutOfRangeException();
                }

                int[] bits = this.ConvertValueToBits();
                return bits[index];
            }
        }

        public static bool operator ==(BitArray64 firstValue, BitArray64 secondValue)
        {
            return BitArray64.Equals(firstValue, secondValue);
        }

        public static bool operator !=(BitArray64 firstValue, BitArray64 secondValue)
        {
            return !BitArray64.Equals(firstValue, secondValue);
        }
    }
}
