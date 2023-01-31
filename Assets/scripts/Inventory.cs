using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public int coinsCount;
    public Text coinsCountText;
    public Text youwin;
    public Text youlose;
    public Text nextlevel;



    public static Inventory instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de Inventory dans la scène");
            return;
        }

        instance = this;
    }
    public void AddCoins(int count)
    {
        coinsCount += count;
        coinsCountText.text = coinsCount.ToString();
        youwin.text = coinsCount.ToString();
        youlose.text = coinsCount.ToString();
        nextlevel.text = coinsCount.ToString();
    }
}
   
  


