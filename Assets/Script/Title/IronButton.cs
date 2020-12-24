using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class IronButton : MonoBehaviour
{
    public static int GetMaterialHP()
    {
        return 200;
    }
    public void OnClickStartButton()
    {
        Rock.HP = GetMaterialHP();
        SceneManager.LoadScene("PlayScene");
    }
}
