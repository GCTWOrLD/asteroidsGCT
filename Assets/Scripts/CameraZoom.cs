using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public float changementZoom;
    public float smoothChange;
    public float min, max;

    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mouseScrollDelta.y > 0)
        {
            cam.orthographicSize -= changementZoom * Time.deltaTime * smoothChange;
        }
        else if (Input.mouseScrollDelta.y < 0)
        {
            cam.orthographicSize += changementZoom * Time.deltaTime * smoothChange;
        }
        cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, min, max);
    }
}
