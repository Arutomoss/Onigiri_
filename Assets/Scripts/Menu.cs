using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject btnPlay, btnSettings, btnExit;
    public GameObject panel, settingsPanel;
    bool isEscape = false, isOpenSettings = false;
    public Slider musicSlider;

    private void Start()
    {
        Time.timeScale = 1;

        GameObject obj = GameObject.FindGameObjectWithTag("Music");

        int s = Application.loadedLevel;
        print(s);

        if (s == 0)
        {
            Destroy(obj);
        }

    }

    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            Time.timeScale = 0;
            panel.SetActive(true);
            isOpenSettings = false;
        }
    }

    public void Update()
    {
        AudioListener.volume = musicSlider.value;
    }

    public void OnClickPlay()
    {
        SceneManager.LoadScene(1);
    }

    public void OnClickExit()
    {
        Application.Quit();
    }

    public void OnClickResume()
    {
        Time.timeScale = 1;
        panel.SetActive(false);
        settingsPanel.SetActive(false);
    }

    public void OnClickBackToMainMenu()
    {
        Application.LoadLevel(0);
    }

    public void OnClickSettings()
    {
        if (!isOpenSettings)
        {
            settingsPanel.SetActive(true);
            isOpenSettings = true;
        }
        else if (isOpenSettings)
        {
            settingsPanel.SetActive(false);
            isOpenSettings = false;
        }

    }

}
