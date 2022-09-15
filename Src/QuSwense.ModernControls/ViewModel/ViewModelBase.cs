using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace QuSwense.ModernControls.ViewModel
{
    /// <summary>
    /// An abstract base class for all the view model classes.
    /// This class contains all the common methods for use in a view model.
    /// <see cref="INotifyPropertyChanged"/> interface is used to notify clients,
    /// typically binding clients, that a property value has changed.
    /// </summary>
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged

        /// <summary>
        /// The event to register an instance of a delegate that handles the PropertyChanged 
        /// raised when a property is changed on a component.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Call this method when you need to notify the UI client of the property chnaged event.
        /// Normally when a property is declared this method is called in the set declaration after the 
        /// property value is changed.
        /// </summary>
        /// <param name="name"></param>
        protected void NotifyPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
