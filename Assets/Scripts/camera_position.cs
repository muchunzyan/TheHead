using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_position : MonoBehaviour
{
    public Camera cam;
    public float move_here;

    void Start()
    {
        cam = GetComponent<Camera>();
        move_here = 5;
    }

    void FixedUpdate()
    {
        cam.orthographicSize = Mathf.MoveTowards(cam.orthographicSize, move_here, 30 * Time.deltaTime);
    }

    public void MoveCamera()
    {
        move_here = 15;
    }

    public void MoveCameraBack()
    {
        move_here = 5;
    }
}
