﻿#pragma checksum "E:\Documents\Visual Studio 2012\Projects\SudokuAdv\SudokuAdv\PlayPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2A54316C8DBF16F60099FF995EAEE507"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace SudokuAdv {
    
    
    public partial class PlayPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button btnCampaign;
        
        internal System.Windows.Controls.Button btnLevels;
        
        internal System.Windows.Controls.Button btnRandom;
        
        internal System.Windows.Controls.Button btnSolver;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/SudokuAdv;component/PlayPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.btnCampaign = ((System.Windows.Controls.Button)(this.FindName("btnCampaign")));
            this.btnLevels = ((System.Windows.Controls.Button)(this.FindName("btnLevels")));
            this.btnRandom = ((System.Windows.Controls.Button)(this.FindName("btnRandom")));
            this.btnSolver = ((System.Windows.Controls.Button)(this.FindName("btnSolver")));
        }
    }
}

