using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MVVM_Base.Properties;

namespace MVVM_Base
{
    /// <inheritdoc />
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    /// <inheritdoc />
    public class ViewModelBase<TModel> : ViewModelBase
    {
        protected TModel Model { get; }

        public ViewModelBase()
        {
            Model = Activator.CreateInstance<TModel>();
        }
    }
}
