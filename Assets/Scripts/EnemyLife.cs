using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{

    // Use this for initialization
    public float life = 3f;
    public float scaleFactor = 0.9f;
    public GameObject HitParticellar;
    Renderer renderer;
    Color startcolor;
    EnemyMovement movement;

    private void Start()
    {
        renderer = GetComponentInChildren<Renderer>();
        startcolor = renderer.material.color;
        movement = GetComponent<EnemyMovement>();


    }

    // Update is called once per frame
    void Update () {

		
	}

    
    public void Hit(float damage)
    {
        life -= damage;
        movement.speed -= 0.25f;
        Destroy(Instantiate(HitParticellar, transform.position, transform.rotation), 2.0f);
        StartCoroutine(ChangeColor());
        if (life <= 0)
        {
            Destroy(gameObject, 0.4f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Spine")
            Hit(other.gameObject.GetComponentInParent<Plant>().DamageLeaf);
    }

    IEnumerator ChangeColor()
    {
        renderer.material.color = Color.red;
        yield return new WaitForSeconds(0.25f);
        renderer.material.color = startcolor;
    }
}
