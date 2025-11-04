using UnityEngine;

public class SpringMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.down * transform.position.y + Vector2.left * transform.position.x);
        float h, s, v;
        Color.RGBToHSV(Camera.main.backgroundColor, out h, out s, out v);
        Camera.main.backgroundColor = Color.HSVToRGB(h + Time.deltaTime, 1, 1);
    }
}
