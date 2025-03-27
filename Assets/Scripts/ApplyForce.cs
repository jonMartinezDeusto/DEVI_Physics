using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    public float forceAmount = 10f;
    private Rigidbody rb;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb = GetComponent<Rigidbody>();

            // Generate a random number between 0 and 3
            int randomDirection = Random.Range(0, 4);

            // Apply force based on the random direction
            switch (randomDirection)
            {
                case 0:
                    rb.AddForce(Vector3.up * forceAmount);
                    Debug.Log("Applied UP force");
                    break;
                case 1:
                    rb.AddForce(Vector3.down * forceAmount);
                    Debug.Log("Applied DOWN force");
                    break;
                case 2:
                    rb.AddForce(Vector3.forward * forceAmount);
                    Debug.Log("Applied FORWARD force");
                    break;
                case 3:
                    rb.AddForce(Vector3.back * forceAmount);
                    Debug.Log("Applied BACKWARD force");
                    break;
            }
        }
    }
}