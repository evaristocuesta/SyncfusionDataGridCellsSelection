using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SyncfusionDataGridCellsSelection.Data;
using SyncfusionDataGridCellsSelection.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SyncfusionDataGridCellsSelection.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private bool _updating = false;

    [ObservableProperty]
    private ObservableCollection<Person> _people;

    [RelayCommand]
    private void LoadData()
    {
        Updating = true;
        People = [];
        IEnumerable<Person> people = Seeder.GetPeople(100_000);
        People = new ObservableCollection<Person>(people);
        Updating = false;
    }
}
