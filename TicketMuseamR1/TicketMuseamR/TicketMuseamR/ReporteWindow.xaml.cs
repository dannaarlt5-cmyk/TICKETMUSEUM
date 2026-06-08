using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Printing;

namespace TicketMuseamR
{
    /// <summary>
    /// Lógica de interacción para ReporteWindow.xaml
    /// </summary>
    public partial class ReporteWindow : Window
    {
        private decimal efectivo, tarjeta, total;
        private int boletos;
        public ReporteWindow(decimal ef, decimal tj, decimal tot, int bol)
        {
            InitializeComponent();
            this.efectivo = ef;
            this.tarjeta = tj;
            this.total = tot;
            this.boletos = bol;

            GenerarDocumentoBonito();
        }
        private void GenerarDocumentoBonito()
        {
            FixedDocument fixedDoc = new FixedDocument();
            PageContent pageContent = new PageContent();
            FixedPage fixedPage = new FixedPage();

            // Configurar tamaño de hoja estándar Carta (8.5 x 11 pulgadas a 96 DPI)
            fixedPage.Width = 816;
            fixedPage.Height = 1056;
            fixedPage.Background = Brushes.White;

            // Contenedor principal de texto con márgenes
            StackPanel mainStack = new StackPanel { Margin = new Thickness(50), Width = 716 };

            // Encabezado
            mainStack.Children.Add(new TextBlock { Text = "TICKET MUSEUM", FontSize = 28, FontWeight = FontWeights.Bold, Foreground = new SolidColorBrush(Color.FromRgb(0, 90, 158)), HorizontalAlignment = HorizontalAlignment.Center });
            mainStack.Children.Add(new TextBlock { Text = "REPORTE OFICIAL DE AUDITORÍA INTERNA", FontSize = 14, FontWeight = FontWeights.SemiBold, Foreground = Brushes.Gray, HorizontalAlignment = HorizontalAlignment.Center, Margin = new Thickness(0, 5, 0, 20) });

            // Línea divisoria
            mainStack.Children.Add(new System.Windows.Shapes.Line { X1 = 0, X2 = 716, Stroke = Brushes.LightGray, StrokeThickness = 1, Margin = new Thickness(0, 0, 0, 20) });

            // Información de Emisión
            mainStack.Children.Add(new TextBlock { Text = $"Fecha de Emisión: {DateTime.Now:dd/MM/yyyy}", FontSize = 12, Margin = new Thickness(0, 2, 0, 2) });
            mainStack.Children.Add(new TextBlock { Text = $"Hora de Emisión: {DateTime.Now:hh:mm:ss tt}", FontSize = 12, Margin = new Thickness(0, 2, 0, 2) });
            mainStack.Children.Add(new TextBlock { Text = "Estado del Turno: CERRADO / ARCHIVADO", FontSize = 12, FontWeight = FontWeights.Bold, Foreground = Brushes.DarkGreen, Margin = new Thickness(0, 2, 0, 30) });

            // Título de Sección Finanzas
            mainStack.Children.Add(new TextBlock { Text = "DESGLOSE DE INGRESOS (CAJA)", FontSize = 16, FontWeight = FontWeights.Bold, Foreground = Brushes.DimGray, Margin = new Thickness(0, 10, 0, 10) });

            // Tabla / Filas de contenido financiero
            mainStack.Children.Add(CrearFilaReporte("(+) Recaudado en Efectivo:", $"$ {efectivo:F2}", false));
            mainStack.Children.Add(CrearFilaReporte("(+) Recaudado en Tarjeta:", $"$ {tarjeta:F2}", false));

            mainStack.Children.Add(new System.Windows.Shapes.Line { X1 = 0, X2 = 716, Stroke = Brushes.LightGray, StrokeThickness = 1, Margin = new Thickness(0, 10, 0, 10) });
            mainStack.Children.Add(CrearFilaReporte("TOTAL GENERAL EN CAJA:", $"$ {total:F2}", true));

            // Sección de Visitantes
            mainStack.Children.Add(new TextBlock { Text = "FLUJO DE VISITAS", FontSize = 16, FontWeight = FontWeights.Bold, Foreground = Brushes.DimGray, Margin = new Thickness(0, 30, 0, 10) });
            mainStack.Children.Add(CrearFilaReporte("Total de Boletos Emitidos:", $"{boletos} Unidades", false));

            // Pie de página institucional
            mainStack.Children.Add(new TextBlock
            {
                Text = "Este documento constituye un registro financiero protegido generado directamente por el sistema de administración BDMUSEO.",
                FontSize = 10,
                FontStyle = FontStyles.Italic,
                Foreground = Brushes.DarkGray,
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(0, 150, 0, 0)
            });

            // Ensamble del documento WPF
            fixedPage.Children.Add(mainStack);
            ((IAddChild)pageContent).AddChild(fixedPage);
            fixedDoc.Pages.Add(pageContent);

            // Asignar el documento generado al visor de la pantalla
            dvVisor.Document = fixedDoc;
        }

