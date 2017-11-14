using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour {

    public Text TimeInGame;
    float startTime;
	// Use this for initialization
	void Start ()
    {
        startTime = BuildManager.instance.getStartTime();
    }
	
	// Update is called once per frame
	void Update ()
    {

        float t = Time.time - startTime;
        string min =((int)t/60).ToString();
        string sec= (t % 60).ToString("0");
        TimeInGame.text = min + "." + sec;
	}

}
