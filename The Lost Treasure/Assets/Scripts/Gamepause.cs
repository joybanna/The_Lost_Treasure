using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamepause : MonoBehaviour {
    [SerializeField] private int inscene;
    public static bool GameIsPaused;
    public GameObject PauseMenuUI;
    public GameObject DieUI;
    public GameObject loading;
   
    

    // Use this for initialization
    void Start()
    {
       
        Time.timeScale = 1f;
        Loading();       
        PauseMenuUI.SetActive(false);
        DieUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (!GameIsPaused)
            {
                Pause();
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Time.timeScale = 0f;
            }

        }
        Healthcheck();

    }
    public void Restart()
    {        
        SceneManager.LoadScene(inscene);
    }
    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {  
        PauseMenuUI.SetActive(true);
        GameIsPaused = true;
    }
    void isDie()
    {        
        DieUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

   
    void Healthcheck()
    {
        if (playerstatus.currenthealt <= 0)
        {
            StartCoroutine(wait());
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            GameIsPaused = false;
            PauseMenuUI.SetActive(false);          
        }
        
    }

    void Loading()
    {        
        StartCoroutine(waitLoad());
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(3);
        isDie();
    }
    IEnumerator waitLoad()
    {
        yield return new WaitForSeconds(1);
        GameIsPaused = false;
        loading.SetActive(false);       
    }

}
