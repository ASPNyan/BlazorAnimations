namespace BlazorAnimations.Pages;

public partial class Home
{
    private void ChangeRound()
    {
        ShapesRoundness = new Random().Next(1, 7);
        CirclesRoundness = new Random().Next(1, 7);
        OtherRoundness = new Random().Next(1, 7);
        while (ShapesRoundness == CirclesRoundness || OtherRoundness == CirclesRoundness)
            CirclesRoundness = new Random().Next(1, 7);
        while (CirclesRoundness == ShapesRoundness || CirclesRoundness == OtherRoundness)
            CirclesRoundness = new Random().Next(1, 7);
        while (OtherRoundness == ShapesRoundness || OtherRoundness == CirclesRoundness)
            OtherRoundness = new Random().Next(1, 7);
        StateHasChanged();
    }
}