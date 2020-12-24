using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrillMovement : MonoBehaviour
{
    public GameObject Drill;
    private float yPos;
    private float zPos;
    private float temp;
    private int num = 0;

    public float ZMinMoveRange;
    public float ZMaxMoveRange;

    Vector3 screenPoint;

    public const int MoveSound = 0;
    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Transform myTransform = this.transform;
            // 座標を取得
            Vector3 pos = myTransform.position;

            DrillZMovement();

            Vector3 targetPosition = transform.position;
            targetPosition.z = Mathf.Clamp(transform.position.z, ZMinMoveRange, ZMaxMoveRange) ;
            transform.position = new Vector3(targetPosition.x, targetPosition.y, targetPosition.z);
        }
        else
        {
            this.screenPoint = Camera.main.WorldToScreenPoint(transform.position);
            Vector3 TouchPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
            transform.position = Camera.main.ScreenToWorldPoint(TouchPosition);
            //Debug.Log(screenPoint.z);
            num = 0;
        }
        //Debug.Log(transform.position);
    }
    
    private void DrillZMovement()
    {
        Transform myTransform = this.transform;
        // 座標を取得
        Vector3 pos = myTransform.position;

        while (num == 0)
        {
            num++;
            yPos = Input.mousePosition.y;
            temp = yPos;
            pos.z = 0;
            //Debug.Log(pos.z);
        }

        zPos = Input.mousePosition.y;

        pos.z += (zPos - temp) / 20;
        //Debug.Log(zPos - temp);
        temp = zPos;
        myTransform.position = pos;
    }
}
