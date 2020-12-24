using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RockButton : MonoBehaviour
{
    public static int GetMaterialHP()
    {
        return 100;
    }
    public void OnClickStartButton()
    {
        Rock.HP = GetMaterialHP();
        SceneManager.LoadScene("PlayScene");
    }
}
