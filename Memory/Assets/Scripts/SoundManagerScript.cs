using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip BombExplodeSound, Music;
    static AudioSource audioSrc;











    // Start is called before the first frame update
    void Start()
    {
       

        BombExplodeSound = Resources.Load<AudioClip> ("explode");

        Music = Resources.Load<AudioClip>("gamemusic");

        audioSrc = GetComponent<AudioSource>();



        SoundManagerScript.PlaySound("gamemusic");
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "explode":
                audioSrc.PlayOneShot (BombExplodeSound);
                break;

            case "gamemusic":
                audioSrc.PlayOneShot(Music);
                break;

        }
    }
}
