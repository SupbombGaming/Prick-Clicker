using UnityEngine;
using TMPro;
public class Manager : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] TMP_Text scoreText;
    public void AddScore()
    {
        score += 1;
        Display();

    }
    void Display()
    {
        scoreText.text = scoreText.text = score.ToString();
    }
    public void SubtractScore()
    {
        score -= 1;
        Display();

    }
}