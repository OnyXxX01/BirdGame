
using UnityEngine;
using UnityEngine.SceneManagement;

public class startedgame : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("main");
    }
}
