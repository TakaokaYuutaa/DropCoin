using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    [SerializeField] GameObject _moveFloor;
    Vector3 setpos;
    private void Start()
    {
        _moveFloor.transform.position = setpos;
    }
    private void Update()
    {
        float floorAddXpos= 0;
        floorAddXpos += Mathf.Sin(Time.time);
        _moveFloor.transform.position = new Vector3(setpos.x,setpos.y,setpos.z+floorAddXpos);   
    }
}
