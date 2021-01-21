using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyConfig : MonoBehaviour
{
    [SerializeField] private  Dropdown dropdown;
    private DrillMovement drillmovement;
    // Start is called before the first frame update
    void Start()
    {
        drillmovement = GameObject.Find("Drill").GetComponent<DrillMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeButton()
    {
        if(dropdown.value > -1 && dropdown.value < 3)drillmovement.setTriggerMode(dropdown.value);
    }
}
