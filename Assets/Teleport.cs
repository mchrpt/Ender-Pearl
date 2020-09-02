using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject prefab;
    public GameObject newOb;
    // Start is called before the first frame update
    void Start()
    {
        Contact.teleport += triggerTeleport;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            newOb = Instantiate(prefab, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Quaternion.identity) as GameObject;
            newOb.GetComponent<Rigidbody2D>().AddRelativeForce(Vector3.left * 600);


        }
        else if(Input.GetKeyDown(KeyCode.E))
        {
            newOb = Instantiate(prefab, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Quaternion.identity) as GameObject;
            newOb.GetComponent<Rigidbody2D>().AddRelativeForce(Vector3.right * 600);
        }
    }
    void triggerTeleport(bool isTrue)
    {
        transform.position = new Vector3(newOb.transform.position.x, newOb.transform.position.y + .5f, newOb.transform.position.z);
    }
}
