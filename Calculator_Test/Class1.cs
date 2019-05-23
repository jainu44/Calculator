using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;

namespace Calculator_Test
{

    public class CalcTest
    {
        [Test]
        public void GetAddition_Input3point4and5point6_Returns9point0()
        {
            //Arrange 
            double number1 = 3.4;
            double number2 = 5.6;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        
        [Test]

        public void GetAddition_Input4and5_Returns9()
        {
            //Arrange 
            int number1 = 4;
            int number2 = 5;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]

        public void GetAddition_Inputminus1and7_Returns6()
        {
            //Arrange 
            double number1 = -1;
            double number2 = 7;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]

        public void GetSubtraction_Input4and4_Returns0()
        {
            //Arrange 
            double number1 = 4;
            double number2 = 4;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetSubtraction();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetSubtraction_Input4point1and5point1_Returnsminus1()
        {
            //Arrange 
            double number1 = 4.1;
            double number2 = 5.1;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetSubtraction();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetSubtraction_Input1andminus9_Returnsminus8()
        {
            //Arrange 
            double number1 = 1;
            double number2 = -9;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetSubtraction();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetDivision_Input4and2_Return1()
        {
            //Arrange 
            double number1 = 4;
            double number2 = 2;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetDivision();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetDivision_Input4and0_Returnsenfinity()
        {
            //Arrange 
            double number1 = 4;
            double number2 = 0;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetDivision();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetDivision_Input4and4_Return1()
        {
            //Arrange 
            double number1 = 4;
            double number2 = 4;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetDivision();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetMultiplication_Input4and4_Returns16()
        {
            //Arrange 
            double number1 = 4;
            double number2 = 4;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetMultiplication();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetMultiplication_Input4ponit5and4point5_Returns20point25()
        {
            //Arrange 
            double number1 = 4.5;
            double number2 = 4.5;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetMultiplication();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetMultiplication_Input4and0_Returns0()
        {
            //Arrange 
            double number1 = 4;
            double number2 = 0;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetMultiplication();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }


    }
}

        