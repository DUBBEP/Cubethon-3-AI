using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnStartButton()
    {
        SceneManager.LoadScene(1);
    }
}
