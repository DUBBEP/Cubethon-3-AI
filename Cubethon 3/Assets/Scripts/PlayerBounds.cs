using UnityEngine;

public class PlayerBounds : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0)
        {
            GameManager.instance.ResetLevel(1.5f);
        }
    }
}