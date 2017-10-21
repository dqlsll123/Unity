using UnityEngine;
using System.Collections;

public class RandomPipe : MonoBehaviour {

    public Random random;

    // Use this for initialization
    public void RandomGeneratePosition() {
        float y_position = Random.Range(0.6f, 0.9f);
        transform.localPosition = new Vector3(transform.position.x,y_position,transform.position.z);

    }


	void Start () {
        RandomGeneratePosition();


    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
