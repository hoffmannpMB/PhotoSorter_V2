using System;
using System.ComponentModel;
using System.Reflection;
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
        private TModel _model;

        protected ViewModelBase()
        {
            _model = Activator.CreateInstance<TModel>();
        }

        private void SetModelValues(TModel value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));

            var properties = _model.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);

            foreach (var property in properties)
            {
                property.SetValue(_model, property.GetValue(value));
                OnPropertyChanged(property.Name);
            }
        }

        public TModel Model
        {
            get => _model;
            set => SetModelValues(value);
        }
    }
}
