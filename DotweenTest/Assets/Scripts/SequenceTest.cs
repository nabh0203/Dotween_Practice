using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SequenceTest : MonoBehaviour
{
    Sequence sequence;

    //.Prepend : 맨 처음에 추가
    //.Append : 트윈 마지막에 추가
    //.Insert : 일정 시간에 시작
    //.Join : 앞에 추가된 트윈과 동시 시작

    private void Start()
    {
        sequence = DOTween.Sequence();

        sequence.Append(transform.DOMove(new Vector3(0f, 5f, 0f), 2f))
                .Join(transform.DORotate(new Vector3(0f, -180f, 0f), 2f))
                .Append(transform.DORotate(new Vector3(0f, 360f, 0f), 2f))
                .Insert(4.0f, transform.DOScale(new Vector3(1.5f, 1.5f, 1.5f), 2f))
                .Prepend(transform.DOScale(new Vector3(0.5f, 0.5f, 0.5f), 2f));
    }
}
