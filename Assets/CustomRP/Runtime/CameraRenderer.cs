using System.Linq;
using UnityEngine;
using UnityEngine.Rendering;


public class CameraRenderer {

    private ScriptableRenderContext m_context;
    private Camera m_camera;


    public void Render(ScriptableRenderContext context, Camera camera) {
        m_context = context;
        m_camera = camera;

        Steup();
        DrawVisibleGeometry();
        Submit();
    }

    private void Steup() {
        m_context.SetupCameraProperties(m_camera);
    }


    private void DrawVisibleGeometry() {
        m_context.DrawSkybox(m_camera);
    }

    private void Submit() {
        m_context.Submit();
    }

}