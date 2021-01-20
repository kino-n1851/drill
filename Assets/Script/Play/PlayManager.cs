using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayManager : MonoBehaviour
{
    private List<string> RockList = new List<string>();
    public GameObject fossil1;
    private int ct = 0;
    private int delay = 80;
    private bool isHalt;
    private GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        isHalt = false;
        Cursor.visible = false;
        menu = GameObject.Find("Menu");
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {   
        if(ct < delay) ct++;
        else if (RockList.Count <= 0)
        {
               // Debug.Log("clear");
        }

        if (ct == delay - 2)
        {
            GameObject target = Instantiate(fossil1) as GameObject;
            target.transform.position = new Vector3(Random.Range(-5f,5f), Random.Range(-4.5f,5f), 7.8f);
            Debug.Log("spone");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("push");
            isHalt = !isHalt;
            if (isHalt)
            {
                Cursor.visible = true;
                menu.SetActive(true);
            }
            else
            {
                Cursor.visible = false;
                menu.SetActive(false);
            }
        }
        
    }

    public void AddRockName(string name)
    {
        RockList.Add(name);
        Debug.Log("add :" + name);
    }

    public void RemoveRockName(string name)
    {
        RockList.Remove(name);
        Debug.Log("delete :"+ name);
        Debug.Log("remain :" + RockList.Count);
    }

    public bool GetIsNotHalt()
    {
        return !isHalt;
    }

    public bool GetIsHalt()
    {
        return isHalt;
    }

}
