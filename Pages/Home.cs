namespace BlazorAnimations.Pages;

public partial class Home
{
    private void ChangeRound()
    {
        ShapesRoundness = new Random().Next(1, 7);
        CirclesRoundness = new Random().Next(1, 7);
        ProfileRoundness = new Random().Next(1, 7);
        while (ShapesRoundness == CirclesRoundness || ProfileRoundness == CirclesRoundness)
            CirclesRoundness = new Random().Next(1, 7);
        while (CirclesRoundness == ShapesRoundness || CirclesRoundness == ProfileRoundness)
            CirclesRoundness = new Random().Next(1, 7);
        while (ProfileRoundness == ShapesRoundness || ProfileRoundness == CirclesRoundness)
            ProfileRoundness = new Random().Next(1, 7);
        StateHasChanged();
    }

    private string VertColor()
    {
        Vert = true;
        return Position switch
        {
            1 => "yellow",
            2 => "deeppink",
            3 => "cyan",
            _ => "white"
        };
    }
}