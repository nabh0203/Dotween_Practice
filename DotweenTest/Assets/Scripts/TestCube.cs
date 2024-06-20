using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TestCube : MonoBehaviour
{
    Vector3 targetPos = new Vector3(0, 5, 0);

    void Start()
    {
        //transform.DOShakePosition(10f);    
        var targetScale = new Vector3(2, 3, 2);
        //transform.DOScale(targetScale, 3f);
        //처음부터 반복
        //transform.DOScale(targetScale, 3f).SetLoops(3,LoopType.Restart);
        //반복마다 증가
        //transform.DOScale(targetScale, 3f).SetLoops(3, LoopType.Incremental);
        //왕복
        //transform.DOScale(targetScale, 3f).SetLoops(3, LoopType.Yoyo);

        //SetDelay(2f); 를 사용하여 2초뒤에 크기 증가
        //transform.DOScale(targetScale, 3f).SetDelay(2f);

        //Ease 값을 사용하여 크기 증가
        //transform.DOScale(targetScale, 3f).SetEase(Ease.InCirc);
        //통통 튀면서 증가
        //transform.DOScale(targetScale, 3f).SetEase(Ease.InOutBounce);

        //OnComplete 을 사용하여 앞에 식이 끝나면 후에 있는 식을 실행한다.
        transform.DOScale(targetScale, 3f).SetEase(Ease.InOutBounce).OnComplete(() => transform.DOMove(targetPos,2f));
        
    }
}
