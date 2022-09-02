using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.audiomanager.Play("Menu");
    }

    // Update is called once per frame
    public void OnPlayBtnPressed()
    {
        SceneManager.LoadScene("Game");
        AudioManager.audiomanager.Play("Transition");
    }
}
