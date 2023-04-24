using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float speed;
    private float currentPosX;
    private float currentposY;
    private Vector3 velocity = Vector3.zero;
    [SerializeField] private GameObject startPos;

    private void Start()
    {
        transform.position = new Vector3(startPos.transform.position.x, startPos.transform.position.y, -10);
    }
    private void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentPosX, currentposY, transform.position.z), ref velocity, speed);
    }


    public void MoveToNewRoom(Transform _newRoom)
    {
        currentPosX = _newRoom.position.x;
        currentposY = _newRoom.position.y;
    }
}
