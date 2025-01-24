using System.Windows.Forms;

public static class InputHandler
{
    public static bool IsKeyPressed(Keys key)
    {
        return (Control.ModifierKeys & key) == key;
    }
}