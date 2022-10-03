using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vascinations
{
    public class PrismImpl : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string DialogHostSpaceName
        {
            get { return GetType().ToString(); }
        }
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        protected virtual void OnPropertyChanged<T>(Expression<Func<T>> propertyExpression)
        {
            var propertyName = PropertySupport.ExtractPropertyName(propertyExpression);
            if (propertyName != null)
                OnPropertyChanged(propertyName);
            else
                throw new Exception("PrismImpl");
        }
    }
}