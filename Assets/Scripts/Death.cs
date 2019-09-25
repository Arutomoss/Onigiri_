using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    [System.Obsolete]
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Onigiri")
        {
            Application.LoadLevel(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
