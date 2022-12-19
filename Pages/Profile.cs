namespace BlazorAnimations.Pages;

public partial class Profile
{
    private async Task ToggleBackground()
    {
        while (true)
        {
            Background = "lightskyblue";
            StateHasChanged();
            await Task.Delay(4000);
            Background = "mediumpurple";
            StateHasChanged();
            await Task.Delay(4000);
        }
    }
}