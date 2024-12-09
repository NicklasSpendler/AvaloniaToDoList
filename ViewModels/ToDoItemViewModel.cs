using CommunityToolkit.Mvvm.ComponentModel;
using TodoListv1.Models;

namespace TodoListv1.ViewModels;

public partial class ToDoItemViewModel : ViewModelBase
{
    [ObservableProperty]
    public bool _isChecked;

    [ObservableProperty]
    private string? _content;

    public ToDoItemViewModel()
    {
    }

    public ToDoItemViewModel(bool isChecked, string? content)
    {
        _isChecked = isChecked;
        _content = content;
    }

    public ToDoItem GetToDoItem()
    {
        return new ToDoItem()
        {
            IsChecked = this._isChecked,
            Content = this._content
        };
    }
}