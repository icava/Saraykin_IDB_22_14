
using System.Collections;
using UnityEngine;
using System;

public class CreateObj : MonoBehaviour
{

    public GameObject[] obj;
    private void Update()
    {
        //Invoke("Create", 2f);
        if(Input.GetKeyUp(KeyCode.U))
            StartCoroutine(Create3dObjects(2f));
    }

    private void Create()
    {
        for (int i = 0; i < 5; i++)
        {
            //GameObject newObject = Instantiate(obj, new Vector3(6.1f,4.3f,-3.69f), Quaternion.Euler(0,0,0)) as GameObject;
            //newObject.GetComponent < Transform >().position = new Vector3(6.1f, 4.3f, -3f);
            Instantiate(obj[UnityEngine.Random.Range(0, obj.Length)], new Vector3(RandomNumber(), RandomNumber(), RandomNumber()), Quaternion.Euler(0, RandomNumber(), RandomNumber()));
        }
    }
    private int RandomNumber()
    {
        return UnityEngine.Random.Range(0, 10);
    }
    
    private IEnumerator Create3dObjects(float sec)
    {
        while(true)
        {
            Instantiate(obj[UnityEngine.Random.Range(0, obj.Length)], new Vector3(RandomNumber(), RandomNumber(), RandomNumber()), Quaternion.Euler(0, RandomNumber(), RandomNumber()));
            yield return new WaitForSeconds(sec);
        }
    }
    
}
