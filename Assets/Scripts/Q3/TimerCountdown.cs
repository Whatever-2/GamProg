using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TimerCountdown : MonoBehaviour
{
    public static TimerCountdown instance;
    public TextMeshProUGUI timerText; 
    public TextMeshProUGUI EndText; 
    
    public GameObject Player;
    public GameObject Canvas;

    public float timer = 60.0f;


    private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

    void Update()
    {
        if (timer > 0)        {
        timer -= Time.deltaTime; 
        timerText.text = timer.ToString("0") + "s"; 
    }else
    {
        timer = 0;
        timerText.text = "0s";

        if (ScoreManager.instance.score >= ScoreManager.instance.WinningScore)
        {
            EndText.text = "Win!";
        }
        else
        {
            EndText.text = "Womp Womp";
        }
        Canvas.SetActive(true);

    }
    }

}