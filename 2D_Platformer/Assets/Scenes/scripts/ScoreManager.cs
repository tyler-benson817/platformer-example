
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int totalCoins = 0;
    public TextMeshProUGUI coinText; // Assign in Inspector

    //public TextMeshProUGUI scoreText;
    private int m_Score; 
    
    void Awake()
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

    public void AddScore(int amount)
    {
        totalCoins += amount;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        if (coinText != null)
        {
            coinText.text = "Coins: " + totalCoins;
        }
    }
}
