
using UnityEngine;
using UnityEngine.UI;

public class PlayerCtrl : MonoBehaviour
{
    public float vSpeed = 5f, hSpeed  = 5f, flySpeed = 5f;
    private Rigidbody _rb;

    public Text scoreText;
    private int score = 1;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal") * hSpeed * Time.fixedDeltaTime;
        float v = Input.GetAxis("Vertical") * vSpeed * Time.fixedDeltaTime;

        _rb.velocity = transform.TransformDirection(new Vector3(h, _rb.velocity.y, v));
        

    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            transform.Translate(new Vector3(0, 1, 0) * flySpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Food")
        {
            Destroy(other.gameObject);
            if (score != 5)
                scoreText.text = "Score: " + score;
            else
                scoreText.text = "You Win!";
            score++;
        }
    }
}
