using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    [Header("Elements")]
    public GameObject normalPickup;     //regular pickup, small length bonus, low points, no lifetime
    public GameObject fasterPickup;     //this pickup ups the player's speed, high points, medium lifetime
    public GameObject slowerPickup;     //slows the player, high points, small lifetime
    public GameObject smallerPickup;    //smaller player, low points, small lifetime
    public GameObject longerPickup;     //longer player, huge points, medium lifetime
    public GameObject pickupParent;     

    [Header("Tweak")]
    [Range(0f, 5f)]
    public float spawnTime = 0.5f;

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
            Invoke("Spawn", spawnTime);
            isPickedUp = false;
       } 
    }

    void Spawn()
    { 
        position = new Vector3(Random.Range(-2f,2f), Random.Range(-4f, 4f), 0f);
        Instantiate(normalPickup, position, Quaternion.identity ,pickupParent.transform);
    }
}
