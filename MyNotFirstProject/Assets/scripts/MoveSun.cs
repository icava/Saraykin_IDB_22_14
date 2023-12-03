
using UnityEngine;

public class MoveSun : MonoBehaviour
{
    public float rotateSpeed = 5.0f;

    private void Update()
    {
        
        transform.Rotate(new Vector3(1, 0, 0) * rotateSpeed * Time.deltaTime);
        
    }
}
