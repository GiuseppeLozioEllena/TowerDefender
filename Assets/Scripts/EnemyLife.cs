using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour {

    // Use this for initialization
    public float life = 3f;
    public float scaleFactor = 0.9f;
	
	// Update is called once per frame
	void Update () {

		
	}

    
    public void Hit(float damage)
    {
        life -= damage;
        transform.localScale = new Vector3(transform.localScale.x* scaleFactor, transform.localScale.y * scaleFactor, transform.localScale.z * scaleFactor);
        if (life <= 0)
        {
            Destroy(gameObject, 0.4f);
        }
    }
}
