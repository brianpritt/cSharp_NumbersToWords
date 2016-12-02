using Xunit;
using System;
using System.Collections.Generic;
using NumberToWords.Objects;

namespace NumberToWords
{
  public class NumberToWordsTest
  {
    [Fact]
    public void NumberToWords_Ones_true()
    {
      //Arrange
      int theNumber = 7;
      Number myNumberToWords = new Number(theNumber);
      string theWord = myNumberToWords.ToWords();
      string proof = "seven";
      //Act
      //Assert
      Assert.Equal(true, proof == theWord);
    }
    [Fact]
    public void NumberToWords_Tens_true()
    {
      //Arrange
      int theNumber = 7;
      Number myNumberToWords = new Number(theNumber);
      string theWord = myNumberToWords.ToWords();
      string proof = "seven";
      //Act
      //Assert
      Assert.Equal(true, proof == theWord);
    }
  }
}
