namespace OpenGL
{
    class Program
    {
        static void Main()
        {
            using (View view = new View())
            {
                view.Run(30.0);
            }
        }
    }
}
