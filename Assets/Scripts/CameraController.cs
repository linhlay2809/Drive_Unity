using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject car;
    public float carX;
    public float carY;
    public float carZ;
    private Vector3 vector3;

    void Start()
    {
        vector3 = new Vector3(0, 1.5f, -8f);
    }
    void Update()
    {    // kết nối với tranform của component của vật thể Camera
        carX = car.transform.eulerAngles.x;
        carY = car.transform.eulerAngles.y;
        carZ = car.transform.eulerAngles.z;
        transform.eulerAngles = new Vector3(carX - carX, carY, carZ - carZ);
        
    }
}
