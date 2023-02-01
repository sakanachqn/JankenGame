using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript1 : MonoBehaviour
{
    private bool IsClick = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        if(!IsClick)Fade.instance.gameObject.SetActive(true);
        Fade.GtoS = true;
        Fade.IsFadeOut = true;
    }
}
