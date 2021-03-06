﻿using System;
using System.Data;

namespace Light.Data
{
	abstract class CustomMapping : DataMapping, IJoinTableMapping
	{
		protected CustomMapping (Type type)
			: base (type)
		{
		}

		public abstract object LoadAliasJoinTableData (DataContext context, IDataReader datareader, QueryState queryState, string aliasName);
	}
}

