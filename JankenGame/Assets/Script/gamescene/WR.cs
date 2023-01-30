using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WR : MonoBehaviour
{
    [SerializeField]
    janken jnk;
    [SerializeField]
    CPscript cps;
    [SerializeField]
    PrevScript prev;

    [SerializeField]
    private GameObject PlPrev;
    [SerializeField]
    private GameObject CpPrev;
    [SerializeField]
    TextMeshProUGUI WRtext;

    private int plnum, cpnum;

    public static bool check = false;

    private bool win, lose, draw;
    private bool Isdelhand = false;
    private bool winPlus = false;

    public static int winCount;
    // Start is called before the first frame update
    void Start()
    {
        winCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(check)
        {
            HandCheck();
            winCheck();
            ChangeText();
            StartCoroutine("ResGame");

            check = false;
        }
    }

    void HandCheck()
    {
        if (true == PlPrev.transform.Find("GUU").gameObject.activeSelf)
        {
            plnum = 1;
        }
        else if (true == PlPrev.transform.Find("CHOKI").gameObject.activeSelf)
        {
            plnum = 2;
        }
        else if (true == PlPrev.transform.Find("PAA").gameObject.activeSelf)
        {
            plnum = 3;
        }


        if (true == CpPrev.transform.Find("GUU").gameObject.activeSelf)
        {
            cpnum = 1;
        }
        else if (true == CpPrev.transform.Find("CHOKI").gameObject.activeSelf)
        {
            cpnum = 2;
        }
        else if (true == CpPrev.transform.Find("PAA").gameObject.activeSelf)
        {
            cpnum = 3;
        }
    }

    void winCheck()
    {
        switch(plnum)
        {
            case 1:
                {
                    switch(cpnum)
                    {
                        case 1:
                            {
                                draw = true;
                            }
                            break;
                        case 2:
                            {
                                win = true;
                            }
                            break;
                        case 3:
                            {
                                lose = true;
                            }
                            break ;
                    }
                }
                break;
            case 2:
                {
                    switch (cpnum)
                    {
                        case 1:
                            {
                                lose = true;
                            }
                            break;
                        case 2:
                            {
                                draw = true;
                            }
                            break;
                        case 3:
                            {
                                win = true;
                            }
                            break;
                    }
                }
                break;
            case 3:
                {
                    switch (cpnum)
                    {
                        case 1:
                            {
                                win = true;
                            }
                            break;
                        case 2:
                            {
                                lose = true;
                            }
                            break;
                        case 3:
                            {
                                draw = true;
                            }
                            break;
                    }
                }
                break;
        }
    }

    void ChangeText()
    {
        if (win)
        {
            WRtext.text = "èüÇøÅI"; win = false; Isdelhand = true; winPlus = true;
        }
        else if (lose)
        {
            WRtext.text = "ïâÇØÅI"; lose = false; Isdelhand = true;
        }
        else if (draw)
        { 
            WRtext.text = "Ç†Ç¢Ç±ÅI"; draw = false; 
        }

    }

    void DelHand()
    {
        Destroy(PLhandGene.nowPrev);
        Destroy(cps.cpCardArea.transform.GetChild(0).gameObject);
        cps.CPhand[cps.rndnum] = 3;
        Isdelhand = false;
    }

    private IEnumerator ResGame()
    {
        yield return new WaitForSeconds(2);
        if(Isdelhand) DelHand();
        jnk.vsbutton.SetActive(true);
        WRtext.gameObject.SetActive(false);
        prev.PrevRes();
        cps.CPprevRes();
        if (winPlus)
        {
            winCount++;
            winPlus = false;
        }
    }
    




}
