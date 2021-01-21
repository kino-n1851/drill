using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    private float countup = 0;
    public static float HP = 30;
    private PlayManager manager;
    private void Start()
    { GameObject.Find("PlayManagerObj");
        manager = GameObject.Find("PlayManagerObj").GetComponent<PlayManager>();
    }

    private void Update()
    {
        
    }
    // ブロックが壊れた時の効果音、エフェクト
    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "OverDig")
        {
            //Debug.Log("OVERDIG");
            // ドリルの効果音の設定
            if (SoundControl.SoundControler != 10)
            {
                SoundControl.SoundControler = 10;
            }

            countup += Time.deltaTime * 10;
            
            // ブロックの耐久値が0以下になったときの処理
            if (countup >= HP)
            {
                manager.RemoveRockName(this.name);
                Destroy(this.gameObject);
                SoundControl.SoundControler = 5;
            }
        }
        else if (other.gameObject.tag == "GoodDig")
        {
            //Debug.Log("GOODDIG");
            // ドリルの効果音の設定
            if (SoundControl.SoundControler != 15)
            {
                SoundControl.SoundControler = 15;
            }

            countup += Time.deltaTime * 40;
            
            // ブロックの耐久値が0以下になったときの処理
            if (countup >= HP)
            {
                manager.RemoveRockName(this.name);
                Destroy(this.gameObject);
                SoundControl.SoundControler = 5;
            }
        }
    }
    // ブロックが何にもあたっていないときの処理
    private void OnCollisionExit(Collision collision)
    {
        SoundControl.SoundControler = 5;
    }
}
