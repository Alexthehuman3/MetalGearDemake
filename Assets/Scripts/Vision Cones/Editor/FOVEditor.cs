using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor (typeof(FOV))]
public class FOVEditor : Editor
{
    private void OnSceneGUI()
    {
        FOV fov = (FOV)target;

        Handles.color = Color.white;
        Handles.DrawWireArc(
            fov.transform.position, 
            Vector3.right, 
            Vector3.forward, 
            360, 
            fov.viewRadius);

        Vector3 viewAngleA = fov.DirectionFromAngle(-fov.viewAngle / 2, false);
        Vector3 viewAngleB = fov.DirectionFromAngle(fov.viewAngle / 2, false);

        Handles.DrawLine(
            fov.transform.position, 
            fov.transform.position + viewAngleA * fov.viewAngle);

        Handles.DrawLine(
            fov.transform.position, 
            fov.transform.position + viewAngleB * fov.viewAngle);

        Handles.DrawLine(fov.transform.position, fov.transform.position + fov.transform.up * 3);
        
    }
}
