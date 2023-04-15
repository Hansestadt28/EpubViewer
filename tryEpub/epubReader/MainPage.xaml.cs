using epubReader.Helper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x407 dokumentiert.

namespace epubReader
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public List<string> TocItems;
        
        public MainPage()
        {
            this.InitializeComponent();
            Inhaltsverzeichnis();
        }

        public void Inhaltsverzeichnis()
        {
            Reader reader = new Reader();
            var liste = reader.ReadFile();
            TocItems = liste;

            //TreeViewNode rootNode = new TreeViewNode();
            //rootNode.IsExpanded = true;
            //rootNode.Children.Add(new TreeViewNode() { Content = "Vanilla" });
            //rootNode.Children.Add(new TreeViewNode() { Content = "Strawberry" });
            //rootNode.Children.Add(new TreeViewNode() { Content = "Chocolate" });
            //rootNode.Content = "Inhaltsverzeichnis";

            //this.Inhalt.RootNodes.Add(rootNode);
        }
    }
}
