﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace Aerodrom.ViewModel.Helper
{
    public class Messenger
    {
        public  static void prikaziPoruku(String p)
        {
            var dialog = new MessageDialog(p);
             dialog.ShowAsync();
        }
    }
}
