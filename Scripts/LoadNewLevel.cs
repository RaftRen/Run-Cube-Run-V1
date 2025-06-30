using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewLevel : MonoBehaviour
{
    private void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
