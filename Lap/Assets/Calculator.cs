using UnityEngine;
using TMPro;

public class Calculator : MonoBehaviour
{
    [SerializeField] private TMP_InputField Text;
    private float result;
    private float leftValue;
    private float rightValue;
    private bool isLeft;
    private string currentOperator;


    public void GetText(string text)
    {
        if (!isLeft)
        {
            if (!IsOperator(text))
            {
                if (float.TryParse(text, out leftValue))
                {
                    isLeft = true;
                }
                
                else if (text == "c")
                {
                    ResetCalculator();
                }
                else
                {
                    Debug.LogError("숫자가 아닙니다");
                
                }
            }
        }
        else
        {
            if (!IsOperator(text))
            {
                rightValue= float.Parse(text);
                Calculate();
            }
            

            else
            {
                currentOperator = text;
            }
        }

        
    }

    private bool IsOperator(string text)
    {
        return text=="+" || text=="-" || text=="*" || text=="/";
    }

    private void Calculate()
    {
        switch (currentOperator)
        {
            case "+":
                result = Addition(leftValue, rightValue);
                break;
            case "-":
                result = Subtraction(leftValue, rightValue);
                break;
            case "*":
                result = Multiplication(leftValue, rightValue);
                break;
            case "/":
                result = Division(leftValue, rightValue);
                break;
        }
        Text.text = result.ToString();
        ResetValues();
        
    }

    private void ResetCalculator()
    {
        result = 0;
        ResetValues();
        Text.text = result.ToString();
    }
    
    private void ResetValues()
    {
        leftValue = 0;
        rightValue = 0;
        isLeft = false;
    }



    
    private float Addition(float a, float b)
    {
        return a + b;
    }
    
    private float Subtraction(float a, float b)
    {
        return a - b;
    }

    private float Multiplication(float a, float b)
    {
        return a * b;
    }
    
    private float Division(float a, float b)
    {
        if (b == 0)
        {
            Debug.LogError("0으로 나눌 수 없다");
            return 0;
        }

        else
            return a / b;
    }
    
    
    
}
