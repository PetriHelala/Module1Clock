using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpMovement : MonoBehaviour
{
    [SerializeField]
    
    private AnimationCurve curve;
    private Vector3 endPosition = new Vector3(479, 253, -853);
    private Vector3 startPosition;
    private float desiredDuration = 3f;
    private float elapsedTime;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        float percentageComplete = elapsedTime / desiredDuration;

        transform.position = Vector3.Lerp(startPosition, endPosition, curve.Evaluate(percentageComplete));
    }
}
