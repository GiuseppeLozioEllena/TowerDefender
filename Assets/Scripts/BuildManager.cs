using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {

    // Use this for initialization
    public static BuildManager instance;
    private GameObject turrentToBuild;
    public GameObject[] Turrets;

    internal static object Instantiate<T>()
    {
        throw new NotImplementedException();
    }

    float startTime;

    void Awake()
    {
        if (instance != null)
            return;

        instance = this;
        startTime = Time.time;
    }

	void Start ()
    {
        InvokeRepeating("CheckGrowing", 1.0f,0.0f);
	}
    public float getStartTime()
    {
        return startTime;
    }

    public GameObject GetTurrentToBuild()
    {
        return turrentToBuild;
    }
	// Update is called once per frame
	void Update ()
    {
    }

    void CheckGrowing()
    {
        float t = Time.time - startTime;
        float sec = (t % 60);
        if (sec > 10f)
            GrowPlants();
    }

    void GrowPlants()
    {
        Debug.Log("Grow PLANTS!!");
    }

    public void setTurretSelected(GameObject turret)
    {
        turrentToBuild = turret;

    }
}
