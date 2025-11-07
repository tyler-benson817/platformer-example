
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public int m_Value = 1;
    public ScoreManager scoremanager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // only trigger if the player touches the coin
        if (collision.CompareTag("Player"))
        {
            // find the score manager nad add points
            if (scoremanager != null)
            {
                scoremanager.AddScore(m_Value);
            }
            Destroy(gameObject);
        }
    }
}
