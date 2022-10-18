using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    public RenderTexture setTargetTexture;

    public Transform player;

    private void Update()
    {
        gameObject.GetComponent<Camera>().targetTexture = setTargetTexture;
        //Debug.Log(setTargetTexture);

        Vector3 newPosition = player.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;
        Debug.Log(newPosition);
    }

    private void LateUpdate()
    {
        
    }
}
