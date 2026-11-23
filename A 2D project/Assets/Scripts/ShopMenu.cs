using UnityEngine;

public class ShopMenu : MonoBehaviour
{
    bool ShopOpen;
    [SerializeField] GameObject shopMenuOBJ;
    public void ShopMenuUI()
    {
        if (ShopOpen)
        {
            ShopOpen = false;
            shopMenuOBJ.SetActive(false);
            return;
        }

        ShopOpen = true;
        shopMenuOBJ.SetActive(true);
    }
}
