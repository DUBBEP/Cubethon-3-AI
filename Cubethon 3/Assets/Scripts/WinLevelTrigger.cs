using UnityEngine;

public class WinLevelTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject winScreen;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            winScreen.SetActive(true);
    }
}
