using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public List<GameObject> gameObjects;

    int index = 0;

    public Transform spawnPoint;

    public void CreatObject()
    {
        if (index < gameObjects.Count)
        {
            gameObjects[index].transform.position = spawnPoint.position;
            index += 1;
        }
        else
        {
            GameManager.Instance.CheckLevelUp();
        }
    }

    private void Start()
    {
        CreatObject();
    }

    public static List<GameObject> GetAllChilds(GameObject Go)
    {
        List<GameObject> list = new List<GameObject>();
        for (int i = 0; i < Go.transform.childCount; i++)
        {
            list.Add(Go.transform.GetChild(i).gameObject);
        }
        return list;
    }
}
