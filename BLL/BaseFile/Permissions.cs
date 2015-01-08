using System;
using System.ComponentModel;

namespace Hownet.BLL.BaseFile
{
    /// <summary>
    /// 权限设计
    /// </summary>
    public class Permissions
    {
        public enum PermissionsEnum
        {
            /// <summary>
            /// 查看
            /// </summary>
            [Description("查看")]
            V,
            /// <summary>
            /// 编辑
            /// </summary>
            [Description("编辑")]
            E,
            /// <summary>
            /// 添加
            /// </summary>
            [Description("添加")]
            N,
            /// <summary>
            /// 打印
            /// </summary>
            [Description("打印")]
            P,
            /// <summary>
            /// 删除
            /// </summary>
            [Description("删除")]
            D,
            /// <summary>
            /// 审核
            /// </summary>
            [Description("审核")]
            S,
            /// <summary>
            /// 弃审
            /// </summary>
            [Description("弃审")]
            Q,
            /// <summary>
            /// 查看单价
            /// </summary>
            [Description("查看单价")]
            C,
            /// <summary>
            /// 编辑单价
            /// </summary>
            [Description("编辑单价")]
            B,
            [Description("导出Excel")]
            X,
        }
    }
}