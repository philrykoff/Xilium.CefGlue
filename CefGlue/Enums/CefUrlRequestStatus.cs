﻿//
// This file manually written from cef/include/internal/cef_types.h.
// C API name: cef_urlrequest_flags_t.
//
namespace Xilium.CefGlue
{
    using System;

    public enum CefUrlRequestStatus
    {
        /// <summary>
        /// Unknown status.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Request succeeded.
        /// </summary>
        Success,

        /// <summary>
        /// An IO request is pending, and the caller will be informed when it is
        /// completed.
        /// </summary>
        IOPending,

        /// <summary>
        /// Request was successful but was handled by an external program, so there
        /// is no response data. This usually means the current page should not be
        /// navigated, but no error should be displayed.
        /// </summary>
        HandledExternally,

        /// <summary>
        /// Request was canceled programatically.
        /// </summary>
        Canceled,

        /// <summary>
        /// Request failed for some reason.
        /// </summary>
        Failed,
    }
}
