using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PausePlayButton : MonoBehaviour
{
    [SerializeField] Sprite pauseSprite;
    [SerializeField] Sprite playSprite;

    Image image;

    //Button button;
    // Start is called before the first frame update
    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(TaskOnClick);

        image = GetComponent<Image>();

        bool isPaused = FindObjectOfType<BGSound>().GetComponent<BGSound>().isPaused;
        if (isPaused)
        {
            image.sprite = playSprite;
        }
        else
        {
            image.sprite = pauseSprite;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        FindObjectOfType<BGSound>().PlayPause();
    }

    public void Toggle(bool isPaused)
    {
        if (isPaused)
        {
            image.sprite = playSprite;
        }
        else
        {
            image.sprite = pauseSprite;
        }
    }
}
