﻿using Mall3s.Dependency;
using System.ComponentModel;

namespace Mall3s.Common.Enum
{
    /// <summary>
    /// 通知公告用户状态
    /// </summary>
    [SuppressSniffer]
    public enum NoticeUserStatus
    {
        /// <summary>
        /// 未读
        /// </summary>
        [Description("未读")]
        UNREAD = 0,

        /// <summary>
        /// 已读
        /// </summary>
        [Description("已读")]
        READ = 1
    }
}
