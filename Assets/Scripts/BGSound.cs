using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGSound : MonoBehaviour
{
    public bool isPaused;
    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private static BGSound instance = null;
    public static BGSound Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayPause()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
            FindObjectOfType<PausePlayButton>().GetComponent<PausePlayButton>().Toggle(true);  //different button for different scene
            isPaused = true;
        }
        else
        {
            audioSource.Play();
            FindObjectOfType<PausePlayButton>().GetComponent<PausePlayButton>().Toggle(false); //different button for different scene
            isPaused = false;
        }
    }
}
