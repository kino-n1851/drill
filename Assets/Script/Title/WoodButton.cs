using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WoodButton : MonoBehaviour
{
    public static int GetMaterialHP()
    {
        return 50;
    }
    public void OnClickStartButton()
    {
        Rock.HP = GetMaterialHP();
        SceneManager.LoadScene("PlayScene");
    }
}
