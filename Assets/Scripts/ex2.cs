using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ex2 : MonoBehaviour
{
    public int secondsCounter = 0;
    public TextMeshProUGUI counterText;
    private void Start()
    {
        StartCoroutine("Counter");
    }
    public IEnumerator Counter()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            secondsCounter++;
            counterText.text = $"{secondsCounter}";
        }
    }
}
