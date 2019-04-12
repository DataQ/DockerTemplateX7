﻿using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using corel = Corel.Interop.VGCore;

namespace $safeprojectname$
{
  
    public partial class ControlUI : UserControl
    {
        private corel.Application corelApp;
        private Styles.StylesController stylesController;
        public ControlUI(object app)
        {
            InitializeComponent();
            try
            {
                this.corelApp = app as corel.Application;
                stylesController = new Styles.StylesController(this.Resources, app);
            }
            catch 
            {
                global::System.Windows.MessageBox.Show("VGCore Erro");
            }
            btn_Command.Click += (s, e) => { corelApp.MsgShow("Working"); };
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            stylesController.LoadThemeFromPreference();
        }
  
    }
}
