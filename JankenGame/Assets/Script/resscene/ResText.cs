using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResText : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI text;

    public static bool IsWin = false;
    // Start is called before the first frame update
    void Start()
    {
        if(IsWin)
        {
            text.text = "�����I";
        }
        else
        {
            text.text = "�s�k�I";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
