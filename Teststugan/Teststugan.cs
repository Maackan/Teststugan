using System;
using System.Diagnostics;
using Xunit;
using Xunit.Sdk;

namespace Teststugan
{
    public class Teststugan //Till för att kanske testa vissa komponenter i ett projekt utan att behöva köra hela stora grejen.
    {
        [Fact]//Betyder att det är ett test, Assert(Hävda)
        public void AlwaysSucceed()
        {
            Assert.Equal(expected: 4, actual: 4);
            Assert.NotEqual(expected:4, actual:5);
            Assert.True(true);
            Assert.True(true);

        }

        [Fact]

        public void AlwaysFail()
        {
            Assert.Equal(expected: 45, actual: 100);
            Assert.False(true);

        }

        [Fact]
        public void TestaVariabler()
        {
            bool container = true;

            container = true;

            Assert.True(container);
        }

        [Fact]
        public void TestaString()
        {
            string name;

            bool lever = false;

            if (lever)
            {
                name = "Jonte";
            }
            else
            {
                name = "Markus Yli-Länttä Andersson Harri";
            }
            Assert.Equal(expected: "Markus Yli-Länttä Andersson Harri", actual: name);
        }

        [Fact]
        public void TestaInt()
        {
            int birthDay = 17;
            int birthMonth = 1;
            int birthYear = 1994;

            Assert.Equal(expected: 17, actual: birthDay);
            Assert.Equal(expected: 1, actual: birthMonth);
            Assert.Equal(expected: 1994, actual: birthYear);


        }

        [Fact]

        public void test1()
        {
            Assert.Equal(expected:5, actual: 2 + 3);//Man ska inte skriva"expected och "actual" det kommer efteråt automatiskt.
        }

        [Fact]
        public void test2()
        {
            Assert.True("Jag har fyllt " + 29 == "Jag har fyllt 29");
        }

        [Fact]
        public void test3()
        {
            int bigNumber = 2147483647;
            int biggerNumber = bigNumber = + 1;
            Assert.True(biggerNumber > bigNumber);
        }

        [Fact]
        public void test4()
        {
            string purchasedDrink = "Beer";
            int age = 28;

            if (age > 18)
            {
                purchasedDrink = "Beer";
            }
            else
            {
                purchasedDrink = "Coca-cola";
            }
            
            Assert.Equal("Beer", purchasedDrink);
            
        }

        

    
    }
}
