// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct int4x4 : System.IEquatable<int4x4>, IFormattable
    {
        public int4 c0;
        public int4 c1;
        public int4 c2;
        public int4 c3;

        /// <summary>int4x4 identity transform.</summary>
        public static readonly int4x4 identity = new int4x4(1, 0, 0, 0,   0, 1, 0, 0,   0, 0, 1, 0,   0, 0, 0, 1);

        /// <summary>int4x4 zero value.</summary>
        public static readonly int4x4 zero;

        /// <summary>Constructs a int4x4 matrix from four int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x4(int4 c0, int4 c1, int4 c2, int4 c3)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        /// <summary>Constructs a int4x4 matrix from 16 int values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x4(int m00, int m01, int m02, int m03,
                      int m10, int m11, int m12, int m13,
                      int m20, int m21, int m22, int m23,
                      int m30, int m31, int m32, int m33)
        { 
            this.c0 = new int4(m00, m10, m20, m30);
            this.c1 = new int4(m01, m11, m21, m31);
            this.c2 = new int4(m02, m12, m22, m32);
            this.c3 = new int4(m03, m13, m23, m33);
        }

        /// <summary>Constructs a int4x4 matrix from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x4(int v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        /// <summary>Constructs a int4x4 matrix from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x4(bool v)
        {
            this.c0 = math.select(new int4(0), new int4(1), v);
            this.c1 = math.select(new int4(0), new int4(1), v);
            this.c2 = math.select(new int4(0), new int4(1), v);
            this.c3 = math.select(new int4(0), new int4(1), v);
        }

        /// <summary>Constructs a int4x4 matrix from a bool4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x4(bool4x4 v)
        {
            this.c0 = math.select(new int4(0), new int4(1), v.c0);
            this.c1 = math.select(new int4(0), new int4(1), v.c1);
            this.c2 = math.select(new int4(0), new int4(1), v.c2);
            this.c3 = math.select(new int4(0), new int4(1), v.c3);
        }

        /// <summary>Constructs a int4x4 matrix from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x4(uint v)
        {
            this.c0 = (int4)v;
            this.c1 = (int4)v;
            this.c2 = (int4)v;
            this.c3 = (int4)v;
        }

        /// <summary>Constructs a int4x4 matrix from a uint4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x4(uint4x4 v)
        {
            this.c0 = (int4)v.c0;
            this.c1 = (int4)v.c1;
            this.c2 = (int4)v.c2;
            this.c3 = (int4)v.c3;
        }

        /// <summary>Constructs a int4x4 matrix from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x4(float v)
        {
            this.c0 = (int4)v;
            this.c1 = (int4)v;
            this.c2 = (int4)v;
            this.c3 = (int4)v;
        }

        /// <summary>Constructs a int4x4 matrix from a float4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x4(float4x4 v)
        {
            this.c0 = (int4)v.c0;
            this.c1 = (int4)v.c1;
            this.c2 = (int4)v.c2;
            this.c3 = (int4)v.c3;
        }

        /// <summary>Constructs a int4x4 matrix from a single double value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x4(double v)
        {
            this.c0 = (int4)v;
            this.c1 = (int4)v;
            this.c2 = (int4)v;
            this.c3 = (int4)v;
        }

        /// <summary>Constructs a int4x4 matrix from a double4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x4(double4x4 v)
        {
            this.c0 = (int4)v.c0;
            this.c1 = (int4)v.c1;
            this.c2 = (int4)v.c2;
            this.c3 = (int4)v.c3;
        }


        /// <summary>Implicitly converts a single int value to a int4x4 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int4x4(int v) { return new int4x4(v); }

        /// <summary>Explicitly converts a single bool value to a int4x4 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x4(bool v) { return new int4x4(v); }

        /// <summary>Explicitly converts a bool4x4 matrix to a int4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x4(bool4x4 v) { return new int4x4(v); }

        /// <summary>Explicitly converts a single uint value to a int4x4 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x4(uint v) { return new int4x4(v); }

        /// <summary>Explicitly converts a uint4x4 matrix to a int4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x4(uint4x4 v) { return new int4x4(v); }

        /// <summary>Explicitly converts a single float value to a int4x4 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x4(float v) { return new int4x4(v); }

        /// <summary>Explicitly converts a float4x4 matrix to a int4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x4(float4x4 v) { return new int4x4(v); }

        /// <summary>Explicitly converts a single double value to a int4x4 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x4(double v) { return new int4x4(v); }

        /// <summary>Explicitly converts a double4x4 matrix to a int4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x4(double4x4 v) { return new int4x4(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator * (int4x4 lhs, int4x4 rhs) { return new int4x4 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2, lhs.c3 * rhs.c3); }

        /// <summary>Returns the result of a componentwise multiplication operation on an int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator * (int4x4 lhs, int rhs) { return new int4x4 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs, lhs.c3 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on an int value and an int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator * (int lhs, int4x4 rhs) { return new int4x4 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2, lhs * rhs.c3); }


        /// <summary>Returns the result of a componentwise addition operation on two int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator + (int4x4 lhs, int4x4 rhs) { return new int4x4 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2, lhs.c3 + rhs.c3); }

        /// <summary>Returns the result of a componentwise addition operation on an int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator + (int4x4 lhs, int rhs) { return new int4x4 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs, lhs.c3 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on an int value and an int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator + (int lhs, int4x4 rhs) { return new int4x4 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2, lhs + rhs.c3); }


        /// <summary>Returns the result of a componentwise subtraction operation on two int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator - (int4x4 lhs, int4x4 rhs) { return new int4x4 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2, lhs.c3 - rhs.c3); }

        /// <summary>Returns the result of a componentwise subtraction operation on an int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator - (int4x4 lhs, int rhs) { return new int4x4 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs, lhs.c3 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on an int value and an int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator - (int lhs, int4x4 rhs) { return new int4x4 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2, lhs - rhs.c3); }


        /// <summary>Returns the result of a componentwise division operation on two int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator / (int4x4 lhs, int4x4 rhs) { return new int4x4 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2, lhs.c3 / rhs.c3); }

        /// <summary>Returns the result of a componentwise division operation on an int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator / (int4x4 lhs, int rhs) { return new int4x4 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs, lhs.c3 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on an int value and an int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator / (int lhs, int4x4 rhs) { return new int4x4 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2, lhs / rhs.c3); }


        /// <summary>Returns the result of a componentwise modulus operation on two int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator % (int4x4 lhs, int4x4 rhs) { return new int4x4 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2, lhs.c3 % rhs.c3); }

        /// <summary>Returns the result of a componentwise modulus operation on an int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator % (int4x4 lhs, int rhs) { return new int4x4 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs, lhs.c3 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on an int value and an int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator % (int lhs, int4x4 rhs) { return new int4x4 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2, lhs % rhs.c3); }


        /// <summary>Returns the result of a componentwise increment operation on an int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator ++ (int4x4 val) { return new int4x4 (++val.c0, ++val.c1, ++val.c2, ++val.c3); }


        /// <summary>Returns the result of a componentwise decrement operation on an int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator -- (int4x4 val) { return new int4x4 (--val.c0, --val.c1, --val.c2, --val.c3); }


        /// <summary>Returns the result of a componentwise less than operation on two int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator < (int4x4 lhs, int4x4 rhs) { return new bool4x4 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2, lhs.c3 < rhs.c3); }

        /// <summary>Returns the result of a componentwise less than operation on an int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator < (int4x4 lhs, int rhs) { return new bool4x4 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs, lhs.c3 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on an int value and an int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator < (int lhs, int4x4 rhs) { return new bool4x4 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2, lhs < rhs.c3); }


        /// <summary>Returns the result of a componentwise less or equal operation on two int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator <= (int4x4 lhs, int4x4 rhs) { return new bool4x4 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2, lhs.c3 <= rhs.c3); }

        /// <summary>Returns the result of a componentwise less or equal operation on an int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator <= (int4x4 lhs, int rhs) { return new bool4x4 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs, lhs.c3 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on an int value and an int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator <= (int lhs, int4x4 rhs) { return new bool4x4 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2, lhs <= rhs.c3); }


        /// <summary>Returns the result of a componentwise greater than operation on two int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator > (int4x4 lhs, int4x4 rhs) { return new bool4x4 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2, lhs.c3 > rhs.c3); }

        /// <summary>Returns the result of a componentwise greater than operation on an int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator > (int4x4 lhs, int rhs) { return new bool4x4 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs, lhs.c3 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on an int value and an int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator > (int lhs, int4x4 rhs) { return new bool4x4 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2, lhs > rhs.c3); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator >= (int4x4 lhs, int4x4 rhs) { return new bool4x4 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2, lhs.c3 >= rhs.c3); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator >= (int4x4 lhs, int rhs) { return new bool4x4 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs, lhs.c3 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an int value and an int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator >= (int lhs, int4x4 rhs) { return new bool4x4 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2, lhs >= rhs.c3); }


        /// <summary>Returns the result of a componentwise unary minus operation on an int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator - (int4x4 val) { return new int4x4 (-val.c0, -val.c1, -val.c2, -val.c3); }


        /// <summary>Returns the result of a componentwise unary plus operation on an int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator + (int4x4 val) { return new int4x4 (+val.c0, +val.c1, +val.c2, +val.c3); }


        /// <summary>Returns the result of a componentwise left shift operation on an int4x4 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator << (int4x4 x, int n) { return new int4x4 (x.c0 << n, x.c1 << n, x.c2 << n, x.c3 << n); }

        /// <summary>Returns the result of a componentwise right shift operation on an int4x4 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator >> (int4x4 x, int n) { return new int4x4 (x.c0 >> n, x.c1 >> n, x.c2 >> n, x.c3 >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator == (int4x4 lhs, int4x4 rhs) { return new bool4x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }

        /// <summary>Returns the result of a componentwise equality operation on an int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator == (int4x4 lhs, int rhs) { return new bool4x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on an int value and an int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator == (int lhs, int4x4 rhs) { return new bool4x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }


        /// <summary>Returns the result of a componentwise not equal operation on two int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator != (int4x4 lhs, int4x4 rhs) { return new bool4x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }

        /// <summary>Returns the result of a componentwise not equal operation on an int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator != (int4x4 lhs, int rhs) { return new bool4x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on an int value and an int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator != (int lhs, int4x4 rhs) { return new bool4x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }


        /// <summary>Returns the result of a componentwise bitwise not operation on an int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator ~ (int4x4 val) { return new int4x4 (~val.c0, ~val.c1, ~val.c2, ~val.c3); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator & (int4x4 lhs, int4x4 rhs) { return new int4x4 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2, lhs.c3 & rhs.c3); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator & (int4x4 lhs, int rhs) { return new int4x4 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs, lhs.c3 & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an int value and an int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator & (int lhs, int4x4 rhs) { return new int4x4 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2, lhs & rhs.c3); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator | (int4x4 lhs, int4x4 rhs) { return new int4x4 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2, lhs.c3 | rhs.c3); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator | (int4x4 lhs, int rhs) { return new int4x4 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs, lhs.c3 | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an int value and an int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator | (int lhs, int4x4 rhs) { return new int4x4 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2, lhs | rhs.c3); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator ^ (int4x4 lhs, int4x4 rhs) { return new int4x4 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2, lhs.c3 ^ rhs.c3); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator ^ (int4x4 lhs, int rhs) { return new int4x4 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs, lhs.c3 ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an int value and an int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator ^ (int lhs, int4x4 rhs) { return new int4x4 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2, lhs ^ rhs.c3); }



        /// <summary>Returns the int4 element at a specified index.</summary>
        unsafe public int4 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (int4x4* array = &this) { return ((int4*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (int4* array = &c0) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the int4x4 is equal to a given int4x4, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(int4x4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }

        /// <summary>Returns true if the int4x4 is equal to a given int4x4, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((int4x4)o); }


        /// <summary>Returns a hash code for the int4x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the int4x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("int4x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7},  {8}, {9}, {10}, {11},  {12}, {13}, {14}, {15})", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y, c0.z, c1.z, c2.z, c3.z, c0.w, c1.w, c2.w, c3.w);
        }

        /// <summary>Returns a string representation of the int4x4 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("int4x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7},  {8}, {9}, {10}, {11},  {12}, {13}, {14}, {15})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c3.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c3.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c2.z.ToString(format, formatProvider), c3.z.ToString(format, formatProvider), c0.w.ToString(format, formatProvider), c1.w.ToString(format, formatProvider), c2.w.ToString(format, formatProvider), c3.w.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        /// <summary>Returns a int4x4 matrix constructed from four int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 int4x4(int4 c0, int4 c1, int4 c2, int4 c3) { return new int4x4(c0, c1, c2, c3); }

        /// <summary>Returns a int4x4 matrix constructed from from 16 int values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 int4x4(int m00, int m01, int m02, int m03,
                                    int m10, int m11, int m12, int m13,
                                    int m20, int m21, int m22, int m23,
                                    int m30, int m31, int m32, int m33)
        {
            return new int4x4(m00, m01, m02, m03,
                              m10, m11, m12, m13,
                              m20, m21, m22, m23,
                              m30, m31, m32, m33);
        }

        /// <summary>Returns a int4x4 matrix constructed from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 int4x4(int v) { return new int4x4(v); }

        /// <summary>Returns a int4x4 matrix constructed from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 int4x4(bool v) { return new int4x4(v); }

        /// <summary>Return a int4x4 matrix constructed from a bool4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 int4x4(bool4x4 v) { return new int4x4(v); }

        /// <summary>Returns a int4x4 matrix constructed from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 int4x4(uint v) { return new int4x4(v); }

        /// <summary>Return a int4x4 matrix constructed from a uint4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 int4x4(uint4x4 v) { return new int4x4(v); }

        /// <summary>Returns a int4x4 matrix constructed from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 int4x4(float v) { return new int4x4(v); }

        /// <summary>Return a int4x4 matrix constructed from a float4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 int4x4(float4x4 v) { return new int4x4(v); }

        /// <summary>Returns a int4x4 matrix constructed from a single double value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 int4x4(double v) { return new int4x4(v); }

        /// <summary>Return a int4x4 matrix constructed from a double4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 int4x4(double4x4 v) { return new int4x4(v); }

        /// <summary>Return the int4x4 transpose of a int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 transpose(int4x4 v)
        {
            return int4x4(
                v.c0.x, v.c0.y, v.c0.z, v.c0.w,
                v.c1.x, v.c1.y, v.c1.z, v.c1.w,
                v.c2.x, v.c2.y, v.c2.z, v.c2.w,
                v.c3.x, v.c3.y, v.c3.z, v.c3.w);
        }

        /// <summary>Returns the determinant of a int4x4 matrix.</summary>
        public static int determinant(int4x4 m)
        {
            int4 c0 = m.c0;
            int4 c1 = m.c1;
            int4 c2 = m.c2;
            int4 c3 = m.c3;

            int m00 = c1.y * (c2.z * c3.w - c2.w * c3.z) - c2.y * (c1.z * c3.w - c1.w * c3.z) + c3.y * (c1.z * c2.w - c1.w * c2.z);
            int m01 = c0.y * (c2.z * c3.w - c2.w * c3.z) - c2.y * (c0.z * c3.w - c0.w * c3.z) + c3.y * (c0.z * c2.w - c0.w * c2.z);
            int m02 = c0.y * (c1.z * c3.w - c1.w * c3.z) - c1.y * (c0.z * c3.w - c0.w * c3.z) + c3.y * (c0.z * c1.w - c0.w * c1.z);
            int m03 = c0.y * (c1.z * c2.w - c1.w * c2.z) - c1.y * (c0.z * c2.w - c0.w * c2.z) + c2.y * (c0.z * c1.w - c0.w * c1.z);

            return c0.x * m00 - c1.x * m01 + c2.x * m02 - c3.x * m03;
        }

        /// <summary>Returns a uint hash code of a int4x4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(int4x4 v)
        {
            return csum(asuint(v.c0) * uint4(0x5D1B165Bu, 0x87096CD7u, 0x4C7F6DD1u, 0x4822A3E9u) + 
                        asuint(v.c1) * uint4(0xAAC3C25Du, 0xD21D0945u, 0x88FCAB2Du, 0x614DA60Du) + 
                        asuint(v.c2) * uint4(0x5BA2C50Bu, 0x8C455ACBu, 0xCD266C89u, 0xF1852A33u) + 
                        asuint(v.c3) * uint4(0x77E35E77u, 0x863E3729u, 0xE191B035u, 0x68586FAFu)) + 0xD4DFF6D3u;
        }

        /// <summary>
        /// Returns a uint4 vector hash code of a int4x4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 hashwide(int4x4 v)
        {
            return (asuint(v.c0) * uint4(0xCB634F4Du, 0x9B13B92Du, 0x4ABF0813u, 0x86068063u) + 
                    asuint(v.c1) * uint4(0xD75513F9u, 0x5AB3E8CDu, 0x676E8407u, 0xB36DE767u) + 
                    asuint(v.c2) * uint4(0x6FCA387Du, 0xAF0F3103u, 0xE4A056C7u, 0x841D8225u) + 
                    asuint(v.c3) * uint4(0xC9393C7Du, 0xD42EAFA3u, 0xD9AFD06Du, 0x97A65421u)) + 0x7809205Fu;
        }

    }
}
