using UnityEngine;
using TMPro;
using JetBrains.Annotations;
public class Manager : MonoBehaviour
{
    [SerializeField] AutoClicker autoClicker;
    [SerializeField] int score;
    [SerializeField] int cost;
    [SerializeField] int autoCost;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text pointText;
    [SerializeField] TMP_Text costText;
    int points = 1;
    bool bonuspoints;
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
        if (score < cost)
        {
            return;
        }
        points += 1;
        score -= cost;
        cost = cost + cost / 2;
        costText.text = cost.ToString();
        pointText.text = points.ToString();
        Display();
    }
    public void AddAutoScore()
    {
        score += 1;
        Display();
    }
    public void BuyAutoClick()
    {
        if (score < autoCost)
        {  return; }
        score -= autoCost;
        Display();
    }
    public void Bonus()
    {
        if (!bonuspoints)
        {
            bonuspoints = true;
            score += 25;
            Display();
        }
    }
}