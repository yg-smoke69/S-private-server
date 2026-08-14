using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C64")]
public class NewPlayerLevelUpTaskUpdateInfo
{
	[Token(Token = "0x400B47E")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Cid_003Ek__BackingField;

	[Token(Token = "0x400B47F")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Cstate_003Ek__BackingField;

	[Token(Token = "0x17000A18")]
	public uint id
	{
		[Token(Token = "0x6008312")]
		[Address(RVA = "0x435CA88", Offset = "0x435CA88", VA = "0x435CA88")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008313")]
		[Address(RVA = "0x435CA90", Offset = "0x435CA90", VA = "0x435CA90")]
		set
		{
		}
	}

	[Token(Token = "0x17000A19")]
	public uint state
	{
		[Token(Token = "0x6008314")]
		[Address(RVA = "0x435CA98", Offset = "0x435CA98", VA = "0x435CA98")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008315")]
		[Address(RVA = "0x435CAA0", Offset = "0x435CAA0", VA = "0x435CAA0")]
		set
		{
		}
	}

	[Token(Token = "0x6008311")]
	[Address(RVA = "0x435CA80", Offset = "0x435CA80", VA = "0x435CA80")]
	public NewPlayerLevelUpTaskUpdateInfo()
	{
	}
}
