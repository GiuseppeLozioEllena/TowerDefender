using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {


    public float speed;
    private int pointIndex=0;
    private Transform target;
    
	// Use this for initialization
	void Start () {
        target = WayPoints.points[0];

	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 dir = target.position - transform.position;
        float step = speed * Time.deltaTime;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, dir, step, 0.0F);
        transform.rotation = Quaternion.LookRotation(newDir);


        transform.Translate(dir.normalized * speed * Time.deltaTime,Space.World);
     
        if (Vector3.Distance(transform.position,target.position) <= 0.4f)
            gotNextWaypoint();
	}
    void gotNextWaypoint()
    {
        pointIndex++;
      

        if (pointIndex >= WayPoints.points.Length)
        {
            Destroy(gameObject);
            return; 
        }
        target = WayPoints.points[pointIndex];
       
       

    }

}
