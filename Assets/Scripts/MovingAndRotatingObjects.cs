using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MovingAndRotatingObjects : MonoBehaviour
{
    [Header("Default Fortnite Skin And Movement Speed")]
    public float moveSpeed = 10f;
    [Header("Default Rotating Fortnite Skin And Speed")]
    public float rotateSpeed = 50f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
        transform.Rotate * Time.deltaTime, 0);
    }
}
