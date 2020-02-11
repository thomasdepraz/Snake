using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    [Header("Elements")]
    public CircleCollider2D playerCol;
    public Animator anim;

    [Header("Logic")]
    public float speedModifier;
    public float lengthModifier;
    public int scoreValue;
    public float lifeTime;

  
    

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
            if (lifeTime != 0)
                StartCoroutine("LifeTime");
        }
            


            if (parameter.Equals("disappear"))
        { }
            //lancer l'anim de destruction
            

        
    }

    private IEnumerator LifeTime()
    {
        new WaitForSeconds(lifeTime);
        
        //lancer l'anim de destruction
        yield return null;
    }
}
