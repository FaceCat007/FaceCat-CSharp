using System;
using System.Collections.Generic;
using System.Text;
using FaceCat;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace encodeex
{
    /// <summary>
    /// ������
    /// </summary>
    public class MainFrame : UIXmlEx
    {
        /// <summary>
        /// ����XML
        /// </summary>
        /// <param name="xmlPath">XML��ַ</param>
        public override void loadFile(String file, FCView parent)
        {
            //Ԥ�����ؼ�
            base.loadFile(file, parent);
        }
    }
}