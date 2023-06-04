using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [Header("等級與經驗值介面")]
    public TextMeshProUGUI textLv;
    public TextMeshProUGUI textExp;
    public Image imgExp;

    private int lv = 1;
    private float exp;

    public float[] expNeeds = { 100, 200, 300 };

    [ContextMenu("更新經驗值需求表")]
    private void UpdateExpNeeds()
    {
        expNeeds = new float[100];

        for (int i = 0; i < 100; i++)
        {
            expNeeds[i] = (i + 1) * 100;
        }
    }

    /// <summary>
    /// 獲得經驗值
    /// </summary>
    /// <param name="getExp">取得的經驗值浮點數</param>
    public void GetExp(float getExp)
    {
        exp += getExp;
        print($"<color=yellow>當前經驗值：{ exp }</color>");
    }
}
