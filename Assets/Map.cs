using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject SpawnPos;
    Vector3 position;
    Quaternion roatate;
    Object plumb;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        plumb = Resources.Load("Plumb");
        position = SpawnPos.transform.position;
        roatate = SpawnPos.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2)
        {
            Instantiate(plumb, randomSpawn(), roatate);
            timer = 0;
        }
    }

    Vector3 randomSpawn()
    {
        int ypos = Random.Range(-3, 3);
        Vector3 result = position;
        result.y = ypos;
        return result;
    }
}
