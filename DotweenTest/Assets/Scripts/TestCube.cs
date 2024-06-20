using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TestCube : MonoBehaviour
{
    void Start()
    {
        transform.DOShakePosition(10f);    
    }
}
