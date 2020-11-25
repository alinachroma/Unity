using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform player;
    public float speed = 0.5f;
    public float rotationSpeed = 32.0f;

    private void Start()
    {
        
    }

    private void Update()
    {
        float moveHorizontal = speed * Input.GetAxis("Horizontal") * Time.deltaTime * 10f;
        float moveVertical = speed * Input.GetAxis("Vertical") * Time.deltaTime * 10f;
        transform.Translate(moveHorizontal, 0f, moveVertical);

        if (Input.GetKey(KeyCode.Q))
        {
            //direction to Player - subtract Player position by the current position.
            Vector3 directionToTarget = (player.transform.position - this.transform.position).normalized;
            Quaternion targetRotation = Quaternion.LookRotation(directionToTarget, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, Time.deltaTime * 10.0f);

            //Rotate the Player around this object, at a speed of 90 degrees per second.
            player.RotateAround(transform.position, Vector3.up, Time.deltaTime * 90);
        }
 
        if (Input.GetKey(KeyCode.E))
        {
            Vector3 directionToTarget = (player.transform.position - this.transform.position).normalized;
            Quaternion targetRotation = Quaternion.LookRotation(directionToTarget, Vector3.down);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, Time.deltaTime * 10.0f);
            player.RotateAround(transform.position, Vector3.down, Time.deltaTime * 90);
        }
    }
}

//https://low-scope.com/unity-quick-most-common-ways-to-rotate-an-object/
//