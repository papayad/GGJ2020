using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarFade : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer renderer = gameObject.GetComponent<MeshRenderer>();
        Material material = renderer.material;

        material.SetFloat("_Mode", 3f);

        //0f - opacity
        //1f - cutout
        //2f - fade
        //3f - transparent

        Color32 col = renderer.material.GetColor("_Color");
        col.a = 100;
        renderer.material.SetColor("_Color", col);

        material.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
        material.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
        material.SetInt("_ZWrite", 0);
        material.DisableKeyword("_ALPHATEST_ON");
        material.EnableKeyword("_ALPHABLEND_ON");
        material.DisableKeyword("_ALPHAPREMULTIPLY_ON");
        material.renderQueue = 3000;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
