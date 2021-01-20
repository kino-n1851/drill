using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public static int SoundControler = 0;
    int temp = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SoundControler != temp)
        {
            switch (SoundControler)
            {
                // 動いていない
                case 0:
                    GetComponents<AudioSource>()[0].Stop();
                    GetComponents<AudioSource>()[1].Stop();
                    GetComponents<AudioSource>()[2].Stop();
                    break;
                // 動いている
                case 5:
                    GetComponents<AudioSource>()[1].Stop();
                    GetComponents<AudioSource>()[2].Stop();
                    GetComponents<AudioSource>()[0].Play();
                    //Debug.Log("SoundPlaying");
                    break;
                // 押し付けている
                case 10:
                    GetComponents<AudioSource>()[0].Stop();
                    GetComponents<AudioSource>()[2].Stop();
                    GetComponents<AudioSource>()[1].Play();
                    break;
                // 押し付けすぎ
                case 15:
                    GetComponents<AudioSource>()[0].Stop();
                    GetComponents<AudioSource>()[1].Stop();
                    GetComponents<AudioSource>()[2].Play();
                    break;

            }
        }
        temp = SoundControler;
    }
}
