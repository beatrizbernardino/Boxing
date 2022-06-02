using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public AudioClip firstAudioClip;
    public AudioClip secondAudioClip;
    public AudioClip thirdAudioClip;
    public AudioClip AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        int i = Random.Range(1, 4);
         if(i == 1) {
           
        } else if(i == 2) {
           
        } else if(i == 3) {
           
        }

        
    }
}
