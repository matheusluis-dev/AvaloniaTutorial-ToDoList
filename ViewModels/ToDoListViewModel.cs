using System.Collections.Generic;
using System.Collections.ObjectModel;
using ToDoList.Models;

namespace ToDoList.ViewModels;

public class ToDoListViewModel : ViewModelBase
{
    public ObservableCollection<ToDoItem> ListItems { get; }

    public ToDoListViewModel(IEnumerable<ToDoItem> items)
    {
        ListItems = new ObservableCollection<ToDoItem>(items);
    }
}
