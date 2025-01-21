using UnityEngine;

public class PlayerGravity : MonoBehaviour
{
    [SerializeField]
    private Transform castOrigin;
    [SerializeField]
    private Rigidbody playerRb;
    [SerializeField]
    private float gravityStrength;

    private Vector3 currentGravity = Vector3.down;

    private void Start()
    {
        if (playerRb == null)
            playerRb = GetComponent<Rigidbody>();
        if (castOrigin == null)
            castOrigin = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        playerRb.AddForce(currentGravity * gravityStrength * Time.deltaTime);

        RaycastHit hit;
        if (Physics.Raycast(castOrigin.position, transform.InverseTransformDirection(Vector3.down), out hit, 10f))
        {
            Vector3 normalRelativeGravity = hit.normal * -1;

            if (normalRelativeGravity != currentGravity)
            {
                currentGravity = normalRelativeGravity;
            }

            Quaternion targetAngle = Quaternion.LookRotation(Vector3.forward, hit.normal);

            transform.rotation = Quaternion.Slerp(transform.rotation, targetAngle, Time.deltaTime * 4);
        }
    }
}
