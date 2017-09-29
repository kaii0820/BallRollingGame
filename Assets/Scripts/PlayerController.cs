using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    // speedを制御する
    public float speed = 3;
    public bool jump = false;
    public bool stop = false;
    public float sphereRadius = 1.1f;
    public Transform charaRay;	//　レイを飛ばす体の位置
    public float charaRayRange; //　レイの距離
    private bool isjumping = false;


    void Update()
    {
        // Player が持つ Rigidbody コンポーネントを取得
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        

        if  (Input.GetButtonDown("Jump") && isjumping == false)
        {
            rigidbody.AddForce(0, 150, 0);
            isjumping = true;
        }

        // stop
        if (Input.GetKey(KeyCode.X))
        {
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
        }
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isjumping = false;
        }
    }


    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");              // Horizontal は水平X方向
        float z = Input.GetAxis("Vertical");                // Vertical は垂直方向	

        // Player が持つ Rigidbody コンポーネントを取得
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        // rigidbody のx軸（横）とz軸（奥）に力を加える
        rigidbody.AddForce(x * speed, 0, z * speed);


    }
}