using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spine : MonoBehaviour {

    
    
    Vector3 startPos;
    public Transform target;
    Quaternion startRotation;
    Cactus plants;

    private void Awake()
    {
        plants=GetComponentInParent<Cactus>();
    }

   

    void Start ()
    {
        startPos = transform.position;
        startRotation = transform.rotation;
    }

    public void ResetPosition()
    {
        if (Vector3.Distance(startPos, transform.position) > plants.range*5f)
        {
            transform.position = startPos;
            transform.rotation = startRotation;
        }
    }

     
    // Update is called once per frame
    void Update ()
    {
        if (plants.getEnemyTriggered()>0)
        {
            transform.Translate(Vector3.forward * plants.speedLeaf * Time.deltaTime);
            ResetPosition();
        }
        else
        {
            if (transform.position != startPos)
            {
                transform.position = startPos;
                transform.rotation = startRotation;
            }
        }
    }

    
}
