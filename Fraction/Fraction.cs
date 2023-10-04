using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
	internal class Fraction
	{
		int integer;
		int numerator;
		int denominator;
		public int getInteger()
		{
			return integer;
		}
		public int getNumerator()
		{
			return numerator;
		}
		public int getDenominator()
		{
			return denominator;
		}
		public void setInteger(int integer)
		{
			this.integer = integer;
		}
		public void setDenominator(int denominator)
		{
			if (denominator == 0) denominator = 1;
			this.denominator = denominator;
		}
		//				Constructor:
		Fraction()
		{
			integer = numerator = 0;
			denominator = 1;
			Console.WriteLine("DefaultConstructor");
		}

		Fraction(int integer)
		{
			this.integer = integer;
			this.numerator = 0;
			this.denominator = 1;
			Console.WriteLine("1ArgConstructor:\t");
		}
		Fraction(int numerator, int denominator)
		{
			this.integer = 0;
			setNumerator(numerator);
			setDenominator(denominator);
			Console.WriteLine($"Constructor:{this.GetHashCode()}");

		}
		Fraction(int integer, int numerator, int denominator)
		{
			setInteger(integer);
			setNumerator(numerator);
			setDenominator(denominator);
			Console.WriteLine($"Constructor:\t{this.GetHashCode()}");
		}

		// Methods
		public void Print()
		{
			if (integer != 0) Console.Write(integer);
			if (numerator != 0)
			{
				if (integer != 0) Console.Write("(");
				Console.WriteLine($"{numerator} / {denominator}");
				if (integer != 0) Console.Write(")");
			}
			else if (integer == 0) Console.Write(0);
			else Console.WriteLine();
		}
	}
}
