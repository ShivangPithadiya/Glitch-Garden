using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fadein : MonoBehaviour
{
    public float fadeInTime;
    private Image penal;
    private Color currentcolor = Color.black;
    // Start is called before the first frame update
    void Start()
    {
        penal = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad < fadeInTime)
        {
            float alphaChange = Time.deltaTime / fadeInTime;
            currentcolor.a -= alphaChange;
            penal.color = currentcolor;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
