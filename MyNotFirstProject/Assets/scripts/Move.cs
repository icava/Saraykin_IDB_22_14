
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed = 5f, hSpeed = 10f, _thrust = 500f;
    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal") * hSpeed * Time.fixedDeltaTime;
        float v = Input.GetAxis("Vertical") * Speed * Time.fixedDeltaTime;

        _rb.velocity = transform.TransformDirection(new Vector3(h,_rb.velocity.y,v));
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Block")
        {
            _rb.AddForce(new Vector3(0,1,0) * _thrust);
        }
    }

    private void OnCollisionStay(Collision other)
    {
        _rb.AddForce(new Vector3(0, 1, 0) * _thrust);
    }

    private void OnCollisionExit(Collision other)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Block")
        {
            _rb.AddForce(new Vector3(0, 1, 0) * _thrust);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
