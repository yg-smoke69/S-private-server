using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000140")]
internal class GameFunctionSwitchData : CSVBaseData
{
	[Token(Token = "0x4000813")]
	[FieldOffset(Offset = "0x8")]
	private FunctionType m_FunctionType;

	[Token(Token = "0x4000814")]
	[FieldOffset(Offset = "0xC")]
	private FunctionType _003CFunctionType_003Ek__BackingField;

	[Token(Token = "0x4000815")]
	[FieldOffset(Offset = "0x10")]
	private string m_FunctionName;

	[Token(Token = "0x4000816")]
	[FieldOffset(Offset = "0x14")]
	private string _003CFunctionName_003Ek__BackingField;

	[Token(Token = "0x4000817")]
	[FieldOffset(Offset = "0x18")]
	private int m_LevelLimit;

	[Token(Token = "0x4000818")]
	[FieldOffset(Offset = "0x1C")]
	private int _003CLevelLimit_003Ek__BackingField;

	[Token(Token = "0x4000819")]
	[FieldOffset(Offset = "0x20")]
	private bool m_IsOpen;

	[Token(Token = "0x400081A")]
	[FieldOffset(Offset = "0x21")]
	private bool _003CIsOpen_003Ek__BackingField;

	[Token(Token = "0x17000125")]
	public FunctionType FunctionType
	{
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x1DD3754", Offset = "0x1DD3754", VA = "0x1DD3754")]
		get
		{
			return default(FunctionType);
		}
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x1DD375C", Offset = "0x1DD375C", VA = "0x1DD375C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000126")]
	public string FunctionName
	{
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x1DD3764", Offset = "0x1DD3764", VA = "0x1DD3764")]
		get
		{
			return null;
		}
		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x1DD376C", Offset = "0x1DD376C", VA = "0x1DD376C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000127")]
	public int LevelLimit
	{
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x1DD3774", Offset = "0x1DD3774", VA = "0x1DD3774")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x1DD377C", Offset = "0x1DD377C", VA = "0x1DD377C")]
		set
		{
		}
	}

	[Token(Token = "0x17000128")]
	public bool IsOpen
	{
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x1DD3784", Offset = "0x1DD3784", VA = "0x1DD3784")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x1DD378C", Offset = "0x1DD378C", VA = "0x1DD378C")]
		private set
		{
		}
	}

	[Token(Token = "0x60007A0")]
	[Address(RVA = "0x1DD36D0", Offset = "0x1DD36D0", VA = "0x1DD36D0")]
	public GameFunctionSwitchData()
	{
	}

	[Token(Token = "0x60007A9")]
	[Address(RVA = "0x1DD3794", Offset = "0x1DD3794", VA = "0x1DD3794", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60007AA")]
	[Address(RVA = "0x1DD38AC", Offset = "0x1DD38AC", VA = "0x1DD38AC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
