using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TestCube : MonoBehaviour
{
    void Start()
    {
        //transform.DOShakePosition(10f);    
        var targetScale = new Vector3(2, 3, 2);
        transform.DOScale(targetScale, 3f);
    }
}
