using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    public void LoadGallery()
    {
        SceneManager.LoadScene("gallery");
    }
    public void LoadStadium()
    {
        SceneManager.LoadScene("Stadium_Scene");
    }
    public void LoadConference()
    {
        SceneManager.LoadScene("Conference");
    }

}
