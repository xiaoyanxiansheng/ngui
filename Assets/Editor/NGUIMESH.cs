using UnityEngine;
using System.Collections;
using UnityEditor;

// WG TODO
public static class NGUIMESH
{

    [MenuItem("NGUI/NguiMeshView")]

    static public void NguiMeshView()
    {
        foreach (var panel in UIPanel.list)
        {
            foreach (var dc in panel.drawCalls)
            {
                if (dc.gameObject.hideFlags != HideFlags.DontSave)
                {
                    dc.gameObject.hideFlags = HideFlags.DontSave;
                }
                else
                {
                    dc.gameObject.hideFlags = HideFlags.HideAndDontSave;
                }
            }
        }
    }
}