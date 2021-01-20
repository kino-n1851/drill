using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyConfig : MonoBehaviour
{
    [SerializeField] private  Dropdown dropdown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeButton()
    {
        if (dropdown.value == 0)
        {
            cube.GetComponent<Renderer>().material.color = Color.red;
        }
        //DropdownのValueが1のとき（青が選択されているとき）
        else if (dropdown.value == 1)
        {
            cube.GetComponent<Renderer>().material.color = Color.blue;
        }
        //DropdownのValueが2のとき（黄が選択されているとき）
        else if (dropdown.value == 2)
        {
            cube.GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}
