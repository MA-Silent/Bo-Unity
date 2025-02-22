using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    
    private static UIManager _instance;
    public Text coinText;
    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("UIManager is null!");
            }
            return _instance;
        }
    }

    public void UpdateCoins(int coins)
    {
        coinText.text = "Coins: " + coins;
    }

    void Awake()
    {
        _instance = this;  
    }
}
