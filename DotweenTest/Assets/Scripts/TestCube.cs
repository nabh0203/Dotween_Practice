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
        //ó������ �ݺ�
        //transform.DOScale(targetScale, 3f).SetLoops(3,LoopType.Restart);
        //�ݺ����� ����
        //transform.DOScale(targetScale, 3f).SetLoops(3, LoopType.Incremental);
        //�պ�
        //transform.DOScale(targetScale, 3f).SetLoops(3, LoopType.Yoyo);

        //SetDelay(2f); �� ����Ͽ� 2�ʵڿ� ũ�� ����
        //transform.DOScale(targetScale, 3f).SetDelay(2f);

        //Ease ���� ����Ͽ� ũ�� ����
        //transform.DOScale(targetScale, 3f).SetEase(Ease.InCirc);
        //���� Ƣ�鼭 ����
        //transform.DOScale(targetScale, 3f).SetEase(Ease.InOutBounce);

        //OnComplete �� ����Ͽ� �տ� ���� ������ �Ŀ� �ִ� ���� �����Ѵ�.
        transform.DOScale(targetScale, 3f).SetEase(Ease.InOutBounce).OnComplete(() => transform.DOMove(targetPos,2f));
        
    }
}
