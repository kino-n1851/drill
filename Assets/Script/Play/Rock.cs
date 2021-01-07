using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    private float countup = 0;
    public static float HP;

    private void Update()
    {
        
    }
    // ブロックが壊れた時の効果音、エフェクト
    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "OverDig")
        {
            Debug.Log("OVERDIG");

            if (SoundControl.SoundControler != 10)
            {
                SoundControl.SoundControler = 10;
            }

            countup += Time.deltaTime * 20;

            if (countup >= HP)
            {
                Destroy(this.gameObject);
                SoundControl.SoundControler = 5;
            }
        }
        else if (other.gameObject.tag == "GoodDig")
        {
            Debug.Log("GOODDIG");

            if (SoundControl.SoundControler != 15)
            {
                SoundControl.SoundControler = 15;
            }

            countup += Time.deltaTime * 40;

            if (countup >= HP)
            {
                Destroy(this.gameObject);
                SoundControl.SoundControler = 5;
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        SoundControl.SoundControler = 5;
    }
}
