using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FollowGyro : MonoBehaviour
{
    [Header("Tweaks")]
    [SerializeField] private Quaternion baseRotation = new Quaternion(0, 0, 1, 0);

    [Header("Debug")]
    public GameObject cubeRotation;
    private Text cubeRotationText;


    // Start is called before the first frame update
    void Start()
    {
        GyroManager.Instance.EnableGyro();
        cubeRotationText = cubeRotation.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        cubeRotationText.text = "Cube Rotation : " + transform.localRotation;
        Debug.Log("CubeRotation : " + transform.localRotation);
        transform.localRotation = GyroManager.Instance.GetGyroRotation() * baseRotation;
    }

    public void ResetRotation()
    {
        transform.localRotation = new Quaternion(0, 0, 0, 0);
        baseRotation = GyroManager.Instance.GetGyroRotation();
    }
}
