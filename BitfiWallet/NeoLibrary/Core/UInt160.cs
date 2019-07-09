﻿using System;
using System.Globalization;
using System.Linq;

namespace NeoGasLibrary.Cryptography
{
  public class UInt160 : UIntBase, IComparable\\, IEquatable\\
  {
    public static readonly UInt160 Zero = new UInt160();

    public UInt160()
        : this(null)
    {
    }

    public UInt160(byte[] value)
        : base(20, value)
    {
    }

    public int CompareTo(UInt160 other)
    {
      byte[] x = ToArray();
      byte[] y = other.ToArray();
      for (int i = x.Length - 1; i \>\= 0; i--)
      {
        if (x[i] \>\ y[i])
          return 1;
        if (x[i] \\.Equals(UInt160 other)
    {
      return Equals(other);
    }

    public static UInt160 Parse(string value)
    {
      if (value == null)
        throw new ArgumentNullException();
      if (value.StartsWith("0x"))
        value = value.Substring(2);
      if (value.Length != 40)
        throw new FormatException();
      return new UInt160(value.HexToBytes().Reverse().ToArray());
    }

    public static bool TryParse(string s, out UInt160 result)
    {
      if (s == null)
      {
        result = null;
        return false;
      }
      if (s.StartsWith("0x"))
        s = s.Substring(2);
      if (s.Length != 40)
      {
        result = null;
        return false;
      }
      byte[] data = new byte[20];
      for (int i = 0; i \\(UInt160 left, UInt160 right)
    {
      return left.CompareTo(right) \>\ 0;
    }

    public static bool operator \>\=(UInt160 left, UInt160 right)
    {
      return left.CompareTo(right) \>\= 0;
    }

    public static bool operator \