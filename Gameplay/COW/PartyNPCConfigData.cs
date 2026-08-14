using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001CE")]
internal class PartyNPCConfigData : CSVBaseData
{
	[Token(Token = "0x4000B04")]
	[FieldOffset(Offset = "0x8")]
	private uint _003CNPCID_003Ek__BackingField;

	[Token(Token = "0x4000B05")]
	[FieldOffset(Offset = "0xC")]
	private uint _003CCharID_003Ek__BackingField;

	[Token(Token = "0x4000B06")]
	[FieldOffset(Offset = "0x10")]
	private string _003CCharName_003Ek__BackingField;

	[Token(Token = "0x4000B07")]
	[FieldOffset(Offset = "0x14")]
	private uint _003CCharSuit_003Ek__BackingField;

	[Token(Token = "0x4000B08")]
	[FieldOffset(Offset = "0x18")]
	private ResourceID _003CActionID_003Ek__BackingField;

	[Token(Token = "0x4000B09")]
	[FieldOffset(Offset = "0x1C")]
	private bool _003CIsInteractive_003Ek__BackingField;

	[Token(Token = "0x4000B0A")]
	[FieldOffset(Offset = "0x20")]
	private uint _003CDialogID_003Ek__BackingField;

	[Token(Token = "0x1700014A")]
	public uint NPCID
	{
		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x28D0CBC", Offset = "0x28D0CBC", VA = "0x28D0CBC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x28D0CC4", Offset = "0x28D0CC4", VA = "0x28D0CC4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700014B")]
	public uint CharID
	{
		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x28D0CCC", Offset = "0x28D0CCC", VA = "0x28D0CCC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x28D0CD4", Offset = "0x28D0CD4", VA = "0x28D0CD4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700014C")]
	public string CharName
	{
		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x28D0CDC", Offset = "0x28D0CDC", VA = "0x28D0CDC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x28D0CE4", Offset = "0x28D0CE4", VA = "0x28D0CE4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700014D")]
	public uint CharSuit
	{
		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x28D0CEC", Offset = "0x28D0CEC", VA = "0x28D0CEC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x28D0CF4", Offset = "0x28D0CF4", VA = "0x28D0CF4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700014E")]
	public ResourceID ActionID
	{
		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x28D0CFC", Offset = "0x28D0CFC", VA = "0x28D0CFC")]
		get
		{
			return default(ResourceID);
		}
		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x28D0D04", Offset = "0x28D0D04", VA = "0x28D0D04")]
		private set
		{
		}
	}

	[Token(Token = "0x1700014F")]
	public bool IsInteractive
	{
		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x28D0D0C", Offset = "0x28D0D0C", VA = "0x28D0D0C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x28D0D14", Offset = "0x28D0D14", VA = "0x28D0D14")]
		private set
		{
		}
	}

	[Token(Token = "0x17000150")]
	public uint DialogID
	{
		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x28D0D1C", Offset = "0x28D0D1C", VA = "0x28D0D1C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x28D0D24", Offset = "0x28D0D24", VA = "0x28D0D24")]
		private set
		{
		}
	}

	[Token(Token = "0x60009A5")]
	[Address(RVA = "0x28D0C38", Offset = "0x28D0C38", VA = "0x28D0C38")]
	public PartyNPCConfigData()
	{
	}

	[Token(Token = "0x60009B4")]
	[Address(RVA = "0x28D0D2C", Offset = "0x28D0D2C", VA = "0x28D0D2C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60009B5")]
	[Address(RVA = "0x28D0DA8", Offset = "0x28D0DA8", VA = "0x28D0DA8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x60009B6")]
	[Address(RVA = "0x28D1008", Offset = "0x28D1008", VA = "0x28D1008")]
	public static PartyNPCConfigData GetDataByCharID(uint charID)
	{
		return null;
	}
}
