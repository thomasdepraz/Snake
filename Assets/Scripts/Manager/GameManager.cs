using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [HideInInspector] public enum gameStates{RUNNING, PAUSE, NONE};
    [HideInInspector] public gameStates currentState = gameStates.NONE;

    //PLAYER
    private GameObject player;
    private PlayerManager playerManager;

    //PICKUPABLES
    private GameObject spawner;
    private PickupSpawner pickupSpawner;

    //UI
    private int score;
    private int highscore;

    //CAMERA
    private float height;
    private float width;

    // Start is called before the first frame update
    void Start()
    {
        //Set Game State to RUNNING
        currentState = gameStates.RUNNING ;

        //Get Player
        player = GameObject.FindGameObjectWithTag("Player");
        playerManager = player.GetComponent<PlayerManager>();

        //Get Spawner
        spawner = GameObject.FindGameObjectWithTag("Spawner");
        pickupSpawner = spawner.GetComponent<PickupSpawner>();

        //Get Screen resolution in units
        height = Camera.main.orthographicSize * 2;
        width = height * Screen.width / Screen.height;



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
