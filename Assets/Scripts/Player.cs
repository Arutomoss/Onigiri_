using UnityEngine.UI;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Text death;
    int death_count = 0;
    public GameObject key, panelFinish;
    bool isKeyUp = false;

    void Start()
    {
        isKeyUp = false;
        panelFinish.SetActive(false);
    }
    

    [System.Obsolete]
    private void OnTriggerEnter2D(Collider2D collider)
    {
       // var dethreason= collider.GetComponent<IDeathReason>();
        if (collider.tag == "Key")
        {
            isKeyUp = true;
            print(isKeyUp);
            Destroy(collider.gameObject);
        }
        if (collider.tag == "Finish" && isKeyUp)
        {
            Time.timeScale = 0;
            panelFinish.SetActive(true);
        }
    }
}
