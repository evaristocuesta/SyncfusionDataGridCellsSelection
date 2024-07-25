using CommunityToolkit.Mvvm.ComponentModel;
using System;

namespace SyncfusionDataGridCellsSelection.Models;

public partial class Person : ObservableObject
{
    [ObservableProperty]
    private int _id;

    [ObservableProperty]
    private string _name;

    [ObservableProperty]
    private string _surname;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Age))]
    private DateTime _birthday;

    public double Age => DateTime.Now.Year - Birthday.Year;

    [ObservableProperty]
    private bool _married;
}
