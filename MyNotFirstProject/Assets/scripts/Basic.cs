
using UnityEditor;
using UnityEngine;

public class Basic : MonoBehaviour
{
    public GameObject[] obj = new GameObject[3];


    public Transform target;

    public Transform[] transforms = new Transform[3];
    public float speed = 2.0f, rotateSpeed = 5.0f;
    private void Start()
    {

        //obj.SetActive(false);
        //obj.GetComponent<Transform>().position = new Vector3(3,3,0);
        //target.position = new Vector3(10, 3, 3);



    }

    private void Update()
    {
        for(int i = 0; i < transforms.Length; i++)
        {
            if (transforms[i] == null)
                continue;
            transforms[i].Translate(new Vector3(-1,0,0)*speed*Time.deltaTime);
            transforms[i].Rotate(new Vector3(10, 0, 0) * rotateSpeed * Time.deltaTime);


            float posX = transforms[i].position.x;
            if (posX < -10.0f && transforms[i].gameObject.name == "Cube")
                Destroy(transforms[i].gameObject);
        }
    }

}
