using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
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

namespace Async
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //DownloadHtml("https://www.marxists.org");
            DownloadHtmlAsync("https://www.marxists.org");
        }

        // What is a Task? A Task is an object that encapsulates the state of an asynchronous
        // operation.
        // If you are going to return something like a string, you have to use this: 
        // 'Task<string>'
        // If you are returning void, just use 'Task' like below.

        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();

            // O que significa o await? A impressão inicial é que a execução do programa tem que
            // esperar esse método terminar. Mas não é o caso de forma alguma.
            // Este é apenas um marcador para o compilador. Quando o compilador vê esse marcador, ele
            // sabe que essa operação vai ser custosa. Nesse caso, ao invés de bloquear esta thread, 
            // ele vai retornar para o chamador deste método (Neste caso o Button_Click) e continuar 
            // sua execução. Depois  que o método com await ser terminado, o runtime volta nele e continua
            // a execução do resto do método.
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"D:\Estudos\testesArquivos\result.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }

        // Synchronous
        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"D:\Estudos\testesArquivos\result.html"))
            {
                streamWriter.Write(html);
            }
        }
    }
}
