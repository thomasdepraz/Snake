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
    private GameObject pickupToSpawn;

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
        int randValue = (int)Random.Range(0, 100);

        if (PlayerManager.pickupCount > 5)
        {
            //Choose a pickup based on randValue
            if (randValue < 7 && PlayerTrail.trailLength > 1f)
                pickupToSpawn = smallerPickup;
            else if (randValue > 7 && randValue < 16)
                pickupToSpawn = longerPickup;
            else if (randValue > 16 && randValue < 30 && PlayerMovement.moveSpeedModifier > 0.4)
                pickupToSpawn = slowerPickup;
            else if (randValue > 30 && randValue < 45)
                pickupToSpawn = fasterPickup;
            else if (randValue > 45)
                pickupToSpawn = normalPickup;
            //----------------------------------
        }
        else
            pickupToSpawn = normalPickup;

        position = new Vector3(Random.Range(-2f,2f), Random.Range(-4f, 4f), 0f);
        Instantiate(pickupToSpawn, position, Quaternion.identity ,pickupParent.transform);
    }
}
