using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadTopFirstPersonViewScene()
    {
        SceneManager.LoadScene("TopFirstPersonViewScene");
    }
    
    public void LoadFreeLookViewScene()
    {
        SceneManager.LoadScene("FreeLookScene");
    }
    
    public void LoadGyroVRViewScene()
    {
        SceneManager.LoadScene("VRScene");
    }

    public void LoadSceneSelection()
    {
        SceneManager.LoadScene("SelectViewScene");
    }

    public void LoadAttireChangeScene()
    {
        SceneManager.LoadScene("AttireChangeScene");
    }
}
