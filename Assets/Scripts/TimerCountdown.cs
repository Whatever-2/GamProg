using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TimerCountdown : MonoBehaviour
{
    public TextMeshProUGUI timerText; 
    
    private float timer = 60.0f;

    void Update()
    {
        timer -= Time.deltaTime; 
        timerText.text = timer.ToString("0") + "s"; 
    }
}