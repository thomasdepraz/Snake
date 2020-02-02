using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBuilder : MonoBehaviour
{

    [Header("Device Resolution")]
    public float screenHeight;
    public float screenWidth;

    [Header("Elements")]
    public GameObject NorthWall;
    public GameObject SouthWall;
    public GameObject WestWall;
    public GameObject EastWall;

    [Header("Tweaks")]
    [Range(0f, 100f)]
    public float divider = 20f;


    void Awake()
    {
        GetDeviceResolution();
    }

    // Start is called before the first frame update
    void Start()
    {
        NorthWall.transform.localScale = new Vector3(1, screenHeight / divider, 1);
        //NorthWall.transform.position = new Vector3(screenWidth / 2,0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        NorthWall.transform.localScale = new Vector3(1, screenHeight / divider, 1);
    }

    void GetDeviceResolution()
    {
        screenHeight = Screen.height;
        screenWidth = Screen.width;
    }
}
