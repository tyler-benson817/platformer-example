
using UnityEngine.SceneManagement;
using UnityEngine;
using Unity.VisualScripting;

public class SceneTransition : MonoBehaviour
{
    public string sceneToLoad = "quiz 1"; 

    private bool playerInRange = false;

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.W)) 
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
       
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
    
}
