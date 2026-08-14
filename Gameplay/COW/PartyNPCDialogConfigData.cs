using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001CF")]
internal class PartyNPCDialogConfigData : CSVBaseData
{
	[Token(Token = "0x4000B0B")]
	[FieldOffset(Offset = "0x8")]
	private uint _003CGroupID_003Ek__BackingField;

	[Token(Token = "0x4000B0C")]
	[FieldOffset(Offset = "0xC")]
	private uint _003CCharID_003Ek__BackingField;

	[Token(Token = "0x4000B0D")]
	[FieldOffset(Offset = "0x10")]
	private string _003CCharDialog_003Ek__BackingField;

	[Token(Token = "0x4000B0E")]
	[FieldOffset(Offset = "0x14")]
	private uint _003COrder_003Ek__BackingField;

	[Token(Token = "0x17000151")]
	public uint GroupID
	{
		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x28D12E8", Offset = "0x28D12E8", VA = "0x28D12E8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x28D12F0", Offset = "0x28D12F0", VA = "0x28D12F0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000152")]
	public uint CharID
	{
		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x28D12F8", Offset = "0x28D12F8", VA = "0x28D12F8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x28D1300", Offset = "0x28D1300", VA = "0x28D1300")]
		private set
		{
		}
	}

	[Token(Token = "0x17000153")]
	public string CharDialog
	{
		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x28D1308", Offset = "0x28D1308", VA = "0x28D1308")]
		get
		{
			return null;
		}
		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x28D1310", Offset = "0x28D1310", VA = "0x28D1310")]
		private set
		{
		}
	}

	[Token(Token = "0x17000154")]
	public uint Order
	{
		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x28D1318", Offset = "0x28D1318", VA = "0x28D1318")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x28D1320", Offset = "0x28D1320", VA = "0x28D1320")]
		private set
		{
		}
	}

	[Token(Token = "0x60009B7")]
	[Address(RVA = "0x28D1264", Offset = "0x28D1264", VA = "0x28D1264")]
	public PartyNPCDialogConfigData()
	{
	}

	[Token(Token = "0x60009C0")]
	[Address(RVA = "0x28D1328", Offset = "0x28D1328", VA = "0x28D1328", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60009C1")]
	[Address(RVA = "0x28D13B0", Offset = "0x28D13B0", VA = "0x28D13B0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
