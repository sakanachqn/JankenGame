using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    [SerializeField]
    GameObject FadeCanv;

    public static Fade instance;

    private bool IsFadeNow = false;
    private bool IsChangeScene = false;

    public static bool StoG = false;
    void Awake()
    {
        CheckInstance();
    }
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        FadeCanv.GetComponent<CanvasGroup>().alpha = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (StoG) StartCoroutine(StartToGame());
    }

    void FadeIn()
    {
        
    }

    void FadeOut()
    {
        
    }

    void CheckInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private IEnumerator StartToGame()
    {

    }
}
