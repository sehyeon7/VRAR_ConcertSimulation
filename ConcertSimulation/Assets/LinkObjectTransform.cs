using UnityEngine;
using System.Collections;

public class LinkObjectTransform : MonoBehaviour
{
    public GameObject obj;
    public string name;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        name = gameObject.name;
        obj = GameObject.Find("/Duplicate_Map/" + name);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = obj.transform.position;
        gameObject.transform.rotation = obj.transform.rotation;
    }
}
