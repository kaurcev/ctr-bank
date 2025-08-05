// Piter Gavrinev program.
// Simple and easy code for use and explore.
// free for use in non-commercial

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;


namespace SecHeper
{
    /// <summary>
    /// Это программа - пример создана для получения даных из веб-сервисов Банка России
    /// Free use
    /// </summary>
    public class WSExplorerForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ComboBox Methods;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button button1;
        private Label MethodDescription;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label3;
        private ComboBox Serv_Enum;
        private Label Met_label;
        private Label Serv_label4;
        private Label InfoLbl;
        private CheckBox SaveAsXml;
        private CheckBox SaveRequest;
        private DataGridView ParamGridView;
        private DataGridViewTextBoxColumn gridParamName;
        private DataGridViewTextBoxColumn gridParamValue;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

		public WSExplorerForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.Methods = new System.Windows.Forms.ComboBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.MethodDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Serv_Enum = new System.Windows.Forms.ComboBox();
            this.Met_label = new System.Windows.Forms.Label();
            this.Serv_label4 = new System.Windows.Forms.Label();
            this.InfoLbl = new System.Windows.Forms.Label();
            this.SaveAsXml = new System.Windows.Forms.CheckBox();
            this.SaveRequest = new System.Windows.Forms.CheckBox();
            this.ParamGridView = new System.Windows.Forms.DataGridView();
            this.gridParamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridParamValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParamGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Methods
            // 
            this.Methods.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Methods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Methods.Location = new System.Drawing.Point(23, 111);
            this.Methods.Name = "Methods";
            this.Methods.Size = new System.Drawing.Size(302, 24);
            this.Methods.TabIndex = 0;
            this.Methods.SelectedIndexChanged += new System.EventHandler(this.Methods_SelectedIndexChanged);
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(331, 47);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.Size = new System.Drawing.Size(544, 436);
            this.dataGrid1.TabIndex = 3;
            this.dataGrid1.DataSourceChanged += new System.EventHandler(this.dataGrid1_DataSourceChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Получить >>";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MethodDescription
            // 
            this.MethodDescription.AutoSize = true;
            this.MethodDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MethodDescription.Location = new System.Drawing.Point(19, 10);
            this.MethodDescription.Name = "MethodDescription";
            this.MethodDescription.Size = new System.Drawing.Size(20, 18);
            this.MethodDescription.TabIndex = 5;
            this.MethodDescription.Text = "->";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(12, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 25);
            this.button2.TabIndex = 8;
            this.button2.Text = "Get xsd schema";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 10;
            // 
            // Serv_Enum
            // 
            this.Serv_Enum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Serv_Enum.FormattingEnabled = true;
            this.Serv_Enum.Items.AddRange(new object[] {
            "http://www.cbr.ru/secinfo/secinfo.asmx",
            "http://www.cbr.ru/DailyInfoWebServ/DailyInfo.asmx",
            "http://www.cbr.ru/CoinsBaseWS/CoinsBaseWS.asmx",
            "http://www.cbr.ru/FO_ZoomWS/FinOrg.asmx"});
            this.Serv_Enum.Location = new System.Drawing.Point(23, 63);
            this.Serv_Enum.Name = "Serv_Enum";
            this.Serv_Enum.Size = new System.Drawing.Size(302, 24);
            this.Serv_Enum.TabIndex = 11;
            this.Serv_Enum.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Met_label
            // 
            this.Met_label.AutoSize = true;
            this.Met_label.Location = new System.Drawing.Point(26, 91);
            this.Met_label.Name = "Met_label";
            this.Met_label.Size = new System.Drawing.Size(58, 16);
            this.Met_label.TabIndex = 12;
            this.Met_label.Text = "Методы";
            // 
            // Serv_label4
            // 
            this.Serv_label4.AutoSize = true;
            this.Serv_label4.Location = new System.Drawing.Point(25, 43);
            this.Serv_label4.Name = "Serv_label4";
            this.Serv_label4.Size = new System.Drawing.Size(64, 16);
            this.Serv_label4.TabIndex = 13;
            this.Serv_label4.Text = "Сервисы";
            // 
            // InfoLbl
            // 
            this.InfoLbl.AutoSize = true;
            this.InfoLbl.Location = new System.Drawing.Point(247, 507);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(325, 16);
            this.InfoLbl.TabIndex = 14;
            this.InfoLbl.Text = "Тестовый пример использования Web-сервисов";
            // 
            // SaveAsXml
            // 
            this.SaveAsXml.AutoSize = true;
            this.SaveAsXml.Location = new System.Drawing.Point(19, 463);
            this.SaveAsXml.Name = "SaveAsXml";
            this.SaveAsXml.Size = new System.Drawing.Size(186, 20);
            this.SaveAsXml.TabIndex = 15;
            this.SaveAsXml.Text = "Сохранять ответ как xml";
            this.SaveAsXml.UseVisualStyleBackColor = true;
            // 
            // SaveRequest
            // 
            this.SaveRequest.AutoSize = true;
            this.SaveRequest.Location = new System.Drawing.Point(19, 431);
            this.SaveRequest.Name = "SaveRequest";
            this.SaveRequest.Size = new System.Drawing.Size(195, 20);
            this.SaveRequest.TabIndex = 16;
            this.SaveRequest.Text = "Сохранять запрос как xml";
            this.SaveRequest.UseVisualStyleBackColor = true;
            // 
            // ParamGridView
            // 
            this.ParamGridView.AllowUserToAddRows = false;
            this.ParamGridView.AllowUserToDeleteRows = false;
            this.ParamGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParamGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridParamName,
            this.gridParamValue});
            this.ParamGridView.Location = new System.Drawing.Point(22, 157);
            this.ParamGridView.Name = "ParamGridView";
            this.ParamGridView.RowHeadersWidth = 51;
            this.ParamGridView.RowTemplate.Height = 24;
            this.ParamGridView.Size = new System.Drawing.Size(303, 207);
            this.ParamGridView.TabIndex = 17;
            // 
            // gridParamName
            // 
            this.gridParamName.DataPropertyName = "ParamName";
            this.gridParamName.HeaderText = "Имя параметра";
            this.gridParamName.MinimumWidth = 6;
            this.gridParamName.Name = "gridParamName";
            this.gridParamName.ReadOnly = true;
            this.gridParamName.Width = 125;
            // 
            // gridParamValue
            // 
            this.gridParamValue.DataPropertyName = "ParamValue";
            this.gridParamValue.HeaderText = "Значение";
            this.gridParamValue.MinimumWidth = 6;
            this.gridParamValue.Name = "gridParamValue";
            this.gridParamValue.Width = 125;
            // 
            // WSExplorerForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(887, 532);
            this.Controls.Add(this.ParamGridView);
            this.Controls.Add(this.SaveRequest);
            this.Controls.Add(this.SaveAsXml);
            this.Controls.Add(this.InfoLbl);
            this.Controls.Add(this.Serv_label4);
            this.Controls.Add(this.Met_label);
            this.Controls.Add(this.Serv_Enum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MethodDescription);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.Methods);
            this.Name = "WSExplorerForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParamGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new WSExplorerForm());
		}

		public string ServiceURL;
		private void Form1_Load(object sender, System.EventArgs e)
		{
            Serv_Enum.SelectedIndex = 0;

            ServiceURL = Serv_Enum.Text; // тут получаем адрес сервиса из списка
            DiscoveryWSDL();
            Methods.Text = "";
		}

        private System.Xml.XmlDocument xd; // wsdl сервиса
        private XmlNamespaceManager nm; // схема менаджер
        private string targetNamespace; // targetNamespace веб-сервиса

        // получаем описание метода из названия
        private string GetMethodTitle(string NethodName)
        {
            if (xd == null) return "";
            string title="";
            XmlNode xn = xd.SelectSingleNode("/wsdl:definitions/wsdl:portType/wsdl:operation[@name='" + NethodName + "']/wsdl:documentation", nm);
            if (xn!=null){
                title = xn.InnerText;
            }
            return title;
        }
            

        
        private List<QueryParam> GetQueryParameters(string NethodName)
        {
           var qp = new List<QueryParam>();
           XmlNodeList Params = xd.SelectNodes("/wsdl:definitions/wsdl:types/s:schema/s:element[@name='" + NethodName + "']/s:complexType/s:sequence/s:element", nm);
            for (int i = 0; i < Params.Count; i++)
            {

                string param_type = Params[i].SelectSingleNode("@type").Value;
                string default_value = "someCode";
                if (param_type == "s:dateTime")
                {
                    default_value = System.DateTime.Now.ToString("yyyy-MM-dd");
                }
                if (param_type == "s:boolean")
                {
                    default_value = "false";
                }
                if (param_type == "s:int" || param_type == "s:short" || param_type == "s:unsignedInt" || param_type == "s:unsignedShort")
                {
                    default_value = "0";
                }

                if (param_type == "s:double" || param_type == "s:float")
                {
                    default_value = "0.0";
                }

                var param = new QueryParam()
                {
                    ParamName = Params[i].SelectSingleNode("@name").Value.Trim(),
                    ParamValue = default_value                  

                };

                qp.Add(param);             
               



            }
            return qp;
        }

        

        //****************
        // получаем список доступных методов
        private bool DiscoveryWSDL(){
            try
            {
                Methods.Items.Clear();
               
                xd = new System.Xml.XmlDocument();
                xd.Load(ServiceURL + "?WSDL"); // загружаем wsdl с сервера в XmlDocument



                nm = new XmlNamespaceManager(xd.NameTable);
                nm.AddNamespace("wsdl", "http://schemas.xmlsoap.org/wsdl/");
                nm.AddNamespace("s", "http://www.w3.org/2001/XMLSchema");
                nm.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/");

                nm.PushScope();


                targetNamespace = xd.SelectSingleNode("/wsdl:definitions/@targetNamespace", nm).Value;
                this.Text = xd.SelectSingleNode("/wsdl:definitions/wsdl:service/wsdl:documentation", nm).InnerText +" | WSExplorer v0.3";

                XmlNodeList methods = xd.SelectNodes("/wsdl:definitions/wsdl:types/s:schema/s:element", nm);
                for (int i = 0; i < methods.Count; i++)
                {
                    string met_name = methods[i].SelectSingleNode("@name").Value;
                    if (met_name.IndexOf("Response") == -1)
                    {
                        // добавляем имя метода
                         Methods.Items.Add(met_name);


                    }


                }
               

                
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:" + ex.Message);
                return false;
            }
           
        }

        // формируем SOAP сообщение и посылаем его на сервер, получаем ответ
        private System.Xml.XmlDocument SendSOAPQueryToServer(string ReqString, string method_name, bool SaveToDisk)
        {
            try
            {

                StringBuilder sb = new StringBuilder();
           
                  sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                  sb.AppendLine("<soap:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\">");
                  sb.AppendLine("<soap:Body>");
                  sb.AppendLine("<" + method_name + " xmlns=\"" + targetNamespace + "\">");


                var ds = (List<QueryParam>)ParamGridView.DataSource;
                foreach(var param in ds)
                {
                    sb.AppendLine("<" + param.ParamName + ">" + param.ParamValue + "</" + param.ParamName + ">");

                }                        

             
                  sb.AppendLine("</" + method_name + ">");
                  sb.AppendLine("</soap:Body>");
                  sb.AppendLine("</soap:Envelope>");
              
                if (SaveToDisk)
                {
                    SaveRequestToDisk(ReqString, method_name, sb);
                }

                XmlDocument soap_res = new XmlDocument();
                HttpWebRequest wr = (HttpWebRequest)WebRequest.Create(ReqString);

                wr.ContentType = "text/xml";
                
                string SoapMsg = sb.ToString();

                             
                UTF8Encoding encoding = new UTF8Encoding();
                byte[] byte1 = encoding.GetBytes(SoapMsg);

                wr.Method = "POST";
                wr.Headers.Add("SOAPAction", $"{targetNamespace}{method_name}");
                Stream newStream = wr.GetRequestStream();
                newStream.Write(byte1, 0, byte1.Length);
              
                newStream.Close();



                
                HttpWebResponse response = (HttpWebResponse)wr.GetResponse();

                using (Stream dataStream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(dataStream))
                    {
                        soap_res.LoadXml(reader.ReadToEnd());                     
                        reader.Close();
                    }
                    dataStream.Close();
                }
                response.Close();

                return soap_res;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
                return null;
            }


        }

        private void SaveRequestToDisk(string ReqString, string method_name, StringBuilder sb)
        {
            File.WriteAllText($"{method_name}_Query.xml", sb.ToString());
            // construct curl config file for debug

            StringBuilder sb2 = new StringBuilder();
            sb2.AppendLine("# curl config file");
            sb2.AppendLine($"url = {ReqString} ");
            sb2.AppendLine($"-X POST ");
            sb2.AppendLine($"-H \"Content-Type: text/xml; charset=utf-8\" ");
            sb2.AppendLine($"-H \"SOAPAction: \\\"{targetNamespace}{method_name}\\\"\"");
            sb2.AppendLine($"--data @{method_name}_Query.xml");
            File.WriteAllText($"curlconf_{method_name}.txt", sb2.ToString());

            string curlstr = $"curl -K curlconf_{method_name}.txt -o output_{method_name}.xml\r\npause";
            File.WriteAllText($"{method_name}_QueryCurl.cmd", curlstr.ToString());
        }

        // кнопка получение данных

        private void button1_Click(object sender, System.EventArgs e)
		{
            try
            {
                string met_name = (string)Methods.Text;
                if (met_name == "")
                {
                    InfoLbl.Text = "Необходимо выбрать метод";
                    return;
                }
                // отправляем запрос на сервер и получаем хмл документ в качестве ответа
                XmlDocument ret_xml = SendSOAPQueryToServer(ServiceURL, met_name, SaveRequest.Checked);
                if (ret_xml == null) return;

                if (SaveAsXml.Checked)
                {
                    // сохраняем результат как xml файл
                    string fnm = met_name + "_Response.xml";
                    ret_xml.Save(fnm);
                    InfoLbl.Text = " сохранено св файл:" + fnm;

                }

                // разбираем SOAP ответ и вынимаем нужные данные
                string srr = "/soap:Envelope/soap:Body";
                XmlNode rs = ret_xml.SelectSingleNode(srr, nm);
                rs = rs.FirstChild;
                if (rs != null)
                {
                    if (rs.SelectSingleNode("*/s:schema", nm) != null)
                    {
                        // если есть схема - то это DataSet, паказывае его в таблице
                        XmlReaderSettings settings = new XmlReaderSettings();
                        settings.ConformanceLevel = ConformanceLevel.Fragment;
                        XmlReader reader = XmlReader.Create(new StringReader(rs.InnerXml), settings);
                        System.Data.DataSet sd = new DataSet();
                        sd.ReadXml(reader);
                        dataGrid1.DataSource = sd;
                    }
                    else
                    {
                        // если нет схемы то это простой xml, просто выводим его                        
                        SchemaView sv = new SchemaView();
                        sv.Ext_i = 1;
                        sv.Default_filename = rs.FirstChild.FirstChild.Name + ".xml";
                        sv.EditorBox.Text = rs.FirstChild.InnerXml;
                        sv.ShowDialog();
                       
                    }
                }
                else
                {
                    // странный ответ в случае каких то ошибок
                    SchemaView sv = new SchemaView();
                    sv.Ext_i = 1;
                    sv.Default_filename =  "Error.xml";
                    sv.EditorBox.Text = ret_xml.InnerXml;
                    sv.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ->" + ex.Message);
            }

		}

        private void Methods_SelectedIndexChanged(object sender, EventArgs e)
        {
            // выбор метода

            

            var q_params = GetQueryParameters(Methods.Text.Trim()); // получаем список параметров 
            ParamGridView.DataSource = q_params;

            

            MethodDescription.Text = this.GetMethodTitle((string)Methods.Text.Trim());
            dataGrid1.DataSource = null;
        }

        private void dataGrid1_DataSourceChanged(object sender, EventArgs e)
        {
            if (dataGrid1.DataSource != null)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // получение схемы из DataSet
            if (dataGrid1.DataSource != null)
            {
                System.Data.DataSet ds = (DataSet)dataGrid1.DataSource;
                
                SchemaView sv = new SchemaView();
                sv.Ext_i = 2;
                sv.Default_filename = ds.DataSetName + ".xsd";
                string sx = ds.GetXmlSchema();
                sx=sx.Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                sv.EditorBox.Text = sx;
        
                sv.ShowDialog();
               
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // если дрогой веб-сервис, то получаем его методы
            ServiceURL = Serv_Enum.Text;
            DiscoveryWSDL();
            ParamGridView.DataSource = new List<QueryParam>();
           
        }



	}
}
