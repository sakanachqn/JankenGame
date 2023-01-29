using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLhandGene : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Hand = new GameObject[3];
    [SerializeField]
    private GameObject PLhandArea;

    public static GameObject PrevObj = null;

    private GameObject gobj;
    private Transform plArea;
    private int rnd;
    // Start is called before the first frame update
    void Start()
    {
        plArea  = PLhandArea.transform;


        for(int i = 0; i < 5; i++)
        {
            rnd = Random.Range(0, 3);
            gobj = Instantiate(Hand[rnd], plArea, false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
