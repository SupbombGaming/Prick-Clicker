using UnityEngine;
using TMPro;
public class Manager : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] int cost;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text pointText;
    [SerializeField] TMP_Text costText;
    int points = 1;
    public void AddScore()
    {
        score += points;
        Display();

    }
    void Display()
    {
        scoreText.text = score.ToString();
    }
    public void SubtractScore()
    {
        score -= 1;
        Display();

    }
    public void IncreaseScore()
    {
        if (score <= cost)
        {
            return;
        }
        points += 1;
        score -= cost;
        cost = cost + cost / 2;
        costText.text = cost.ToString();
        pointText.text = points.ToString();
    }
}