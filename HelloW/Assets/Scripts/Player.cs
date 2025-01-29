using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _coins;
    private static Player _instance;
    public static Player Instance
    {
        get
        { 
            if( _instance == null)
            {
                Debug.LogError("Player is null");
            }
            return _instance;
        }
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.tag = "Player";
        _coins = 0;
    }

    void Awake()
    {
        _instance = this;
    }

    public void AddCoin()
    {
        _coins++;
    }

    // Update is called once per frame
    void Update()
    {
        UIManager.Instance.UpdateCoins(_coins);
    }
}
