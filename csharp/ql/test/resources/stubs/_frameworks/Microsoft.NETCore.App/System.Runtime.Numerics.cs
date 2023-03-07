// This file contains auto-generated code.
// Generated from `System.Runtime.Numerics, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a`.

namespace System
{
    namespace Numerics
    {
        public struct BigInteger : System.IComparable, System.IComparable<System.Numerics.BigInteger>, System.IEquatable<System.Numerics.BigInteger>, System.IFormattable, System.IParsable<System.Numerics.BigInteger>, System.ISpanFormattable, System.ISpanParsable<System.Numerics.BigInteger>, System.Numerics.IAdditionOperators<System.Numerics.BigInteger, System.Numerics.BigInteger, System.Numerics.BigInteger>, System.Numerics.IAdditiveIdentity<System.Numerics.BigInteger, System.Numerics.BigInteger>, System.Numerics.IBinaryInteger<System.Numerics.BigInteger>, System.Numerics.IBinaryNumber<System.Numerics.BigInteger>, System.Numerics.IBitwiseOperators<System.Numerics.BigInteger, System.Numerics.BigInteger, System.Numerics.BigInteger>, System.Numerics.IComparisonOperators<System.Numerics.BigInteger, System.Numerics.BigInteger, bool>, System.Numerics.IDecrementOperators<System.Numerics.BigInteger>, System.Numerics.IDivisionOperators<System.Numerics.BigInteger, System.Numerics.BigInteger, System.Numerics.BigInteger>, System.Numerics.IEqualityOperators<System.Numerics.BigInteger, System.Numerics.BigInteger, bool>, System.Numerics.IIncrementOperators<System.Numerics.BigInteger>, System.Numerics.IModulusOperators<System.Numerics.BigInteger, System.Numerics.BigInteger, System.Numerics.BigInteger>, System.Numerics.IMultiplicativeIdentity<System.Numerics.BigInteger, System.Numerics.BigInteger>, System.Numerics.IMultiplyOperators<System.Numerics.BigInteger, System.Numerics.BigInteger, System.Numerics.BigInteger>, System.Numerics.INumber<System.Numerics.BigInteger>, System.Numerics.INumberBase<System.Numerics.BigInteger>, System.Numerics.IShiftOperators<System.Numerics.BigInteger, int, System.Numerics.BigInteger>, System.Numerics.ISignedNumber<System.Numerics.BigInteger>, System.Numerics.ISubtractionOperators<System.Numerics.BigInteger, System.Numerics.BigInteger, System.Numerics.BigInteger>, System.Numerics.IUnaryNegationOperators<System.Numerics.BigInteger, System.Numerics.BigInteger>, System.Numerics.IUnaryPlusOperators<System.Numerics.BigInteger, System.Numerics.BigInteger>
        {
            static bool System.Numerics.IEqualityOperators<System.Numerics.BigInteger, System.Numerics.BigInteger, bool>.operator !=(System.Numerics.BigInteger left, System.Numerics.BigInteger right) => throw null;
            public static bool operator !=(System.Numerics.BigInteger left, System.Int64 right) => throw null;
            public static bool operator !=(System.Numerics.BigInteger left, System.UInt64 right) => throw null;
            public static bool operator !=(System.Int64 left, System.Numerics.BigInteger right) => throw null;
            public static bool operator !=(System.UInt64 left, System.Numerics.BigInteger right) => throw null;
            static System.Numerics.BigInteger System.Numerics.IModulusOperators<System.Numerics.BigInteger, System.Numerics.BigInteger, System.Numerics.BigInteger>.operator %(System.Numerics.BigInteger dividend, System.Numerics.BigInteger divisor) => throw null;
            static System.Numerics.BigInteger System.Numerics.IBitwiseOperators<System.Numerics.BigInteger, System.Numerics.BigInteger, System.Numerics.BigInteger>.operator &(System.Numerics.BigInteger left, System.Numerics.BigInteger right) => throw null;
            static System.Numerics.BigInteger System.Numerics.IMultiplyOperators<System.Numerics.BigInteger, System.Numerics.BigInteger, System.Numerics.BigInteger>.operator *(System.Numerics.BigInteger left, System.Numerics.BigInteger right) => throw null;
            static System.Numerics.BigInteger System.Numerics.IUnaryPlusOperators<System.Numerics.BigInteger, System.Numerics.BigInteger>.operator +(System.Numerics.BigInteger value) => throw null;
            static System.Numerics.BigInteger System.Numerics.IAdditionOperators<System.Numerics.BigInteger, System.Numerics.BigInteger, System.Numerics.BigInteger>.operator +(System.Numerics.BigInteger left, System.Numerics.BigInteger right) => throw null;
            static System.Numerics.BigInteger System.Numerics.IIncrementOperators<System.Numerics.BigInteger>.operator ++(System.Numerics.BigInteger value) => throw null;
            static System.Numerics.BigInteger System.Numerics.IUnaryNegationOperators<System.Numerics.BigInteger, System.Numerics.BigInteger>.operator -(System.Numerics.BigInteger value) => throw null;
            static System.Numerics.BigInteger System.Numerics.ISubtractionOperators<System.Numerics.BigInteger, System.Numerics.BigInteger, System.Numerics.BigInteger>.operator -(System.Numerics.BigInteger left, System.Numerics.BigInteger right) => throw null;
            static System.Numerics.BigInteger System.Numerics.IDecrementOperators<System.Numerics.BigInteger>.operator --(System.Numerics.BigInteger value) => throw null;
            static System.Numerics.BigInteger System.Numerics.IDivisionOperators<System.Numerics.BigInteger, System.Numerics.BigInteger, System.Numerics.BigInteger>.operator /(System.Numerics.BigInteger dividend, System.Numerics.BigInteger divisor) => throw null;
            static bool System.Numerics.IComparisonOperators<System.Numerics.BigInteger, System.Numerics.BigInteger, bool>.operator <(System.Numerics.BigInteger left, System.Numerics.BigInteger right) => throw null;
            public static bool operator <(System.Numerics.BigInteger left, System.Int64 right) => throw null;
            public static bool operator <(System.Numerics.BigInteger left, System.UInt64 right) => throw null;
            public static bool operator <(System.Int64 left, System.Numerics.BigInteger right) => throw null;
            public static bool operator <(System.UInt64 left, System.Numerics.BigInteger right) => throw null;
            static System.Numerics.BigInteger System.Numerics.IShiftOperators<System.Numerics.BigInteger, int, System.Numerics.BigInteger>.operator <<(System.Numerics.BigInteger value, int shift) => throw null;
            static bool System.Numerics.IComparisonOperators<System.Numerics.BigInteger, System.Numerics.BigInteger, bool>.operator <=(System.Numerics.BigInteger left, System.Numerics.BigInteger right) => throw null;
            public static bool operator <=(System.Numerics.BigInteger left, System.Int64 right) => throw null;
            public static bool operator <=(System.Numerics.BigInteger left, System.UInt64 right) => throw null;
            public static bool operator <=(System.Int64 left, System.Numerics.BigInteger right) => throw null;
            public static bool operator <=(System.UInt64 left, System.Numerics.BigInteger right) => throw null;
            static bool System.Numerics.IEqualityOperators<System.Numerics.BigInteger, System.Numerics.BigInteger, bool>.operator ==(System.Numerics.BigInteger left, System.Numerics.BigInteger right) => throw null;
            public static bool operator ==(System.Numerics.BigInteger left, System.Int64 right) => throw null;
            public static bool operator ==(System.Numerics.BigInteger left, System.UInt64 right) => throw null;
            public static bool operator ==(System.Int64 left, System.Numerics.BigInteger right) => throw null;
            public static bool operator ==(System.UInt64 left, System.Numerics.BigInteger right) => throw null;
            static bool System.Numerics.IComparisonOperators<System.Numerics.BigInteger, System.Numerics.BigInteger, bool>.operator >(System.Numerics.BigInteger left, System.Numerics.BigInteger right) => throw null;
            public static bool operator >(System.Numerics.BigInteger left, System.Int64 right) => throw null;
            public static bool operator >(System.Numerics.BigInteger left, System.UInt64 right) => throw null;
            public static bool operator >(System.Int64 left, System.Numerics.BigInteger right) => throw null;
            public static bool operator >(System.UInt64 left, System.Numerics.BigInteger right) => throw null;
            static bool System.Numerics.IComparisonOperators<System.Numerics.BigInteger, System.Numerics.BigInteger, bool>.operator >=(System.Numerics.BigInteger left, System.Numerics.BigInteger right) => throw null;
            public static bool operator >=(System.Numerics.BigInteger left, System.Int64 right) => throw null;
            public static bool operator >=(System.Numerics.BigInteger left, System.UInt64 right) => throw null;
            public static bool operator >=(System.Int64 left, System.Numerics.BigInteger right) => throw null;
            public static bool operator >=(System.UInt64 left, System.Numerics.BigInteger right) => throw null;
            static System.Numerics.BigInteger System.Numerics.IShiftOperators<System.Numerics.BigInteger, int, System.Numerics.BigInteger>.operator >>(System.Numerics.BigInteger value, int shift) => throw null;
            static System.Numerics.BigInteger System.Numerics.IShiftOperators<System.Numerics.BigInteger, int, System.Numerics.BigInteger>.operator >>>(System.Numerics.BigInteger value, int shiftAmount) => throw null;
            public static System.Numerics.BigInteger Abs(System.Numerics.BigInteger value) => throw null;
            public static System.Numerics.BigInteger Add(System.Numerics.BigInteger left, System.Numerics.BigInteger right) => throw null;
            static System.Numerics.BigInteger System.Numerics.IAdditiveIdentity<System.Numerics.BigInteger, System.Numerics.BigInteger>.AdditiveIdentity { get => throw null; }
            static System.Numerics.BigInteger System.Numerics.IBinaryNumber<System.Numerics.BigInteger>.AllBitsSet { get => throw null; }
            // Stub generator skipped constructor 
            public BigInteger(System.Byte[] value) => throw null;
            public BigInteger(System.ReadOnlySpan<System.Byte> value, bool isUnsigned = default(bool), bool isBigEndian = default(bool)) => throw null;
            public BigInteger(System.Decimal value) => throw null;
            public BigInteger(double value) => throw null;
            public BigInteger(float value) => throw null;
            public BigInteger(int value) => throw null;
            public BigInteger(System.Int64 value) => throw null;
            public BigInteger(System.UInt32 value) => throw null;
            public BigInteger(System.UInt64 value) => throw null;
            public static System.Numerics.BigInteger Clamp(System.Numerics.BigInteger value, System.Numerics.BigInteger min, System.Numerics.BigInteger max) => throw null;
            public static int Compare(System.Numerics.BigInteger left, System.Numerics.BigInteger right) => throw null;
            public int CompareTo(System.Numerics.BigInteger other) => throw null;
            public int CompareTo(System.Int64 other) => throw null;
            public int CompareTo(object obj) => throw null;
            public int CompareTo(System.UInt64 other) => throw null;
            public static System.Numerics.BigInteger CopySign(System.Numerics.BigInteger value, System.Numerics.BigInteger sign) => throw null;
            static System.Numerics.BigInteger System.Numerics.INumberBase<System.Numerics.BigInteger>.CreateChecked<TOther>(TOther value) => throw null;
            static System.Numerics.BigInteger System.Numerics.INumberBase<System.Numerics.BigInteger>.CreateSaturating<TOther>(TOther value) => throw null;
            static System.Numerics.BigInteger System.Numerics.INumberBase<System.Numerics.BigInteger>.CreateTruncating<TOther>(TOther value) => throw null;
            static (System.Numerics.BigInteger, System.Numerics.BigInteger) System.Numerics.IBinaryInteger<System.Numerics.BigInteger>.DivRem(System.Numerics.BigInteger left, System.Numerics.BigInteger right) => throw null;
            public static System.Numerics.BigInteger DivRem(System.Numerics.BigInteger dividend, System.Numerics.BigInteger divisor, out System.Numerics.BigInteger remainder) => throw null;
            public static System.Numerics.BigInteger Divide(System.Numerics.BigInteger dividend, System.Numerics.BigInteger divisor) => throw null;
            public bool Equals(System.Numerics.BigInteger other) => throw null;
            public bool Equals(System.Int64 other) => throw null;
            public override bool Equals(object obj) => throw null;
            public bool Equals(System.UInt64 other) => throw null;
            public System.Int64 GetBitLength() => throw null;
            int System.Numerics.IBinaryInteger<System.Numerics.BigInteger>.GetByteCount() => throw null;
            public int GetByteCount(bool isUnsigned = default(bool)) => throw null;
            public override int GetHashCode() => throw null;
            int System.Numerics.IBinaryInteger<System.Numerics.BigInteger>.GetShortestBitLength() => throw null;
            public static System.Numerics.BigInteger GreatestCommonDivisor(System.Numerics.BigInteger left, System.Numerics.BigInteger right) => throw null;
            public static bool IsCanonical(System.Numerics.BigInteger value) => throw null;
            public static bool IsComplexNumber(System.Numerics.BigInteger value) => throw null;
            public bool IsEven { get => throw null; }
            public static bool IsEvenInteger(System.Numerics.BigInteger value) => throw null;
            public static bool IsFinite(System.Numerics.BigInteger value) => throw null;
            public static bool IsImaginaryNumber(System.Numerics.BigInteger value) => throw null;
            public static bool IsInfinity(System.Numerics.BigInteger value) => throw null;
            public static bool IsInteger(System.Numerics.BigInteger value) => throw null;
            public static bool IsNaN(System.Numerics.BigInteger value) => throw null;
            public static bool IsNegative(System.Numerics.BigInteger value) => throw null;
            public static bool IsNegativeInfinity(System.Numerics.BigInteger value) => throw null;
            public static bool IsNormal(System.Numerics.BigInteger value) => throw null;
            public static bool IsOddInteger(System.Numerics.BigInteger value) => throw null;
            public bool IsOne { get => throw null; }
            public static bool IsPositive(System.Numerics.BigInteger value) => throw null;
            public static bool IsPositiveInfinity(System.Numerics.BigInteger value) => throw null;
            public static bool IsPow2(System.Numerics.BigInteger value) => throw null;
            public bool IsPowerOfTwo { get => throw null; }
            public static bool IsRealNumber(System.Numerics.BigInteger value) => throw null;
            public static bool IsSubnormal(System.Numerics.BigInteger value) => throw null;
            public bool IsZero { get => throw null; }
            static bool System.Numerics.INumberBase<System.Numerics.BigInteger>.IsZero(System.Numerics.BigInteger value) => throw null;
            public static System.Numerics.BigInteger LeadingZeroCount(System.Numerics.BigInteger value) => throw null;
            public static double Log(System.Numerics.BigInteger value) => throw null;
            public static double Log(System.Numerics.BigInteger value, double baseValue) => throw null;
            public static double Log10(System.Numerics.BigInteger value) => throw null;
            public static System.Numerics.BigInteger Log2(System.Numerics.BigInteger value) => throw null;
            public static System.Numerics.BigInteger Max(System.Numerics.BigInteger left, System.Numerics.BigInteger right) => throw null;
            public static System.Numerics.BigInteger MaxMagnitude(System.Numerics.BigInteger x, System.Numerics.BigInteger y) => throw null;
            public static System.Numerics.BigInteger MaxMagnitudeNumber(System.Numerics.BigInteger x, System.Numerics.BigInteger y) => throw null;
            public static System.Numerics.BigInteger MaxNumber(System.Numerics.BigInteger x, System.Numerics.BigInteger y) => throw null;
            public static System.Numerics.BigInteger Min(System.Numerics.BigInteger left, System.Numerics.BigInteger right) => throw null;
            public static System.Numerics.BigInteger MinMagnitude(System.Numerics.BigInteger x, System.Numerics.BigInteger y) => throw null;
            public static System.Numerics.BigInteger MinMagnitudeNumber(System.Numerics.BigInteger x, System.Numerics.BigInteger y) => throw null;
            public static System.Numerics.BigInteger MinNumber(System.Numerics.BigInteger x, System.Numerics.BigInteger y) => throw null;
            public static System.Numerics.BigInteger MinusOne { get => throw null; }
            public static System.Numerics.BigInteger ModPow(System.Numerics.BigInteger value, System.Numerics.BigInteger exponent, System.Numerics.BigInteger modulus) => throw null;
            static System.Numerics.BigInteger System.Numerics.IMultiplicativeIdentity<System.Numerics.BigInteger, System.Numerics.BigInteger>.MultiplicativeIdentity { get => throw null; }
            public static System.Numerics.BigInteger Multiply(System.Numerics.BigInteger left, System.Numerics.BigInteger right) => throw null;
            public static System.Numerics.BigInteger Negate(System.Numerics.BigInteger value) => throw null;
            static System.Numerics.BigInteger System.Numerics.ISignedNumber<System.Numerics.BigInteger>.NegativeOne { get => throw null; }
            static System.Numerics.BigInteger System.Numerics.INumberBase<System.Numerics.BigInteger>.One { get => throw null; }
            public static System.Numerics.BigInteger Parse(System.ReadOnlySpan<System.Char> s, System.IFormatProvider provider) => throw null;
            public static System.Numerics.BigInteger Parse(System.ReadOnlySpan<System.Char> value, System.Globalization.NumberStyles style = default(System.Globalization.NumberStyles), System.IFormatProvider provider = default(System.IFormatProvider)) => throw null;
            public static System.Numerics.BigInteger Parse(string value) => throw null;
            public static System.Numerics.BigInteger Parse(string value, System.IFormatProvider provider) => throw null;
            public static System.Numerics.BigInteger Parse(string value, System.Globalization.NumberStyles style) => throw null;
            public static System.Numerics.BigInteger Parse(string value, System.Globalization.NumberStyles style, System.IFormatProvider provider) => throw null;
            public static System.Numerics.BigInteger PopCount(System.Numerics.BigInteger value) => throw null;
            public static System.Numerics.BigInteger Pow(System.Numerics.BigInteger value, int exponent) => throw null;
            static int System.Numerics.INumberBase<System.Numerics.BigInteger>.Radix { get => throw null; }
            public static System.Numerics.BigInteger Remainder(System.Numerics.BigInteger dividend, System.Numerics.BigInteger divisor) => throw null;
            public static System.Numerics.BigInteger RotateLeft(System.Numerics.BigInteger value, int rotateAmount) => throw null;
            public static System.Numerics.BigInteger RotateRight(System.Numerics.BigInteger value, int rotateAmount) => throw null;
            public int Sign { get => throw null; }
            static int System.Numerics.INumber<System.Numerics.BigInteger>.Sign(System.Numerics.BigInteger value) => throw null;
            public static System.Numerics.BigInteger Subtract(System.Numerics.BigInteger left, System.Numerics.BigInteger right) => throw null;
            public System.Byte[] ToByteArray() => throw null;
            public System.Byte[] ToByteArray(bool isUnsigned = default(bool), bool isBigEndian = default(bool)) => throw null;
            public override string ToString() => throw null;
            public string ToString(System.IFormatProvider provider) => throw null;
            public string ToString(string format) => throw null;
            public string ToString(string format, System.IFormatProvider provider) => throw null;
            public static System.Numerics.BigInteger TrailingZeroCount(System.Numerics.BigInteger value) => throw null;
            static bool System.Numerics.INumberBase<System.Numerics.BigInteger>.TryConvertFromChecked<TOther>(TOther value, out System.Numerics.BigInteger result) => throw null;
            static bool System.Numerics.INumberBase<System.Numerics.BigInteger>.TryConvertFromSaturating<TOther>(TOther value, out System.Numerics.BigInteger result) => throw null;
            static bool System.Numerics.INumberBase<System.Numerics.BigInteger>.TryConvertFromTruncating<TOther>(TOther value, out System.Numerics.BigInteger result) => throw null;
            static bool System.Numerics.INumberBase<System.Numerics.BigInteger>.TryConvertToChecked<TOther>(System.Numerics.BigInteger value, out TOther result) => throw null;
            static bool System.Numerics.INumberBase<System.Numerics.BigInteger>.TryConvertToSaturating<TOther>(System.Numerics.BigInteger value, out TOther result) => throw null;
            static bool System.Numerics.INumberBase<System.Numerics.BigInteger>.TryConvertToTruncating<TOther>(System.Numerics.BigInteger value, out TOther result) => throw null;
            public bool TryFormat(System.Span<System.Char> destination, out int charsWritten, System.ReadOnlySpan<System.Char> format = default(System.ReadOnlySpan<System.Char>), System.IFormatProvider provider = default(System.IFormatProvider)) => throw null;
            public static bool TryParse(System.ReadOnlySpan<System.Char> s, System.IFormatProvider provider, out System.Numerics.BigInteger result) => throw null;
            public static bool TryParse(System.ReadOnlySpan<System.Char> value, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.Numerics.BigInteger result) => throw null;
            public static bool TryParse(System.ReadOnlySpan<System.Char> value, out System.Numerics.BigInteger result) => throw null;
            public static bool TryParse(string s, System.IFormatProvider provider, out System.Numerics.BigInteger result) => throw null;
            public static bool TryParse(string value, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.Numerics.BigInteger result) => throw null;
            public static bool TryParse(string value, out System.Numerics.BigInteger result) => throw null;
            public static bool TryReadBigEndian(System.ReadOnlySpan<System.Byte> source, bool isUnsigned, out System.Numerics.BigInteger value) => throw null;
            public static bool TryReadLittleEndian(System.ReadOnlySpan<System.Byte> source, bool isUnsigned, out System.Numerics.BigInteger value) => throw null;
            bool System.Numerics.IBinaryInteger<System.Numerics.BigInteger>.TryWriteBigEndian(System.Span<System.Byte> destination, out int bytesWritten) => throw null;
            public bool TryWriteBytes(System.Span<System.Byte> destination, out int bytesWritten, bool isUnsigned = default(bool), bool isBigEndian = default(bool)) => throw null;
            bool System.Numerics.IBinaryInteger<System.Numerics.BigInteger>.TryWriteLittleEndian(System.Span<System.Byte> destination, out int bytesWritten) => throw null;
            static System.Numerics.BigInteger System.Numerics.INumberBase<System.Numerics.BigInteger>.Zero { get => throw null; }
            static System.Numerics.BigInteger System.Numerics.IBitwiseOperators<System.Numerics.BigInteger, System.Numerics.BigInteger, System.Numerics.BigInteger>.operator ^(System.Numerics.BigInteger left, System.Numerics.BigInteger right) => throw null;
            public static explicit operator System.Byte(System.Numerics.BigInteger value) => throw null;
            public static explicit operator System.Char(System.Numerics.BigInteger value) => throw null;
            public static explicit operator System.Decimal(System.Numerics.BigInteger value) => throw null;
            public static explicit operator System.Half(System.Numerics.BigInteger value) => throw null;
            public static explicit operator System.Int128(System.Numerics.BigInteger value) => throw null;
            public static explicit operator System.Int16(System.Numerics.BigInteger value) => throw null;
            public static explicit operator System.Int64(System.Numerics.BigInteger value) => throw null;
            public static explicit operator System.IntPtr(System.Numerics.BigInteger value) => throw null;
            public static explicit operator System.SByte(System.Numerics.BigInteger value) => throw null;
            public static explicit operator System.UInt128(System.Numerics.BigInteger value) => throw null;
            public static explicit operator System.UInt16(System.Numerics.BigInteger value) => throw null;
            public static explicit operator System.UInt32(System.Numerics.BigInteger value) => throw null;
            public static explicit operator System.UInt64(System.Numerics.BigInteger value) => throw null;
            public static explicit operator System.UIntPtr(System.Numerics.BigInteger value) => throw null;
            public static explicit operator double(System.Numerics.BigInteger value) => throw null;
            public static explicit operator float(System.Numerics.BigInteger value) => throw null;
            public static explicit operator int(System.Numerics.BigInteger value) => throw null;
            public static explicit operator System.Numerics.BigInteger(System.Numerics.Complex value) => throw null;
            public static explicit operator System.Numerics.BigInteger(System.Half value) => throw null;
            public static explicit operator System.Numerics.BigInteger(System.Decimal value) => throw null;
            public static explicit operator System.Numerics.BigInteger(double value) => throw null;
            public static explicit operator System.Numerics.BigInteger(float value) => throw null;
            public static implicit operator System.Numerics.BigInteger(System.Int128 value) => throw null;
            public static implicit operator System.Numerics.BigInteger(System.IntPtr value) => throw null;
            public static implicit operator System.Numerics.BigInteger(System.UInt128 value) => throw null;
            public static implicit operator System.Numerics.BigInteger(System.UIntPtr value) => throw null;
            public static implicit operator System.Numerics.BigInteger(System.Byte value) => throw null;
            public static implicit operator System.Numerics.BigInteger(System.Char value) => throw null;
            public static implicit operator System.Numerics.BigInteger(int value) => throw null;
            public static implicit operator System.Numerics.BigInteger(System.Int64 value) => throw null;
            public static implicit operator System.Numerics.BigInteger(System.SByte value) => throw null;
            public static implicit operator System.Numerics.BigInteger(System.Int16 value) => throw null;
            public static implicit operator System.Numerics.BigInteger(System.UInt32 value) => throw null;
            public static implicit operator System.Numerics.BigInteger(System.UInt64 value) => throw null;
            public static implicit operator System.Numerics.BigInteger(System.UInt16 value) => throw null;
            static System.Numerics.BigInteger System.Numerics.IBitwiseOperators<System.Numerics.BigInteger, System.Numerics.BigInteger, System.Numerics.BigInteger>.operator |(System.Numerics.BigInteger left, System.Numerics.BigInteger right) => throw null;
            static System.Numerics.BigInteger System.Numerics.IBitwiseOperators<System.Numerics.BigInteger, System.Numerics.BigInteger, System.Numerics.BigInteger>.operator ~(System.Numerics.BigInteger value) => throw null;
        }

