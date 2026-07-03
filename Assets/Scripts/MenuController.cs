using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    void Start()
    {
        GameSession session = FindFirstObjectByType<GameSession>();
        if (session != null)
        {
            Destroy(session.gameObject);
        }
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is Exiting");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
}
