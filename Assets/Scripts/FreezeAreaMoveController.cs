using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeAreaMoveController : MonoBehaviour
{
    [Header("Position")]
    public Transform player;
    private float horizontalOffset;

    // Start is called before the first frame update
    void Start()
    {
        horizontalOffset = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.x = player.position.x + horizontalOffset;
        transform.position = newPosition;

    }
}
