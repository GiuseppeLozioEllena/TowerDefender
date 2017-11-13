using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour {

    // Use this for initialization

    public Color OverMouse;
    private Renderer rend;
    private Color startColor;
    BuildManager buildManager;
    private bool free = true;

	void Start () {

        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManager = BuildManager.instance;

    }
    void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (buildManager.GetTurrentToBuild() == null)
            return;

        rend.material.color = OverMouse;
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }

    void OnMouseDown()
    {


        if (free)
        {
            if (buildManager.GetTurrentToBuild() == null)
                return;

            GameObject turrent = buildManager.GetTurrentToBuild();         
            Instantiate(turrent, new Vector3(transform.position.x, transform.position.y + 0.43f, transform.position.z), transform.rotation);
            free = false;
        }
    }


}
