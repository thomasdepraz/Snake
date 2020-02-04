using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    [Header("Elements")]
    public CircleCollider2D playerCol;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetAnimationEvent(string parameter)
    {
        if (parameter.Equals("spawn"))
        {
            anim.SetBool("HasSpawned", true);
        }
    }
}
