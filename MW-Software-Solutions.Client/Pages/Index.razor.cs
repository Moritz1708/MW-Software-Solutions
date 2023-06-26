using MudBlazor;

namespace MW_Software_Solutions.Client.Pages;

public partial class Index
{
    
    private bool arrows = false;
    private bool bullets = false;
    private bool enableSwipeGesture = true;
    private bool autocycle = false;
    private Transition transition = Transition.Slide;
    
    private string _value = null!;
}