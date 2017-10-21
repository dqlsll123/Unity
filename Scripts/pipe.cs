using UnityEngine;
using System.Collections;

public class pipe : MonoBehaviour
{

 

    // Use this for initialization
    public void RandomGeneratePosition()
    {
        float y_position = Random.Range(0.60f, 0.9f);
        this.transform.localPosition = new Vector3(this.transform.localPosition.x, y_position, this.transform.localPosition.z);

    }


    void Start()
    {
        RandomGeneratePosition();


    }
}
