using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SequenceTest : MonoBehaviour
{
    Sequence sequence;

    //.Prepend : �� ó���� �߰�
    //.Append : Ʈ�� �������� �߰�
    //.Insert : ���� �ð��� ����
    //.Join : �տ� �߰��� Ʈ���� ���� ����

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
