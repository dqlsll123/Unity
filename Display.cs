using UnityEngine;
using System.Collections;

public class Display : MonoBehaviour {

    public Transform bird;

    // Use this for initialization
    void Start () {
        GetComponent<TextMesh>().text = "111";
    }
	
	// Update is called once per frame
	void Update () {
        int score = (int)((bird.transform.position.x + 3) / 3);
        GetComponent<TextMesh>().text = score.ToString();

    }
   
}
