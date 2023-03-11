using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ex3 : MonoBehaviour
{
    public int value = 0;
    public TextMeshProUGUI valueText;
    public int newPoints;

    void Start()
    {
        //text on creen
        valueText.text = $"value: {value}";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) //Detect when the up arrow key is pressed up
        {
            value++; //sum of points
            valueText.text = $"value: {value}";
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow)) // //Detect when the up arrow key is pressed down
        {
            value--; //points substraction
            valueText.text = $"value: {value}";
        }
    }
}
