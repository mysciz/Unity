using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Try : MonoBehaviour
{
    public float speed = 5.0f; // 控制移动速度
    void Awake()
    {
    Debug.Log("Awake: This is called once when the script is loaded.");
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }
    
    // Update is called once per frame
    void Update()
    {
          float horizontalInput = Input.GetAxis("Horizontal"); // A 和 D 键（左右移动）
        float verticalInput = Input.GetAxis("Vertical");     // W 和 S 键（上下移动）

        // 计算移动方向
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0); // X轴和Y轴移动

        // 应用移动
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
