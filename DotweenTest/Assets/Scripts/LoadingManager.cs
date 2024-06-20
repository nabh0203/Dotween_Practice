using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{
    public static LoadingManager Instance
    {
        get
        {
            return instance;
        }
    }
    private static LoadingManager instance;

    public CanvasGroup FadeImg;
    float fadeDuration = 2f;
    public GameObject loading;
    public Text loadingText;
    public GameObject loadingImage;


    private void Start()
    {
        if (instance != null)
        {
            DestroyImmediate(this.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    public void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        FadeImg.DOFade(0, fadeDuration).OnStart(() =>
        {
            loading.SetActive(false);
            loadingImage.transform.DOKill();
        }).OnComplete(() =>
        {
            FadeImg.blocksRaycasts = false;
        });
    }
    public void ChagneScene(string sceneName)
    {
        FadeImg.DOFade(1, fadeDuration).OnStart(() =>
        {
            FadeImg.blocksRaycasts = true;
        }).OnComplete(() =>
        {
            StartCoroutine("LoadScene", sceneName);
        });
    }

    IEnumerator LoadScene(string sceneName)
    {
        loading.SetActive(true);

        //AsyncOperation �� �񵿱� �� �̵��� ���� ����Ѵ�.
        //����ϰ� �ȴٸ� ���̶�Űâ�� �������� �̵��Ǵ� ���� �ε�ǰ� ���� ������ �ε� �Ѵ�.
        //�̷��� ����� ������ LoadScene���� �߻��Ǵ� ���� ���ϼ� �ִ� ȿ������ ����̴�.
        AsyncOperation async = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName);
        async.allowSceneActivation = false;
        float pastTime = 0;
        float percentage = 0;
        loadingImage.transform.DORotate(new Vector3(0, 0, -360), 1f, RotateMode.FastBeyond360).SetLoops(-1);
        while (!async.isDone)
        {
            yield return null;
            pastTime += Time.deltaTime;
            if (percentage >= 90)
            {
                percentage = Mathf.Lerp(percentage, 100, pastTime);

                if (percentage == 100)
                {
                    async.allowSceneActivation = true;
                }
            }
            else
            {
                percentage = Mathf.Lerp(percentage, async.progress * 100f, pastTime);
                if (percentage >= 90f)
                {
                    pastTime = 0;
                }
            }
            loadingText.text = percentage.ToString("0") + "%";
        }
    }
}