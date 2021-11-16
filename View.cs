using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace OpenGL
{
    class View : GameWindow
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Title = "OpenGL Test";
            GL.ClearColor(Color.DarkGray);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            

            Matrix4 modelView = Matrix4.LookAt(Vector3.Zero, Vector3.UnitZ, Vector3.UnitY);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelView);

            GL.Begin(BeginMode.Triangles);

            #region tri bottom left
            // bottom left
            GL.Color3(Color.MediumVioletRed);     
            GL.Vertex3(-1.0f, -0.5f, 4.0f);

            // bottom right
            GL.Color3(Color.MediumVioletRed);       
            GL.Vertex3(0.0f, -0.5f, 4.0f);

            // top center
            GL.Color3(Color.MediumVioletRed);        
            GL.Vertex3(-0.5f, 0.5f, 4.0f);
            #endregion

            #region tri bottom right
            // bottom left
            GL.Color3(Color.BlueViolet);
            GL.Vertex3(0.0f, -0.5f, 4.0f);

            // bottom right
            GL.Color3(Color.BlueViolet);
            GL.Vertex3(1.0f, -0.5f, 4.0f);

            // top center
            GL.Color3(Color.BlueViolet);
            GL.Vertex3(0.5f, 0.5f, 4.0f);
            #endregion
            
            #region tri top mid
            // bottom left
            GL.Color3(Color.SlateBlue);
            GL.Vertex3(0.5f, 0.5f, 4.0f);

            // bottom right
            GL.Color3(Color.SlateBlue);
            GL.Vertex3(-0.5f, 0.5f, 4.0f);

            // top center
            GL.Color3(Color.SlateBlue);
            GL.Vertex3(0.0f, 1.5f, 4.0f);
            #endregion
            
            GL.End();
            SwapBuffers();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GL.Viewport(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height);

            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView((float)Math.PI / 4, Width / (float)Height, 1.0f, 64.0f);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
        }
    }
}
