using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveCubeDotween : MonoBehaviour
{
    //��ǥ ��ġ ��
    Vector3 targetPos = new Vector3(0, 5, 0);
    public Ease ease;
    private void Start()
    {
        //.SetLoops(-1,LoopType.Restart) �� �ϸ� ���� ������ �ȴ�.
        //transform.DOMove(targetPos, 1f).SetEase(ease).SetLoops(-1,LoopType.Restart);
        //StopMotion �� ����ϸ� ������ ������ ����鼭 �����δ�.
        transform.DOMove(targetPos, 1f).SetEase(EaseFactory.StopMotion(10,Ease.Linear));
    }
}
