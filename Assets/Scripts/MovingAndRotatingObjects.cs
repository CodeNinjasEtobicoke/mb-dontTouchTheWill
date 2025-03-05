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

    Material material;

    // Start is called before the first frame update
    private void Start()
    {
        material = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);

        ChangeColor();
    }

    void ChangeColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(1f, 0f);
        float b = Random.Range(0f, 1f);

        Color color = new Color(r, g, b);
        material.color = color;

    }
}

