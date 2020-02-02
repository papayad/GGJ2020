using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barks : MonoBehaviour
{
    public GameObject[] barkArray;

    private int currentIndex = 0;

    float elapsedTime = 0f; // Counts up to repeatTime
    float repeatTime = 10f; // Time taken to repeat in seconds

    void Start()
    {
        Debug.Log("The number of UI elements in the array is: " + barkArray.Length);
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= repeatTime) {
            // Do something here
            NewRandomObject();
             // Subtract repeat time
             elapsedTime -= repeatTime;
        }
    }

        public void NewRandomObject()
    {
        int newIndex = Random.Range(0, barkArray.Length);
        // Deactivate old gameobject
        barkArray[currentIndex].SetActive(false);
        // Activate new gameobject
        currentIndex = newIndex;
        barkArray[currentIndex].SetActive(true);
    }
}
