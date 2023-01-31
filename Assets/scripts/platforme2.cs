using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platforme2 : MonoBehaviour
{

    public Transform pos3, pos4;
    public float speed;
    public Transform startPos;
    Vector3 nextPos;
    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == pos3.position)
        { nextPos = pos4.position; }

        if (transform.position == pos4.position)
        { nextPos = pos3.position; }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);

    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos3.position, pos4.position);
    }
}

