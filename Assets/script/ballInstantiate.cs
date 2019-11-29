using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballInstantiate : MonoBehaviour
{
  //  public float InstSpeed = 4.4f;
    public GameObject ball;
    public GameObject enemy;
   void Start()
    {

        StartCoroutine(Fun());
        StartCoroutine(Enemy());
   }
  

    IEnumerator Fun()
        {
    
        while (true)
        {
            Instantiate(ball, new Vector3(Random.Range(-2.27f, 2.27f), 6.4f, 0f), Quaternion.identity);
            yield return new WaitForSeconds(0.80f);

        }

    }
    IEnumerator Enemy()
    {

        while (true)
        {
            Instantiate(enemy, new Vector3(Random.Range(-2.27f, 2.27f), 6.4f, 0f), Quaternion.identity);
            yield return new WaitForSeconds(1f);

        }

    }



}
