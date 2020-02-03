using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    [Header("Elements")]
    public GameObject pickup;
    public GameObject pickupParent;

    private Vector3 position;
    [HideInInspector] public bool isPickedUp = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       if(isPickedUp == true)
       {
            Invoke("Spawn", 3f);
            isPickedUp = false;
       } 
    }

    void Spawn()
    { 
        position = new Vector3(Random.Range(-2f,2f), Random.Range(-4f, 4f), 0f);
        Instantiate(pickup, position, Quaternion.identity ,pickupParent.transform);
    }
}
