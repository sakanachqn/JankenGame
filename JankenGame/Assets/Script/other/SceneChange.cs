using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(3 == WR.winCount)
        {
            ResText.IsWin = true;
            FadeCreate.fadecanvas.gameObject.SetActive(true);
            Fade.GtoR = true;
            Fade.IsFadeOut = true;
        }
    }
}
