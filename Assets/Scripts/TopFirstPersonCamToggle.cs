using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopFirstPersonCamToggle : MonoBehaviour
{
    [SerializeField] GameObject topViewCam;
    [SerializeField] GameObject FirstPersonCam;

    Text txt;

    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponentInChildren<Text>();

        topViewCam.SetActive(true);
        FirstPersonCam.SetActive(false);
        txt.text = "First Person Camera";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CamChange()
    {
        if (topViewCam.activeSelf == true)
        {
            FirstPersonCam.SetActive(true);
            topViewCam.SetActive(false);
            txt.text = "Top View Camera";
        }
        else
        {
            topViewCam.SetActive(true);
            FirstPersonCam.SetActive(false);
            txt.text = "First Person Camera";
        }
    }
}
