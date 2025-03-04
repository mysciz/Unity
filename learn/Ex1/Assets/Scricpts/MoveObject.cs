using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float movementSpeed = 0.1f; // 控制移动速度

    void Update()
    {
        // 获取垂直输入（上/下箭头键）
        float verticalInput = Input.GetAxis("Vertical");

        // 计算移动向量
        Vector3 movement = transform.position.normalized * verticalInput * movementSpeed;

        // 更新位置
        Vector3 newPosition = transform.position + movement;

        // 确保位置在指定范围内
        newPosition.x = Mathf.Clamp(newPosition.x, -50f, 50f);
        newPosition.y = Mathf.Clamp(newPosition.y, -50f, 50f);

        // 设置新位置
        transform.position = newPosition;
    }
}