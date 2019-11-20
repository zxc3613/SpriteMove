using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteMove : MonoBehaviour
{
    [SerializeField] float speed = 0;
    [SerializeField] float startPos;
    [SerializeField] float endPos;

    void Update()
    {
        transform.Translate(-1 * (speed * Time.deltaTime), 0, 0);
        if (transform.position.x < endPos)
        {
            transform.Translate(-1 * (endPos-startPos), 0, 0);
        }
       
    }
}
