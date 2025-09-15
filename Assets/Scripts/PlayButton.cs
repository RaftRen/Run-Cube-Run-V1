using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    [SerializeField] private AudioSource ClickButton;
    public void Play ()
    {
        ClickButton.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
