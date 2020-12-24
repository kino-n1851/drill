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
            countup += Time.deltaTime * 20;

            if (countup >= HP)
            {
                Destroy(this.gameObject);
            }
        }
        else if (other.gameObject.tag == "GoodDig")
        {
            Debug.Log("GOODDIG");
            countup += Time.deltaTime * 40;

            if (countup >= HP)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
