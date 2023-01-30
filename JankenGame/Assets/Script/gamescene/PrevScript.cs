using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrevScript : MonoBehaviour
{
    public static bool IsChangePrev = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(IsChangePrev)
        {
            switch(HandTag.prevType)
            {
                case HandTag.HandType.GUU:
                    {
                        PrevRes();
                        this.gameObject.transform.Find("GUU").gameObject.SetActive(true);
                    }
                break;
                case HandTag.HandType.CHOKI:
                    {
                        PrevRes();
                        this.gameObject.transform.Find("CHOKI").gameObject.SetActive(true);
                    }
                    break;
                case HandTag.HandType.PAA:
                    {
                        PrevRes();
                        this.gameObject.transform.Find("PAA").gameObject.SetActive(true);
                    }
                    break;
                    default:
                    {
                        PrevRes();
                    }
                    break;
            }
            IsChangePrev = false;
        }
    }

    public void PrevRes()
    {
        this.gameObject.transform.Find("GUU").gameObject.SetActive(false);
        this.gameObject.transform.Find("CHOKI").gameObject.SetActive(false);
        this.gameObject.transform.Find("PAA").gameObject.SetActive(false);
    }
}

