using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveCubeDotween : MonoBehaviour
{
    //목표 위치 값
    Vector3 targetPos = new Vector3(0, 5, 0);
    public Ease ease;
    private void Start()
    {
        //.SetLoops(-1,LoopType.Restart) 로 하면 무한 루프가 된다.
        //transform.DOMove(targetPos, 1f).SetEase(ease).SetLoops(-1,LoopType.Restart);
        //StopMotion 을 사용하면 프레임 단위로 끊기면서 움직인다.
        transform.DOMove(targetPos, 1f).SetEase(EaseFactory.StopMotion(10,Ease.Linear));
    }
}
