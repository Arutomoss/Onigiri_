using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [System.Obsolete]
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Onigiri")
        {
            Application.LoadLevel(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}