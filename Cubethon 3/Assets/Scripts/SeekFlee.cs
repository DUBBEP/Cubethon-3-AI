using UnityEngine;

public class SeekFlee : MonoBehaviour
{
    private Transform playerTransform;

    [SerializeField]
    private LocalGravity localGravity;

    [SerializeField]
    private float chaseRange = 80;

    [SerializeField]
    private float maxSpeed = 20;

    [SerializeField]
    private bool flee;

    private void Start()
    {
        playerTransform = GameObject.Find("Player").transform;
    }

    void Update()
    {
        if ((playerTransform.position - transform.position).magnitude > chaseRange)
            return;

        Vector3 chaseDirection = (playerTransform.position - transform.position).normalized;

        if (flee)
        {
            transform.position -= ((chaseDirection * maxSpeed) * Time.deltaTime);
            transform.rotation = Quaternion.LookRotation(chaseDirection * -1, localGravity.GetLocalUp());

        }
        else
        {
            transform.position += ((chaseDirection * maxSpeed) * Time.deltaTime);
            transform.rotation = Quaternion.LookRotation(chaseDirection, localGravity.GetLocalUp());
        }


    }
}
