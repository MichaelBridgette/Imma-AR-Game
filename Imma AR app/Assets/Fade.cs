using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour {
    Image m_Image;
    //Set this in the Inspector
    public Sprite[] m_Sprite;

    bool fadeOn = true;
    bool appear = false;
    bool changeImage = false;
    float timer = 0;
    public float maxTime = 6;
    float convertedTime;
    int spriteCounter = 1;

    // Use this for initialization
    void Start () {
        m_Image = GetComponent<Image>();
        convertedTime = maxTime * 60;
	}
	
	// Update is called once per frame
	void Update () {
		if(fadeOn)
        {
            timer++;
            m_Image.color = new Color(m_Image.color.r, m_Image.color.g, m_Image.color.b, 1-(timer / convertedTime));

            if(timer >= convertedTime)
            {
                timer = 0;
                fadeOn = false;



                m_Image.sprite = m_Sprite[spriteCounter];

                if (spriteCounter >= m_Sprite.Length - 1)
                {
                    spriteCounter = 0;

                }
                else
                {
                    spriteCounter++;
                }
                appear = true;
            }
        }
        else if(appear)
        {
            timer++;
            m_Image.color = new Color(m_Image.color.r, m_Image.color.g, m_Image.color.b,  (timer / convertedTime));
            if (timer >= convertedTime)
            {
                timer = 0;
                appear = false;



                fadeOn = true;
            }
        }
	}
}
