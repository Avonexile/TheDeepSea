using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(FishSpawner))]
public class FishSpawnerEditor : Editor
{
    private void OnSceneGUI()
    {
        Draw();
    }
    void Draw ()
    {
        FishSpawner spawner = (FishSpawner)target;

        for (int i = 0; i < spawner.spawnPositions.Count; i++)
        {
            Handles.DrawSphere(i, spawner.spawnPositions[i].position, Quaternion.identity, 5f);
        }
    }
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        FishSpawner spawner = (FishSpawner)target;

        if (GUILayout.Button("Add fish"))
        {
            Undo.RecordObject(spawner, "Add fish");
            spawner.AddFish();
        }
        if (GUILayout.Button("Add position"))
        {
            Undo.RecordObject(spawner, "Add position");
            spawner.AddPosition();
            //EditorUtility.SetDirty(tar);
        }
    }
}
