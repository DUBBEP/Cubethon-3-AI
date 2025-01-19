using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private PlayerMovement playerMovement;
    
    public static GameManager instance;

    void Start()
    {
        instance = this;
        playerMovement = FindFirstObjectByType<PlayerMovement>().GetComponent<PlayerMovement>();
        SetPlayerControls(true);
    }



    public void SetPlayerControls(bool toggle)
    {
        playerMovement.enabled = toggle;
    }


    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ResetLevel(float delay)
    {
        SetPlayerControls(false);
        Invoke("ResetLevel", delay);
    }

    private void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void WinLevel()
    {

    }
}
