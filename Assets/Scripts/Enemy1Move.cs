using UnityEngine;
using System.Collections;
//using EnemySpawn; 
//using System.Collections.Generic;

public class Enemy1Move : MonoBehaviour
{
    public Transform startMarker;
    public Transform midPoint1;
    public Transform midPoint2;
    public Transform endMarker;
    //public bool hasSpawn = false;
    public float speed = 0.1f;
    
    public Transform currentTarget = null;
    public Animator anim = null;

    private void Start()
    {
        anim = GetComponent<Animator>();
        currentTarget = midPoint1;
    }

    void Update()
    {
        if(currentTarget != null) // this is required because i used the null to stop the shakey effect.
            transform.position += (currentTarget.position - transform.position).normalized * speed * Time.deltaTime;
        // normalized takes two points on a large vector and simplifies it to 0-1.
        //transform.position = Vector3.Lerp(transform.position, currentTarget.position, speed * Time.deltaTime  );
        
        if (currentTarget == null )
            Idle();
    }

    private void Next()
    {
        if (currentTarget == midPoint1)
            currentTarget = midPoint2;
        else if (currentTarget == midPoint2)
            currentTarget = endMarker;
        if (midPoint2 == null)
            midPoint2 = endMarker;
      
        
       
    }

    private void Idle()
    {
        if (anim != null)
            anim.SetBool("Idle", true);
    }

    private void OnTriggerEnter(Collider c)
    {
        //Debug.Log(c.name + " | " + currentTarget.name);

        if (c.name == currentTarget.name)
            Next();
        if (c.name == endMarker.name)
            currentTarget = null;
        if (c.name == midPoint1.name)
            currentTarget = midPoint2;
       
        
       

    }
}