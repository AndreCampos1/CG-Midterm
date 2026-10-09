using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    public int moveSpeed = 20;

    private Vector3 DirRight = new Vector3(1, 0 ,0);
    private Vector3 DirLeft = new Vector3(-1, 0 ,0);
    private Vector3 Jump = new Vector3(0, 1 ,0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)){
            rb.AddForce(DirRight * moveSpeed, ForceMode.Force);
        }

         if (Input.GetKey(KeyCode.A)){
            rb.AddForce(DirLeft * moveSpeed, ForceMode.Force);
        }

         if (Input.GetKey(KeyCode.Space)){
            rb.AddForce(Jump * 2, ForceMode.Force);
        }
    }
}
