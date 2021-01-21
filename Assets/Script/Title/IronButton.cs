using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class IronButton : MonoBehaviour
{
    // プロックの耐久値の設定
    public static int GetMaterialHP()
    {
        return 200;
    }
    public void OnClickStartButton()
    {
        //　ブロックの耐久値の代入
        Rock.HP = GetMaterialHP();
        // PlaySceneに移動
        SceneManager.LoadScene("PlayScene");
    }
}
