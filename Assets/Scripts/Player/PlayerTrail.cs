using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrail : MonoBehaviour
{

    //Trail
    [HideInInspector] public TrailRenderer trailRenderer;
    
    [HideInInspector] public bool isEmitting = false;
    [Header("Tweaks")]
    [Range(0f,2f)]
    public float trailLength = 0.2f;  //in seconds

    // Start is called before the first frame update
    void Start()
    {
        trailRenderer = gameObject.GetComponent<TrailRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isEmitting)
            trailRenderer.emitting = false;
        else
            trailRenderer.emitting = true;

        SetTrailLength();
    }

    void SetTrailLength()
    {
        trailRenderer.time = trailLength;
    }
}
