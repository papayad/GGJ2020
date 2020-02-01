using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookForStars : MonoBehaviour
{
    SpriteRenderer sprite;
    public float fadeInTime;
    Color starColor;
    Color finalColor = new Color(255, 255, 255, 1);

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        //Ray 
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if (hit.collider.tag == "Star")
            {
                Debug.Log("Found a star");
                sprite.color = Color.Lerp(sprite.color, finalColor, fadeInTime);
            }
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Did Hit");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
    }
}