        // Función auxiliar para maquetar renglones alineados
        private Grid CrearFilaReporte(string concepto, string valor, bool esTotal)
        {
            Grid fila = new Grid { Margin = new Thickness(0, 5, 0, 5) };
            fila.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            fila.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            TextBlock txtConcepto = new TextBlock { Text = concepto, FontSize = esTotal ? 16 : 13, FontWeight = esTotal ? FontWeights.Bold : FontWeights.Normal };
            TextBlock txtValor = new TextBlock { Text = valor, FontSize = esTotal ? 16 : 13, FontWeight = esTotal ? FontWeights.Bold : FontWeights.Normal, HorizontalAlignment = HorizontalAlignment.Right };

            if (esTotal) txtValor.Foreground = new SolidColorBrush(Color.FromRgb(16, 124, 65)); // Verde Dinero

            Grid.SetColumn(txtConcepto, 0);
            Grid.SetColumn(txtValor, 1);

            fila.Children.Add(txtConcepto);
            fila.Children.Add(txtValor);

            return fila;
        }

        // OPERACIÓN DE GUARDADO (Si el usuario decide conservarlo)
        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // 1. Configurar el cuadro de diálogo para guardar el PDF
                Microsoft.Win32.SaveFileDialog dialogoSaved = new Microsoft.Win32.SaveFileDialog();
                dialogoSaved.Filter = "Documento PDF (*.pdf)|*.pdf";
                dialogoSaved.FileName = $"CorteCaja_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                dialogoSaved.Title = "Selecciona dónde guardar el reporte PDF";

                if (dialogoSaved.ShowDialog() == true)
                {
                    // Ocultamos temporalmente los botones de la ventana para que no salgan pintados en el PDF
                    BtnGuardar.Visibility = Visibility.Collapsed;
                    BtnCerrar.Visibility = Visibility.Collapsed;

                    try
                    {
                        // 2. Usar el PrintDialog integrado de Windows en modo silencioso apuntando a un archivo
                        PrintDialog dialogoImpresion = new PrintDialog();

                        // Configurar la hoja en tamaño Carta estándar
                        dialogoImpresion.PrintTicket.PageMediaSize = new System.Printing.PageMediaSize(System.Printing.PageMediaSizeName.NorthAmericaLetter);

                        // Buscamos la cola de impresión nativa de PDF de Windows de forma directa
                        using (var servidor = new System.Printing.LocalPrintServer())
                        {
                            var colas = servidor.GetPrintQueues(new[] { System.Printing.EnumeratedPrintQueueTypes.Local });
                            foreach (var cola in colas)
                            {
                                if (cola.Name.Contains("Microsoft Print to PDF"))
                                {
                                    dialogoImpresion.PrintQueue = cola;
                                    break;
                                }
                            }
                        }

                        // Mandamos a exportar el documento visual que está cargado en tu visor
                        dialogoImpresion.PrintDocument((dvVisor.Document as System.Windows.Documents.FixedDocument).DocumentPaginator, "Corte de Caja");

                        MessageBox.Show("¡Reporte PDF exportado y guardado con éxito!", "PDF Generado", MessageBoxButton.OK, MessageBoxImage.Information);
                        this.Close();
                    }
                    finally
                    {
                        // Volvemos a hacer visibles los botones por si algo falla o se cancela
                        BtnGuardar.Visibility = Visibility.Visible;
                        BtnCerrar.Visibility = Visibility.Visible;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un detalle al estructurar el PDF: " + ex.Message +
                                "\n\nTip: Asegúrate de tener activa la característica opcional 'Microsoft Print to PDF' en tu panel de Windows.",
                                "Error de Exportación", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Cierra el Popup sin hacer nada más
        }
    }
}
