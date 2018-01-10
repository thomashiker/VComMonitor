using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Drawing;
using MetroFramework.Components;
using MetroFramework.Interfaces;
using MetroFramework.Native;
using MetroFramework.Controls;
using System.Runtime.InteropServices;
using System.IO.Ports;
using WMI_Hardware;
using System.Management;

namespace VComMonitor
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            portlist_init();
        }

        private void VComAdd(string com)
        {
            for (int i = 0; i < PortStateGrid.RowCount; i++)
            {
                if (PortStateGrid.Rows[i].Cells[0].Value.Equals(com))
                {
                    return;
                }
            }

            int index = PortStateGrid.Rows.Add();
            PortStateGrid.Rows[index].Cells[0].Value = com;
            PortStateGrid.Rows[index].Cells[0].ToolTipText = com;
        }

        private void VComRemove(string com)
        {
            for (int i = 0; i < PortStateGrid.RowCount; i++)
            {
                if (PortStateGrid.Rows[i].Cells[0].Value.Equals(com))
                {
                    //PortStateGrid.Rows[i].SetValues
                    PortStateGrid.Rows.RemoveAt(i);
                    return;
                }
            }
        }

        private void portlist_init()
        {
            string[] ports = SerialPort.GetPortNames();

            foreach (string name in ports)
            {
                portListToolStripMenuItem.DropDownItems.Add(name);
            }

            foreach (string name in ports)
            {
                int index = PortStateGrid.Rows.Add();
                PortStateGrid.Rows[index].Cells[0].Value = name;
                PortStateGrid.Rows[index].Cells[0].ToolTipText = name;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            /*this.BeginInvoke(new Action(() => {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }));*/
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Normal)
            //{
            //    this.WindowState = FormWindowState.Minimized;
            //    this.Hide();
            //}
            //else if (this.WindowState == FormWindowState.Minimized)
            //if (this.WindowState == FormWindowState.Minimized)
            //{
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            //}
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (e.CloseReason == CloseReason.UserClosing)//当用户点击窗体右上角X按钮或(Alt + F4)时 发生          
            //{
            //    e.Cancel = true;
            //    this.ShowInTaskbar = false;
            //    this.Hide();
            //}
            if (DialogResult.OK == MetroMessageBox.Show(this, "close ?", "close", MessageBoxButtons.OKCancel, 100))
            {

            }
            else
            {
                e.Cancel = true;
                this.Hide();
            }
        }


        // usb消息定义
        public const int WM_DEVICE_CHANGE = 0x219;
        public const int DBT_DEVICEARRIVAL = 0x8000;
        public const int DBT_DEVICE_REMOVE_COMPLETE = 0x8004;
        public const UInt32 DBT_DEVTYP_PORT = 0x00000003;

        //[StructLayout(LayoutKind.Sequential)]
        struct DEV_BROADCAST_HDR
        {
            public UInt32 dbch_size;
            public UInt32 dbch_devicetype;
            public UInt32 dbch_reserved;
        }

        struct DEV_BROADCAST_PORT
        {
            public uint dbcp_size;
            public uint dbcp_devicetype;
            public uint dbcp_reserved;
            //public char dbcp_name[1];
        }

        struct DEV_BROADCAST_VOLUME
        {
            public uint dbcv_size;
            public uint dbcv_devicetype;
            public uint dbcv_reserved;
            public uint dbcv_unitmask;
            public uint dbcv_flags;
        }

        struct GUID
         {
            public UInt64 Data1;
            public short Data2;
            public short Data3;
            public UInt64 Data4;
        }

        struct DEV_BROADCAST_DEVICEINTERFACE
        {
            public uint dbcc_size;
            public uint dbcc_devicetype;
            public uint dbcc_reserved;
            //GUID dbcc_classguid;
            //TCHAR dbcc_name[1];
        }


        /// <summary>
        /// 检测USB串口的拔插
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            //DEV_BROADCAST_HDR *lpdb = (DEV_BROADCAST_HDR*)m.LParam;
            //DEV_BROADCAST_VOLUME *lpdbv = (DEV_BROADCAST_VOLUME*)lpdb;

            if (m.Msg == WM_DEVICE_CHANGE)        // 捕获USB设备的拔出消息WM_DEVICECHANGE
            {
                DEV_BROADCAST_HDR dbhdr;
                switch (m.WParam.ToInt32())
                {
                    case DBT_DEVICE_REMOVE_COMPLETE:    // USB拔出     
                        dbhdr = (DEV_BROADCAST_HDR)Marshal.PtrToStructure(m.LParam, typeof(DEV_BROADCAST_HDR));
                        if (dbhdr.dbch_devicetype == DBT_DEVTYP_PORT)
                        {
                            string portName = Marshal.PtrToStringUni((IntPtr)(m.LParam.ToInt32() + Marshal.SizeOf(typeof(DEV_BROADCAST_PORT))));
                            //SysNotify.ShowBalloonTip(3000, "info", portName + " removed\n", ToolTipIcon.Info);
                            richTextBox1.AppendText(portName + " removed\n");
                            VComRemove(portName);

                            portName = Marshal.PtrToStringUni((IntPtr)(m.LParam.ToInt32() + Marshal.SizeOf(typeof(DEV_BROADCAST_PORT)) + 10));
                            richTextBox1.AppendText(portName);
                        }
                        break;
                    case DBT_DEVICEARRIVAL:             // USB插入获取对应串口名称
                        dbhdr = (DEV_BROADCAST_HDR)Marshal.PtrToStructure(m.LParam, typeof(DEV_BROADCAST_HDR));
                        if (dbhdr.dbch_devicetype == DBT_DEVTYP_PORT)
                        {
                            string portName = Marshal.PtrToStringUni((IntPtr)(m.LParam.ToInt32() + Marshal.SizeOf(typeof(DEV_BROADCAST_PORT))));
                            //SysNotify.ShowBalloonTip(3000, "info", portName + " inserted\n", ToolTipIcon.Info);
                            richTextBox1.AppendText(portName + " inserted\n");
                            VComAdd(portName);
                        }
                        break;
                }
            }
            base.WndProc(ref m);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Connection wmiConnection = new Connection();
            //
            //Win32_SerialPort aa = new Win32_SerialPort(wmiConnection);
            //
            //
            //foreach (string property in aa.GetPropertyValues())
            //{
            //    richTextBox1.AppendText(property + "\n");
            //}
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity");//Win32_SerialPort
            foreach (ManagementObject obj in searcher.Get())
            {
                // loop until you find the driver you're looking for (Hopefully you can distinguish this by the DeviceName, DriverName or FriendlyName)
                //string version = obj.GetPropertyValue("DriverVersion").ToString();

                string propKey = "Name";

                if (null != obj)
                {
                    if (null != obj.Properties[propKey])
                    {
                        if (null != obj.Properties[propKey].Value)
                        {
                            string drv = obj.Properties[propKey].Value.ToString();
                            richTextBox1.AppendText(drv + "\n");

                            //if (obj.Properties[propKey].Value.ToString().Contains("COM"))
                            //{
                                
                                richTextBox2.AppendText(obj.Properties[propKey].Value.ToString() + "\n");
                                richTextBox2.AppendText(obj.GetPropertyValue("Description") + "\n");
                                richTextBox2.AppendText(obj.GetPropertyValue("Caption") + "\n");
                                richTextBox2.AppendText(obj.GetPropertyValue("ClassGuid") + "\n");
                                richTextBox2.AppendText(obj.GetPropertyValue("CompatibleID") + "\n");
                                richTextBox2.AppendText(obj.GetPropertyValue("ConfigManagerUserConfig") + "\n");
                                richTextBox2.AppendText(obj.GetPropertyValue("CreationClassName") + "\n");
                                richTextBox2.AppendText(obj.GetPropertyValue("DeviceID") + "\n");
                                richTextBox2.AppendText(obj.GetPropertyValue("HardwareID") + "\n");
                                richTextBox2.AppendText(obj.GetPropertyValue("InstallDate") + "\n");
                                richTextBox2.AppendText(obj.GetPropertyValue("Manufacturer") + "\n");
                                richTextBox2.AppendText(obj.GetPropertyValue("Name") + "\n");
                                richTextBox2.AppendText(obj.GetPropertyValue("PNPClass") + "\n");
                                richTextBox2.AppendText(obj.GetPropertyValue("PNPDeviceID") + "\n");
                                richTextBox2.AppendText(obj.GetPropertyValue("Present") + "\n");
                                richTextBox2.AppendText(obj.GetPropertyValue("Service") + "\n");
                                richTextBox2.AppendText(obj.GetPropertyValue("Status") + "\n");
                                richTextBox2.AppendText(obj.GetPropertyValue("StatusInfo") + "\n");


                                //foreach (PropertyData property in obj.Properties)
                                //{
                                //    richTextBox2.AppendText("Property:" + property.Name + "\n");
                                //    
                                //
                                //    foreach (QualifierData q in property.Qualifiers)
                                //    {
                                //        richTextBox2.AppendText("\t" + q.Name + "\n");
                                //        richTextBox2.AppendText("\t" + q.Value.ToString() + "\n");
                                //        //Console.WriteLine(
                                //        //    processClass.GetPropertyQualifierValue(
                                //        //    property.Name, q.Name));
                                //        richTextBox2.AppendText("\t" + property.Name + "\n");
                                //    }
                                //
                                //    richTextBox2.AppendText("\n");
                                //}
                            //}
                        }
                        
                    }  
                }  
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.Hide();
        }
    }
}
