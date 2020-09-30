using UnityEngine;

public class playerScript : MonoBehaviour
{
    public CharacterController controller;
    public float speedMovement = 12f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speedMovement * Time.deltaTime);
    }
}
