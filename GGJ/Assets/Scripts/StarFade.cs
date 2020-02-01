using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarFade : MonoBehaviour
{
    SpriteRenderer sprite;
    public float fadeInTime;
    Color starColor;
    //Color invisiColor = new Color(255, 255, 255, 1);
    Color finalColor = new Color(255, 255, 255, 1);

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // accessing from LookForStars script
        //FadeAlpha();
    }

    public void FadeAlpha()
    {
        sprite.color = Color.Lerp(sprite.color, finalColor, fadeInTime);
    }
}
