using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slide : MonoBehaviour
{

    Image m_Image;
    //Set this in the Inspector
    public Sprite[] m_Sprite;
    public float maxTime = 4;
    public float maxScale = 0.25f;
    int spriteCounter = 1;

    float timer = 0;
    RectTransform transform;

    void Start()
    {
        //Fetch the Image from the GameObject
        m_Image = GetComponent<Image>();
        m_Image.color = new Color(m_Image.color.r, m_Image.color.g, m_Image.color.b, 1.0f);
        transform = GetComponent<RectTransform>();
        maxTime *= 60;
        maxScale = (maxScale * 100);
        maxScale = 100 / maxScale;
    }

    void Update()
    {

        //Press space to change the Sprite of the Image
        m_Image.color = new Color(m_Image.color.r, m_Image.color.g, m_Image.color.b, timer / maxTime);
        transform.localScale = new Vector3((timer / maxTime)/maxScale, (timer / maxTime)/maxScale, (timer / maxTime)/maxScale);
        if (timer > maxTime)
        {
            m_Image.sprite = m_Sprite[spriteCounter];

            if (spriteCounter >= m_Sprite.Length - 1)
            {
                spriteCounter = 0;

            }
            else
            {
                spriteCounter++;
            }
            timer = 0;
            transform.localScale = new Vector3(0, 0, 0);
        }
        timer++;
    }

}
