using UnityEngine;

public class ControlSystem : MonoBehaviour
{
    [Header("移動速度")]
    [Range(0.5f, 99.9f)]
    public float moveSpeed = 3.5f;

    [Header("2D 剛體")]
    public Rigidbody2D rig;

    [Header("動畫控制器")]
    public Animator ani;

    [Header("跑步參數")]
    public string parRun = "開關跑步";

    private void Awake()
    {
        // print("隨便寫~");

        // print("1 + 2");

        // print($"{1 + 2}");
    }

    private void Start()
    {
        // print("<color=red>這是開始事件</color>");
    }

    private void Update()
    {
        MoveAndAnimation();
    }

    private void MoveAndAnimation()
    {
        // print("<color=yellow>這是更新事件~</color>");

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rig.velocity = new Vector3(h, v, 0) * moveSpeed;

        // 玩家有按 A 輸出 true，沒有輸出 false
        // print(Input.GetKeyDown(KeyCode.A));

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        // 如果 h > 0 就開啟跑步動畫
        // h > 0 或者 h < 0 或者 v > 0 或者 v < 0
        ani.SetBool(parRun, h > 0 || h < 0 || v > 0 || v < 0);
    }
}
