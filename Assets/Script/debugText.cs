using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debugText : MonoBehaviour
{

    [System.Runtime.InteropServices.DllImport("SpidarMouse")] private static extern int OpenSpidarMouse();
    [System.Runtime.InteropServices.DllImport("SpidarMouse")] private static extern int CloseSpidarMouse();
    [System.Runtime.InteropServices.DllImport("SpidarMouse")] private static extern void SetDutyOnCh(float duty1, float duty2, float duty3, float duty4, int duration);
    public GameObject TextObject;
    private TextMesh textMesh;

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
        
    }
}
