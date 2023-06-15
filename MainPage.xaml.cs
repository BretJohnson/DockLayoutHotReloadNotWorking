using CommunityToolkit.Maui.Layouts;

namespace DockLayoutHotReloadNotWorking;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnMoveButtonClicked(object sender, EventArgs e)
	{
		DockLayout.SetDockPosition(RightThenLeftButton, CommunityToolkit.Maui.Core.DockPosition.Left);
	}
}

