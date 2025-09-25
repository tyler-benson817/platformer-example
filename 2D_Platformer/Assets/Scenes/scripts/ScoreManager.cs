using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public TextMeshProUGUI m_ScoreText;
    private int m_Score;

    void Start()
    {
        UpdateScoreUI();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int amount)
    {

        m_Score += amount;
        UpdateScoreUI();

    }

    void UpdateScoreUI()
    {
        m_ScoreText.text = "Score: " + m_Score;
    }
}
