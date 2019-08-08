using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPlayer : MonoBehaviour
{
    [SerializeField]
    Transform target;
    Vector3 offset;
    public Transform Target { get => target; set => target = value; }

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.position;
        if (target != null)
            transform.Translate(new Vector2(target.position.x, target.position.y));
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
