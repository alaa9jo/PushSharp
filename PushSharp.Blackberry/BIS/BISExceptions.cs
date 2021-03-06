﻿using System;
using System.Collections.Generic;

namespace PushSharp.Blackberry
{
	public class BISNotificationSendFailureException : Exception
	{
	    private readonly string _message;
	    private readonly Dictionary<string, object> _data = new Dictionary<string, object>();  
		public BISNotificationSendFailureException(BISMessageStatus msgStatus,string desc)
		{
            _data.Add("HttpStatus", msgStatus.HttpStatus);
            _data.Add("Code", (Int32) msgStatus.NotificationStatus);
            _data.Add("Notification", msgStatus.Notification);
            _data.Add("Description",desc);
            _message = desc;
		}

        public override string Message
        {
            get
            {
                return _message;
            }
        }

        public override System.Collections.IDictionary Data
        {
            get
            {
                return _data;
            }
        }
		public BISMessageStatus MessageStatus
		{
			get;
			set;
		}
	}
}
