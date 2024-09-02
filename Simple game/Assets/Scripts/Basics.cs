using UnityEngine;
using System;


public class Basics : MonoBehaviour
{


    public Transform[] objs = new Transform[3];
    public Transform target;
    public BoxCollider box;

    public GameObject[] objsTest = new GameObject[3];


    public float speed = 1.0f;
    public float rotadeSpeed = 10.0f;

  private void Update()
      {
          for (int i = 0; i < objs.Length; i++)
          {
              if (objs[i] == null)
                  continue;

              objs[i].Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime); 
              objs[i].Rotate(new Vector3(-1, 0, 0) * rotadeSpeed * Time.deltaTime);

              float posX = objs[i].position.x;

              if (posX < -10f && objs[i].gameObject.name == "Cube")
              {
                Destroy(objs[i].gameObject);
              }


          }
      } 






}




