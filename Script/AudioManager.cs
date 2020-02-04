using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource audioSource ;
    public AudioClip EnemyDestroy ;
    public AudioClip background;
    public AudioClip gameOver;
    public AudioClip button;
    public bool bg  = false;
    public static AudioManager instance;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
        instance = this;
       // DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void destroy ()
    {
        audioSource.PlayOneShot(EnemyDestroy);
        audioSource.PlayOneShot(gameOver);
    }

    public void anybutton ()
    {
        audioSource.PlayOneShot(button);
       
    }

    
}
