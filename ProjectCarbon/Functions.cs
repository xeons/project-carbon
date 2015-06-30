using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;

namespace ProjectCarbon
{
    public static class Functions
    {
        const string REG_RUN = @"Software\Microsoft\Windows\CurrentVersion\Run";

        public static void SetStartup()
        {
            RegistryKey key = Registry.CurrentUser;
            try
            {
                key = key.OpenSubKey(REG_RUN, true);
                key.SetValue(Application.ProductName,
                    Application.ExecutablePath);
            }
            catch (Exception e)
            {
                //return "error " + e.Message;
                Debug.WriteLine(e.Message);
            }
            finally
            {
                key.Close();
            }
        }

        public static void RemoveStartup()
        {
            RegistryKey key = Registry.CurrentUser;
            try
            {
                key = key.OpenSubKey(REG_RUN, true);
                key.DeleteValue(Application.ProductName);
            }
            catch (ArgumentException e)
            {
                //this just means it didnt exist...
                Debug.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                //return "error " + e.Message;
                Debug.WriteLine(e.Message);
            }
            finally
            {
                key.Close();
            }
        }

        public static string GetHexBlock(byte[] txt)
        {
            int i;
            // disp is the 16-bytes of display
            StringBuilder disp = new StringBuilder();
            // hex is the complete output (hex+disp)
            StringBuilder hex = new StringBuilder();

            for (i = 0; i < txt.Length; i++)
            {
                if (i == 0)
                    hex.Append("0000: ");

                if (i > 0)
                {
                    if (i % 16 == 0)
                    {
                        if (hex.Length > 0)
                        { // end current line
                            hex.Append(" " + disp.ToString() + "\r\n");
                            if (i % 16 == 0)
                                hex.Append(String.Format("{0:X4}: ", (i / 16) * 16));
                            disp.Length = 0;
                        }
                    }
                }
                hex.Append(string.Format("{0:X2} ", txt[i]));
                if (txt[i] >= ' ' && txt[i] <= 127)
                    disp.Append(Convert.ToChar(txt[i]));
                else disp.Append('.');
            }
            // end of text - make sure we end the last line of hex
            if (disp.Length > 0)
            {
                if (disp.Length < 16)
                {
                    for (i = disp.Length; i < 16; i++)
                        hex.Append("   ");
                }
                hex.Append(" " + disp.ToString());
            }
            return hex.ToString();
        }

        public static string GetHexOnly(byte[] txt)
        {
            StringBuilder disp = new StringBuilder();
            for (int i = 0; i < txt.Length; i++)
                disp.Append(String.Format("{0:X2} ", txt[i]));
            return disp.ToString().Trim();
        }

        public static string GetDecBlock(byte[] txt)
        {
            int i;
            // disp is the 16-bytes of display
            StringBuilder disp = new StringBuilder();
            // hex is the complete output (hex+disp)
            StringBuilder hex = new StringBuilder();

            for (i = 0; i < txt.Length; i++)
            {
                if (i == 0)
                    hex.Append("0000: ");

                if (i > 0)
                {
                    if (i % 16 == 0)
                    {
                        if (hex.Length > 0)
                        { // end current line
                            hex.Append(" " + disp.ToString() + "\r\n");
                            if (i % 16 == 0)
                                hex.Append(String.Format("{0:X4}: ", (i / 16) * 16));
                            disp.Length = 0;
                        }
                    }
                }
                hex.Append(string.Format("{0:000} ", txt[i]));
                if (txt[i] >= ' ' && txt[i] <= 127)
                    disp.Append(Convert.ToChar(txt[i]));
                else disp.Append('.');
            }
            // end of text - make sure we end the last line of hex
            if (disp.Length > 0)
            {
                if (disp.Length < 16)
                {
                    for (i = disp.Length; i < 16; i++)
                        hex.Append("    ");
                }
                hex.Append(" " + disp.ToString());
            }
            return hex.ToString();
        }

        public static string GetDecOnly(byte[] txt)
        {
            StringBuilder disp = new StringBuilder();
            for (int i = 0; i < txt.Length; i++)
                disp.Append(txt[i].ToString() + " ");
            return disp.ToString().Trim();
        }

        public static string GetSafeString(byte[] txt)
        {
            StringBuilder disp = new StringBuilder();
            for (int i = 0; i < txt.Length; i++)
                if (txt[i] >= ' ' && txt[i] <= 127 || 
                    (txt[i] == 9 || txt[i] == 10 || txt[i] == 13))
                    disp.Append(Convert.ToChar(txt[i]));
                else
                    disp.Append('.');
            return disp.ToString().Trim();
        }
    }
}
