using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {

    // Use this for initialization
    public static BuildManager instance;
    private GameObject turrentToBuild;
    public GameObject[] Turrets;

    void Awake()
    {
        if (instance != null)
            return;

        instance = this;
    }
	void Start ()
    {
        
	}

    public GameObject GetTurrentToBuild()
    {
        return turrentToBuild;
    }
	// Update is called once per frame
	void Update () {
		
	}

    public void setTurretSelected(GameObject turret)
    {
        turrentToBuild = turret;

    }
}
