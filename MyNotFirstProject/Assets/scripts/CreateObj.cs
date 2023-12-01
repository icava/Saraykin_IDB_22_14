
using System.Collections;
using UnityEngine;

public class CreateObj : MonoBehaviour
{
    
    public GameObject[] obj;
    
    


    private void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            //GameObject newObject = Instantiate(obj, new Vector3(6.1f,4.3f,-3.69f), Quaternion.Euler(0,0,0)) as GameObject;
            //newObject.GetComponent < Transform >().position = new Vector3(6.1f, 4.3f, -3f);
            Instantiate(obj [Random.Range(0, obj.Length)], new Vector3(RandomNumber(), RandomNumber(), RandomNumber()), Quaternion.Euler(0, RandomNumber(), RandomNumber()));
        }

        int RandomNumber()
        {
            return Random.Range(0, 10);
        }
    }
}
