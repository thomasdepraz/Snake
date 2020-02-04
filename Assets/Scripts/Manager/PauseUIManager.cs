using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;

public class PauseUIManager : MonoBehaviour
{
    [Header("Elements")]
    public GameObject pauseMenu;
    public Button pauseButton;
    public Image pauseButtonShadow;
    public Button resumeButton;
    public Button optionButton;
    public EventSystem eventSystem;

    private bool gameIsPaused = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        gameIsPaused = true;
        pauseMenu.SetActive(true);
        pauseButton.gameObject.SetActive(false);
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        gameIsPaused = false;
        pauseMenu.SetActive(false);
        pauseButton.gameObject.SetActive(true);
    }

    public void Options()
    {
        Debug.Log("WIP");
        //DO SHIT
    }


}
