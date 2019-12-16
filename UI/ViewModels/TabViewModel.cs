using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMenu.ViewModels
{
    class TabViewModel : Conductor<Caliburn.Micro.IScreen>.Collection.OneActive
    {
            protected override void OnInitialize()
            {
                //ActivateItem(new InsuranceViewModel
                //{
                //    DisplayName = "Tab item 1"
                //});

                //ActivateItem(new UserInfoViewModel
                //{
                //    DisplayName = "Tab item 2"
                //});

        }
       
    }
}
