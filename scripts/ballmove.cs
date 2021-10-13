using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ballmove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float thrust=150f;
    [SerializeField] private Rigidbody rb;
    private Vector2 lastMousePos;
    [SerializeField] private float wallDistance = 5f;
    // [SerializeField] private float minCamDistance = 3f;
    void Start()
    {
        // transform.position = new Vector3(0.088f,1.2780f,-98.7f);
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    	
        Vector2 deltPos = Vector2.zero;
        if(Input.GetMouseButton(0))
        {
          Vector2 currentMousePos = Input.mousePosition;
          if(lastMousePos == Vector2.zero)
          {
            lastMousePos = currentMousePos;
          }
          deltPos = currentMousePos - lastMousePos;
          lastMousePos = currentMousePos;
          Vector3 force = new Vector3(deltPos.x,0,deltPos.y)*thrust;
          rb.AddForce(force);
        }
        else
        {
          lastMousePos = Vector2.zero;
        }
        if(transform.position.x >7.5f || transform.position.x < -5.1f || transform.position.z <-106.9)
        {
          // Debug.Log("end");
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
    void OnCollisionEnter(Collision col)
    {
        if(col.collider.tag == "badcube")
        {
          // Debug.Log("bad");
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if(col.collider.tag == "goodcube")
        {
            Debug.Log("good");
        }
    }
    // void LateUpdate()
    // {
    //     Vector3 pos = transform.position;
    //     // if(transform.position.x < -wallDistance)
    //     // {
    //     //     pos.x = -wallDistance;
    //     // }
    //     // else
    //     // {
    //     //   pos.x = wallDistance;
    //     // }
    //     // transform.position = pos;
    //     if(transform.position.z < Camera.main.transform.position.z + minCamDistance)
    //     {
    //       pos.z = Camera.main.transform.position.z + minCamDistance;
    //     }
    //     transform.position = pos;
    // }

}
