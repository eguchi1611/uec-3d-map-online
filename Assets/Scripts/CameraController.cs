using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        // 移動
        float speed = 6.0f;
        float horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(horizontal, 0, vertical);

        // 上下移動
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }

        // 回転
        float rotateSpeed = 2.0f;
        Vector3 angle = new(Input.GetAxis("Mouse X") * rotateSpeed, -Input.GetAxis("Mouse Y") * rotateSpeed, 0);

        //transform.RotateAround()をしようしてメインカメラを回転させる
        transform.RotateAround(transform.position, Vector3.up, angle.x);
        transform.RotateAround(transform.position, transform.right, angle.y);
    }
}
