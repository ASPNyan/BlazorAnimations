namespace BlazorAnimations.Pages;

public partial class TurningCircles
{
    private int CurrentRotation = 1;
    private string Rotation(byte Group)
    {
       if (Group is < 1 or > 3) return "0deg";

       const float SixthTurn = 0.16666666666667f;
       return $"{Group * SixthTurn + CurrentRotation * SixthTurn}turn";
    }
    private string AltRotation(byte Group)
    {
       if (Group is < 1 or > 3) return "0.16666666666667turn";

       const float SixthTurn = 0.16666666666667f;
       return $"{0.083333333333335f + (Group * SixthTurn - CurrentRotation * SixthTurn)}turn";
    }
    
    private async Task Animate()
    {
        while (true)
        {
            int NextRotation = CurrentRotation;
            while (NextRotation == CurrentRotation)
            {
                NextRotation = new Random().Next(0, 11);
            }
            CurrentRotation = NextRotation;
            StateHasChanged();
            
            await Task.Delay(2400);
        }
    }
    
    private static string RandRGB()
    {
        int R = new Random().Next(40, 255);
        int G = new Random().Next(40, 255);
        int B = new Random().Next(40, 255);

        return $"rgb({R}, {G}, {B})";
    }
}