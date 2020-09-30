using HID_Report_Descriptor_Editor.Utils;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HID_Report_Descriptor_Editor.Controls
{
    public partial class HexEditor : UserControl
    {
        const int ByteOffset = 1;

        private uint _widthByte;
        private byte[] _data; 

        #region Properties

        [Category("HEX")]
        public Color HeaderForeColor
        {
            get => AddressPanel.ForeColor;
            set
            {
                AddressPanel.ForeColor = value;
                OffsetPanel.ForeColor = value;
                TextHeaderPanel.ForeColor = value;
            }
        }

        public new Font Font
        {
            get => ContentPanel.Font;
            set
            {
                if (value != null)
                {
                    AddressPanel.Font = value;
                    OffsetPanel.Font = value;
                    ContentPanel.Font = value;
                    TextHeaderPanel.Font = value;
                    TextPanel.Font = value;
                }
            }
        }

        public new Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                ContentPanel.ForeColor = value;
                TextPanel.ForeColor = value;
            }
        }

        [Category("HEX")]
        [Description("(in px)")]
        public int HeaderOffset
        {
            get => AddressPanel.Margin.Right;
            set
            {
                AddressPanel.Margin = new Padding(AddressPanel.Margin.Left, AddressPanel.Margin.Top, value, AddressPanel.Margin.Bottom);
                OffsetPanel.Margin = new Padding(OffsetPanel.Margin.Left, OffsetPanel.Margin.Top, OffsetPanel.Margin.Right, value);
                TextHeaderPanel.Margin = new Padding(value, TextHeaderPanel.Margin.Top, TextHeaderPanel.Margin.Right, value);
                TextPanel.Margin = new Padding(value, TextPanel.Margin.Top, TextPanel.Margin.Right, TextPanel.Margin.Bottom);
            }
        }

        [Category("HEX")]
        public uint WidthByte
        {
            get => _widthByte;
            set
            {
                _widthByte = value;
                Refresh();
            }
        }

        [Category("HEX")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public byte[] Data
        {
            get => _data;
            set
            {
                _data = value;
                Refresh();
            }
        }

        #endregion // Properties

        public HexEditor()
        {
            InitializeComponent();

            HeaderOffset = 15;
            WidthByte = 16;

            //AddressPanel.BackColor = Color.LightCoral;
            //OffsetPanel.BackColor = Color.LightCoral;
            //ContentPanel.BackColor = Color.LightCoral;
            //TextHeaderPanel.BackColor = Color.LightCoral;
            //TextPanel.BackColor = Color.LightCoral;

            Refresh();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            Refresh();
        }

        public override void Refresh()
        {
            base.Refresh();

            var byteFormat = "{0,-" + (ByteOffset + 2) + ":X2}";

            var addrBuilder = new StringBuilder();
            var offsetBuilder = new StringBuilder();
            var contentBuilder = new StringBuilder();
            var textBuilder = new StringBuilder();

            if (Data != null && Data.Length > 0)
            {
                for (int offset = 0; offset < WidthByte; offset++)
                {
                    offsetBuilder.AppendFormat(byteFormat, offset);
                }

                var countRows = (int)Math.Ceiling((double)Data.Length / WidthByte);

                for (uint row = 0; row < countRows; row++)
                {
                    var addr = row * WidthByte;

                    addrBuilder.AppendLine(addr.ToString("X4"));

                    var lostOffset = Math.Min(WidthByte, (uint)Data.Length - ((uint)countRows - 1) * WidthByte);
                    for (uint offset = 0; offset < lostOffset; offset++)
                    {
                        var value = Data[addr + offset];
                        contentBuilder.AppendFormat(byteFormat, value);
                    }

                    contentBuilder.AppendLine();

                    var subArray = Data
                        .Skip((int)addr)
                        .Take((int)lostOffset)
                        .ToArray();

                    var str = GetCurrentEncoding().GetString(subArray);
                    textBuilder.AppendLine(str.Replace("\t\r\n", "."));
                }
            }

            AddressPanel.Text = addrBuilder.ToString();
            OffsetPanel.Text = offsetBuilder.ToString();
            ContentPanel.Text = contentBuilder.ToString();
            TextPanel.Text = textBuilder.ToString();
        }

        private Encoding GetCurrentEncoding()
        {
            return new Windows1251();
        }
    }
}