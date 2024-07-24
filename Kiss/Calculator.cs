namespace DontRepeatYourself;

public class Calculator
{
  public decimal CalculateSum(decimal firstNum, decimal secondNum) 
  {
    CalculateSubstraction(firstNum, secondNum);
    CalculateProduct(firstNum, secondNum);
    CalculateDivision(firstNum, secondNum);
    return firstNum + secondNum;
  }

  public decimal CalculateSubstraction(decimal firstNum, decimal secondNum) 
  {
    return firstNum - secondNum;
  }

  public decimal CalculateProduct(decimal firstNum, decimal secondNum) 
  {
    return firstNum * secondNum;
    
  }

  public decimal CalculateDivision(decimal firstNum, decimal secondNum) 
  {
    return firstNum / secondNum;
  }
}