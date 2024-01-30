using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PrintText : MonoBehaviour
{
    public TextMeshProUGUI AmountTextTMP;
    public TMP_InputField InputFieldTMP;

    public void DisplayText()
    {
       string inputText=InputFieldTMP.text;
        AmountTextTMP.text = inputText;
    }
}
