using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonScript : MonoBehaviour
{
    [SerializeField]
    GameObject gobj;


    public static GameObject button;

    public static bool pressButton = false;

    // Start is called before the first frame update
    void Start()
    {
        button = gobj;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        if(PLhandGene.nowPrev != null)pressButton = true;
    }




}
