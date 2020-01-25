using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Tweaks")]
    [SerializeField] private Quaternion baseRotation = new Quaternion(0, 0, 1, 0);
    private Vector3 direction = new Vector3(1, 1, 0);
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        GyroManager.Instance.EnableGyro();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = (GyroManager.Instance.GetGyroRotation() * baseRotation) * direction;
    }
}
