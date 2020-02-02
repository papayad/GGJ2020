using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LookForStars : MonoBehaviour
{
    public StarFade starFadeScript;
    public SparkleSounds sparkleSoundsScript;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
 
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if (hit.collider.tag == "Star")
            {
                Debug.Log("Found a star");
                //sprite.color = Color.Lerp(sprite.color, finalColor, fadeInTime);
                starFadeScript.FadeAlpha();
                sparkleSoundsScript.PlaySparkles();
                StartCoroutine("LoadNextScene");
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

    IEnumerator LoadNextScene()
    {
        Debug.Log("IEnumberator LoadNextScene");
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        yield return null;
    }
}
