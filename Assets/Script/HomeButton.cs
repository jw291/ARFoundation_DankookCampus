using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
public class HomeButton : MonoBehaviour
{
    public void FadeTo(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
