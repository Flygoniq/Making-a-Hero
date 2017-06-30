using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    

    // Use this for initialization
    void Awake () {
        StartGame();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartGame()
    {
        MenuMaster.SaveSlot = -1;
        SceneManager.LoadScene("Game");
    }
}
