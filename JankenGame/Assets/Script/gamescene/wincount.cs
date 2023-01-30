using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class wincount : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI wc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        wc.text = "èüÇøì_:" + WR.winCount.ToString("F0");
    }
}
