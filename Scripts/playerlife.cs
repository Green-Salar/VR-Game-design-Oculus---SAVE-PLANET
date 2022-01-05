using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerlife : MonoBehaviour
{
    float dt,dthit;
    public GameObject rawImageObj;
    private Color rawColor;
    private RawImage img;
    private float life,alpha;
    private float totallife = 10;
    // Start is called before the first frame update
    void Start()
    {
        img = rawImageObj.GetComponent<RawImage>();
        rawColor = img.color;
        Debug.Log("color" + rawColor);
        dt = 0;
    }

    // Update is called once per frame
    void Update()
    {
        dthit += Time.deltaTime;
        dt += Time.deltaTime;
        if (dthit > 3 && life>0)
        {
            if (life == 1) { life = 0; } else { life -= 2;} 
            
        }
        alpha = (life / totallife);
        img.color = new Color(rawColor.r, rawColor.g, rawColor.b, alpha);
        // Debug.Log("time is" + Time.time);
    }
    public void hit()
    {
        
        if (dt > .5)
        {
            life = life + 1;
            Debug.Log("ooooooch my life"+life);
            dt = 0;
        }
        dthit = 0;
    }

 
}
