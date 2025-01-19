using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField]
    private float maxSpeed;
    [SerializeField]
    private float sideForce;
    [SerializeField]
    private float forwardforce;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.linearVelocity.z < maxSpeed)
            rb.AddForce(0 , 0 , forwardforce);

        if (Input.GetKey(KeyCode.A))
            rb.AddForce(-sideForce, 0, 0);

        if (Input.GetKey(KeyCode.D))
            rb.AddForce(sideForce, 0, 0);
    }
}