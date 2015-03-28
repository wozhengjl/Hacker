using ScopeRuntime;
using Microsoft.SCOPE.Types;
using Microsoft.SCOPE.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Runtime.Serialization;
using System.Linq;
using Double.Color.Ball.Common;
using System.Runtime.Versioning;
[assembly:TargetFramework(".NETFramework,Version=v4.5", FrameworkDisplayName = ".NET Framework, Version 4.5")]

public class ___Scope_Generated_Classes___
{
	public static int __RuntimeVersion__ = 0;
	public static int __WriteSStreamVersion__ = 3;
	public static bool __BondIntermediates__ = false;
	private delegate ColumnData ColumnDataCtor();
#region ==BEGIN USER CODE==
#endregion ==END USER CODE==

	public class Row_PeriodNo_String_RedBalls_String : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("PeriodNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls", ColumnDataType.String, typeof(string), null),
		};
		ScopeRuntime.StringColumnData s0_PeriodNo;
		public ScopeRuntime.StringColumnData PeriodNo
		{
			get { return s0_PeriodNo; }
			set
			{
				s0_PeriodNo = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBalls;
		public ScopeRuntime.StringColumnData RedBalls
		{
			get { return s0_RedBalls; }
			set
			{
				s0_RedBalls = value;
				_columns[1] = value;
			}
		}
		public Row_PeriodNo_String_RedBalls_String(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_PeriodNo_String_RedBalls_String(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_PeriodNo_String_RedBalls_String() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_PeriodNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 1:
						s0_RedBalls = (ScopeRuntime.StringColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_PeriodNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (s0_RedBalls.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 2);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			if (!s0_PeriodNo.IsNull())
			{
				s0_PeriodNo.Serialize(writer);
			}
			if (!s0_RedBalls.IsNull())
			{
				s0_RedBalls.Serialize(writer);
			}
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_PeriodNo.Deserialize(reader);
				s0_RedBalls.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				if ((___masking___[0] & 2) != 2)
				{
					s0_PeriodNo.Deserialize(reader);
				}
				else
				{
					s0_PeriodNo.SetNull();
				}
				if ((___masking___[0] & 4) != 4)
				{
					s0_RedBalls.Deserialize(reader);
				}
				else
				{
					s0_RedBalls.SetNull();
				}
			}
		}
	}


	public class Row_RedBallsNo_String_PeriodNo_String_RedBalls_String : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBallsNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("PeriodNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls", ColumnDataType.String, typeof(string), null),
		};
		ScopeRuntime.StringColumnData s0_RedBallsNo;
		public ScopeRuntime.StringColumnData RedBallsNo
		{
			get { return s0_RedBallsNo; }
			set
			{
				s0_RedBallsNo = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_PeriodNo;
		public ScopeRuntime.StringColumnData PeriodNo
		{
			get { return s0_PeriodNo; }
			set
			{
				s0_PeriodNo = value;
				_columns[1] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBalls;
		public ScopeRuntime.StringColumnData RedBalls
		{
			get { return s0_RedBalls; }
			set
			{
				s0_RedBalls = value;
				_columns[2] = value;
			}
		}
		public Row_RedBallsNo_String_PeriodNo_String_RedBalls_String(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_RedBallsNo_String_PeriodNo_String_RedBalls_String(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_RedBallsNo_String_PeriodNo_String_RedBalls_String() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_RedBallsNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 1:
						s0_PeriodNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 2:
						s0_RedBalls = (ScopeRuntime.StringColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_RedBallsNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (s0_PeriodNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 2);
			}
			if (s0_RedBalls.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 3);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			if (!s0_RedBallsNo.IsNull())
			{
				s0_RedBallsNo.Serialize(writer);
			}
			if (!s0_PeriodNo.IsNull())
			{
				s0_PeriodNo.Serialize(writer);
			}
			if (!s0_RedBalls.IsNull())
			{
				s0_RedBalls.Serialize(writer);
			}
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_RedBallsNo.Deserialize(reader);
				s0_PeriodNo.Deserialize(reader);
				s0_RedBalls.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				if ((___masking___[0] & 2) != 2)
				{
					s0_RedBallsNo.Deserialize(reader);
				}
				else
				{
					s0_RedBallsNo.SetNull();
				}
				if ((___masking___[0] & 4) != 4)
				{
					s0_PeriodNo.Deserialize(reader);
				}
				else
				{
					s0_PeriodNo.SetNull();
				}
				if ((___masking___[0] & 8) != 8)
				{
					s0_RedBalls.Deserialize(reader);
				}
				else
				{
					s0_RedBalls.SetNull();
				}
			}
		}
	}


	public class ScopeTransformer_1 : ScopeRuntime.Processor
	{
		public override IEnumerable<Row> Process(RowSet input, Row outputRow, string[] args)
		{
			Row_RedBallsNo_String_PeriodNo_String_RedBalls_String outRow = (Row_RedBallsNo_String_PeriodNo_String_RedBalls_String)outputRow;
			foreach (Row_PeriodNo_String_RedBalls_String row in input.Rows)
			{
				int exceptionIndex = 0;
				try
				{
					StringColumnData col_PeriodNo = row.PeriodNo;
					string col_RedBalls = row.RedBalls.String;

					outRow.RedBallsNo.Set((DCBallHelper.DecodeBalls(col_RedBalls)));
					exceptionIndex++;
					outRow.PeriodNo.Set((col_PeriodNo));
					exceptionIndex++;
					outRow.RedBalls.Set((col_RedBalls));
					exceptionIndex++;
				}
				catch (Exception exception)
				{
					throw new ScopeUserExpressionException(exceptionsInfo[exceptionIndex], row.Dump(), exception);
				}
				yield return outRow;
			} //end of foreach Row_PeriodNo_String_RedBalls_String
		}
		public static string[] exceptionsInfo = 
		{
			@"DCBallHelper.DecodeBalls(RedBalls)",
			@"PeriodNo",
			@"RedBalls",
		};
	}


	public class Row_RedBalls_String_RedBallsNo_String : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBallsNo", ColumnDataType.String, typeof(string), null),
		};
		ScopeRuntime.StringColumnData s0_RedBalls;
		public ScopeRuntime.StringColumnData RedBalls
		{
			get { return s0_RedBalls; }
			set
			{
				s0_RedBalls = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBallsNo;
		public ScopeRuntime.StringColumnData RedBallsNo
		{
			get { return s0_RedBallsNo; }
			set
			{
				s0_RedBallsNo = value;
				_columns[1] = value;
			}
		}
		public Row_RedBalls_String_RedBallsNo_String(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_RedBalls_String_RedBallsNo_String(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_RedBalls_String_RedBallsNo_String() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_RedBalls = (ScopeRuntime.StringColumnData)value;
						break;
					case 1:
						s0_RedBallsNo = (ScopeRuntime.StringColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_RedBalls.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (s0_RedBallsNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 2);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			if (!s0_RedBalls.IsNull())
			{
				s0_RedBalls.Serialize(writer);
			}
			if (!s0_RedBallsNo.IsNull())
			{
				s0_RedBallsNo.Serialize(writer);
			}
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_RedBalls.Deserialize(reader);
				s0_RedBallsNo.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				if ((___masking___[0] & 2) != 2)
				{
					s0_RedBalls.Deserialize(reader);
				}
				else
				{
					s0_RedBalls.SetNull();
				}
				if ((___masking___[0] & 4) != 4)
				{
					s0_RedBallsNo.Deserialize(reader);
				}
				else
				{
					s0_RedBallsNo.SetNull();
				}
			}
		}
	}


	public class Row_RedBalls_String_RedBallsNo_String_partialagg0___Long : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBallsNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("partialagg0__", ColumnDataType.Long, typeof(long), null),
		};
		ScopeRuntime.StringColumnData s0_RedBalls;
		public ScopeRuntime.StringColumnData RedBalls
		{
			get { return s0_RedBalls; }
			set
			{
				s0_RedBalls = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBallsNo;
		public ScopeRuntime.StringColumnData RedBallsNo
		{
			get { return s0_RedBallsNo; }
			set
			{
				s0_RedBallsNo = value;
				_columns[1] = value;
			}
		}
		ScopeRuntime.LongColumnData s0_partialagg0__;
		public ScopeRuntime.LongColumnData partialagg0__
		{
			get { return s0_partialagg0__; }
			set
			{
				s0_partialagg0__ = value;
				_columns[2] = value;
			}
		}
		public Row_RedBalls_String_RedBallsNo_String_partialagg0___Long(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_RedBalls_String_RedBallsNo_String_partialagg0___Long(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_RedBalls_String_RedBallsNo_String_partialagg0___Long() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_RedBalls = (ScopeRuntime.StringColumnData)value;
						break;
					case 1:
						s0_RedBallsNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 2:
						s0_partialagg0__ = (ScopeRuntime.LongColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_RedBalls.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (s0_RedBallsNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 2);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			if (!s0_RedBalls.IsNull())
			{
				s0_RedBalls.Serialize(writer);
			}
			if (!s0_RedBallsNo.IsNull())
			{
				s0_RedBallsNo.Serialize(writer);
			}
			s0_partialagg0__.Serialize(writer);
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_RedBalls.Deserialize(reader);
				s0_RedBallsNo.Deserialize(reader);
				s0_partialagg0__.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				if ((___masking___[0] & 2) != 2)
				{
					s0_RedBalls.Deserialize(reader);
				}
				else
				{
					s0_RedBalls.SetNull();
				}
				if ((___masking___[0] & 4) != 4)
				{
					s0_RedBallsNo.Deserialize(reader);
				}
				else
				{
					s0_RedBallsNo.SetNull();
				}
				s0_partialagg0__.Deserialize(reader);
			}
		}
	}


	public class Row_RedBalls_String_RedBallsNo_String_OneBallCount_Long : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBallsNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("OneBallCount", ColumnDataType.Long, typeof(long), null),
		};
		ScopeRuntime.StringColumnData s0_RedBalls;
		public ScopeRuntime.StringColumnData RedBalls
		{
			get { return s0_RedBalls; }
			set
			{
				s0_RedBalls = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBallsNo;
		public ScopeRuntime.StringColumnData RedBallsNo
		{
			get { return s0_RedBallsNo; }
			set
			{
				s0_RedBallsNo = value;
				_columns[1] = value;
			}
		}
		ScopeRuntime.LongColumnData s0_OneBallCount;
		public ScopeRuntime.LongColumnData OneBallCount
		{
			get { return s0_OneBallCount; }
			set
			{
				s0_OneBallCount = value;
				_columns[2] = value;
			}
		}
		public Row_RedBalls_String_RedBallsNo_String_OneBallCount_Long(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_RedBalls_String_RedBallsNo_String_OneBallCount_Long(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_RedBalls_String_RedBallsNo_String_OneBallCount_Long() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_RedBalls = (ScopeRuntime.StringColumnData)value;
						break;
					case 1:
						s0_RedBallsNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 2:
						s0_OneBallCount = (ScopeRuntime.LongColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_RedBalls.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (s0_RedBallsNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 2);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			if (!s0_RedBalls.IsNull())
			{
				s0_RedBalls.Serialize(writer);
			}
			if (!s0_RedBallsNo.IsNull())
			{
				s0_RedBallsNo.Serialize(writer);
			}
			s0_OneBallCount.Serialize(writer);
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_RedBalls.Deserialize(reader);
				s0_RedBallsNo.Deserialize(reader);
				s0_OneBallCount.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				if ((___masking___[0] & 2) != 2)
				{
					s0_RedBalls.Deserialize(reader);
				}
				else
				{
					s0_RedBalls.SetNull();
				}
				if ((___masking___[0] & 4) != 4)
				{
					s0_RedBallsNo.Deserialize(reader);
				}
				else
				{
					s0_RedBallsNo.SetNull();
				}
				s0_OneBallCount.Deserialize(reader);
			}
		}
	}


	public class Row_OneBallCount_Long_RedBalls1_String : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("OneBallCount", ColumnDataType.Long, typeof(long), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls1", ColumnDataType.String, typeof(string), null),
		};
		ScopeRuntime.LongColumnData s0_OneBallCount;
		public ScopeRuntime.LongColumnData OneBallCount
		{
			get { return s0_OneBallCount; }
			set
			{
				s0_OneBallCount = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBalls1;
		public ScopeRuntime.StringColumnData RedBalls1
		{
			get { return s0_RedBalls1; }
			set
			{
				s0_RedBalls1 = value;
				_columns[1] = value;
			}
		}
		public Row_OneBallCount_Long_RedBalls1_String(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_OneBallCount_Long_RedBalls1_String(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_OneBallCount_Long_RedBalls1_String() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_OneBallCount = (ScopeRuntime.LongColumnData)value;
						break;
					case 1:
						s0_RedBalls1 = (ScopeRuntime.StringColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_RedBalls1.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			s0_OneBallCount.Serialize(writer);
			if (!s0_RedBalls1.IsNull())
			{
				s0_RedBalls1.Serialize(writer);
			}
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_OneBallCount.Deserialize(reader);
				s0_RedBalls1.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				s0_OneBallCount.Deserialize(reader);
				if ((___masking___[0] & 2) != 2)
				{
					s0_RedBalls1.Deserialize(reader);
				}
				else
				{
					s0_RedBalls1.SetNull();
				}
			}
		}
	}


	public class Row_PeriodNo_String_RedBalls_String_RedBallsNo_String_OneBallCount_LongQ : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("PeriodNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBallsNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("OneBallCount", ColumnDataType.LongQ, typeof(long?), null),
		};
		ScopeRuntime.StringColumnData s0_PeriodNo;
		public ScopeRuntime.StringColumnData PeriodNo
		{
			get { return s0_PeriodNo; }
			set
			{
				s0_PeriodNo = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBalls;
		public ScopeRuntime.StringColumnData RedBalls
		{
			get { return s0_RedBalls; }
			set
			{
				s0_RedBalls = value;
				_columns[1] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBallsNo;
		public ScopeRuntime.StringColumnData RedBallsNo
		{
			get { return s0_RedBallsNo; }
			set
			{
				s0_RedBallsNo = value;
				_columns[2] = value;
			}
		}
		ScopeRuntime.LongQColumnData s0_OneBallCount;
		public ScopeRuntime.LongQColumnData OneBallCount
		{
			get { return s0_OneBallCount; }
			set
			{
				s0_OneBallCount = value;
				_columns[3] = value;
			}
		}
		public Row_PeriodNo_String_RedBalls_String_RedBallsNo_String_OneBallCount_LongQ(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_PeriodNo_String_RedBalls_String_RedBallsNo_String_OneBallCount_LongQ(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_PeriodNo_String_RedBalls_String_RedBallsNo_String_OneBallCount_LongQ() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_PeriodNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 1:
						s0_RedBalls = (ScopeRuntime.StringColumnData)value;
						break;
					case 2:
						s0_RedBallsNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 3:
						s0_OneBallCount = (ScopeRuntime.LongQColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_PeriodNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (s0_RedBalls.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 2);
			}
			if (s0_RedBallsNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 3);
			}
			if (s0_OneBallCount.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 4);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			if (!s0_PeriodNo.IsNull())
			{
				s0_PeriodNo.Serialize(writer);
			}
			if (!s0_RedBalls.IsNull())
			{
				s0_RedBalls.Serialize(writer);
			}
			if (!s0_RedBallsNo.IsNull())
			{
				s0_RedBallsNo.Serialize(writer);
			}
			if (!s0_OneBallCount.IsNull())
			{
				s0_OneBallCount.Serialize(writer);
			}
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_PeriodNo.Deserialize(reader);
				s0_RedBalls.Deserialize(reader);
				s0_RedBallsNo.Deserialize(reader);
				s0_OneBallCount.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				if ((___masking___[0] & 2) != 2)
				{
					s0_PeriodNo.Deserialize(reader);
				}
				else
				{
					s0_PeriodNo.SetNull();
				}
				if ((___masking___[0] & 4) != 4)
				{
					s0_RedBalls.Deserialize(reader);
				}
				else
				{
					s0_RedBalls.SetNull();
				}
				if ((___masking___[0] & 8) != 8)
				{
					s0_RedBallsNo.Deserialize(reader);
				}
				else
				{
					s0_RedBallsNo.SetNull();
				}
				if ((___masking___[0] & 16) != 16)
				{
					s0_OneBallCount.Deserialize(reader);
				}
				else
				{
					s0_OneBallCount.SetNull();
				}
			}
		}
	}


	public class Row_RedBalls_String_RedBallsNo_String_partialagg1___Long : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBallsNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("partialagg1__", ColumnDataType.Long, typeof(long), null),
		};
		ScopeRuntime.StringColumnData s0_RedBalls;
		public ScopeRuntime.StringColumnData RedBalls
		{
			get { return s0_RedBalls; }
			set
			{
				s0_RedBalls = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBallsNo;
		public ScopeRuntime.StringColumnData RedBallsNo
		{
			get { return s0_RedBallsNo; }
			set
			{
				s0_RedBallsNo = value;
				_columns[1] = value;
			}
		}
		ScopeRuntime.LongColumnData s0_partialagg1__;
		public ScopeRuntime.LongColumnData partialagg1__
		{
			get { return s0_partialagg1__; }
			set
			{
				s0_partialagg1__ = value;
				_columns[2] = value;
			}
		}
		public Row_RedBalls_String_RedBallsNo_String_partialagg1___Long(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_RedBalls_String_RedBallsNo_String_partialagg1___Long(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_RedBalls_String_RedBallsNo_String_partialagg1___Long() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_RedBalls = (ScopeRuntime.StringColumnData)value;
						break;
					case 1:
						s0_RedBallsNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 2:
						s0_partialagg1__ = (ScopeRuntime.LongColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_RedBalls.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (s0_RedBallsNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 2);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			if (!s0_RedBalls.IsNull())
			{
				s0_RedBalls.Serialize(writer);
			}
			if (!s0_RedBallsNo.IsNull())
			{
				s0_RedBallsNo.Serialize(writer);
			}
			s0_partialagg1__.Serialize(writer);
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_RedBalls.Deserialize(reader);
				s0_RedBallsNo.Deserialize(reader);
				s0_partialagg1__.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				if ((___masking___[0] & 2) != 2)
				{
					s0_RedBalls.Deserialize(reader);
				}
				else
				{
					s0_RedBalls.SetNull();
				}
				if ((___masking___[0] & 4) != 4)
				{
					s0_RedBallsNo.Deserialize(reader);
				}
				else
				{
					s0_RedBallsNo.SetNull();
				}
				s0_partialagg1__.Deserialize(reader);
			}
		}
	}


	public class Row_RedBalls_String_RedBallsNo_String_TwoBallCount_Long : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBallsNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("TwoBallCount", ColumnDataType.Long, typeof(long), null),
		};
		ScopeRuntime.StringColumnData s0_RedBalls;
		public ScopeRuntime.StringColumnData RedBalls
		{
			get { return s0_RedBalls; }
			set
			{
				s0_RedBalls = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBallsNo;
		public ScopeRuntime.StringColumnData RedBallsNo
		{
			get { return s0_RedBallsNo; }
			set
			{
				s0_RedBallsNo = value;
				_columns[1] = value;
			}
		}
		ScopeRuntime.LongColumnData s0_TwoBallCount;
		public ScopeRuntime.LongColumnData TwoBallCount
		{
			get { return s0_TwoBallCount; }
			set
			{
				s0_TwoBallCount = value;
				_columns[2] = value;
			}
		}
		public Row_RedBalls_String_RedBallsNo_String_TwoBallCount_Long(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_RedBalls_String_RedBallsNo_String_TwoBallCount_Long(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_RedBalls_String_RedBallsNo_String_TwoBallCount_Long() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_RedBalls = (ScopeRuntime.StringColumnData)value;
						break;
					case 1:
						s0_RedBallsNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 2:
						s0_TwoBallCount = (ScopeRuntime.LongColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_RedBalls.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (s0_RedBallsNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 2);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			if (!s0_RedBalls.IsNull())
			{
				s0_RedBalls.Serialize(writer);
			}
			if (!s0_RedBallsNo.IsNull())
			{
				s0_RedBallsNo.Serialize(writer);
			}
			s0_TwoBallCount.Serialize(writer);
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_RedBalls.Deserialize(reader);
				s0_RedBallsNo.Deserialize(reader);
				s0_TwoBallCount.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				if ((___masking___[0] & 2) != 2)
				{
					s0_RedBalls.Deserialize(reader);
				}
				else
				{
					s0_RedBalls.SetNull();
				}
				if ((___masking___[0] & 4) != 4)
				{
					s0_RedBallsNo.Deserialize(reader);
				}
				else
				{
					s0_RedBallsNo.SetNull();
				}
				s0_TwoBallCount.Deserialize(reader);
			}
		}
	}


	public class Row_TwoBallCount_Long_RedBalls1_String : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("TwoBallCount", ColumnDataType.Long, typeof(long), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls1", ColumnDataType.String, typeof(string), null),
		};
		ScopeRuntime.LongColumnData s0_TwoBallCount;
		public ScopeRuntime.LongColumnData TwoBallCount
		{
			get { return s0_TwoBallCount; }
			set
			{
				s0_TwoBallCount = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBalls1;
		public ScopeRuntime.StringColumnData RedBalls1
		{
			get { return s0_RedBalls1; }
			set
			{
				s0_RedBalls1 = value;
				_columns[1] = value;
			}
		}
		public Row_TwoBallCount_Long_RedBalls1_String(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_TwoBallCount_Long_RedBalls1_String(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_TwoBallCount_Long_RedBalls1_String() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_TwoBallCount = (ScopeRuntime.LongColumnData)value;
						break;
					case 1:
						s0_RedBalls1 = (ScopeRuntime.StringColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_RedBalls1.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			s0_TwoBallCount.Serialize(writer);
			if (!s0_RedBalls1.IsNull())
			{
				s0_RedBalls1.Serialize(writer);
			}
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_TwoBallCount.Deserialize(reader);
				s0_RedBalls1.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				s0_TwoBallCount.Deserialize(reader);
				if ((___masking___[0] & 2) != 2)
				{
					s0_RedBalls1.Deserialize(reader);
				}
				else
				{
					s0_RedBalls1.SetNull();
				}
			}
		}
	}


	public class Row_PeriodNo_String_RedBalls_String_RedBallsNo_String_TwoBallCount_LongQ : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("PeriodNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBallsNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("TwoBallCount", ColumnDataType.LongQ, typeof(long?), null),
		};
		ScopeRuntime.StringColumnData s0_PeriodNo;
		public ScopeRuntime.StringColumnData PeriodNo
		{
			get { return s0_PeriodNo; }
			set
			{
				s0_PeriodNo = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBalls;
		public ScopeRuntime.StringColumnData RedBalls
		{
			get { return s0_RedBalls; }
			set
			{
				s0_RedBalls = value;
				_columns[1] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBallsNo;
		public ScopeRuntime.StringColumnData RedBallsNo
		{
			get { return s0_RedBallsNo; }
			set
			{
				s0_RedBallsNo = value;
				_columns[2] = value;
			}
		}
		ScopeRuntime.LongQColumnData s0_TwoBallCount;
		public ScopeRuntime.LongQColumnData TwoBallCount
		{
			get { return s0_TwoBallCount; }
			set
			{
				s0_TwoBallCount = value;
				_columns[3] = value;
			}
		}
		public Row_PeriodNo_String_RedBalls_String_RedBallsNo_String_TwoBallCount_LongQ(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_PeriodNo_String_RedBalls_String_RedBallsNo_String_TwoBallCount_LongQ(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_PeriodNo_String_RedBalls_String_RedBallsNo_String_TwoBallCount_LongQ() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_PeriodNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 1:
						s0_RedBalls = (ScopeRuntime.StringColumnData)value;
						break;
					case 2:
						s0_RedBallsNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 3:
						s0_TwoBallCount = (ScopeRuntime.LongQColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_PeriodNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (s0_RedBalls.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 2);
			}
			if (s0_RedBallsNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 3);
			}
			if (s0_TwoBallCount.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 4);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			if (!s0_PeriodNo.IsNull())
			{
				s0_PeriodNo.Serialize(writer);
			}
			if (!s0_RedBalls.IsNull())
			{
				s0_RedBalls.Serialize(writer);
			}
			if (!s0_RedBallsNo.IsNull())
			{
				s0_RedBallsNo.Serialize(writer);
			}
			if (!s0_TwoBallCount.IsNull())
			{
				s0_TwoBallCount.Serialize(writer);
			}
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_PeriodNo.Deserialize(reader);
				s0_RedBalls.Deserialize(reader);
				s0_RedBallsNo.Deserialize(reader);
				s0_TwoBallCount.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				if ((___masking___[0] & 2) != 2)
				{
					s0_PeriodNo.Deserialize(reader);
				}
				else
				{
					s0_PeriodNo.SetNull();
				}
				if ((___masking___[0] & 4) != 4)
				{
					s0_RedBalls.Deserialize(reader);
				}
				else
				{
					s0_RedBalls.SetNull();
				}
				if ((___masking___[0] & 8) != 8)
				{
					s0_RedBallsNo.Deserialize(reader);
				}
				else
				{
					s0_RedBallsNo.SetNull();
				}
				if ((___masking___[0] & 16) != 16)
				{
					s0_TwoBallCount.Deserialize(reader);
				}
				else
				{
					s0_TwoBallCount.SetNull();
				}
			}
		}
	}


	public class Row_RedBalls_String_RedBallsNo_String_partialagg2___Long : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBallsNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("partialagg2__", ColumnDataType.Long, typeof(long), null),
		};
		ScopeRuntime.StringColumnData s0_RedBalls;
		public ScopeRuntime.StringColumnData RedBalls
		{
			get { return s0_RedBalls; }
			set
			{
				s0_RedBalls = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBallsNo;
		public ScopeRuntime.StringColumnData RedBallsNo
		{
			get { return s0_RedBallsNo; }
			set
			{
				s0_RedBallsNo = value;
				_columns[1] = value;
			}
		}
		ScopeRuntime.LongColumnData s0_partialagg2__;
		public ScopeRuntime.LongColumnData partialagg2__
		{
			get { return s0_partialagg2__; }
			set
			{
				s0_partialagg2__ = value;
				_columns[2] = value;
			}
		}
		public Row_RedBalls_String_RedBallsNo_String_partialagg2___Long(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_RedBalls_String_RedBallsNo_String_partialagg2___Long(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_RedBalls_String_RedBallsNo_String_partialagg2___Long() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_RedBalls = (ScopeRuntime.StringColumnData)value;
						break;
					case 1:
						s0_RedBallsNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 2:
						s0_partialagg2__ = (ScopeRuntime.LongColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_RedBalls.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (s0_RedBallsNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 2);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			if (!s0_RedBalls.IsNull())
			{
				s0_RedBalls.Serialize(writer);
			}
			if (!s0_RedBallsNo.IsNull())
			{
				s0_RedBallsNo.Serialize(writer);
			}
			s0_partialagg2__.Serialize(writer);
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_RedBalls.Deserialize(reader);
				s0_RedBallsNo.Deserialize(reader);
				s0_partialagg2__.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				if ((___masking___[0] & 2) != 2)
				{
					s0_RedBalls.Deserialize(reader);
				}
				else
				{
					s0_RedBalls.SetNull();
				}
				if ((___masking___[0] & 4) != 4)
				{
					s0_RedBallsNo.Deserialize(reader);
				}
				else
				{
					s0_RedBallsNo.SetNull();
				}
				s0_partialagg2__.Deserialize(reader);
			}
		}
	}


	public class Row_RedBalls_String_RedBallsNo_String_ThreeBallCount_Long : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBallsNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("ThreeBallCount", ColumnDataType.Long, typeof(long), null),
		};
		ScopeRuntime.StringColumnData s0_RedBalls;
		public ScopeRuntime.StringColumnData RedBalls
		{
			get { return s0_RedBalls; }
			set
			{
				s0_RedBalls = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBallsNo;
		public ScopeRuntime.StringColumnData RedBallsNo
		{
			get { return s0_RedBallsNo; }
			set
			{
				s0_RedBallsNo = value;
				_columns[1] = value;
			}
		}
		ScopeRuntime.LongColumnData s0_ThreeBallCount;
		public ScopeRuntime.LongColumnData ThreeBallCount
		{
			get { return s0_ThreeBallCount; }
			set
			{
				s0_ThreeBallCount = value;
				_columns[2] = value;
			}
		}
		public Row_RedBalls_String_RedBallsNo_String_ThreeBallCount_Long(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_RedBalls_String_RedBallsNo_String_ThreeBallCount_Long(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_RedBalls_String_RedBallsNo_String_ThreeBallCount_Long() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_RedBalls = (ScopeRuntime.StringColumnData)value;
						break;
					case 1:
						s0_RedBallsNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 2:
						s0_ThreeBallCount = (ScopeRuntime.LongColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_RedBalls.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (s0_RedBallsNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 2);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			if (!s0_RedBalls.IsNull())
			{
				s0_RedBalls.Serialize(writer);
			}
			if (!s0_RedBallsNo.IsNull())
			{
				s0_RedBallsNo.Serialize(writer);
			}
			s0_ThreeBallCount.Serialize(writer);
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_RedBalls.Deserialize(reader);
				s0_RedBallsNo.Deserialize(reader);
				s0_ThreeBallCount.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				if ((___masking___[0] & 2) != 2)
				{
					s0_RedBalls.Deserialize(reader);
				}
				else
				{
					s0_RedBalls.SetNull();
				}
				if ((___masking___[0] & 4) != 4)
				{
					s0_RedBallsNo.Deserialize(reader);
				}
				else
				{
					s0_RedBallsNo.SetNull();
				}
				s0_ThreeBallCount.Deserialize(reader);
			}
		}
	}


	public class Row_ThreeBallCount_Long_RedBalls1_String : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("ThreeBallCount", ColumnDataType.Long, typeof(long), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls1", ColumnDataType.String, typeof(string), null),
		};
		ScopeRuntime.LongColumnData s0_ThreeBallCount;
		public ScopeRuntime.LongColumnData ThreeBallCount
		{
			get { return s0_ThreeBallCount; }
			set
			{
				s0_ThreeBallCount = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBalls1;
		public ScopeRuntime.StringColumnData RedBalls1
		{
			get { return s0_RedBalls1; }
			set
			{
				s0_RedBalls1 = value;
				_columns[1] = value;
			}
		}
		public Row_ThreeBallCount_Long_RedBalls1_String(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_ThreeBallCount_Long_RedBalls1_String(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_ThreeBallCount_Long_RedBalls1_String() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_ThreeBallCount = (ScopeRuntime.LongColumnData)value;
						break;
					case 1:
						s0_RedBalls1 = (ScopeRuntime.StringColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_RedBalls1.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			s0_ThreeBallCount.Serialize(writer);
			if (!s0_RedBalls1.IsNull())
			{
				s0_RedBalls1.Serialize(writer);
			}
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_ThreeBallCount.Deserialize(reader);
				s0_RedBalls1.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				s0_ThreeBallCount.Deserialize(reader);
				if ((___masking___[0] & 2) != 2)
				{
					s0_RedBalls1.Deserialize(reader);
				}
				else
				{
					s0_RedBalls1.SetNull();
				}
			}
		}
	}


	public class Row_PeriodNo_String_RedBalls_String_RedBallsNo_String_ThreeBallCount_LongQ : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("PeriodNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBallsNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("ThreeBallCount", ColumnDataType.LongQ, typeof(long?), null),
		};
		ScopeRuntime.StringColumnData s0_PeriodNo;
		public ScopeRuntime.StringColumnData PeriodNo
		{
			get { return s0_PeriodNo; }
			set
			{
				s0_PeriodNo = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBalls;
		public ScopeRuntime.StringColumnData RedBalls
		{
			get { return s0_RedBalls; }
			set
			{
				s0_RedBalls = value;
				_columns[1] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBallsNo;
		public ScopeRuntime.StringColumnData RedBallsNo
		{
			get { return s0_RedBallsNo; }
			set
			{
				s0_RedBallsNo = value;
				_columns[2] = value;
			}
		}
		ScopeRuntime.LongQColumnData s0_ThreeBallCount;
		public ScopeRuntime.LongQColumnData ThreeBallCount
		{
			get { return s0_ThreeBallCount; }
			set
			{
				s0_ThreeBallCount = value;
				_columns[3] = value;
			}
		}
		public Row_PeriodNo_String_RedBalls_String_RedBallsNo_String_ThreeBallCount_LongQ(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_PeriodNo_String_RedBalls_String_RedBallsNo_String_ThreeBallCount_LongQ(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_PeriodNo_String_RedBalls_String_RedBallsNo_String_ThreeBallCount_LongQ() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_PeriodNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 1:
						s0_RedBalls = (ScopeRuntime.StringColumnData)value;
						break;
					case 2:
						s0_RedBallsNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 3:
						s0_ThreeBallCount = (ScopeRuntime.LongQColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_PeriodNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (s0_RedBalls.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 2);
			}
			if (s0_RedBallsNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 3);
			}
			if (s0_ThreeBallCount.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 4);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			if (!s0_PeriodNo.IsNull())
			{
				s0_PeriodNo.Serialize(writer);
			}
			if (!s0_RedBalls.IsNull())
			{
				s0_RedBalls.Serialize(writer);
			}
			if (!s0_RedBallsNo.IsNull())
			{
				s0_RedBallsNo.Serialize(writer);
			}
			if (!s0_ThreeBallCount.IsNull())
			{
				s0_ThreeBallCount.Serialize(writer);
			}
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_PeriodNo.Deserialize(reader);
				s0_RedBalls.Deserialize(reader);
				s0_RedBallsNo.Deserialize(reader);
				s0_ThreeBallCount.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				if ((___masking___[0] & 2) != 2)
				{
					s0_PeriodNo.Deserialize(reader);
				}
				else
				{
					s0_PeriodNo.SetNull();
				}
				if ((___masking___[0] & 4) != 4)
				{
					s0_RedBalls.Deserialize(reader);
				}
				else
				{
					s0_RedBalls.SetNull();
				}
				if ((___masking___[0] & 8) != 8)
				{
					s0_RedBallsNo.Deserialize(reader);
				}
				else
				{
					s0_RedBallsNo.SetNull();
				}
				if ((___masking___[0] & 16) != 16)
				{
					s0_ThreeBallCount.Deserialize(reader);
				}
				else
				{
					s0_ThreeBallCount.SetNull();
				}
			}
		}
	}


	public class Row_RedBalls_String_RedBallsNo_String_partialagg3___Long : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBallsNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("partialagg3__", ColumnDataType.Long, typeof(long), null),
		};
		ScopeRuntime.StringColumnData s0_RedBalls;
		public ScopeRuntime.StringColumnData RedBalls
		{
			get { return s0_RedBalls; }
			set
			{
				s0_RedBalls = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBallsNo;
		public ScopeRuntime.StringColumnData RedBallsNo
		{
			get { return s0_RedBallsNo; }
			set
			{
				s0_RedBallsNo = value;
				_columns[1] = value;
			}
		}
		ScopeRuntime.LongColumnData s0_partialagg3__;
		public ScopeRuntime.LongColumnData partialagg3__
		{
			get { return s0_partialagg3__; }
			set
			{
				s0_partialagg3__ = value;
				_columns[2] = value;
			}
		}
		public Row_RedBalls_String_RedBallsNo_String_partialagg3___Long(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_RedBalls_String_RedBallsNo_String_partialagg3___Long(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_RedBalls_String_RedBallsNo_String_partialagg3___Long() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_RedBalls = (ScopeRuntime.StringColumnData)value;
						break;
					case 1:
						s0_RedBallsNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 2:
						s0_partialagg3__ = (ScopeRuntime.LongColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_RedBalls.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (s0_RedBallsNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 2);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			if (!s0_RedBalls.IsNull())
			{
				s0_RedBalls.Serialize(writer);
			}
			if (!s0_RedBallsNo.IsNull())
			{
				s0_RedBallsNo.Serialize(writer);
			}
			s0_partialagg3__.Serialize(writer);
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_RedBalls.Deserialize(reader);
				s0_RedBallsNo.Deserialize(reader);
				s0_partialagg3__.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				if ((___masking___[0] & 2) != 2)
				{
					s0_RedBalls.Deserialize(reader);
				}
				else
				{
					s0_RedBalls.SetNull();
				}
				if ((___masking___[0] & 4) != 4)
				{
					s0_RedBallsNo.Deserialize(reader);
				}
				else
				{
					s0_RedBallsNo.SetNull();
				}
				s0_partialagg3__.Deserialize(reader);
			}
		}
	}


	public class Row_RedBalls_String_RedBallsNo_String_FourBallCount_Long : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBallsNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("FourBallCount", ColumnDataType.Long, typeof(long), null),
		};
		ScopeRuntime.StringColumnData s0_RedBalls;
		public ScopeRuntime.StringColumnData RedBalls
		{
			get { return s0_RedBalls; }
			set
			{
				s0_RedBalls = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBallsNo;
		public ScopeRuntime.StringColumnData RedBallsNo
		{
			get { return s0_RedBallsNo; }
			set
			{
				s0_RedBallsNo = value;
				_columns[1] = value;
			}
		}
		ScopeRuntime.LongColumnData s0_FourBallCount;
		public ScopeRuntime.LongColumnData FourBallCount
		{
			get { return s0_FourBallCount; }
			set
			{
				s0_FourBallCount = value;
				_columns[2] = value;
			}
		}
		public Row_RedBalls_String_RedBallsNo_String_FourBallCount_Long(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_RedBalls_String_RedBallsNo_String_FourBallCount_Long(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_RedBalls_String_RedBallsNo_String_FourBallCount_Long() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_RedBalls = (ScopeRuntime.StringColumnData)value;
						break;
					case 1:
						s0_RedBallsNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 2:
						s0_FourBallCount = (ScopeRuntime.LongColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_RedBalls.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (s0_RedBallsNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 2);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			if (!s0_RedBalls.IsNull())
			{
				s0_RedBalls.Serialize(writer);
			}
			if (!s0_RedBallsNo.IsNull())
			{
				s0_RedBallsNo.Serialize(writer);
			}
			s0_FourBallCount.Serialize(writer);
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_RedBalls.Deserialize(reader);
				s0_RedBallsNo.Deserialize(reader);
				s0_FourBallCount.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				if ((___masking___[0] & 2) != 2)
				{
					s0_RedBalls.Deserialize(reader);
				}
				else
				{
					s0_RedBalls.SetNull();
				}
				if ((___masking___[0] & 4) != 4)
				{
					s0_RedBallsNo.Deserialize(reader);
				}
				else
				{
					s0_RedBallsNo.SetNull();
				}
				s0_FourBallCount.Deserialize(reader);
			}
		}
	}


	public class Row_FourBallCount_Long_RedBalls1_String : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("FourBallCount", ColumnDataType.Long, typeof(long), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls1", ColumnDataType.String, typeof(string), null),
		};
		ScopeRuntime.LongColumnData s0_FourBallCount;
		public ScopeRuntime.LongColumnData FourBallCount
		{
			get { return s0_FourBallCount; }
			set
			{
				s0_FourBallCount = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBalls1;
		public ScopeRuntime.StringColumnData RedBalls1
		{
			get { return s0_RedBalls1; }
			set
			{
				s0_RedBalls1 = value;
				_columns[1] = value;
			}
		}
		public Row_FourBallCount_Long_RedBalls1_String(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_FourBallCount_Long_RedBalls1_String(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_FourBallCount_Long_RedBalls1_String() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_FourBallCount = (ScopeRuntime.LongColumnData)value;
						break;
					case 1:
						s0_RedBalls1 = (ScopeRuntime.StringColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_RedBalls1.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			s0_FourBallCount.Serialize(writer);
			if (!s0_RedBalls1.IsNull())
			{
				s0_RedBalls1.Serialize(writer);
			}
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_FourBallCount.Deserialize(reader);
				s0_RedBalls1.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				s0_FourBallCount.Deserialize(reader);
				if ((___masking___[0] & 2) != 2)
				{
					s0_RedBalls1.Deserialize(reader);
				}
				else
				{
					s0_RedBalls1.SetNull();
				}
			}
		}
	}


	public class Row_PeriodNo_String_RedBalls_String_RedBallsNo_String_FourBallCount_LongQ : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("PeriodNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBallsNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("FourBallCount", ColumnDataType.LongQ, typeof(long?), null),
		};
		ScopeRuntime.StringColumnData s0_PeriodNo;
		public ScopeRuntime.StringColumnData PeriodNo
		{
			get { return s0_PeriodNo; }
			set
			{
				s0_PeriodNo = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBalls;
		public ScopeRuntime.StringColumnData RedBalls
		{
			get { return s0_RedBalls; }
			set
			{
				s0_RedBalls = value;
				_columns[1] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBallsNo;
		public ScopeRuntime.StringColumnData RedBallsNo
		{
			get { return s0_RedBallsNo; }
			set
			{
				s0_RedBallsNo = value;
				_columns[2] = value;
			}
		}
		ScopeRuntime.LongQColumnData s0_FourBallCount;
		public ScopeRuntime.LongQColumnData FourBallCount
		{
			get { return s0_FourBallCount; }
			set
			{
				s0_FourBallCount = value;
				_columns[3] = value;
			}
		}
		public Row_PeriodNo_String_RedBalls_String_RedBallsNo_String_FourBallCount_LongQ(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_PeriodNo_String_RedBalls_String_RedBallsNo_String_FourBallCount_LongQ(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_PeriodNo_String_RedBalls_String_RedBallsNo_String_FourBallCount_LongQ() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_PeriodNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 1:
						s0_RedBalls = (ScopeRuntime.StringColumnData)value;
						break;
					case 2:
						s0_RedBallsNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 3:
						s0_FourBallCount = (ScopeRuntime.LongQColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_PeriodNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (s0_RedBalls.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 2);
			}
			if (s0_RedBallsNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 3);
			}
			if (s0_FourBallCount.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 4);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			if (!s0_PeriodNo.IsNull())
			{
				s0_PeriodNo.Serialize(writer);
			}
			if (!s0_RedBalls.IsNull())
			{
				s0_RedBalls.Serialize(writer);
			}
			if (!s0_RedBallsNo.IsNull())
			{
				s0_RedBallsNo.Serialize(writer);
			}
			if (!s0_FourBallCount.IsNull())
			{
				s0_FourBallCount.Serialize(writer);
			}
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_PeriodNo.Deserialize(reader);
				s0_RedBalls.Deserialize(reader);
				s0_RedBallsNo.Deserialize(reader);
				s0_FourBallCount.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				if ((___masking___[0] & 2) != 2)
				{
					s0_PeriodNo.Deserialize(reader);
				}
				else
				{
					s0_PeriodNo.SetNull();
				}
				if ((___masking___[0] & 4) != 4)
				{
					s0_RedBalls.Deserialize(reader);
				}
				else
				{
					s0_RedBalls.SetNull();
				}
				if ((___masking___[0] & 8) != 8)
				{
					s0_RedBallsNo.Deserialize(reader);
				}
				else
				{
					s0_RedBallsNo.SetNull();
				}
				if ((___masking___[0] & 16) != 16)
				{
					s0_FourBallCount.Deserialize(reader);
				}
				else
				{
					s0_FourBallCount.SetNull();
				}
			}
		}
	}


	public class Row_RedBalls_String_RedBallsNo_String_partialagg4___Long : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBallsNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("partialagg4__", ColumnDataType.Long, typeof(long), null),
		};
		ScopeRuntime.StringColumnData s0_RedBalls;
		public ScopeRuntime.StringColumnData RedBalls
		{
			get { return s0_RedBalls; }
			set
			{
				s0_RedBalls = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBallsNo;
		public ScopeRuntime.StringColumnData RedBallsNo
		{
			get { return s0_RedBallsNo; }
			set
			{
				s0_RedBallsNo = value;
				_columns[1] = value;
			}
		}
		ScopeRuntime.LongColumnData s0_partialagg4__;
		public ScopeRuntime.LongColumnData partialagg4__
		{
			get { return s0_partialagg4__; }
			set
			{
				s0_partialagg4__ = value;
				_columns[2] = value;
			}
		}
		public Row_RedBalls_String_RedBallsNo_String_partialagg4___Long(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_RedBalls_String_RedBallsNo_String_partialagg4___Long(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_RedBalls_String_RedBallsNo_String_partialagg4___Long() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_RedBalls = (ScopeRuntime.StringColumnData)value;
						break;
					case 1:
						s0_RedBallsNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 2:
						s0_partialagg4__ = (ScopeRuntime.LongColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_RedBalls.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (s0_RedBallsNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 2);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			if (!s0_RedBalls.IsNull())
			{
				s0_RedBalls.Serialize(writer);
			}
			if (!s0_RedBallsNo.IsNull())
			{
				s0_RedBallsNo.Serialize(writer);
			}
			s0_partialagg4__.Serialize(writer);
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_RedBalls.Deserialize(reader);
				s0_RedBallsNo.Deserialize(reader);
				s0_partialagg4__.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				if ((___masking___[0] & 2) != 2)
				{
					s0_RedBalls.Deserialize(reader);
				}
				else
				{
					s0_RedBalls.SetNull();
				}
				if ((___masking___[0] & 4) != 4)
				{
					s0_RedBallsNo.Deserialize(reader);
				}
				else
				{
					s0_RedBallsNo.SetNull();
				}
				s0_partialagg4__.Deserialize(reader);
			}
		}
	}


	public class Row_RedBalls_String_RedBallsNo_String_FiveBallCount_Long : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBallsNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("FiveBallCount", ColumnDataType.Long, typeof(long), null),
		};
		ScopeRuntime.StringColumnData s0_RedBalls;
		public ScopeRuntime.StringColumnData RedBalls
		{
			get { return s0_RedBalls; }
			set
			{
				s0_RedBalls = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBallsNo;
		public ScopeRuntime.StringColumnData RedBallsNo
		{
			get { return s0_RedBallsNo; }
			set
			{
				s0_RedBallsNo = value;
				_columns[1] = value;
			}
		}
		ScopeRuntime.LongColumnData s0_FiveBallCount;
		public ScopeRuntime.LongColumnData FiveBallCount
		{
			get { return s0_FiveBallCount; }
			set
			{
				s0_FiveBallCount = value;
				_columns[2] = value;
			}
		}
		public Row_RedBalls_String_RedBallsNo_String_FiveBallCount_Long(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_RedBalls_String_RedBallsNo_String_FiveBallCount_Long(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_RedBalls_String_RedBallsNo_String_FiveBallCount_Long() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_RedBalls = (ScopeRuntime.StringColumnData)value;
						break;
					case 1:
						s0_RedBallsNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 2:
						s0_FiveBallCount = (ScopeRuntime.LongColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_RedBalls.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (s0_RedBallsNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 2);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			if (!s0_RedBalls.IsNull())
			{
				s0_RedBalls.Serialize(writer);
			}
			if (!s0_RedBallsNo.IsNull())
			{
				s0_RedBallsNo.Serialize(writer);
			}
			s0_FiveBallCount.Serialize(writer);
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_RedBalls.Deserialize(reader);
				s0_RedBallsNo.Deserialize(reader);
				s0_FiveBallCount.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				if ((___masking___[0] & 2) != 2)
				{
					s0_RedBalls.Deserialize(reader);
				}
				else
				{
					s0_RedBalls.SetNull();
				}
				if ((___masking___[0] & 4) != 4)
				{
					s0_RedBallsNo.Deserialize(reader);
				}
				else
				{
					s0_RedBallsNo.SetNull();
				}
				s0_FiveBallCount.Deserialize(reader);
			}
		}
	}


	public class Row_FiveBallCount_Long_RedBalls1_String : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("FiveBallCount", ColumnDataType.Long, typeof(long), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls1", ColumnDataType.String, typeof(string), null),
		};
		ScopeRuntime.LongColumnData s0_FiveBallCount;
		public ScopeRuntime.LongColumnData FiveBallCount
		{
			get { return s0_FiveBallCount; }
			set
			{
				s0_FiveBallCount = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBalls1;
		public ScopeRuntime.StringColumnData RedBalls1
		{
			get { return s0_RedBalls1; }
			set
			{
				s0_RedBalls1 = value;
				_columns[1] = value;
			}
		}
		public Row_FiveBallCount_Long_RedBalls1_String(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_FiveBallCount_Long_RedBalls1_String(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_FiveBallCount_Long_RedBalls1_String() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_FiveBallCount = (ScopeRuntime.LongColumnData)value;
						break;
					case 1:
						s0_RedBalls1 = (ScopeRuntime.StringColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_RedBalls1.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			s0_FiveBallCount.Serialize(writer);
			if (!s0_RedBalls1.IsNull())
			{
				s0_RedBalls1.Serialize(writer);
			}
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_FiveBallCount.Deserialize(reader);
				s0_RedBalls1.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				s0_FiveBallCount.Deserialize(reader);
				if ((___masking___[0] & 2) != 2)
				{
					s0_RedBalls1.Deserialize(reader);
				}
				else
				{
					s0_RedBalls1.SetNull();
				}
			}
		}
	}


	public class Row_PeriodNo_String_RedBalls_String_RedBallsNo_String_FiveBallCount_LongQ : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("PeriodNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBallsNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("FiveBallCount", ColumnDataType.LongQ, typeof(long?), null),
		};
		ScopeRuntime.StringColumnData s0_PeriodNo;
		public ScopeRuntime.StringColumnData PeriodNo
		{
			get { return s0_PeriodNo; }
			set
			{
				s0_PeriodNo = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBalls;
		public ScopeRuntime.StringColumnData RedBalls
		{
			get { return s0_RedBalls; }
			set
			{
				s0_RedBalls = value;
				_columns[1] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBallsNo;
		public ScopeRuntime.StringColumnData RedBallsNo
		{
			get { return s0_RedBallsNo; }
			set
			{
				s0_RedBallsNo = value;
				_columns[2] = value;
			}
		}
		ScopeRuntime.LongQColumnData s0_FiveBallCount;
		public ScopeRuntime.LongQColumnData FiveBallCount
		{
			get { return s0_FiveBallCount; }
			set
			{
				s0_FiveBallCount = value;
				_columns[3] = value;
			}
		}
		public Row_PeriodNo_String_RedBalls_String_RedBallsNo_String_FiveBallCount_LongQ(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_PeriodNo_String_RedBalls_String_RedBallsNo_String_FiveBallCount_LongQ(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_PeriodNo_String_RedBalls_String_RedBallsNo_String_FiveBallCount_LongQ() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_PeriodNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 1:
						s0_RedBalls = (ScopeRuntime.StringColumnData)value;
						break;
					case 2:
						s0_RedBallsNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 3:
						s0_FiveBallCount = (ScopeRuntime.LongQColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_PeriodNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (s0_RedBalls.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 2);
			}
			if (s0_RedBallsNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 3);
			}
			if (s0_FiveBallCount.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 4);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			if (!s0_PeriodNo.IsNull())
			{
				s0_PeriodNo.Serialize(writer);
			}
			if (!s0_RedBalls.IsNull())
			{
				s0_RedBalls.Serialize(writer);
			}
			if (!s0_RedBallsNo.IsNull())
			{
				s0_RedBallsNo.Serialize(writer);
			}
			if (!s0_FiveBallCount.IsNull())
			{
				s0_FiveBallCount.Serialize(writer);
			}
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_PeriodNo.Deserialize(reader);
				s0_RedBalls.Deserialize(reader);
				s0_RedBallsNo.Deserialize(reader);
				s0_FiveBallCount.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				if ((___masking___[0] & 2) != 2)
				{
					s0_PeriodNo.Deserialize(reader);
				}
				else
				{
					s0_PeriodNo.SetNull();
				}
				if ((___masking___[0] & 4) != 4)
				{
					s0_RedBalls.Deserialize(reader);
				}
				else
				{
					s0_RedBalls.SetNull();
				}
				if ((___masking___[0] & 8) != 8)
				{
					s0_RedBallsNo.Deserialize(reader);
				}
				else
				{
					s0_RedBallsNo.SetNull();
				}
				if ((___masking___[0] & 16) != 16)
				{
					s0_FiveBallCount.Deserialize(reader);
				}
				else
				{
					s0_FiveBallCount.SetNull();
				}
			}
		}
	}


	public class Row_RedBalls_String_RedBallsNo_String_partialagg5___Long : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBallsNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("partialagg5__", ColumnDataType.Long, typeof(long), null),
		};
		ScopeRuntime.StringColumnData s0_RedBalls;
		public ScopeRuntime.StringColumnData RedBalls
		{
			get { return s0_RedBalls; }
			set
			{
				s0_RedBalls = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBallsNo;
		public ScopeRuntime.StringColumnData RedBallsNo
		{
			get { return s0_RedBallsNo; }
			set
			{
				s0_RedBallsNo = value;
				_columns[1] = value;
			}
		}
		ScopeRuntime.LongColumnData s0_partialagg5__;
		public ScopeRuntime.LongColumnData partialagg5__
		{
			get { return s0_partialagg5__; }
			set
			{
				s0_partialagg5__ = value;
				_columns[2] = value;
			}
		}
		public Row_RedBalls_String_RedBallsNo_String_partialagg5___Long(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_RedBalls_String_RedBallsNo_String_partialagg5___Long(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_RedBalls_String_RedBallsNo_String_partialagg5___Long() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_RedBalls = (ScopeRuntime.StringColumnData)value;
						break;
					case 1:
						s0_RedBallsNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 2:
						s0_partialagg5__ = (ScopeRuntime.LongColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_RedBalls.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (s0_RedBallsNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 2);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			if (!s0_RedBalls.IsNull())
			{
				s0_RedBalls.Serialize(writer);
			}
			if (!s0_RedBallsNo.IsNull())
			{
				s0_RedBallsNo.Serialize(writer);
			}
			s0_partialagg5__.Serialize(writer);
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_RedBalls.Deserialize(reader);
				s0_RedBallsNo.Deserialize(reader);
				s0_partialagg5__.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				if ((___masking___[0] & 2) != 2)
				{
					s0_RedBalls.Deserialize(reader);
				}
				else
				{
					s0_RedBalls.SetNull();
				}
				if ((___masking___[0] & 4) != 4)
				{
					s0_RedBallsNo.Deserialize(reader);
				}
				else
				{
					s0_RedBallsNo.SetNull();
				}
				s0_partialagg5__.Deserialize(reader);
			}
		}
	}


	public class Row_RedBalls_String_RedBallsNo_String_SixBallCount_Long : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBallsNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("SixBallCount", ColumnDataType.Long, typeof(long), null),
		};
		ScopeRuntime.StringColumnData s0_RedBalls;
		public ScopeRuntime.StringColumnData RedBalls
		{
			get { return s0_RedBalls; }
			set
			{
				s0_RedBalls = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBallsNo;
		public ScopeRuntime.StringColumnData RedBallsNo
		{
			get { return s0_RedBallsNo; }
			set
			{
				s0_RedBallsNo = value;
				_columns[1] = value;
			}
		}
		ScopeRuntime.LongColumnData s0_SixBallCount;
		public ScopeRuntime.LongColumnData SixBallCount
		{
			get { return s0_SixBallCount; }
			set
			{
				s0_SixBallCount = value;
				_columns[2] = value;
			}
		}
		public Row_RedBalls_String_RedBallsNo_String_SixBallCount_Long(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_RedBalls_String_RedBallsNo_String_SixBallCount_Long(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_RedBalls_String_RedBallsNo_String_SixBallCount_Long() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_RedBalls = (ScopeRuntime.StringColumnData)value;
						break;
					case 1:
						s0_RedBallsNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 2:
						s0_SixBallCount = (ScopeRuntime.LongColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_RedBalls.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (s0_RedBallsNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 2);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			if (!s0_RedBalls.IsNull())
			{
				s0_RedBalls.Serialize(writer);
			}
			if (!s0_RedBallsNo.IsNull())
			{
				s0_RedBallsNo.Serialize(writer);
			}
			s0_SixBallCount.Serialize(writer);
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_RedBalls.Deserialize(reader);
				s0_RedBallsNo.Deserialize(reader);
				s0_SixBallCount.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				if ((___masking___[0] & 2) != 2)
				{
					s0_RedBalls.Deserialize(reader);
				}
				else
				{
					s0_RedBalls.SetNull();
				}
				if ((___masking___[0] & 4) != 4)
				{
					s0_RedBallsNo.Deserialize(reader);
				}
				else
				{
					s0_RedBallsNo.SetNull();
				}
				s0_SixBallCount.Deserialize(reader);
			}
		}
	}


	public class Row_SixBallCount_Long_RedBalls1_String : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("SixBallCount", ColumnDataType.Long, typeof(long), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls1", ColumnDataType.String, typeof(string), null),
		};
		ScopeRuntime.LongColumnData s0_SixBallCount;
		public ScopeRuntime.LongColumnData SixBallCount
		{
			get { return s0_SixBallCount; }
			set
			{
				s0_SixBallCount = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBalls1;
		public ScopeRuntime.StringColumnData RedBalls1
		{
			get { return s0_RedBalls1; }
			set
			{
				s0_RedBalls1 = value;
				_columns[1] = value;
			}
		}
		public Row_SixBallCount_Long_RedBalls1_String(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_SixBallCount_Long_RedBalls1_String(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_SixBallCount_Long_RedBalls1_String() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_SixBallCount = (ScopeRuntime.LongColumnData)value;
						break;
					case 1:
						s0_RedBalls1 = (ScopeRuntime.StringColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_RedBalls1.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			s0_SixBallCount.Serialize(writer);
			if (!s0_RedBalls1.IsNull())
			{
				s0_RedBalls1.Serialize(writer);
			}
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_SixBallCount.Deserialize(reader);
				s0_RedBalls1.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				s0_SixBallCount.Deserialize(reader);
				if ((___masking___[0] & 2) != 2)
				{
					s0_RedBalls1.Deserialize(reader);
				}
				else
				{
					s0_RedBalls1.SetNull();
				}
			}
		}
	}


	public class Row_PeriodNo_String_RedBalls_String_RedBallsNo_String_SixBallCount_LongQ : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("PeriodNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBalls", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RedBallsNo", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("SixBallCount", ColumnDataType.LongQ, typeof(long?), null),
		};
		ScopeRuntime.StringColumnData s0_PeriodNo;
		public ScopeRuntime.StringColumnData PeriodNo
		{
			get { return s0_PeriodNo; }
			set
			{
				s0_PeriodNo = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBalls;
		public ScopeRuntime.StringColumnData RedBalls
		{
			get { return s0_RedBalls; }
			set
			{
				s0_RedBalls = value;
				_columns[1] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RedBallsNo;
		public ScopeRuntime.StringColumnData RedBallsNo
		{
			get { return s0_RedBallsNo; }
			set
			{
				s0_RedBallsNo = value;
				_columns[2] = value;
			}
		}
		ScopeRuntime.LongQColumnData s0_SixBallCount;
		public ScopeRuntime.LongQColumnData SixBallCount
		{
			get { return s0_SixBallCount; }
			set
			{
				s0_SixBallCount = value;
				_columns[3] = value;
			}
		}
		public Row_PeriodNo_String_RedBalls_String_RedBallsNo_String_SixBallCount_LongQ(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_PeriodNo_String_RedBalls_String_RedBallsNo_String_SixBallCount_LongQ(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_PeriodNo_String_RedBalls_String_RedBallsNo_String_SixBallCount_LongQ() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_PeriodNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 1:
						s0_RedBalls = (ScopeRuntime.StringColumnData)value;
						break;
					case 2:
						s0_RedBallsNo = (ScopeRuntime.StringColumnData)value;
						break;
					case 3:
						s0_SixBallCount = (ScopeRuntime.LongQColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_PeriodNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (s0_RedBalls.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 2);
			}
			if (s0_RedBallsNo.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 3);
			}
			if (s0_SixBallCount.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 4);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			if (!s0_PeriodNo.IsNull())
			{
				s0_PeriodNo.Serialize(writer);
			}
			if (!s0_RedBalls.IsNull())
			{
				s0_RedBalls.Serialize(writer);
			}
			if (!s0_RedBallsNo.IsNull())
			{
				s0_RedBallsNo.Serialize(writer);
			}
			if (!s0_SixBallCount.IsNull())
			{
				s0_SixBallCount.Serialize(writer);
			}
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_PeriodNo.Deserialize(reader);
				s0_RedBalls.Deserialize(reader);
				s0_RedBallsNo.Deserialize(reader);
				s0_SixBallCount.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				if ((___masking___[0] & 2) != 2)
				{
					s0_PeriodNo.Deserialize(reader);
				}
				else
				{
					s0_PeriodNo.SetNull();
				}
				if ((___masking___[0] & 4) != 4)
				{
					s0_RedBalls.Deserialize(reader);
				}
				else
				{
					s0_RedBalls.SetNull();
				}
				if ((___masking___[0] & 8) != 8)
				{
					s0_RedBallsNo.Deserialize(reader);
				}
				else
				{
					s0_RedBallsNo.SetNull();
				}
				if ((___masking___[0] & 16) != 16)
				{
					s0_SixBallCount.Deserialize(reader);
				}
				else
				{
					s0_SixBallCount.SetNull();
				}
			}
		}
	}


	public class ScopeFilterTransformer_21 : ScopeRuntime.Processor
	{
		public override IEnumerable<Row> Process(RowSet input, Row outputRow, string[] args)
		{
			Row_RedBallsNo_String_PeriodNo_String_RedBalls_String outRow = (Row_RedBallsNo_String_PeriodNo_String_RedBalls_String)outputRow;
			foreach(Row_PeriodNo_String_RedBalls_String row in input.Rows)
			{
				StringColumnData col_PeriodNo = row.PeriodNo;
				string col_RedBalls = row.RedBalls.String;
				bool bPicked = false;
				int exceptionIndex = 0;
				try
				{
					{
						bPicked = true;
						outRow.RedBallsNo.Set((DCBallHelper.DecodeBalls(col_RedBalls)));
						exceptionIndex++;
						outRow.PeriodNo.Set((col_PeriodNo));
						exceptionIndex++;
						outRow.RedBalls.Set((col_RedBalls));
						exceptionIndex++;
					}
				}
				catch (Exception exception)
				{
					throw new ScopeUserExpressionException(exceptionsInfo[exceptionIndex], row.Dump(), exception);
				}
				if(bPicked)
				{
					yield return outRow;
				}
			} // end of foreach Row_PeriodNo_String_RedBalls_String
		}
		public static string[] exceptionsInfo = 
		{
			@"DCBallHelper.DecodeBalls(RedBalls)",
			@"PeriodNo",
			@"RedBalls",
		};
	}


	public static System.Type[] __UdtTypeTable__ =
	{
		
	};

	public static class __OperatorFactory__
	{
		public static ScopeRuntime.Processor Create_Process_1()
		{
			return new ___Scope_Generated_Classes___.ScopeFilterTransformer_21();
		}
	}
}

	static public class UDTExtensionWrapper
	{
                public static T Create<T>() where T : new() 
                { 
                    return new T(); 
                }

                private static readonly Dictionary<System.Collections.Generic.IEqualityComparer<string>, byte> StringComparerToByteMap =
                    new Dictionary<System.Collections.Generic.IEqualityComparer<string>, byte>()
                    {
                        {System.Collections.Generic.EqualityComparer<string>.Default, 0},
                        {System.StringComparer.CurrentCulture, 1},
                        {System.StringComparer.CurrentCultureIgnoreCase, 2},
                        {System.StringComparer.InvariantCulture, 3},
                        {System.StringComparer.InvariantCultureIgnoreCase, 4},
                        {System.StringComparer.Ordinal, 5},
                        {System.StringComparer.OrdinalIgnoreCase, 6},
                    };

                private static readonly Dictionary<byte, System.Collections.Generic.IEqualityComparer<string>> ByteToStringComparerMap =
                    System.Linq.Enumerable.ToDictionary(StringComparerToByteMap, kvp => kvp.Value, kvp => kvp.Key);

                public static void Read(BinaryValueReader reader, out System.StringComparer value)
                {
                    byte comparerKey;
                    reader.Read(out comparerKey);
                    value = ByteToStringComparerMap[comparerKey] as System.StringComparer;
                }

                public static void Write(BinaryValueWriter writer, System.StringComparer value)
                {
                    // If System.StringComparer is not one of the 6 we recognize, comparerKey should be 0.
                    byte comparerKey;
                    StringComparerToByteMap.TryGetValue(value as System.Collections.Generic.IEqualityComparer<string> ?? System.Collections.Generic.EqualityComparer<string>.Default, out comparerKey);
                    writer.Write(comparerKey);
                }

                static public ScopeStruct       ScopeClone(this ScopeStruct value, ReferenceHashTable<object> seenObject)
                {
                    return (ScopeStruct)new StructColumnData(value).Clone().Value;
                }

                static public ScopeMap<K,V>     ScopeClone<K,V>(this ScopeMap<K,V> value, ReferenceHashTable<object> seenObject)
                {
                    return (ScopeMap<K,V>)new MapColumnData<K,V>(value).Clone().Value;
                }

                static public ScopeArray<T>     ScopeClone<T>(this ScopeArray<T> value, ReferenceHashTable<object> seenObject)
                {
                    return (ScopeArray<T>)new ArrayColumnData<T>(value).Clone().Value;
                }

                static public void Write<T>(BinaryValueWriter writer, ScopeArray<T> v)
                {
                    writer.Write(v);
                }

                static public void Read<T>(BinaryValueReader reader, out ScopeArray<T> v)
                {
                    reader.Read(out v);
                } 

                static public void Write<K,V>(BinaryValueWriter writer, ScopeMap<K,V> v)
                {
                    writer.Write(v);
                }

                static public void Read<K,V>(BinaryValueReader reader, out ScopeMap<K,V> v)
                {
                    reader.Read(out v);
                }                 
                

	}