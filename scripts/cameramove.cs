using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 offset;
    public Transform pl;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = pl.position+offset;
    }
}
