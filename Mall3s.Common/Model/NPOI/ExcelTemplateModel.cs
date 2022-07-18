﻿namespace Mall3s.Common.Model.NPOI
{
    /// <summary>
    /// Excel导出模板
    /// 版 本：V3.0.0
    /// 版 权：Mall3s开发
    /// 作 者：Mall3s开发平台组
    /// 日 期：2017.03.09
    /// </summary>
    public class ExcelTemplateModel
    {
        /// <summary>
        /// 行号
        /// </summary>
        public int row { get; set; }
        /// <summary>
        /// 列号
        /// </summary>
        public int cell { get; set; }
        /// <summary>
        /// 数据值
        /// </summary>
        public string value { get; set; }
    }
}
