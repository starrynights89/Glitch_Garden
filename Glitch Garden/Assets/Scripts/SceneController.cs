using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public float autoLoadNextLevel;

    /// <summary>
    /// Initialisation
    /// </summary>
    void Start()
    {
        if (autoLoadNextLevel > 0) {
            Invoke("LoadNextLevel", autoLoadNextLevel);
        }
    }

    /// <summary>
    /// Loads a scene for the specified name
    /// </summary>
    /// <param name="name">The name of the scene to load</param>
    public void LoadLevel(string name)
    {
        Debug.Log("New Scene load: " + name);
        Scene s = SceneManager.GetSceneByName(name);
        Debug.Log("Scene is:");
        Debug.Log(s.name);
        Debug.Log(s.buildIndex);
        SceneManager.LoadScene(name);
    }

    /// <summary>
    /// Loads the next scene in order of build index
    /// </summary>
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    /// <summary>
    /// Handles a request to quit the game
    /// </summary>
    public void QuitRequest()
    {
        Debug.Log("Quit requested");
        Application.Quit();
    }
}