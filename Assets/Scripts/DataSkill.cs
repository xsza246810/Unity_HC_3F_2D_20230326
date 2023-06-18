using UnityEngine;

[CreateAssetMenu(menuName = "KID/Data Skill")]
public class NewBehaviourScript : ScriptableObject
{
    [Header("�ޯ�W��")]
    public string nameSkill;
    [Header("�ޯ�C�ӵ��żƭ�")]
    public float[] skillValues;
    [Header("�ޯ�ϥ�")]
    public Sprite iconSkill;
    [Header("�ޯ�y�z"), TextArea(3,10)]
    public string description;

    public int lv = 1;
}
 