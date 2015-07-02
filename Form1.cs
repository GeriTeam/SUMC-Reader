using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using mshtml;
using System.Collections.Generic;
using SUMCreader.sumcdbDataSetTableAdapters;
using System.Data;

namespace SUMCreader
{

    public partial class Mform : Form
    {
        readonly WebBrowser _browser = new WebBrowser();

        public Mform()
        {
            InitializeComponent();
        }

        private void Form1Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sumcdbDataSet.Stations' table. You can move, or remove it, as needed.
            stationsTableAdapter.Fill(this.sumcdbDataSet.Stations);

            const string url = "http://m.sumc.bg/vt";
            _browser.Navigated += BrowserNavigated;
            _browser.DocumentCompleted += BrowserDocumentCompleted;
            _firstLoad = true;
            _browser.Navigate(url);
            

            
        }


        void BrowserDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {       
            
                if (!_firstLoad)
                {

                      flpBuses.Controls.Clear();
                      if (_browser.Document != null)
                       {
                          HtmlElementCollection divs = _browser.Document.GetElementsByTagName("DIV");

                          foreach (HtmlElement del in divs)
                            {
                            flpBuses.Visible = true;
                            if (del.GetAttribute("classname").Equals("arr_info_1"))
                              {
                                  if (del.InnerText.Length > del.InnerText.IndexOf("- ", StringComparison.Ordinal) + 2)
                                  {
                                      string times = del.InnerText.Substring(del.InnerText.IndexOf("- ", StringComparison.Ordinal) + 2, del.InnerText.IndexOf("\r\n", StringComparison.Ordinal) - 3);
                                      string[] timesCol = times.Split(Char.Parse(","));
                                      List<DateTime> TimesD = new List<DateTime>();
                                      foreach (string str in timesCol)
                                      {
                                          try
                                          {
                                              DateTime time = DateTime.Parse(str);
                                              TimesD.Add(time);
                                          }
                                          catch
                                          {

                                          }
                                      }

                                      labelControl vehicle = new labelControl();
                                      vehicle.Text = del.InnerText.Substring(0, del.InnerText.IndexOf(" "));
                                      flpBuses.Controls.Add(vehicle);
                                      labelControl TimesForVehicle = new labelControl();
                                      TimesForVehicle.Text = times;
                                      flpBuses.Controls.Add(TimesForVehicle);
                                  }
                              }

                        }

                    }
                
               

            }
                else
                    _firstLoad = false;

        }
        

        #region Helper Functions
        [ComImport, InterfaceType((short)1), Guid("3050F669-98B5-11CF-BB82-00AA00BDCE0B")]
        private interface IHTMLElementRenderFixed
        {
            void DrawToDC(IntPtr hdc);
            void SetDocumentPrinter(string bstrPrinterName, IntPtr hdc);
        }

        private Bitmap GetImage(HtmlElement el)
        {
            HtmlElement e = el;
            var img = (IHTMLImgElement)e.DomElement;
            var render = (IHTMLElementRenderFixed)img;

            var bmp = new Bitmap(img.width, img.height);
            Graphics g = Graphics.FromImage(bmp);
            IntPtr hdc = g.GetHdc();
            render.DrawToDC(hdc);
            g.ReleaseHdc(hdc);

            return bmp;
        }

        #endregion

        void BrowserNavigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (_browser.Document != null)
            {
                try
                {
                    Bitmap b = GetImage(_browser.Document.Images[1]);
                    ValuePicture.Image = b;
                }
                catch
                {

                }
                
            }
            rtbWebCode.Text = _browser.DocumentText.ToString(CultureInfo.InvariantCulture);
        }

        private void Button1Click1(object sender, EventArgs e)
        {
            if (_browser.Document != null)
            {
                HtmlElementCollection inputs = _browser.Document.GetElementsByTagName("input");
                foreach (HtmlElement item in inputs)
                {
                    if (item.GetAttribute("name").Equals("q"))
                    {
                        item.SetAttribute("value", edtStationNumber.SelectedValue.ToString());
                    }
                
                    if (item.GetAttribute("name").Equals("sc"))
                    {
                        
                        item.SetAttribute("value", edtvalue.Text);
                    }
                    else
                    {
                        if (edtvalue.Text.Length == 3)
                        {
                            edtvalue.Visible = false;
                            lblValue.Visible = false;
                            ValuePicture.Visible = false;
                            Width = 225;
                        }
                        else
                        {
                            MessageBox.Show("Моля въведете контролните символи.");
                            break;
                        }
                        
                    } 
                }
            }
            ClickButton("sumbit");                                 
        }

        private void Label1Click(object sender, EventArgs e)
        {

        }

        private void EdtStationNumberValueMemberChanged(object sender, EventArgs e)
        {

            
        }

        private void EdtStationNumberTextChanged(object sender, EventArgs e)
        {

        }

        private void ClickButton(string attName = null)
        {
            if (attName == null) throw new ArgumentNullException("attName");
            if (_browser.Document != null)
            {
                HtmlElementCollection col = _browser.Document.GetElementsByTagName("input");
                foreach (HtmlElement element in col)
                {
                    if (element.GetAttribute("name").Equals(""))
                    {
                        element.InvokeMember("click");   // Invoke the "Click" member of the button
                    }
                }
            }
        }

        private void stationsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }

    public class SpirkaInfo
    {
        //private readonly int _VType;
        //private readonly string _VNumber;
        private readonly int _sprikaNumber;
        public SpirkaInfo(/*int Vtype, string VNumber,*/ int sprikaNumber)
        {
            //_VNumber = VNumber;
            //_VType = Vtype;
            _sprikaNumber = sprikaNumber;
        }

        public string Naimenovanie
        {
            get
            {
                using (StationsTableAdapter ta = new StationsTableAdapter())
                {
                    DataTable dt = ta.GetDataStationByID(_sprikaNumber);
                    return dt.Rows[0]["NAIMENOVANIE"] == DBNull.Value ? "" : dt.Rows[0]["NAIMENOVANIE"].ToString();
                }
                
            }
        }

        public int SpirkaNumber
        {
            get
            {
                return _sprikaNumber;
            }
        }
    }
}
