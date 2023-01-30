using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startbutton : MonoBehaviour
{
    public static bool StartClick = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (StartClick)
        {
            FadeCreate.fadecanvas.gameObject.SetActive(true);
            Fade.StoG = true;
            Fade.IsFadeOut = true;
        }
    }

    public void OnClick()
    {
        if(!StartClick) StartClick = true;
    }
}
