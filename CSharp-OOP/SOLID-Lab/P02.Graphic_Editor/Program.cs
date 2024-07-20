namespace P02.Graphic_Editor
{
    class Program
    {
        static void Main()
        {
            GraphicEditor graphicsEditor = new GraphicEditor();

            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();
            Square square = new Square();

            graphicsEditor.DrawShape(circle);
            graphicsEditor.DrawShape(rectangle);
            graphicsEditor.DrawShape(square);
        }
    }
}
