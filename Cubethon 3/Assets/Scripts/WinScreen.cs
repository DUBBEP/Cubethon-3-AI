using UnityEngine;

public class WinScreen : MonoBehaviour
{
    public void EndLevel()
    {
        GameManager.instance.LoadNextLevel();
    }
}
