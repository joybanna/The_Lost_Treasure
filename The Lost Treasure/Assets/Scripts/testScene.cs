using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class testScene : MonoBehaviour {
    public GameObject test;
	// Use this for initialization
	void Start () {
        test.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
	
	
	public void hint()
    {
        test.SetActive(true);
    }
    public void Playgame()
    {
        SceneManager.LoadScene(1);
    }
    public void Healpmap()
    {
        SceneManager.LoadScene(1);
    }
    public void Pologue()
    {
        SceneManager.LoadScene(9);
    }
    public void VillageI()
    {
        SceneManager.LoadScene(2);
    }
    public void D1()
    {
        SceneManager.LoadScene(3);
    }
    public void VillageII()
    {
        SceneManager.LoadScene(4);
    }
    public void Forest()
    {
        SceneManager.LoadScene(5);
    }
    public void Vamprie()
    {
        SceneManager.LoadScene(6);
    }
    public void D2()
    {
        SceneManager.LoadScene(7);
    }
    public void END()
    {
        SceneManager.LoadScene(8);
    }
}
