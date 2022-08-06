using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMov : MonoBehaviour
{
    Vector3 dir = new Vector3(-1, 0, 0);
    public float speedl =1;
    Vector3 movDis;
    // Start is called before the first frame update
    void Start()
    {
        movDis = dir * Time.fixedDeltaTime * speedl;
    }

    private void FixedUpdate()
    {
        transform.position = transform.position + movDis;
        if (transform.position.x < -15)
        {
            gameObject.SetActive(false);
        }
    }
}
