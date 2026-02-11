using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;
    
    public int score = 0;

    public int WinningScore = 10;
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
    void Start()
    {
        scoreText.text = "Score: " + score;

    }

    public void IncrementScore()
    {
        score += 1;
        scoreText.text = "Score: " + score;
    }

    public void DecrementScore()
    {
        if (score > 0)
        {
        score -= 1;
        scoreText.text = "Score: " + score;
        }
    }
}
