using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001C8")]
internal class PartyInteractiveNPCDialogConfigData : CSVBaseData
{
	[Token(Token = "0x4000AF1")]
	[FieldOffset(Offset = "0x8")]
	private uint _003CID_003Ek__BackingField;

	[Token(Token = "0x4000AF2")]
	[FieldOffset(Offset = "0xC")]
	private string _003CContent_003Ek__BackingField;

	[Token(Token = "0x4000AF3")]
	[FieldOffset(Offset = "0x10")]
	private string _003CNextID_003Ek__BackingField;

	[Token(Token = "0x4000AF4")]
	[FieldOffset(Offset = "0x14")]
	private bool _003CIsNPC_003Ek__BackingField;

	[Token(Token = "0x17000146")]
	public uint ID
	{
		[Token(Token = "0x600098C")]
		[Address(RVA = "0x28D00D8", Offset = "0x28D00D8", VA = "0x28D00D8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600098D")]
		[Address(RVA = "0x28D00E0", Offset = "0x28D00E0", VA = "0x28D00E0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000147")]
	public string Content
	{
		[Token(Token = "0x600098E")]
		[Address(RVA = "0x28D00E8", Offset = "0x28D00E8", VA = "0x28D00E8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600098F")]
		[Address(RVA = "0x28D00F0", Offset = "0x28D00F0", VA = "0x28D00F0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000148")]
	public string NextID
	{
		[Token(Token = "0x6000990")]
		[Address(RVA = "0x28D00F8", Offset = "0x28D00F8", VA = "0x28D00F8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000991")]
		[Address(RVA = "0x28D0100", Offset = "0x28D0100", VA = "0x28D0100")]
		private set
		{
		}
	}

	[Token(Token = "0x17000149")]
	public bool IsNPC
	{
		[Token(Token = "0x6000992")]
		[Address(RVA = "0x28D0108", Offset = "0x28D0108", VA = "0x28D0108")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000993")]
		[Address(RVA = "0x28D0110", Offset = "0x28D0110", VA = "0x28D0110")]
		private set
		{
		}
	}

	[Token(Token = "0x600098B")]
	[Address(RVA = "0x28D0054", Offset = "0x28D0054", VA = "0x28D0054")]
	public PartyInteractiveNPCDialogConfigData()
	{
	}

	[Token(Token = "0x6000994")]
	[Address(RVA = "0x28D0118", Offset = "0x28D0118", VA = "0x28D0118", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000995")]
	[Address(RVA = "0x28D0194", Offset = "0x28D0194", VA = "0x28D0194", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
