using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeCreate : MonoBehaviour
{
    [SerializeField]
    private GameObject fade;

    public static GameObject fadecanvas;
    // Start is called before the first frame update
    void Start()
    {
        fadecanvas = Instantiate(fade);
        fadecanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
