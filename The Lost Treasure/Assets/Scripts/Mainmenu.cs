using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public void MainmenuScene()
    {
        SceneManager.LoadScene(0);
    }
    public void Save()
    {
        PlayerPrefs.SetInt("Scene", SceneManager.GetActiveScene().buildIndex);
        PlayerPrefs.Save();
        print("Game saved!");
    }
    public void Load()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(PlayerPrefs.GetInt("Scene"));
        print("Game loaded!");
    }
    public void Close()
    {
        Application.Quit();
    }

}
