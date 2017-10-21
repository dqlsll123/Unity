using UnityEngine;
using System.Collections;

public class MoveTrigger : MonoBehaviour {


    public Transform bg;
    public Transform bg1;
    public Transform bg2;
    public pipe p11;
    public pipe p12;
    public pipe p21;
    public pipe p22;
    public pipe p31;
    public pipe p32;
    public int index = 0;
    
    // Use this for initialization
    public void OnTriggerEnter(Collider collider) {
        
        if (collider.tag=="Player") {
            index++;
            if (index % 3 == 1) {
                this.transform.position = new Vector3(
                    this.transform.position.x+6,this.transform.position.y,this.transform.position.z);
                bg.position = new Vector3(bg.position.x+18,bg.position.y,bg.position.z);
                p11.RandomGeneratePosition();
                p12.RandomGeneratePosition();

            } else if (index % 3 == 2) {
                this.transform.position = new Vector3(
                    this.transform.position.x + 6, this.transform.position.y, this.transform.position.z);
                bg1.position = new Vector3(bg1.position.x + 18, bg1.position.y, bg1.position.z);
                p21.RandomGeneratePosition();
                p22.RandomGeneratePosition();

            } else if (index % 3 == 0) {
                this.transform.position = new Vector3(
                    this.transform.position.x + 6, this.transform.position.y, this.transform.position.z);
                bg2.position = new Vector3(bg2.position.x + 18, bg2.position.y, bg2.position.z);
                p31.RandomGeneratePosition();
                p32.RandomGeneratePosition();


            }



        }
    }
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
