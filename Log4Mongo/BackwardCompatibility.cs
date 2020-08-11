using System;
using System.Collections;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using log4net.Core;
using log4net.Util;
using System.Collections.Generic;

namespace Log4Mongo
{
	public class BackwardCompatibility
	{
		/// <summary>
		/// 可以根据需要构建记录的日志内容
		/// </summary>
		/// <param name="loggingEvent"></param>
		/// <returns></returns>
		public static BsonDocument BuildBsonDocument(LoggingEvent loggingEvent)
		{
			if(loggingEvent == null)
			{
				return null;
			}

			BsonDocument toReturn = loggingEvent.MessageObject.ToBsonDocument();
			toReturn.Add("ThreadId", loggingEvent.ThreadName);

			// exception information
			if (loggingEvent.ExceptionObject != null)
			{
				toReturn.Add("Exception", BuildExceptionBsonDocument(loggingEvent.ExceptionObject));
			}

			// properties
			PropertiesDictionary compositeProperties = loggingEvent.GetProperties();
			if(compositeProperties != null && compositeProperties.Count > 0)
			{
				var properties = new BsonDocument();
				foreach(DictionaryEntry entry in compositeProperties)
				{
					properties.Add(entry.Key.ToString(), entry.Value.ToString());
				}

				toReturn.Add("Properties", properties);
			}

			return toReturn;
		}

		private static BsonDocument BuildExceptionBsonDocument(Exception ex)
		{
			var toReturn = new BsonDocument {
				{"Message", ex.Message}, 
				{"Source", ex.Source}, 
				{"StackTrace", ex.StackTrace}
			};

			if(ex.InnerException != null)
			{
				toReturn.Add("InnerException", BuildExceptionBsonDocument(ex.InnerException));
			}

			return toReturn;
		}
	}
}