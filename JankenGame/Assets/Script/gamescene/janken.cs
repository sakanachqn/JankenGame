using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class janken : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI jankentext;
    [SerializeField]
    public GameObject vsbutton;

    public static bool Pon = false;
    // Start is called before the first frame update
    void Start()
    {
        jankentext.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(ButtonScript.pressButton)
        {
            StartCoroutine("JanKenPon");
        }
    }

    private IEnumerator JanKenPon()
    {
        ButtonScript.pressButton = false;
        vsbutton.gameObject.SetActive(false);
        jankentext.gameObject.SetActive(true);
        jankentext.text = "‚¶‚á‚ñ‚¯‚ñ";
        yield return new WaitForSeconds(1);
        jankentext.text = "‚Û‚ñ!";
        yield return new WaitForSeconds(1);
        Pon = true;
    }
}
