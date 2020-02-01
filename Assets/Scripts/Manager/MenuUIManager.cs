using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuUIManager : MonoBehaviour
{
    [Header("Elements")]
    public Canvas menuCanvas;
    public Button startButton;
    public Button optionButton;
    public EventSystem eventSystem;

    [Header("Device Resolution")]
    public float screenHeight;
    public float screenWidth;

    private CanvasScaler scaler;
    private Vector2 referenceResolution;

    void Awake()
    {
        GetDeviceResolution();    
    }
    // Start is called before the first frame update
    void Start()
    {
        scaler = menuCanvas.GetComponent<CanvasScaler>();
        referenceResolution.x = screenWidth;
        referenceResolution.y = screenHeight;
        scaler.referenceResolution = referenceResolution;
        Debug.Log("Device Resolution : " + referenceResolution);
        Debug.Log("Canvas Resolution : " + scaler.referenceResolution);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Get the device screen hight and width in pixels.
    void GetDeviceResolution()
    {
        screenHeight = Screen.height;
        screenWidth = Screen.width;
    }

    public void OnPlay()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void OnOptions()
    {
        //DO SHIT
    }
}
