using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{

    // Use this for initialization
    int EnemyTriggered = 0;
    public string EnemyTarget;
    [Range(0, 1)]
    public float range = 0f;
    public float speedLeaf = 0f;
    public float DamageLeaf;

    void Awake ()
    {
        GetComponent<SphereCollider>().radius = range;
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    private void OnTriggerEnter(Collider other)
    {
        if (EnemyTarget == other.gameObject.tag)
        {
            EnemyTriggered++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (EnemyTarget == other.gameObject.tag)
        {
            EnemyTriggered--;
        }
    }

    public float getEnemyTriggered()
    {
        return EnemyTriggered;
    }
}
