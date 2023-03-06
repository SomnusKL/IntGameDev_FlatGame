using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgborder : MonoBehaviour
{
    private static Collider2D _box;

    // Start is called before the first frame update
    void Start()
    {
        _box = GetComponent <Collider2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static Vector3 GetSize()
    {
        return new Vector3(_box.bounds.size.x, _box.bounds.size.y);
    }
}
