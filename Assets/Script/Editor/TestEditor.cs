using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TestEditor : EditorWindow {

    public string[] options = new string[] { "cube", "sphere"};
    public int index = 0;
    string myString = "Hello World";
    bool groupEnabled;
    bool myBool = true;
    float myFloat = 1.23f;
    [MenuItem("Test/Test")]
    private static void ShowWindow() 
    {
        var window = GetWindow<TestEditor>();
        window.titleContent = new GUIContent("Test");
        window.Show();
    }

    private void OnGUI() 
    {
        index = EditorGUILayout.Popup(selectedIndex:index, displayedOptions:options);
        if (GUILayout.Button("Create"))
        {
            // InstantiatePrimitive();
            GetPosition();
        }
        // GUILayout.Label("Bease Settrings", EditorStyles.boldLabel);
        // myString = EditorGUILayout.TextField("Text Field", myString);
        // groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", groupEnabled);
        // myBool = EditorGUILayout.Toggle("Toggle", myBool);
        // myFloat = EditorGUILayout.Slider("Slider", myFloat, -3, 3);
        // EditorGUILayout.EndToggleGroup();
        
    }
    void GetPosition()
    {
        var obj = GameObject.Find("Image");
        Debug.Log(obj.transform.position.ToString());
    }
    void InstantiatePrimitive()
    {
        switch (index)
        {
            case 0:
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = Vector3.zero;
                break;
            case 1:
                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                sphere.transform.position = Vector3.zero;
                break;
                
        }
    }
}
