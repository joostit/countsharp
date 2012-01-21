using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrrrBayBay.CountSharp
{
	public class LineCount
	{

		public long Total
		{
			get
			{
				return Code + Empty + TotalComments;
			}
		}

		private long code = 0;
		private long empty = 0;
		private long standardComments = 0;
		private long xmlComments = 0;
	
		

		public long Code
		{
			get
			{
				return code;
			}
		}

		public long Empty
		{
			get
			{
				return empty;
			}
		}

		

		public long StandardComments
		{
			get
			{
				return standardComments;
			}
		}

		public long XmlComments
		{
			get
			{
				return xmlComments;
			}
		}

		public long TotalComments
		{
			get
			{
				return standardComments + xmlComments;
			}
		}

		public LineCount()
		{

		}


		public void addCodeLine()
		{
			code++;
		}

		public void addEmptyLine()
		{
			empty++;
		}

		public void addXmlComment()
		{
			xmlComments++;
		}

		public void addStandardComments()
		{
			standardComments++;
		}


		public double getPercentOfTotal(long lines)
		{
			return (((double)lines) / ((double)Total)) * 100.0;

		}



	}
}
