using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Excercise : MonoBehaviour
{
    public InputField InputField;
    public InputField InputField2;
    public Text resultText;

    public void CompareNumbers()
    {
        if (float.TryParse(InputField.text, out float number1) 
            && float.TryParse(InputField2.text, out float number2))
        {
            if (number1 > number2)
            {resultText.text = "First number is Greater";} else if (number1 < number2) {resultText.text = "Second number is Greater";} else {resultText.text = "Both are equal";}
        }
        else
        {
            resultText.text = "Please Enter Valid Number";
        }

    }
}
