using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPscript : MonoBehaviour
{
    [SerializeField]
    private GameObject CPPrev;
    [SerializeField]
    private GameObject card;
    [SerializeField]
    public GameObject cpCardArea;

    [HideInInspector]
    public int[] CPhand = new int[5];

    public int rndnum;
    private Transform cpArea;

    // Start is called before the first frame update
    void Start()
    {
        cpArea = cpCardArea.transform;
        for (int i = 0; i < CPhand.Length; i++)
        {
            CPhand[i] = Random.Range(0, 3);
            Instantiate(card, cpArea, false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        while(janken.Pon)
        {
            rndnum = Random.Range(0, 5);
            switch(CPhand[rndnum])
            {
                case 0:
                    {
                        CPprevRes();
                        CPPrev.gameObject.transform.Find("GUU").gameObject.SetActive(true);
                        janken.Pon = false;
                        WR.check = true;
                    }
                    break;
                case 1:
                    {
                        CPprevRes();
                        CPPrev.gameObject.transform.Find("CHOKI").gameObject.SetActive(true);
                        janken.Pon = false;
                        WR.check = true;
                    }
                    break ;
                case 2:
                    {
                        CPprevRes();
                        CPPrev.gameObject.transform.Find("PAA").gameObject.SetActive(true);
                        janken.Pon = false;
                        WR.check = true;
                    }
                    break;
                default:
                    break;
                    
            }
        }
    }

    public void CPprevRes()
    {
        CPPrev.gameObject.transform.Find("GUU").gameObject.SetActive(false);
        CPPrev.gameObject.transform.Find("CHOKI").gameObject.SetActive(false);
        CPPrev.gameObject.transform.Find("PAA").gameObject.SetActive(false);
    }
}
