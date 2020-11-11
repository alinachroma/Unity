using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayGameObject : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform myPrefab;
    public Transform Player;
    public List<Transform> myObjects = new List<Transform>();   

    void Start()
    {
        for (int i = 0; i <= 10; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));

            myObjects.Add(Instantiate(myPrefab, pos, Quaternion.identity) as Transform);
            myPrefab.transform.rotation = Quaternion.Euler(0, 0, Mathf.Sin(Time.time) * 360 * UnityEngine.Random.Range(-1.0f, 1.0f));
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (myPrefab) {

            foreach (Transform t in myObjects)
            {
                t.transform.rotation = Quaternion.Euler(0, Mathf.Sin(5.0f * Time.deltaTime) * 360 * UnityEngine.Random.Range(-10.0f, 10.0f), 0);        

            }
        }
    }
}

//t.transform.rotation = Quaternion.Euler(0, Mathf.Sin(5.0f * Time.deltaTime) * 360 * UnityEngine.Random.Range(-10.0f, 10.0f), 0);   