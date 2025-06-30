using UnityEngine;

public class Exit : MonoBehaviour
{
    [SerializeField] private AudioSource ClickButton;
    public void ExitGame ()
    {
        ClickButton.Play();
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
