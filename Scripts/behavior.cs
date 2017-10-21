using UnityEngine;
using System.Collections;

public class behavior : MonoBehaviour {

    public float timer;
    public int force = 5;
    public int frameNumber = 10;
    public int frameCount = 3;
    private Renderer renderer;
    public Transform transformCamera;
    public Transform transformText;
    private Vector3 offset;
    private Vector3 offset2;
    private Rigidbody rb;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Fail")
        {
            print(1);
        }
    }
    // Use this for initialization
    void Start () {
     
       
        rb = GetComponent<Rigidbody>();
        renderer = GetComponent<Renderer>();
        offset = transformCamera.position-transform.position;
        offset2 = transformText.position - transform.position;
        Vector3 vel = new Vector3(2,0,0);
        rb.velocity = vel;
    }
	
	// Update is called once per frame
	void Update () {

        int score = (int)(this.transform.position.x + 6) / 6;
        //tm.text = score.ToString();
        transformCamera.position = new Vector3(transform.position.x+2,
            transformCamera.position.y,transformCamera.position.z);
        transformText.position = new Vector3(transform.position.x+2,
            transformText.position.y, transformText.position.z);
        //transform.Translate(new Vector3(Time.deltaTime,0,0));
        timer +=Time.deltaTime;
        if (timer>=1.0f/frameNumber) {
            frameCount++;
            timer -= 1.0f / frameNumber;
            int frameIndex = frameCount % 3;
            renderer.material.SetTextureOffset("_MainTex", new Vector2(0.333f*frameIndex,0));
        }
        if (Input.GetMouseButton(0)) {
            Vector3 vel2 = new Vector3(2,3,0);
             rb.velocity = vel2;
//Vector3 vel2 = rb.velocity;
         //   rb.velocity = new Vector3(vel2.x, 2, vel2.z);

        }
	}
  
}
