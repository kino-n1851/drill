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
    private int triggerMode = 0;

    public float ZMinMoveRange;
    public float ZMaxMoveRange;

    Vector3 screenPoint;

    public const int MoveSound = 0;
    private PlayManager playManager;
    void Start()
    {
        playManager = GameObject.Find("PlayManagerObj").GetComponent < PlayManager > ();
    }
    
    void Update()
    {
        if (isTriggerEnter() && playManager.GetIsNotHalt())
        {
            if (SoundControl.SoundControler == 0 && SoundControl.SoundControler != 10 && SoundControl.SoundControler != 15)
            {
                SoundControl.SoundControler = 5;
            }
            
            Transform myTransform = this.transform;
            // 座標を取得
            Vector3 pos = myTransform.position;

            DrillZMovement();

            Vector3 targetPosition = transform.position;
            targetPosition.z = Mathf.Clamp(transform.position.z, ZMinMoveRange, ZMaxMoveRange) ;
            transform.position = new Vector3(targetPosition.x, targetPosition.y, targetPosition.z);
        }
        else if(playManager.GetIsNotHalt())
        {
            SoundControl.SoundControler = 0;
            this.screenPoint = Camera.main.WorldToScreenPoint(transform.position);
            Vector3 TouchPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 14);
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

    private bool isTriggerEnter() 
    {
        switch (triggerMode) 
        {
            case 0:
                return Input.GetMouseButton(0);

            case 1:
                return Input.GetMouseButton(1);

            case 2:
                return Input.GetKey(KeyCode.Return);

            default:
                return false;
        }
    }

    public void setTriggerMode(int mode) 
    {
        triggerMode = mode;
    }
}
