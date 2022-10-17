using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
[ExecuteAlways]
public class FixFrust : MonoBehaviour
{
    #region Constants
    private const string BENDING_FEATURE = "ENABLE_BENDING";
    #endregion


    #region Monobehaviour

    private void Awake()
    {
        if (Application.isPlaying)
        {
            Shader.EnableKeyword(BENDING_FEATURE);
        }
        else
        {
            Shader.DisableKeyword(BENDING_FEATURE);
        }
    }
    private void OnEnable()
    {
       
        RenderPipelineManager.beginCameraRendering += OnBeginCameraRendering;
        RenderPipelineManager.endCameraRendering += OnEndCameraRendering;
    }
    private void OnDisable()
    {
        RenderPipelineManager.beginCameraRendering -= OnBeginCameraRendering;
        RenderPipelineManager.endCameraRendering -= OnEndCameraRendering;
    }
    #endregion

    #region Methods
    private static void OnBeginCameraRendering (ScriptableRenderContext ctx, Camera cam)
    {
        cam.cullingMatrix = Matrix4x4.Ortho(-1000, 1000, -1000, 1000, 0.5f, 5000) * cam.worldToCameraMatrix;
    }

    private static void OnEndCameraRendering(ScriptableRenderContext ctx, Camera cam)
    {
        cam.ResetCullingMatrix();
    }
    #endregion
}