        public struct Complex : System.IEquatable<System.Numerics.Complex>, System.IFormattable, System.IParsable<System.Numerics.Complex>, System.ISpanFormattable, System.ISpanParsable<System.Numerics.Complex>, System.Numerics.IAdditionOperators<System.Numerics.Complex, System.Numerics.Complex, System.Numerics.Complex>, System.Numerics.IAdditiveIdentity<System.Numerics.Complex, System.Numerics.Complex>, System.Numerics.IDecrementOperators<System.Numerics.Complex>, System.Numerics.IDivisionOperators<System.Numerics.Complex, System.Numerics.Complex, System.Numerics.Complex>, System.Numerics.IEqualityOperators<System.Numerics.Complex, System.Numerics.Complex, bool>, System.Numerics.IIncrementOperators<System.Numerics.Complex>, System.Numerics.IMultiplicativeIdentity<System.Numerics.Complex, System.Numerics.Complex>, System.Numerics.IMultiplyOperators<System.Numerics.Complex, System.Numerics.Complex, System.Numerics.Complex>, System.Numerics.INumberBase<System.Numerics.Complex>, System.Numerics.ISignedNumber<System.Numerics.Complex>, System.Numerics.ISubtractionOperators<System.Numerics.Complex, System.Numerics.Complex, System.Numerics.Complex>, System.Numerics.IUnaryNegationOperators<System.Numerics.Complex, System.Numerics.Complex>, System.Numerics.IUnaryPlusOperators<System.Numerics.Complex, System.Numerics.Complex>
        {
            static bool System.Numerics.IEqualityOperators<System.Numerics.Complex, System.Numerics.Complex, bool>.operator !=(System.Numerics.Complex left, System.Numerics.Complex right) => throw null;
            static System.Numerics.Complex System.Numerics.IMultiplyOperators<System.Numerics.Complex, System.Numerics.Complex, System.Numerics.Complex>.operator *(System.Numerics.Complex left, System.Numerics.Complex right) => throw null;
            public static System.Numerics.Complex operator *(System.Numerics.Complex left, double right) => throw null;
            public static System.Numerics.Complex operator *(double left, System.Numerics.Complex right) => throw null;
            static System.Numerics.Complex System.Numerics.IUnaryPlusOperators<System.Numerics.Complex, System.Numerics.Complex>.operator +(System.Numerics.Complex value) => throw null;
            static System.Numerics.Complex System.Numerics.IAdditionOperators<System.Numerics.Complex, System.Numerics.Complex, System.Numerics.Complex>.operator +(System.Numerics.Complex left, System.Numerics.Complex right) => throw null;
            public static System.Numerics.Complex operator +(System.Numerics.Complex left, double right) => throw null;
            public static System.Numerics.Complex operator +(double left, System.Numerics.Complex right) => throw null;
            static System.Numerics.Complex System.Numerics.IIncrementOperators<System.Numerics.Complex>.operator ++(System.Numerics.Complex value) => throw null;
            static System.Numerics.Complex System.Numerics.IUnaryNegationOperators<System.Numerics.Complex, System.Numerics.Complex>.operator -(System.Numerics.Complex value) => throw null;
            static System.Numerics.Complex System.Numerics.ISubtractionOperators<System.Numerics.Complex, System.Numerics.Complex, System.Numerics.Complex>.operator -(System.Numerics.Complex left, System.Numerics.Complex right) => throw null;
            public static System.Numerics.Complex operator -(System.Numerics.Complex left, double right) => throw null;
            public static System.Numerics.Complex operator -(double left, System.Numerics.Complex right) => throw null;
            static System.Numerics.Complex System.Numerics.IDecrementOperators<System.Numerics.Complex>.operator --(System.Numerics.Complex value) => throw null;
            static System.Numerics.Complex System.Numerics.IDivisionOperators<System.Numerics.Complex, System.Numerics.Complex, System.Numerics.Complex>.operator /(System.Numerics.Complex left, System.Numerics.Complex right) => throw null;
            public static System.Numerics.Complex operator /(System.Numerics.Complex left, double right) => throw null;
            public static System.Numerics.Complex operator /(double left, System.Numerics.Complex right) => throw null;
            static bool System.Numerics.IEqualityOperators<System.Numerics.Complex, System.Numerics.Complex, bool>.operator ==(System.Numerics.Complex left, System.Numerics.Complex right) => throw null;
            public static double Abs(System.Numerics.Complex value) => throw null;
            static System.Numerics.Complex System.Numerics.INumberBase<System.Numerics.Complex>.Abs(System.Numerics.Complex value) => throw null;
            public static System.Numerics.Complex Acos(System.Numerics.Complex value) => throw null;
            public static System.Numerics.Complex Add(System.Numerics.Complex left, System.Numerics.Complex right) => throw null;
            public static System.Numerics.Complex Add(System.Numerics.Complex left, double right) => throw null;
            public static System.Numerics.Complex Add(double left, System.Numerics.Complex right) => throw null;
            static System.Numerics.Complex System.Numerics.IAdditiveIdentity<System.Numerics.Complex, System.Numerics.Complex>.AdditiveIdentity { get => throw null; }
            public static System.Numerics.Complex Asin(System.Numerics.Complex value) => throw null;
            public static System.Numerics.Complex Atan(System.Numerics.Complex value) => throw null;
            // Stub generator skipped constructor 
            public Complex(double real, double imaginary) => throw null;
            public static System.Numerics.Complex Conjugate(System.Numerics.Complex value) => throw null;
            public static System.Numerics.Complex Cos(System.Numerics.Complex value) => throw null;
            public static System.Numerics.Complex Cosh(System.Numerics.Complex value) => throw null;
            static System.Numerics.Complex System.Numerics.INumberBase<System.Numerics.Complex>.CreateChecked<TOther>(TOther value) => throw null;
            static System.Numerics.Complex System.Numerics.INumberBase<System.Numerics.Complex>.CreateSaturating<TOther>(TOther value) => throw null;
            static System.Numerics.Complex System.Numerics.INumberBase<System.Numerics.Complex>.CreateTruncating<TOther>(TOther value) => throw null;
            public static System.Numerics.Complex Divide(System.Numerics.Complex dividend, System.Numerics.Complex divisor) => throw null;
            public static System.Numerics.Complex Divide(System.Numerics.Complex dividend, double divisor) => throw null;
            public static System.Numerics.Complex Divide(double dividend, System.Numerics.Complex divisor) => throw null;
            public bool Equals(System.Numerics.Complex value) => throw null;
            public override bool Equals(object obj) => throw null;
            public static System.Numerics.Complex Exp(System.Numerics.Complex value) => throw null;
            public static System.Numerics.Complex FromPolarCoordinates(double magnitude, double phase) => throw null;
            public override int GetHashCode() => throw null;
            public double Imaginary { get => throw null; }
            public static System.Numerics.Complex ImaginaryOne;
            public static System.Numerics.Complex Infinity;
            public static bool IsCanonical(System.Numerics.Complex value) => throw null;
            public static bool IsComplexNumber(System.Numerics.Complex value) => throw null;
            public static bool IsEvenInteger(System.Numerics.Complex value) => throw null;
            public static bool IsFinite(System.Numerics.Complex value) => throw null;
            public static bool IsImaginaryNumber(System.Numerics.Complex value) => throw null;
            public static bool IsInfinity(System.Numerics.Complex value) => throw null;
            public static bool IsInteger(System.Numerics.Complex value) => throw null;
            public static bool IsNaN(System.Numerics.Complex value) => throw null;
            public static bool IsNegative(System.Numerics.Complex value) => throw null;
            public static bool IsNegativeInfinity(System.Numerics.Complex value) => throw null;
            public static bool IsNormal(System.Numerics.Complex value) => throw null;
            public static bool IsOddInteger(System.Numerics.Complex value) => throw null;
            public static bool IsPositive(System.Numerics.Complex value) => throw null;
            public static bool IsPositiveInfinity(System.Numerics.Complex value) => throw null;
            public static bool IsRealNumber(System.Numerics.Complex value) => throw null;
            public static bool IsSubnormal(System.Numerics.Complex value) => throw null;
            public static bool IsZero(System.Numerics.Complex value) => throw null;
            public static System.Numerics.Complex Log(System.Numerics.Complex value) => throw null;
            public static System.Numerics.Complex Log(System.Numerics.Complex value, double baseValue) => throw null;
            public static System.Numerics.Complex Log10(System.Numerics.Complex value) => throw null;
            public double Magnitude { get => throw null; }
            public static System.Numerics.Complex MaxMagnitude(System.Numerics.Complex x, System.Numerics.Complex y) => throw null;
            public static System.Numerics.Complex MaxMagnitudeNumber(System.Numerics.Complex x, System.Numerics.Complex y) => throw null;
            public static System.Numerics.Complex MinMagnitude(System.Numerics.Complex x, System.Numerics.Complex y) => throw null;
            public static System.Numerics.Complex MinMagnitudeNumber(System.Numerics.Complex x, System.Numerics.Complex y) => throw null;
            static System.Numerics.Complex System.Numerics.IMultiplicativeIdentity<System.Numerics.Complex, System.Numerics.Complex>.MultiplicativeIdentity { get => throw null; }
            public static System.Numerics.Complex Multiply(System.Numerics.Complex left, System.Numerics.Complex right) => throw null;
            public static System.Numerics.Complex Multiply(System.Numerics.Complex left, double right) => throw null;
            public static System.Numerics.Complex Multiply(double left, System.Numerics.Complex right) => throw null;
            public static System.Numerics.Complex NaN;
            public static System.Numerics.Complex Negate(System.Numerics.Complex value) => throw null;
            static System.Numerics.Complex System.Numerics.ISignedNumber<System.Numerics.Complex>.NegativeOne { get => throw null; }
            public static System.Numerics.Complex One;
            static System.Numerics.Complex System.Numerics.INumberBase<System.Numerics.Complex>.One { get => throw null; }
            public static System.Numerics.Complex Parse(System.ReadOnlySpan<System.Char> s, System.IFormatProvider provider) => throw null;
            public static System.Numerics.Complex Parse(System.ReadOnlySpan<System.Char> s, System.Globalization.NumberStyles style, System.IFormatProvider provider) => throw null;
            public static System.Numerics.Complex Parse(string s, System.IFormatProvider provider) => throw null;
            public static System.Numerics.Complex Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) => throw null;
            public double Phase { get => throw null; }
            public static System.Numerics.Complex Pow(System.Numerics.Complex value, System.Numerics.Complex power) => throw null;
            public static System.Numerics.Complex Pow(System.Numerics.Complex value, double power) => throw null;
            static int System.Numerics.INumberBase<System.Numerics.Complex>.Radix { get => throw null; }
            public double Real { get => throw null; }
            public static System.Numerics.Complex Reciprocal(System.Numerics.Complex value) => throw null;
            public static System.Numerics.Complex Sin(System.Numerics.Complex value) => throw null;
            public static System.Numerics.Complex Sinh(System.Numerics.Complex value) => throw null;
            public static System.Numerics.Complex Sqrt(System.Numerics.Complex value) => throw null;
            public static System.Numerics.Complex Subtract(System.Numerics.Complex left, System.Numerics.Complex right) => throw null;
            public static System.Numerics.Complex Subtract(System.Numerics.Complex left, double right) => throw null;
            public static System.Numerics.Complex Subtract(double left, System.Numerics.Complex right) => throw null;
            public static System.Numerics.Complex Tan(System.Numerics.Complex value) => throw null;
            public static System.Numerics.Complex Tanh(System.Numerics.Complex value) => throw null;
            public override string ToString() => throw null;
            public string ToString(System.IFormatProvider provider) => throw null;
            public string ToString(string format) => throw null;
            public string ToString(string format, System.IFormatProvider provider) => throw null;
            static bool System.Numerics.INumberBase<System.Numerics.Complex>.TryConvertFromChecked<TOther>(TOther value, out System.Numerics.Complex result) => throw null;
            static bool System.Numerics.INumberBase<System.Numerics.Complex>.TryConvertFromSaturating<TOther>(TOther value, out System.Numerics.Complex result) => throw null;
            static bool System.Numerics.INumberBase<System.Numerics.Complex>.TryConvertFromTruncating<TOther>(TOther value, out System.Numerics.Complex result) => throw null;
            static bool System.Numerics.INumberBase<System.Numerics.Complex>.TryConvertToChecked<TOther>(System.Numerics.Complex value, out TOther result) => throw null;
            static bool System.Numerics.INumberBase<System.Numerics.Complex>.TryConvertToSaturating<TOther>(System.Numerics.Complex value, out TOther result) => throw null;
            static bool System.Numerics.INumberBase<System.Numerics.Complex>.TryConvertToTruncating<TOther>(System.Numerics.Complex value, out TOther result) => throw null;
            public bool TryFormat(System.Span<System.Char> destination, out int charsWritten, System.ReadOnlySpan<System.Char> format, System.IFormatProvider provider) => throw null;
            public static bool TryParse(System.ReadOnlySpan<System.Char> s, System.IFormatProvider provider, out System.Numerics.Complex result) => throw null;
            public static bool TryParse(System.ReadOnlySpan<System.Char> s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.Numerics.Complex result) => throw null;
            public static bool TryParse(string s, System.IFormatProvider provider, out System.Numerics.Complex result) => throw null;
            public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.Numerics.Complex result) => throw null;
            public static System.Numerics.Complex Zero;
            static System.Numerics.Complex System.Numerics.INumberBase<System.Numerics.Complex>.Zero { get => throw null; }
            public static explicit operator System.Numerics.Complex(System.Numerics.BigInteger value) => throw null;
            public static explicit operator System.Numerics.Complex(System.Int128 value) => throw null;
            public static explicit operator System.Numerics.Complex(System.UInt128 value) => throw null;
            public static explicit operator System.Numerics.Complex(System.Decimal value) => throw null;
            public static implicit operator System.Numerics.Complex(System.Half value) => throw null;
            public static implicit operator System.Numerics.Complex(System.IntPtr value) => throw null;
            public static implicit operator System.Numerics.Complex(System.UIntPtr value) => throw null;
            public static implicit operator System.Numerics.Complex(System.Byte value) => throw null;
            public static implicit operator System.Numerics.Complex(System.Char value) => throw null;
            public static implicit operator System.Numerics.Complex(double value) => throw null;
            public static implicit operator System.Numerics.Complex(float value) => throw null;
            public static implicit operator System.Numerics.Complex(int value) => throw null;
            public static implicit operator System.Numerics.Complex(System.Int64 value) => throw null;
            public static implicit operator System.Numerics.Complex(System.SByte value) => throw null;
            public static implicit operator System.Numerics.Complex(System.Int16 value) => throw null;
            public static implicit operator System.Numerics.Complex(System.UInt32 value) => throw null;
            public static implicit operator System.Numerics.Complex(System.UInt64 value) => throw null;
            public static implicit operator System.Numerics.Complex(System.UInt16 value) => throw null;
        }

    }
}
