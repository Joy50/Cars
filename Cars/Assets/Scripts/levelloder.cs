using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelloder : MonoBehaviour {
    GameObject menu_Canvas;
    GameObject settings_Canvas;
	void Start () {
        menu_Canvas = GameObject.Find("MainMenuCanvas");
        settings_Canvas = GameObject.Find("SettingCanvus");
        settings_Canvas.SetActive(false);
        menu_Canvas.SetActive(true);
		
	}
    public void LevelLoder(int a)
    {
        //Application.LoadLevel(a);
        SceneManager.LoadScene(a);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void loadMenu()
    {
        settings_Canvas.SetActive(false);
        menu_Canvas.SetActive(true);
    }
    public void loadSettings()
    {
        settings_Canvas.SetActive(true);
        menu_Canvas.SetActive(false);
    }
}
