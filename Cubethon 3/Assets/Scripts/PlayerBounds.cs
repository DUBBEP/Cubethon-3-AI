using System;
using UnityEngine;

public class PlayerBounds : MonoBehaviour
{
    [SerializeField]
    private float verticalBounds;
    [SerializeField] 
    private float horizontalBounds;
    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(transform.position.y) > verticalBounds)
        {
            GameManager.instance.ResetLevel(1.5f);
        }
        if (MathF.Abs(transform.position.x) > horizontalBounds)
        {
            GameManager.instance.ResetLevel(1.5f);
        }
    }
}
