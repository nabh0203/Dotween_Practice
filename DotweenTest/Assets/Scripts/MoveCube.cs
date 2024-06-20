using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    Vector3 startPos; //시작 위치 저장
    Vector3 targetPos = new Vector3(0,5,0); // 목표 위치 값
    float currentValue;

    private void Start()
    {
        startPos = transform.position;
        currentValue = 0;   
    }

    private void Update()
    {
        if(currentValue <= 1)
        {
            currentValue += Time.deltaTime;
            transform.position = Vector3.Lerp(startPos, targetPos, currentValue);
        }        

    }
}
