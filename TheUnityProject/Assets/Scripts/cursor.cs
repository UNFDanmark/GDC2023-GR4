using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor : MonoBehaviour
{
    public Texture2D cursortexture;
    private CursorMode cursormode = CursorMode.Auto;
    private Vector2 hotspot = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void OnMouseEnter()
        {
            Cursor.SetCursor(cursortexture,hotspot,cursormode);
        }
    
        void OnMouseExit()
        {
            Cursor.SetCursor(null,Vector2.zero,cursormode);
        }
    }
}
