using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCameraMovement : MonoBehaviour
{
    public Camera fpsCamera;

    public float horizontalSpeed;
    public float verticalSpeed;

    float h;
    float v;

    private void Start()
    {
        
    }

    private void Update()
    {
        h = horizontalSpeed * Input.GetAxis("Mouse X");
        v = verticalSpeed * Input.GetAxis("Mouse Y");

        transform.Rotate(0, h, 0);
        fpsCamera.transform.Rotate(-v, 0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, 0.1f);
        }
        else
        {
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(0, 0, -0.1f);
            }
            else
            {
                if (Input.GetKey(KeyCode.A))
                {
                    transform.Translate(-0.1f, 0, 0);
                }
                else
                {
                    if (Input.GetKey(KeyCode.D))
                    {
                        transform.Translate(0.1f, 0, 0);
                    }
                }
            }
        }
    }
}
