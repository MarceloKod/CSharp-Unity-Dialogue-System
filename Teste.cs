using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teste : MonoBehaviour
{
    public string[] text;
    public Text texto;
    public Canvas canvas;
    public int posDiag;
    public bool colisao = false;


    // Start is called before the first frame update
    void Start()
    {

        UpdateText(text[posDiag]);
        canvas.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && colisao)
        {
            canvas.enabled = true;
            if (Input.GetKeyDown(KeyCode.Space) && posDiag < text.Length+1)
            {
                if(posDiag < text.Length)
                {
                    UpdateText(text[posDiag]);
                    posDiag++;
                }
                else
                {
                    texto.text = null;
                    posDiag++;
                }
                

            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && posDiag > text.Length)
        {
            canvas.enabled = false;
        }
    }
    private void UpdateText(string msg)
    {
        texto.text = msg;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        colisao = true;
    }
}
