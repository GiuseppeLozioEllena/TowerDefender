using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    // Use this for initialization

    public float panSpeed = 30f;
    public float panBorderThickness=5f;
    public float scrollSpeed = 100000f;

    private float minY = 25f;
    private float maxY = 55f;

    private float minX = -60f;
    private float maxX = 0f;

    private float minZ = -20f;
    private float maxZ = 60f;
    private Vector3 pos;
    private float speedLerp = 15f;

    void Start () {

        pos = transform.position;
    }
	
	// Update is called once per frame
	void Update ()
    {

        
        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
        {
            pos = transform.position;
            pos.x = transform.position.x + 1f * panSpeed * Time.deltaTime;
            pos.x = Mathf.Clamp(pos.x, minX, maxX);
          
        }
        if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
        {
            pos = transform.position;
            pos.x = transform.position.x - 1f * panSpeed * Time.deltaTime;
            pos.x = Mathf.Clamp(pos.x, minX, maxX);
            
        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            pos = transform.position;
            pos.z = transform.position.z - 1f * panSpeed * Time.deltaTime;
            pos.z = Mathf.Clamp(pos.z, minZ, maxZ);
           
        }
        if (Input.GetKey("a") || Input.mousePosition.x <=  panBorderThickness)
        {
            pos = transform.position;
            pos.z = transform.position.z + 1f * panSpeed * Time.deltaTime;
            pos.z = Mathf.Clamp(pos.z, minZ, maxZ);
           
        }
        transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime * speedLerp);
        float scroll = Input.GetAxis("Mouse ScrollWheel");

        pos = transform.position;

        pos.y -= scroll * scrollSpeed * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime * speedLerp);


    }
}
