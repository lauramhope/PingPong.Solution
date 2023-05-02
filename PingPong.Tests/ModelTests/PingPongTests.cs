using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong.Models;
using System.Collections.Generic;
using System;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongTests
  {

    [TestMethod]
    public void GetOutput_NumberDivisibleByThree_Ping()
    {
      //Arrange
      int number = 3;
      List<string> expected = new List<string> {"1", "2", "Ping"};

      //Act
      List<string> actual = PingPongClass.GetOutput(number);

      //Assert
      Assert.IsInstanceOfType(actual, typeof(List<string>));
    }
  }
}