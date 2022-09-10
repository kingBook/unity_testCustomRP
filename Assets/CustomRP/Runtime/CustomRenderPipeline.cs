using System;
using UnityEngine;
using UnityEngine.Rendering;


public class CustomRenderPipeline : RenderPipeline {

    private readonly CameraRenderer m_cameraRenderer = new CameraRenderer();

    protected override void Render(ScriptableRenderContext context, Camera[] cameras) {
        foreach (Camera camera in cameras) {
            m_cameraRenderer.Render(context, camera);
        }
    }

}