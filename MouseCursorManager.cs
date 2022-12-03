using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursorManager : MonoBehaviour
{
    public Texture2D[] cursors;

    public void ChangeCursor(int cursorIndex)
    {
        Vector2 hotspot = new Vector2(cursors[cursorIndex].width / 2, cursors[cursorIndex].height / 2);
        Cursor.SetCursor(cursors[cursorIndex], hotspot, CursorMode.Auto);
    }
}
