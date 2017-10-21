using UnityEngine;
using System.Collections;

public class Pipe2 : MonoBehaviour {

    void OnCollisionEnter(Collider collision)
    {
        if(collision.gameObject.tag == "player")
        {
            Destroy(collision.gameObject);
        }
    }
}
