using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float currentTime;

    // Start is called before the first frame update
    public float GetCurrentTime()
    {
        return currentTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        timerText.text = currentTime.ToString("0.00");
    }
}
