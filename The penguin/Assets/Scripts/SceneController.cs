using UnityEngine;

public class SceneController : MonoBehaviour
{
    public void Retry()
    {
        Application.LoadLevel( "level1" );
        Time.timeScale = 1;
    }
    public void Menu()
    {
        Application.LoadLevel( "menu" );
    }
}
