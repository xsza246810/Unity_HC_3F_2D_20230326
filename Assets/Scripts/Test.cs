using UnityEngine;

public class Test : MonoBehaviour
{
    public Transform tra;
    public GameObject prefab;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            for (int i = 0; i < tra.childCount; i++)
            {
                Destroy(tra.GetChild(i).gameObject);
            }

            for (int i = 0; i < 5; i++)
            {
                Instantiate(prefab, tra.position, Quaternion.identity, tra);
            }
        }
    }
}
