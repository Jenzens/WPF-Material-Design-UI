using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;


namespace WPFMenu.ViewModels
{
    public class MainViewModel : Conductor<object>
    {
        #region Buttons

        public void CloseWindow()
        {
            TryClose();
        }

        //public void Profile()
        //{
        //    ActivateItem(new ProfileViewModel());
        //}




        #endregion


    }
}
