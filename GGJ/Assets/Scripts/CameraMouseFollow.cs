using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouseFollow : MonoBehaviour
{
    public bool showCursor;
    public float sensitivity;

    void Start()
    {
        showCursor = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (showCursor == false)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        float newRotationY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivity;
        float newRotationX = transform.localEulerAngles.x - Input.GetAxis("Mouse Y") * sensitivity;

        gameObject.transform.localEulerAngles = new Vector3(newRotationX, newRotationY, 0);
    }
}
