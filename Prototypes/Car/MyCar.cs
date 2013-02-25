using System;
using DeltaEngine.Core;
using DeltaEngine.Datatypes;
using DeltaEngine.Input;
using DeltaEngine.Input.Devices;
using DeltaEngine.Rendering;

namespace Breakout
{
    public class MyCar : Renderable
    {
        public MyCar(/*Input input,*/ Time time)
        {
            //RegisterInputCommands(input, time);
        }

        private float angle;
        private const float angleSpeed = 1.5f;

        //private void RegisterInputCommands(Input input, Time time)
        //{
        //    input.Add(Key.CursorLeft, State.Pressed,
        //        () => angle -= angleSpeed * time.CurrentDelta);
        //    input.Add(Key.CursorRight, State.Pressed,
        //        () => angle += angleSpeed * time.CurrentDelta);
        //}

        protected override void Render(Renderer renderer, Time time)
        {
            Point center = GetScreenCenter(renderer);
            DrawBox(renderer, center, Color.Purple);
            DrawBox(renderer, new Point(center.X - 0.2f, center.Y), Color.Green);
            DrawBox(renderer, new Point(center.X + 0.2f, center.Y), Color.Green);

            Vector vector = new Vector();

            renderer.DrawLine(center, new Point(center.X, center.Y - 0.2f), Color.Red);
        }

        private const float BoxSize = .05f;

        private static void DrawBox(Renderer renderer, Point centerPoint, Color color)
        {
            Rectangle rectangle = GetCenteredRectangle(centerPoint, new Size(BoxSize));
            renderer.DrawRectangle(rectangle, color);
        }

        private static Point GetScreenCenter(Renderer renderer)
        {
            return new Point((renderer.Screen.Right + renderer.Screen.Left)/2.0f,
                             (renderer.Screen.Bottom + renderer.Screen.Top)/2.0f);
        }

        private static Rectangle GetCenteredRectangle(Point centerPoint, Size size)
        {
            Point offsetPoint = new Point(centerPoint.X - size.Width/2f, centerPoint.Y - size.Height/2f);
            return new Rectangle(offsetPoint, size);
        }
    }
}