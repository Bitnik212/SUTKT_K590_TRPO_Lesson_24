using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace Variant_2
{
    public partial class ExtraWindow : Window
    {
        SaveFileDialog saver = new SaveFileDialog();

        public ExtraWindow() => InitializeComponent();
		
        public string add(string fileName){
            try{
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(fileName);
                image.EndInit();
                list.Items.Add(image);
                return "Изображение успешно добавлено!";
            }
            catch(Exception exception){
                return exception.Message;
            }
        }

        void display(object sender, SelectionChangedEventArgs e){
            imager.Source = (BitmapImage)list.SelectedItem;
        }

        void save(object sender, RoutedEventArgs e){
            saver.Filter = "Image files (*.PNG)|*.png";
            if(saver.ShowDialog() == true){
                PngBitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create((BitmapImage)list.SelectedItem));
                using(var fileStream = new System.IO.FileStream(saver.FileName, System.IO.FileMode.Create))
                    encoder.Save(fileStream);
                MessageBox.Show("Изображение сохранено как " + saver.FileName);
            }
        }
    }
}