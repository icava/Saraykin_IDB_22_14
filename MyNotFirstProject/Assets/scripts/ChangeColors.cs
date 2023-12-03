
using UnityEngine;

public class ChangeColors : MonoBehaviour
{
    private MeshRenderer _mesh;


    private void Awake()
    {
        _mesh = GetComponent<MeshRenderer>();
    }


    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.B))
        {
            _mesh.material.color = Color.blue;
        }
        if (Input.GetKeyUp(KeyCode.G))
        {
            _mesh.material.color = Color.green;
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            _mesh.material.color = Color.red;
        }
    }
}
