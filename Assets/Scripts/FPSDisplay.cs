using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is a FPS Display created by Dave Hampson.
// It doesn't require a GUIText element and it also shows milliseconds,
// so just drop it into a GameObject and you should be ready to go.
// http://wiki.unity3d.com/index.php/FramesPerSecond
public class  FPSDisplay: MonoBehaviour {
    float deltaTime = 0.0f;

	// Update is called once per frame
	void Update () {
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
	}

    void OnGUI() {
        int w = Screen.width, h = Screen.height;

        GUIStyle style = new GUIStyle();

        Rect rect = new Rect(0, 0, w, h * 2 / 100);
        style.alignment = TextAnchor.UpperLeft;
        style.fontSize = h * 2 / 100;
        style.normal.textColor = new Color(0.0f, 0.0f, 0.5f, 1.0f);
        float msec = deltaTime * 1000.0f;
        float fps = 1.0f / deltaTime;
        string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
        GUI.Label(rect, text, style);
    }
}
