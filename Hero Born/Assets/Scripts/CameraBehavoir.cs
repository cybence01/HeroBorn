using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavoir : MonoBehaviour
{
    //1
    public Vector3 CamOffset = new Vector3 (0f, 1.2f, -2.6f);
    //2
    private Transform _target;
    // Start is called before the first frame update
    void Start()
    {
        _target = GameObject.Find("Player").transform;
    }
    
    //4
    void LateUpdate()
    {
        //5
        this.transform.position = _target.TransformPoint(CamOffset);
        //6
        this.transform.LookAt(_target);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
