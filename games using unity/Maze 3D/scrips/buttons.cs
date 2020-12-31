

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttons : MonoBehaviour
{
    public ui ui;
    public GameObject mapPanel;
    public GameObject play;
    public GameObject levels;
    public GameObject settings;
    public fade_in fade;
    [HideInInspector]
    public bool leftRight = false;

    public Button saveButton;
    public audiaManager sound;


    public void Awake()
    {
        saveSettings save = saveSystem.loadSavedSettings();
        leftRight = save.change;
    }
    public void pauseGame()
    {
        Time.timeScale = 0;
        ui.disableGameobject();
        sound.playSound("click");

    } 

    public void resumeGame()
    {
        Time.timeScale = 1;
        ui.enableGameobject();
        sound.playSound("click");
    }

    public void restart()
    {
        Time.timeScale = 1;
        ui.endGame = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        sound.playSound("click");
    }

    public void showMap()
    {
        mapPanel.SetActive(true);
        GameManager.showMapTime = 7f;

    }

    public void playLevels() {
        fade.fade_to_next_();
        play.SetActive(false);
        fade.Start();
        levels.SetActive(true);
        sound.playSound("click");
    }
    public void loadLevel(string nameScene)
    {
        fade.fade_to(nameScene);
        ui.endGame = false;
        Time.timeScale = 1;
        sound.playSound("click");
    }
    public void quitGame()
    {
        Application.Quit();
        sound.playSound("click");
    }

  /*  public void loadNextLevel(SceneAsset scene)
    {
        fade.fade_to(scene.name);
        Time.timeScale = 1;
    }*/

    public void Settings()
    {
        fade.fade_to_next_();
        play.SetActive(false);
        fade.Start();
        settings.SetActive(true);
        sound.playSound("click");
    }

    public void goBack()
    {
        fade.fade_to_next_();
        play.SetActive(true);
        fade.Start();
        levels.SetActive(false);
        settings.SetActive(false);
        sound.playSound("click");
    }

    public void changeMovement()
    {
        leftRight = !leftRight;
        saveButton.interactable = true;
        sound.playSound("click");
    }

    public void saveBtn()
    {
        saveButton.interactable = false;
        saveSystem.saveSettings(this);
    }
}
