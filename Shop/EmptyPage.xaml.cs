using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Shop
{
    /// <summary>
    /// Interaction logic for EmptyPage.xaml
    /// </summary>
    public partial class EmptyPage : Page
    {
        public EmptyPage()
        {
            InitializeComponent();
        }

        private void DragObject_MouseLeftButtonDown(object sender, MouseEventArgs e)
        {
            Image image = e.Source as Image;
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                
                DragDrop.DoDragDrop(image, new DataObject(DataFormats.Serializable, image), DragDropEffects.Move);
             
            }
            
        }

        private void image_Drop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);
            if (data is UIElement element)
            {
                element.Visibility = Visibility.Hidden;
            }


            }
        private void Canvas_DragOver(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Point dropPosition = e.GetPosition(canvas);
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                if (!canvas.Children.Contains(element))
                {
                    canvas.Children.Add(element);
                }
            }
        }
    }
}
