using UnityEngine;

public class ExpObject : MonoBehaviour
{
    [Header("可以吃這個物件的名稱")]
    public string nameTarget = "犀牛";
    [Header("移動速度"), Range(0, 500)]
    public float moveSpeed = 3.5f;

    private Transform player;

    private void Awake()
    {
        player = GameObject.Find(nameTarget).transform;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print($"<color=#ff6699>{collision.name}</color>");
    }
}
