using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveCubeDotween : MonoBehaviour
{
    //목표 위치 값
    Vector3 targetPos = new Vector3(0, 5, 0);

    private void Start()
    {
        transform.DOMove(targetPos, 1f);
    }
}
