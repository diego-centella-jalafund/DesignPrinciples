namespace DontRepeatYourself;

public class BasicCalculator
{
  private decimal imaginaryNum;
  private decimal piNumber;
  public decimal CalculateSum(decimal firstNum, decimal secondNum) 
  {
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

  public decimal CalculateSin(decimal num) 
  {
    return Math.Sin(num);
  }
 
  public decimal CalculateCos(decimal num) 
  {
    return Math.Cos(num); 
  }
   
  public decimal CalculateTan(decimal num) 
  {
    return Math.Tan(num);
  }
}