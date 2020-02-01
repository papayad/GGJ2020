using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouseFollow : MonoBehaviour
{
    public bool showCursor;
    public float sensitivity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (showCursor == false)
            {
                Debug.Log("Mouse Visible");
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                showCursor = true;
            }
            else if (showCursor == true)
            {
                Debug.Log("Mouse Invisible");
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                showCursor = false;
            }
        }

        float newRotationY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivity;
    }
}
