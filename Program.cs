using HID_Report_Descriptor_Editor.Forms;
using HID_Report_Descriptor_Editor.Items;
using HID_Report_Descriptor_Editor.Properties;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace HID_Report_Descriptor_Editor
{
    static class Program
    {
        public const string FileExtension = ".hid";
        public const string CmdLinePrefix = "--";
        public const string UrlRepository = "https://bitbucket.org/MrWinston34/hid_report_descriptor_editor/";

        [STAThread]
        static void Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ParseCommandLine(args);
        }

        private static void ParseCommandLine(string[] args)
        {
            if (args.Length == 0)
            {
                Application.Run(new MainForm());
            }
            else
            {
                if (args.Where(s => s[0] == '-' && s[1] == '-').Count() == 0)
                {
                    var filename = args[0];
                    if (IsFileValid(filename))
                        Application.Run(new MainForm(filename));
                }
                else
                {
                    var pos = -1;
                    if (CheckParam(args, "h", "help", out pos) || CheckParam(args, "help", out pos, null))
                    {
                        var fmt = "{0,6} {1} | {2,-10} {3}\r\n";
                        var builder = new StringBuilder();
                        builder.AppendLine(Resources.CmdHintCaption);
                        builder.AppendLine();
                        builder.AppendFormat(fmt, CmdLinePrefix, "h", "help", Resources.CmdHintHelp);
                        builder.AppendFormat(fmt, CmdLinePrefix, "l", "language", Resources.CmdHintLanguage);
                        builder.AppendFormat(fmt, CmdLinePrefix, "e", "export", Resources.CmdHintExport);
                        var dlg = new CmdArgsHelpForm()
                        {
                            Text = Application.ProductName,
                            Caption = builder.ToString()
                        };
                        dlg.ShowDialog();
                    }
                    else if (CheckParam(args, "l", "language", out pos))
                    {
                        try
                        {
                            if (args.Length > pos)
                            {
                                var culture = System.Globalization.CultureInfo.GetCultureInfo(args[pos + 1]);
                                Thread.CurrentThread.CurrentCulture = culture;
                                Thread.CurrentThread.CurrentUICulture = culture;
                            }
                        }
                        catch (Exception)
                        {
                        }
                        Application.Run(new MainForm());
                    }
                    else if (CheckParam(args, "e", "export", out pos))
                    {
                        try
                        {
                            var hidFile = args[pos + 1];
                            var hdrFile = args[pos + 2];

                            if (IsFileValid(hidFile))
                            {
                                var ext = Path.GetExtension(hdrFile);
                                if (ext == ".h" || ext == ".hpp")
                                {
                                    var reportItems = MainForm.Open(hidFile);
                                    Export(reportItems, hdrFile);
                                }
                                else
                                    MessageBox.Show(string.Format(Resources.FileTypeNotSupported, ext), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception)
                        {
                            // TODO Not defined hid file
                            MessageBox.Show("Not defined hid file and/or header file.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        static bool IsFileValid(string filename)
        {
            if (File.Exists(filename))
            {
                var ext = Path.GetExtension(filename);
                if (ext == FileExtension)
                {
                    return true;
                }
                else
                    MessageBox.Show(string.Format(Resources.FileTypeNotSupported, ext), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(string.Format(Resources.FileNotExist, filename), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        static bool CheckParam(string[] args, string longName, out int position, string key = CmdLinePrefix)
        {
            return CheckParam(args, null, longName, out position, key);
        }

        static bool CheckParam(string[] args, string shortName, string longName, out int position, string key = CmdLinePrefix)
        {
            if (key == null)
            {
                key = string.Empty;
            }

            if (shortName != null)
            {
                var _short = key + shortName;
                if (args.Contains(_short))
                {
                    position = Array.IndexOf(args, _short);
                    return true;
                }
            }

            if (longName != null)
            {
                var _long = key + longName;
                if (args.Contains(_long))
                {
                    position = Array.IndexOf(args, _long);
                    return true;
                }
            }

            position = -1;
            return false;
        }

        public static void Export(HIDReportItemCollection reportItems, string filename)
        {
            MessageBox.Show(Resources.NotImplemented, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            /*
            int size = reportItems.Sum(i => i.GetBytes().Length);
            var def = Path.GetFileName(filename).ToUpper().Replace(' ', '_').Replace('.', '_');

            var content = "\n";
            content += $"#ifndef {def}\n";
            content += $"#define {def}\n";
            content += $"\n";
            content += $"#include <stdio.h>\n";
            content += $"\n";
            content += $"const uint32_t HID_Report_Descriptor_size = {size}; // bytes\n";
            content += $"\n";
            content += $"const uint8_t HID_Report_Descriptor[{size}] = {{";

            var list = reportItems.ToList();
            foreach (var item in list)
            {
                var index = list.IndexOf(item);
                var bytes = item.GetBytes();
                var line = "\n";
                line = line.PadRight(5, ' ');
                foreach (var b in bytes)
                {
                    line += $"0x{b,2:X2}, ";
                }
                line = line.PadRight(40, ' ');
                line += "// " + ShortItem.1GetDisplayText((IList<ShortItem>)reportItems, index);
                content += line;
            }

            content += $"\n";
            content += $"}};\n";
            content += $"\n";
            //content += $"#endif // {def} \n";

            var writer = new StreamWriter(File.Open(filename, FileMode.Create));
            writer.Write(content);
            writer.Close();
            */
        }
    }
}
