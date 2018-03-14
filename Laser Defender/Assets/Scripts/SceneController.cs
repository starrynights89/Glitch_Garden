using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
       private int _activeSceneBuildIndex = 0;

    /// <summary>
    /// Initialisation
    /// </summary>
    void Start()
    {
        Initialise();
    }

    /// <summary>
    /// Initialises the SceneController
    /// </summary>
    private void Initialise()
    {
        Scene activeScene = SceneManager.GetActiveScene();
        _activeSceneBuildIndex = activeScene.buildIndex;
    }

    /// <summary>
    /// Loads a scene for the specified name
    /// </summary>
    /// <param name="name">The name of the scene to load</param>
    public void LoadSceneAsync(string sceneName)
    {
        Debug.Log("New Scene load: " + sceneName);
        SceneManager.LoadSceneAsync(sceneName);
    }

    /// <summary>
    /// Loads the next scene in order of build index
    /// </summary>
    public void LoadNextSceneAsync()
    {
        SceneManager.LoadSceneAsync(++_activeSceneBuildIndex);
    }

    /// <summary>
    /// Checks to see if the ship has been destroyed and loads the next scene if so
    /// </summary>
    /*public void ShipDestroyed()
    {
        if (PlayerController.health <= 0)
        {
            LoadNextSceneAsync();
        }
    }*/

    /// <summary>
    /// Handles a request to quit the game
    /// </summary>
    public void QuitRequest()
    {
        Debug.Log("Quit requested");
        Application.Quit();
    }
}