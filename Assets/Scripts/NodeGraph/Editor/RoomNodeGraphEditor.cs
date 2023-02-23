using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class RoomNodeGraphEditor : EditorWindow
{
    // private variables names starts as lower case

    // creating variable but is a class
    private GUIStyle roomNodeStyle;

    // Node layout values
    private const float nodeWidht = 160f;
    private const float nodeHeight = 75f;
    private const int nodePadding = 25;
    private const int nodeBorder = 12;

    // Add a menu item named "Do Something" to MyMenu in the menu bar!
    [MenuItem("Room Node Graph Editor", menuItem = "Window/Dungeon Editor/Room Node Graph Editor")]

    // open pop up new windows
    private static void OpenWindow()
    {
        GetWindow<RoomNodeGraphEditor>("Room Node Graph Editor");
    }

    // function/method create a style
    private void OnEnable()
    {
        roomNodeStyle = new GUIStyle(); // initializing 
        roomNodeStyle.normal.background = EditorGUIUtility.Load("node1") as Texture2D;
        roomNodeStyle.normal.textColor = Color.white;
        roomNodeStyle.padding = new RectOffset(nodePadding, nodePadding, nodePadding, nodePadding);
        roomNodeStyle.border = new RectOffset(nodeBorder, nodeBorder, nodeBorder, nodeBorder);

    }

    // Draw Rditor GUI
    private void OnGUI()
    {
        //Debug.Log("OnGUI foi chamdo!");

        GUILayout.BeginArea(new Rect(new Vector2(100f, 100f), new Vector2(nodeWidht, nodeHeight)), roomNodeStyle);
        EditorGUILayout.LabelField("Node 1");
        GUILayout.EndArea();

        GUILayout.BeginArea(new Rect(new Vector2(300f, 300f), new Vector2(nodeWidht, nodeHeight)), roomNodeStyle);
        EditorGUILayout.LabelField("Node 2");
        GUILayout.EndArea();
    }
}
