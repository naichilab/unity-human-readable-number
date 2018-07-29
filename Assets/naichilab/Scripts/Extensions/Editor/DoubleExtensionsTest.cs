using NUnit.Framework;
using UnityEngine;

namespace naichilab.Scripts.Extensions.Editor
{
    public class DoubleExtensionsTest
    {
        private static void assert(double d, string expect)
        {
            log(d);
            Assert.AreEqual(expect, d.ToReadableString());
        }

        private static void log(double d)
        {
            Debug.Log(string.Format("{0} => {1}", d, d.ToReadableString()));
        }

        [Test]
        public void ToReadableStringTest1()
        {
            assert(0.0, "0");
            assert(0.2, "0");
            assert(1.0, "1");
            assert(1.7, "1");
            assert(12.0, "12");
            assert(12.8, "12");
            assert(123.0, "123");
            assert(123.5, "123");
            assert(1234.0, "1.23k");
            assert(12345.0, "12.3k");
            assert(123456.0, "123k");
            assert(1234567.0, "1.23m");
            assert(12345678.0, "12.3m");
            assert(123456789.0, "123m");
            assert(1234567890.0, "1.23b");
        }

        [Test]
        public void ToReadableStringTest2()
        {
            assert(12345e3, "12.3m");
            assert(12345e6, "12.3b");
            assert(12345e9, "12.3t");
            assert(12345e12, "12.3A");
            assert(12345e15, "12.3B");
            assert(12345e18, "12.3C");
            assert(12345e21, "12.3D");
            assert(12345e24, "12.3E");
            assert(12345e27, "12.3F");
            assert(12345e30, "12.3G");
            assert(12345e33, "12.3H");
            assert(12345e36, "12.3I");
            assert(12345e39, "12.3J");
            assert(12345e42, "12.3K");
            assert(12345e45, "12.3L");
            assert(12345e48, "12.3M");
            assert(12345e51, "12.3N");
            assert(12345e54, "12.3O");
            assert(12345e57, "12.3P");
            assert(12345e60, "12.3Q");
            assert(12345e63, "12.3R");
            assert(12345e66, "12.3S");
            assert(12345e69, "12.3T");
            assert(12345e72, "12.3U");
            assert(12345e75, "12.3V");
            assert(12345e78, "12.3W");
            assert(12345e81, "12.3X");
            assert(12345e84, "12.3Y");
            assert(12345e87, "12.3Z");
            assert(12345e90, "12.3AA");
        }

        [Test]
        public void LogForCheck_AllRange()
        {
            log(double.MinValue);
            log(0);
            log(1);
            log(2);
            double baseNum = 1.23456789;
            for (var i = 0; i <= 308; i++)
            {
                log(baseNum);
                baseNum *= 10;
            }

            log(double.MaxValue);
        }

        [Test]
        public void LogForCheck_Custom()
        {
            log(12345);
            log(8454645);
            log(4.25e10); //42,500,000,000
            log(7.342e60); //7,342,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000
            log(925925850.0);
        }
    }
}