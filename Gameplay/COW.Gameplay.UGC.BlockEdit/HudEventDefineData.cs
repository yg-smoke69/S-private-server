using System;
using Il2CppDummyDll;
using LitJson;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B89")]
public class HudEventDefineData
{
	[Token(Token = "0x40061A0")]
	[FieldOffset(Offset = "0x8")]
	public string id;

	[Token(Token = "0x40061A1")]
	[FieldOffset(Offset = "0xC")]
	public Action onChanged;

	[Token(Token = "0x40061A2")]
	[FieldOffset(Offset = "0x10")]
	public BlockEditContext Context;

	[Token(Token = "0x40061A3")]
	[FieldOffset(Offset = "0x14")]
	public GraphData Graph;

	[Token(Token = "0x40061A4")]
	[FieldOffset(Offset = "0x18")]
	protected BlockData m_BlockData;

	[Token(Token = "0x40061A5")]
	[FieldOffset(Offset = "0x1C")]
	protected int m_WidgetId;

	[Token(Token = "0x40061A6")]
	[FieldOffset(Offset = "0x20")]
	protected string m_TypeName;

	[Token(Token = "0x40061A7")]
	[FieldOffset(Offset = "0x24")]
	protected string m_WidgetName;

	[Token(Token = "0x40061A8")]
	[FieldOffset(Offset = "0x28")]
	protected int m_LogicEntityType;

	[Token(Token = "0x40061A9")]
	[FieldOffset(Offset = "0x2C")]
	protected string m_EntityID;

	[Token(Token = "0x40061AA")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsMissingRef;

	[Token(Token = "0x17000700")]
	public string WidgetName
	{
		[Token(Token = "0x600579D")]
		[Address(RVA = "0x2F4A5D4", Offset = "0x2F4A5D4", VA = "0x2F4A5D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000701")]
	public int WidgetId
	{
		[Token(Token = "0x600579E")]
		[Address(RVA = "0x2F4A710", Offset = "0x2F4A710", VA = "0x2F4A710")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600579F")]
		[Address(RVA = "0x2F4A768", Offset = "0x2F4A768", VA = "0x2F4A768")]
		set
		{
		}
	}

	[Token(Token = "0x17000702")]
	public int LogicEntityType
	{
		[Token(Token = "0x60057A0")]
		[Address(RVA = "0x2F4A804", Offset = "0x2F4A804", VA = "0x2F4A804")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60057A1")]
		[Address(RVA = "0x2F4A85C", Offset = "0x2F4A85C", VA = "0x2F4A85C")]
		set
		{
		}
	}

	[Token(Token = "0x17000703")]
	public string EntityID
	{
		[Token(Token = "0x60057A2")]
		[Address(RVA = "0x2F4A8C8", Offset = "0x2F4A8C8", VA = "0x2F4A8C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000704")]
	public bool MissingRef
	{
		[Token(Token = "0x60057A3")]
		[Address(RVA = "0x2F4A920", Offset = "0x2F4A920", VA = "0x2F4A920")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000705")]
	public BlockData EventData
	{
		[Token(Token = "0x60057A4")]
		[Address(RVA = "0x2F4A978", Offset = "0x2F4A978", VA = "0x2F4A978")]
		get
		{
			return null;
		}
		[Token(Token = "0x60057A5")]
		[Address(RVA = "0x2F4A9D0", Offset = "0x2F4A9D0", VA = "0x2F4A9D0")]
		set
		{
		}
	}

	[Token(Token = "0x600579C")]
	[Address(RVA = "0x2F4A5CC", Offset = "0x2F4A5CC", VA = "0x2F4A5CC")]
	public HudEventDefineData()
	{
	}

	[Token(Token = "0x60057A6")]
	[Address(RVA = "0x2F4AA54", Offset = "0x2F4AA54", VA = "0x2F4AA54")]
	public bool FromJsonData(BlockEditContext context, JsonData jsonData)
	{
		return default(bool);
	}

	[Token(Token = "0x60057A7")]
	[Address(RVA = "0x2F4ACC0", Offset = "0x2F4ACC0", VA = "0x2F4ACC0")]
	public bool ToJsonData(BlockEditContext context, JsonWriter jsonWriter)
	{
		return default(bool);
	}

	[Token(Token = "0x60057A8")]
	[Address(RVA = "0x2F4AE80", Offset = "0x2F4AE80", VA = "0x2F4AE80")]
	public KDNPLMHKBHC ToExportProtoData(BlockEditContext context)
	{
		return null;
	}
}
