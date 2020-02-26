using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public bool scrolling,paralax;

    public float backgroundSize;
    public float paralaxSpeed;

    private Transform cameraTranform;
    private Transform[] layers;
	
    private float viewZone = 10;
    private float lastCamraX;
	
    private int leftIndex;
    private int rightIndex;
    
    
    // Use this for initialization
    private void Start()
    {
        cameraTranform = Camera.main.transform;
        lastCamraX = cameraTranform.position.x;
        layers = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
            layers[i] = transform.GetChild(i);

        leftIndex = 0;
        rightIndex = layers.Length - 1;
    }

    // Update is called once per frame
    private void Update()
    {
        if (paralax)
        {
            float deltaX = cameraTranform.position.x - lastCamraX;
            transform.position += Vector3.right * (deltaX * paralaxSpeed);
        }
        
        lastCamraX = cameraTranform.position.x;

        if (scrolling)
        {
            if (cameraTranform.position.x < (layers[leftIndex].transform.position.x + viewZone))
                ScrollLeft();

            if (cameraTranform.position.x > (layers[rightIndex].transform.position.x - viewZone))
                ScrollRight();
        }
    }

    private void ScrollLeft()
    {
        int lastRight = rightIndex;
        layers[rightIndex].position = Vector3.right * (layers[leftIndex].position.x - backgroundSize);
        leftIndex = rightIndex;
        rightIndex--;
        if (rightIndex < 0)
            rightIndex = layers.Length - 1;
    }

    private void ScrollRight()
    {
        int lastLeft = leftIndex;
        layers[leftIndex].position = Vector3.right * (layers[rightIndex].position.x + backgroundSize);
        rightIndex = leftIndex;
        leftIndex++;
        if (leftIndex == layers.Length)
            leftIndex = 0;
    }
}
