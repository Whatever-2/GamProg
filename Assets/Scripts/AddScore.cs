using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    void Start()
    {
        score = 0;
        UpdateScoreText();
    }


    public void AddScoreCount( int PointsToAdd )
    {
        
        score += PointsToAdd;
        UpdateScoreText();

    }
 
       void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();

    }

}
