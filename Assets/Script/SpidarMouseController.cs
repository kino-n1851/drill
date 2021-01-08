using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpidarMouseController : MonoBehaviour
{

    [System.Runtime.InteropServices.DllImport("SpidarMouse")] private static extern int OpenSpidarMouse();
    [System.Runtime.InteropServices.DllImport("SpidarMouse")] private static extern int CloseSpidarMouse();
    [System.Runtime.InteropServices.DllImport("SpidarMouse")] private static extern void SetDutyOnCh(float duty1, float duty2, float duty3, float duty4, int duration);

    public GameObject TextObject;
    private TextMesh textMesh;
    private int temp = 0;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = (TextMesh)TextObject.GetComponent(typeof(TextMesh));
        textMesh.text = "test";
        if (OpenSpidarMouse() == 1) textMesh.text = "connect";
        else textMesh.text = "connection error";
    }

    // Update is called once per frame
    void Update()
    {
        switch (SoundControl.SoundControler)
        {
            // 動いていない
            case 0:
                SetDutyOnCh( (float)0.5, 0, 0, 0, 100);
                break;
            // 動いている
            case 5:
                SetDutyOnCh( (float)0, (float)0.5, (float)0, (float)0, 100);
                break;
            // 押し付けている
            case 10:
                SetDutyOnCh( (float)0, (float)0, (float)0.5, (float)0, 100);
                break;
            // 押し付けすぎ
            case 15:
                SetDutyOnCh( 0, 0, 0, (float)0.5, 100);
                break;
        }

        temp = SoundControl.SoundControler;
    }
}

