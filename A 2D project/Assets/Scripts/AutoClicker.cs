using System.Collections;
using UnityEngine;

public class AutoClicker : MonoBehaviour
{
    bool purchased;
    [SerializeField] Manager manager;
    public void AutoClick()
    {
        if (purchased) 
        { 
        StartCoroutine(ClickAuto());
        }
    }

    public void GetAutoClick()
    {
        purchased = true;
        AutoClick();
    }
    IEnumerator ClickAuto()
    {
        yield return new WaitForSeconds(2f);
        AutoClick();
        manager.AddAutoScore();
    }
}