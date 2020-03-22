
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class startedgame : MonoBehaviour
{
    public AudioClip testSound;

    void Start()
    {
      
    }

    void OnMouseDown()
    {
        SceneManager.LoadScene("main");
    }
}
