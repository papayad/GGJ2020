using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LookForStars : MonoBehaviour
{
    public StarFade starFadeScriptPlanet1;
    public StarFade starFadeScriptPlanet2;
    public StarFade starFadeScriptPlanet3;

    bool planet1;
    bool planet2;
    bool planet3;

    public static int moonAmountP1;
    public static int moonAmountP2;
    public static int moonAmountP3;

    public SparkleSounds sparkleSoundsScript;

    public GameObject moonPF;

    public Transform moonSpawner1;
    public Transform moonSpawner2;
    public Transform moonSpawner3;

    public GameObject text1;
    public GameObject text2;
    public GameObject text3;

    public GameObject sparklep1;

    public Image blackScreen;

    public bool fading;

    private void Awake()
    {
        sparklep1.SetActive(false);

        text1.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (fading == true)
        {
            blackScreen.CrossFadeAlpha(1, 2.0f, false);
        }

        RaycastHit hit;

        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if (hit.collider.tag == "Star")
            {
                Debug.Log("Found a star");
                starFadeScriptPlanet1.FadeAlpha();
                sparkleSoundsScript.PlaySparkles();
                StartCoroutine("LoadNextScene");
            }

            if (hit.collider.tag == "Planet1")
            {
                sparkleSoundsScript.PlaySparkles();
                Debug.Log("Found a planet");
                planet1 = true;
                starFadeScriptPlanet1.FadeAlpha();
                sparklep1.SetActive(true);
                text1.SetActive(true);
            }
            else
            {
                text1.SetActive(false);
            }
            if (hit.collider.tag == "Planet2")
            {
                sparkleSoundsScript.PlaySparkles();
                Debug.Log("Found a planet");
                planet2 = true;
                starFadeScriptPlanet2.FadeAlpha();
                text2.SetActive(true);
            }
            else
            {
                text2.SetActive(false);
            }
            if (hit.collider.tag == "Planet3")
            {
                sparkleSoundsScript.PlaySparkles();
                Debug.Log("Found a planet");
                planet3 = true;
                Debug.Log(planet3);
                text3.SetActive(true);
                starFadeScriptPlanet3.FadeAlpha();
            }
            else
            {
                text3.SetActive(false);
            }
            //else
            //{
            //    text1.SetActive(false);
            //}

            if (Input.GetButtonDown("Jump"))
            {

                if (hit.collider.tag == "Planet1")
                {
                    Debug.Log("p1 moons; " + moonAmountP1);
                    Instantiate(moonPF, new Vector3(moonSpawner1.position.x + Random.Range(0, 10f), 0, moonSpawner1.position.z + Random.Range(0, 10)), moonSpawner1.rotation);
                    moonAmountP1 += 1;
                }
                if (hit.collider.tag == "Planet2")
                {
                    Debug.Log("p2 moons; " + moonAmountP2);
                    Instantiate(moonPF, new Vector3(moonSpawner2.position.x + Random.Range(0, 3f), moonSpawner2.position.x + Random.Range(-5, 0f), moonSpawner2.position.z + Random.Range(0, 2)), moonSpawner2.rotation);
                    moonAmountP2 += 1;
                }
                if (hit.collider.tag == "Planet3")
                {
                    Debug.Log("" + moonAmountP3);
                    Instantiate(moonPF, new Vector3(moonSpawner3.position.x + Random.Range(-10, 10f), moonSpawner3.position.y, moonSpawner3.position.z), moonSpawner3.rotation);
                    moonAmountP3 += 1;
                }
            }

            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
        }

        if (planet1 == true && planet2 == true && planet3 == true && moonAmountP1 == 3 && moonAmountP2 == 1 && moonAmountP3 == 1)
        {
            fading = true;
            StartCoroutine("LoadNextScene");
            Debug.Log("winner");
        }
    }

    //void OnMouseEnter()
    //{
    //    text1.SetActive(true);
    //    //if (hit.collider.tag == "Planet1")
    //    //{
    //    //    text1.SetActive(true);
    //    //}
    //    //if (hit.collider.tag == "Planet1")
    //    //{
    //    //    text1.SetActive(true);
    //    //}

    //}

    void OnMouseExit()
    {
        text1.SetActive(false);
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        yield return null;
    }
}
