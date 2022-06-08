using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public AudioClip firstAudioClip;
    public AudioClip secondAudioClip;
    public AudioClip thirdAudioClip;
    public AudioSource AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        int i = Random.Range(1, 4);
        if(i == 1) {
           AudioSource.PlayOneShot(firstAudioClip,1.0f);
        } else if(i == 2) {
           AudioSource.PlayOneShot(secondAudioClip,1.0f);
           
        } else if(i == 3) {
           AudioSource.PlayOneShot(thirdAudioClip,1.0f);
           
        }
    }

    // Update is called once per frame
    void Update()
    {
      

        
    }
}
