using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    //public LookForStars lookForStarsScript;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Vertical"))
        {
            LookForStars.moonAmountP1 = 0;
            LookForStars.moonAmountP2 = 0;
            LookForStars.moonAmountP3 = 0;
            Destroy(gameObject);
        }
    }
}
