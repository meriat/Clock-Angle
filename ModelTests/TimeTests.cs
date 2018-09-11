using System;
using System.Collections.Generic;
using ClockAngle.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClockAngle.Tests
{
    [TestClass]
    public class ClockAngleTest
    {
        [TestMethod]
        public void IsTime_CheckIfTimeIsValid_Int()
        {
            //Arrange
            int hour = 1;
            int minute = 10;

            //Act
             int result = Clock.IsTime(hour,minute);

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void FindAngle_CheckIfAngleIsValid_Int()
        {
            //Arrange
            int hour = 1;
            int minute = 10;

            //Act
             int result = Clock.FindAngle(hour,minute);

            //Assert
            Assert.AreEqual(30, result);
        }
        [TestMethod]
        public void FindAngle_CheckIfAngleIsValid1_Int()
        {
            //Arrange
            int hour = 1;
            int minute = 50;

            //Act
             int result = Clock.FindAngle(hour,minute);

            //Assert
            Assert.AreEqual(90, result);
        }
      }
    }
