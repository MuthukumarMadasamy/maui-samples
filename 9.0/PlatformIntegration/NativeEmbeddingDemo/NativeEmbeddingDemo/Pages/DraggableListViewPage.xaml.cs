using Microsoft.Maui.Controls;

namespace NativeEmbeddingDemo.Pages;

public partial class DraggableListViewPage : ContentPage
{
    public DraggableListViewPage()
    {
        InitializeComponent();
        collectionView.ItemsSource = new List<string> 
        { 
            "Item 1", 
            "Item 2", 
            "Item 3",
            "Item 4",
            "Item 5" 
        };
    }
}
