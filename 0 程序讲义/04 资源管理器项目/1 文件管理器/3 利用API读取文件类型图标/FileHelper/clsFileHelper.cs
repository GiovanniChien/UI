using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Tools
{
    public class clsFileHelper
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;         // 文件的图标句柄!!!
            public int iIcon;            // 图标的系统索引号
            public uint dwAttributes;    // 文件的属性值
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName; 
            public const int NAMESIZE = 80;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = NAMESIZE)]
            public string szTypeName;   //文件的类型名!!!
        };
        private const uint SHGFI_TYPENAME = 0x400;
        private const uint SHGFI_ICON = 0x100;
        private const uint SHGFI_LARGEICON = 0x0;    // 大图标
        private const uint SHGFI_SMALLICON = 0x1;    // 小图标

        [DllImport("Shell32.dll")]
        private static extern IntPtr SHGetFileInfo(
            string pszPath,          // 指定的文件名
            uint dwFileAttributes,   // 文件属性
            ref SHFILEINFO psfi,
            uint cbFileInfo,
            uint uFlags
        );

        public static Icon GetFileIcon(string filename)
        {
            SHFILEINFO shinfo = new SHFILEINFO();
            IntPtr hImgSmall;
            hImgSmall = SHGetFileInfo(filename, 0, ref shinfo,
                             (uint)Marshal.SizeOf(shinfo),
                              SHGFI_ICON | SHGFI_SMALLICON | SHGFI_TYPENAME);

            if (hImgSmall.ToInt32() != 0)  //如果调用SHGetFileInfo成功
                return Icon.FromHandle(shinfo.hIcon); // 从SHFILEINFO结构中获取图标
            else
                return null;
        }
        
        public static string GetFileType(string filename)
        {
            SHFILEINFO shinfo = new SHFILEINFO();
            IntPtr hImgSmall = SHGetFileInfo(filename, 0, ref shinfo,
                               (uint)Marshal.SizeOf(shinfo),
                               SHGFI_ICON | SHGFI_SMALLICON | SHGFI_TYPENAME);
            if (hImgSmall.ToInt32() != 0)    //如果调用SHGetFileInfo成功
                return shinfo.szTypeName;    //获取文件类型
            else
                return  "";
        }
    }
}
