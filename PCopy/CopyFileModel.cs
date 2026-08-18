using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCopy
{
    public class CopyFileModel
    {

        /// <summary>
        /// 列表ID
        /// </summary>
        public int listID { get; set; }

        /// <summary>
        /// 源文件
        /// </summary>
        public string SrcFile { get; set; }

        /// <summary>
        /// 源文件最后修改时间
        /// </summary>
        public string SrcLastTime { get; set; }

        /// <summary>
        /// 源文件大小
        /// </summary>
        public int SrcFileSize { get; set; }
    
        /// <summary>
        /// 目标文件
        /// </summary>
        public string TargetFile { get; set; }

        /// <summary>
        /// 目标文件最后修改时间
        /// </summary>
        public string TLastTime { get; set; }

        /// <summary>
        /// 目标文件大小
        /// </summary>
        public int TFileSize { get; set; }

    }
}
