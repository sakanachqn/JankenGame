using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    [SerializeField]
    GameObject FadeCanv;

    public static Fade instance;

    private bool IsFadeEnd = false;

    private bool IsChangeScene = false;

    public static bool IsFadeOut = false;
    private bool IsFadeIn = false;

    public static bool StoG = false;
    public static bool GtoR = false;  
    public static bool RtoG = false;

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
        if(StoG) StartToGame();
        if(GtoR) GameToRes();
        if(RtoG) ResToGame();
    }

    void FadeIn()
    {
        FadeCanv.GetComponent<CanvasGroup>().alpha -= Time.deltaTime;
        if(FadeCanv.GetComponent<CanvasGroup>().alpha <= 0)
        {
            IsFadeIn = false;
            FadeCreate.fadecanvas.SetActive(false);
            IsFadeEnd = true;
        }

    }


    void FadeOut()
    {
        FadeCanv.GetComponent<CanvasGroup>().alpha += Time.deltaTime;
        if(FadeCanv.GetComponent <CanvasGroup>().alpha >= 1)
        {
            IsFadeOut = false;
            IsChangeScene = true;
        }
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

    void StartToGame()
    {
        if (IsFadeOut)
        {
            FadeOut();
        }
        if (IsChangeScene)
        {
            SceneManager.LoadScene("GameScene");
            IsChangeScene = false;
            IsFadeIn = true;
        }
        if (IsFadeIn)
        {
            FadeIn();
        }
        if(IsFadeEnd)
        {
            IsFadeEnd = false;
            StoG = false;
        }
    }

    void GameToRes()
    {
        if (IsFadeOut)
        {
            FadeOut();
        }
        if (IsChangeScene)
        {
            SceneManager.LoadScene("ResScene");
            IsChangeScene = false;
            IsFadeIn = true;
        }
        if (IsFadeIn)
        {
            FadeIn();
        }
        if (IsFadeEnd)
        {
            IsFadeEnd = false;
            GtoR = false;
            WR.winCount = 0;
        }
    }

    void ResToGame()
    {
        if (IsFadeOut)
        {
            FadeOut();
        }
        if (IsChangeScene)
        {
            SceneManager.LoadScene("GameScene");
            IsChangeScene = false;
            IsFadeIn = true;
        }
        if (IsFadeIn)
        {
            FadeIn();
        }
        if (IsFadeEnd)
        {
            IsFadeEnd = false;
            RtoG = false;
        }
    }
}
