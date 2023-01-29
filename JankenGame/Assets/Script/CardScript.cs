using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardScript : MonoBehaviour, IPointerDownHandler
{
    
    [SerializeField]
    HandTag.HandType handType;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        this.gameObject.SetActive(false);
        HandTag.prevType = handType;
        PrevScript.IsChangePrev = true;
        PLhandGene.PrevObj = this.gameObject;
    }
}
