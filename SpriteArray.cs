using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpriteArray : MonoBehaviour
{
    public int arrayIndex;
    public Image prot_;
    public Sprite[] protExpressoes;
    void Start()
    {
        prot_ = GetComponent<Image>();
        ChangeExpressao(protExpressoes[arrayIndex]);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && arrayIndex < protExpressoes.Length - 1)
        {
            arrayIndex++;
            ChangeExpressao(protExpressoes[arrayIndex]);
        }
    }

    public void ChangeExpressao(Sprite muda)
    {
        
        {
            prot_.sprite = muda;
        }
    }
}
