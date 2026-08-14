using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ReactUI;

[Serializable]
[Token(Token = "0x2000CB8")]
public sealed class UIMapVariable
{
	[Serializable]
	[Token(Token = "0x2000CB9")]
	public class MapKV
	{
		[Token(Token = "0x400677B")]
		[FieldOffset(Offset = "0x8")]
		public bool BoolKey;

		[Token(Token = "0x400677C")]
		[FieldOffset(Offset = "0x9")]
		public bool BoolValue;

		[Token(Token = "0x400677D")]
		[FieldOffset(Offset = "0xC")]
		public int IntKey;

		[Token(Token = "0x400677E")]
		[FieldOffset(Offset = "0x10")]
		public int IntValue;

		[Token(Token = "0x400677F")]
		[FieldOffset(Offset = "0x14")]
		public float FloatKey;

		[Token(Token = "0x4006780")]
		[FieldOffset(Offset = "0x18")]
		public float FloatValue;

		[Token(Token = "0x4006781")]
		[FieldOffset(Offset = "0x1C")]
		public string StringKey;

		[Token(Token = "0x4006782")]
		[FieldOffset(Offset = "0x20")]
		public string StringValue;

		[Token(Token = "0x60060DC")]
		[Address(RVA = "0x315C67C", Offset = "0x315C67C", VA = "0x315C67C")]
		public MapKV()
		{
		}
	}

	[Token(Token = "0x4006777")]
	[FieldOffset(Offset = "0x8")]
	private int srcVarIdx;

	[Token(Token = "0x4006778")]
	[FieldOffset(Offset = "0xC")]
	private UIVariable outVariable;

	[Token(Token = "0x4006779")]
	[FieldOffset(Offset = "0x10")]
	public List<MapKV> map;

	[Token(Token = "0x400677A")]
	[FieldOffset(Offset = "0x14")]
	private UIVariable srcVariable;

	[Token(Token = "0x1700080F")]
	public UIVariable OutVariable
	{
		[Token(Token = "0x60060CE")]
		[Address(RVA = "0x315AAE4", Offset = "0x315AAE4", VA = "0x315AAE4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000810")]
	public bool IsValid
	{
		[Token(Token = "0x60060CF")]
		[Address(RVA = "0x315AAEC", Offset = "0x315AAEC", VA = "0x315AAEC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000811")]
	public UIVariableType SrcType
	{
		[Token(Token = "0x60060DA")]
		[Address(RVA = "0x315C574", Offset = "0x315C574", VA = "0x315C574")]
		get
		{
			return default(UIVariableType);
		}
	}

	[Token(Token = "0x60060CD")]
	[Address(RVA = "0x315AA50", Offset = "0x315AA50", VA = "0x315AA50")]
	public UIMapVariable()
	{
	}

	[Token(Token = "0x60060D0")]
	[Address(RVA = "0x315ABA8", Offset = "0x315ABA8", VA = "0x315ABA8")]
	public void SetSrcVariable(UIVariableTable variableTable, int srcIdx)
	{
	}

	[Token(Token = "0x60060D1")]
	[Address(RVA = "0x315ABB0", Offset = "0x315ABB0", VA = "0x315ABB0")]
	public void Init(UIVariableTable variableTable)
	{
	}

	[Token(Token = "0x60060D2")]
	[Address(RVA = "0x315ACCC", Offset = "0x315ACCC", VA = "0x315ACCC")]
	public void BindEvent()
	{
	}

	[Token(Token = "0x60060D3")]
	[Address(RVA = "0x315AF80", Offset = "0x315AF80", VA = "0x315AF80")]
	public void UnBindEvent()
	{
	}

	[Token(Token = "0x60060D4")]
	[Address(RVA = "0x315B234", Offset = "0x315B234", VA = "0x315B234")]
	public void UpdateValues()
	{
	}

	[Token(Token = "0x60060D5")]
	[Address(RVA = "0x315BB84", Offset = "0x315BB84", VA = "0x315BB84")]
	private void MapSrcValueBoolean(bool srcVal)
	{
	}

	[Token(Token = "0x60060D6")]
	[Address(RVA = "0x315BD44", Offset = "0x315BD44", VA = "0x315BD44")]
	private void MapSrcValueInt(int srcVal)
	{
	}

	[Token(Token = "0x60060D7")]
	[Address(RVA = "0x315BF0C", Offset = "0x315BF0C", VA = "0x315BF0C")]
	private void MapSrcValueFloat(float srcVal)
	{
	}

	[Token(Token = "0x60060D8")]
	[Address(RVA = "0x315C168", Offset = "0x315C168", VA = "0x315C168")]
	private void MapSrcValueString(string srcVal)
	{
	}

	[Token(Token = "0x60060D9")]
	[Address(RVA = "0x315B9D4", Offset = "0x315B9D4", VA = "0x315B9D4")]
	private void SetOutVariable(MapKV _map)
	{
	}

	[Token(Token = "0x60060DB")]
	[Address(RVA = "0x315C588", Offset = "0x315C588", VA = "0x315C588")]
	public void AddDefaultMapElement()
	{
	}
}
