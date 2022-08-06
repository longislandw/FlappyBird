using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conntroll : MonoBehaviour
{

    Rigidbody2D a;
    // Start is called before the first frame update
    void Start()
    {
        a = gameObject.GetComponent<Rigidbody2D>();
        a.AddForce(new Vector2(0, 1) * 400);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            a.AddForce(new Vector2(0, 1)*400);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger");
        gameObject.SetActive(false);
    }
}
