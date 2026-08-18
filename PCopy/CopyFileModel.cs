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
        public string srcFile { get; set; }

        /// <summary>
        /// 源文件最后修改时间
        /// </summary>
        public string srcLastTime { get; set; }

        /// <summary>
        /// 源文件大小
        /// </summary>
        public string srcFileSize { get; set; }
    
        /// <summary>
        /// 目标文件
        /// </summary>
        public string targetFile { get; set; }

        /// <summary>
        /// 目标文件最后修改时间
        /// </summary>
        public string targetLastTime { get; set; }

        /// <summary>
        /// 目标文件大小
        /// </summary>
        public string targetFileSize { get; set; }

    }
}
