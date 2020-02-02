using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{
    [Header("Device Resolution")]
    public float screenHeight;
    public float screenWidth;

    [Header("Elements")]
    public RectTransform rectTransform;

    private void Awake()
    {
        GetDeviceResolution();
    }
    // Start is called before the first frame update
    void Start()
    {
        rectTransform.sizeDelta = new Vector2(screenWidth / 100, screenHeight / 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetDeviceResolution()
    {
        screenHeight = Screen.height;
        screenWidth = Screen.width;
    }
}
