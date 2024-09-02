using UnityEngine;
using System.Collections;


public class CreateObjects : MonoBehaviour
{
    
    public GameObject [] obj;

    private int RandomNumber()
    {
        return Random.Range(0, 10);
    }


    private void Start()
    {
        StartCoroutine(Create3dObjects()); 
    }

    private void Create()
    {
        //GameObject newObject =  Instantiate(obj, new Vector3(0, 3, 0), Quaternion.Euler(12f, -15f, 45));
        //newObject.GetComponent<Transform>().position = new Vector3(4, 5, 6);

        for (int i = 0; i < 5; i++)
        {
            Instantiate(obj[Random.Range(0, obj.Length)], new Vector3(RandomNumber(), RandomNumber(), RandomNumber()), Quaternion.Euler(RandomNumber(), RandomNumber(), RandomNumber()));
        }


    }


    private IEnumerator Create3dObjects()
    {
        yield return new WaitForSeconds(3f); 
        Create();

    }

}
