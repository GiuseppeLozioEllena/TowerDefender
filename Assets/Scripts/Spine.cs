using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spine : MonoBehaviour {

    
    public float speed;
    Vector3 startPos;
    public Transform target;
    Quaternion startRotation;
    float range = 5f;

    private void SetRange(float r)
    {
        range = r;
    }

	void Start ()
    {
        startPos = transform.position;
        startRotation = transform.rotation;
    }

    void ResetPosition()
    {
        if (Vector3.Distance(startPos, transform.position) > 5f)
        {
            Debug.Log("Reset");
            transform.position = startPos;
            transform.rotation = startRotation;
        
        }

      
    }

    void CheckInRange()
    {
      

    }
    

    // Update is called once per frame
    void Update ()
    {
     
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            ResetPosition();
        
      

    }




    /*
    Vector3 targetDir = target.position - transform.position;
    float step = speed * Time.deltaTime;
    Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step*10f, 0.0F);
    Debug.DrawRay(transform.position, newDir, Color.red);
    transform.rotation = Quaternion.LookRotation(newDir);
    transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    */
}
