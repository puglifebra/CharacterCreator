using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroller : MonoBehaviour
{
    // [SerializeField] private Image _img;
    [SerializeField] private float _x, _y;
    public float resetX;

    // Update is called once per frame
    void Update()
    {
        // _img.uvRect = new Rect(_img.uvRect.position + new Vector2(_x,_y) * Time.deltaTime,_img.uvRect.size);
        float newX = this.transform.position.x + _x * Time.deltaTime;
        float newY = this.transform.position.y + _y * Time.deltaTime;
        this.transform.position = new Vector2(newX, newY);
        Debug.Log($"X: {this.transform.position.x}");
        if (this.transform.localPosition.x < -580) 
        {

        this.transform.localPosition = new Vector2(resetX, 0);
  
        }
    }
}
