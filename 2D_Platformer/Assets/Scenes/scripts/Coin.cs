using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public static int m_Value = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // only trigger if the player touches the coin
        if (collision.CompareTag("player"))
        {
            // find the ScoreManager and add points 
            ScoreManager _scoreManager = FindAnyObjectByType<ScoreManager>();

            if (_scoreManager != null)
            {
                _scoreManager.AddScore(m_Value);
            }

        }
    }
}
