
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Data.Sql;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using System.Windows;


namespace tray
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private readonly IMessageService _iMessageService;
		
	    // Подключение библиотек WIN
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
        
        // Контент
        private string content = "";
        private string buffer1 = "";
        
        
        // дескриптор окна
        private IntPtr nextClipboardViewer;
        
        // Константы
        public const int WM_DRAWCLIPBOARD = 0x308;
        public const int WM_CHANGECBCHAIN = 0x030D;
        
         public MainForm()
        {
            InitializeComponent();
            
            //===================================
          nextClipboardViewer = (IntPtr)SetClipboardViewer((IntPtr)this.Handle);
          reload_tray(); // Обноавляемменю в трее
          //  reload_list_clipboard(); // Обновляем ListBox
          //  _notifyIcon.Text = VirtualClipBoard_Name;
         //    _notifyIcon.MouseDoubleClick += new MouseEventHandler(_notifyIcon_MouseDoubleClick);
            //==================================
            tb_Content.Focus();
        }
		
         
        
        //
        private void SetContent()
        {
        	     	
        	if(Clipboard.GetText() != ""  && buffer1 != Clipboard.GetText() )
            {
        	buffer1= Clipboard.GetText();	
            content= Clipboard.GetText() + tb_AddSymbol.Text + Environment.NewLine + content  ;
            //Clipboard.SetText(content);
            }
           // else content ="";
            
            tb_Content.Text= content;
            Tb_ContentTextChanged(this , EventArgs.Empty );
            //tssl_SymbolCount.Text="0";
            //tssl_LineCount.Text="0";
            
        }
        
        // Метод для реагирование на изменение вбуфере обмена и т.д.
        protected override void WndProc(ref Message m)
        {
            // Console.WriteLine("WndProc");
            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    {
                        SetContent();
                        //tb_Content.Text= Clipboard.GetText();
                    
                       // ClipboardChanged();
                        //Console.WriteLine("WM_DRAWCLIPBOARD ClipboardChanged();");
                        SendMessage(nextClipboardViewer, WM_DRAWCLIPBOARD, m.WParam, m.LParam);
                        break;
                    }
                case WM_CHANGECBCHAIN:
                    {
                        if (m.WParam == nextClipboardViewer)
                        {
                            nextClipboardViewer = m.LParam;
                        }
                        else
                        {
                            SendMessage(nextClipboardViewer, WM_CHANGECBCHAIN, m.WParam, m.LParam);
                        }
                        m.Result = IntPtr.Zero;
                        break;
                    }
                default:
                    {
                        base.WndProc(ref m);
                        //Console.WriteLine("Файл истории: " + VirtualClipBoard_DAT);
                        break;
                    }
            }
        }
        
        // очистить поле и буфер обмена
		void B_ClearClick(object sender, EventArgs e)
		{
			Clipboard.Clear();
			tb_Content.Text="";
		}
		
		// копировать результат в буфер
		void B_CopyClick(object sender, EventArgs e)
		{

			
			try 
            {
                
			string s = tb_Content.Text;
			
			if(tb_Content.Text !="") Clipboard.SetText(tb_Content.Text );
			
			tb_Content.Text= s;	
			
				
            }
            catch (Exception ex)
            {
            	_iMessageService.ShowError(ex.Message);
            }
		}
		
				
		
		// Перезагрузка элементов для трей
        private void reload_tray()
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem menuItem;

          //  int free_slot_to_tray = Properties.Settings.Default.size_tray;
           // var list = VirtualClipBoard_History.OrderByDescending(x => x.Key);
           // foreach (var item in list)
           
                menuItem = new ToolStripMenuItem();
                menuItem.Tag = 1;
                if (tb_Content.Text.Length > 60)
                {
                    menuItem.Text = tb_Content.Text.Replace("\n", "\t").Replace("\r", "\t").Substring(0, 60);
                } else {
                    menuItem.Text = tb_Content.Text.Replace("\n", "\t").Replace("\r", "\t");
                }
                
              //  menuItem.Click += new System.EventHandler(menu_item_click);
                contextMenu.Items.Add(menuItem);
             //   if (free_slot_to_tray == 1) { break; } else { free_slot_to_tray--; }
           

            // Разделитель
            contextMenu.Items.Add(new ToolStripSeparator());

            // Свернуть/Развернуть
            menuItem = new ToolStripMenuItem();
            menuItem.Text = "Настройки";
            //menuItem.Click += new System.EventHandler(menu_item_config);
            contextMenu.Items.Add(menuItem);

            // Выход из программы
            menuItem = new ToolStripMenuItem();
            menuItem.Text = "Выход";
            //menuItem.Click += new System.EventHandler(exit_Click);
            contextMenu.Items.Add(menuItem);

            ni_Tray.ContextMenuStrip = contextMenu;
        }
		void Tb_ContentTextChanged(object sender, EventArgs e)
		{
			tssl_SymbolCount.Text= tb_Content.Text.Length.ToString();
			
			if(tb_Content.Text.Length.ToString()!= "0")
			tssl_LineCount.Text = tb_Content.Text.Split('\n').Length.ToString();
			else tssl_LineCount.Text="0";
			//Environment.NewLine
		
		}
		
	}
}
