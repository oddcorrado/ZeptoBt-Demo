using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZeptoBt;

public class ZeptoBtDemoController : MonoBehaviour
{
    [SerializeField] ZeptoBtViewer zeptoBtViewer;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V) && !zeptoBtViewer.IsEditingText)
            zeptoBtViewer.ToggleShow();
        if (Input.GetKeyDown(KeyCode.G) && !zeptoBtViewer.IsEditingText)
            zeptoBtViewer.ToggleQuickView();

        if (zeptoBtViewer.IsActive)
        {
            if (Input.GetKeyDown(KeyCode.Z) && (Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl)))
                zeptoBtViewer.NodeUndo();
        }
    }
}
