using System;
using Models;
using System.Windows.Input;

namespace ViewModels
{
    public interface IPhotoViewModel : IPhotoModel
    {
        ICommand BackCommand { get; }
        ICommand EditCommand { get; }
        TimeSpan TimeTaken { get; set; }
    }
}