using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;


public class AmountDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    public  TextMeshProUGUI AmountTextTMP;
    public  TMP_InputField  InputFieldTMP;

    public void ALLButtonClick()
    {
        InputFieldTMP.text = AmountTextTMP.text;
        string[] d= InputFieldTMP.text.Split(" ");
        InputFieldTMP.text = d[0]; 
        
    } 
}
