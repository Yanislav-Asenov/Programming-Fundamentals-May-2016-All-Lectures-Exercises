using System;
using System.Numerics;

namespace CenturiesToNanoseconds
{
    public class CenturiesToNanoseconds
    {
        public static void Main()
        {
            int ceturies = int.Parse(Console.ReadLine());
            int years = ceturies * 100;
            long days = (int)(years * 365.2422);
            long hours = days * 24;
            BigInteger minutes = hours * 60;
            BigInteger seconds = minutes * 60;
            BigInteger miliseconds = seconds * 1000;
            BigInteger microseconds = miliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;

            Console.WriteLine($"{ceturies} centuries = {years} years = {days} days = {hours} hours = " +
                              $"{minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} " +
                              $"microseconds = {nanoseconds} nanoseconds");
        }
    }
}
