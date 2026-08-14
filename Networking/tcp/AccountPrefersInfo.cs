using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001DB2")]
public class AccountPrefersInfo
{
	[Token(Token = "0x400BC39")]
	[FieldOffset(Offset = "0x8")]
	private uint[] _003Cpregame_show_choices_003Ek__BackingField;

	[Token(Token = "0x400BC3A")]
	[FieldOffset(Offset = "0xC")]
	private bool _003Chide_captain_lobby_003Ek__BackingField;

	[Token(Token = "0x17000EDF")]
	public uint[] pregame_show_choices
	{
		[Token(Token = "0x6008D9B")]
		[Address(RVA = "0x33E7814", Offset = "0x33E7814", VA = "0x33E7814")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008D9C")]
		[Address(RVA = "0x33E781C", Offset = "0x33E781C", VA = "0x33E781C")]
		set
		{
		}
	}

	[Token(Token = "0x17000EE0")]
	public bool hide_captain_lobby
	{
		[Token(Token = "0x6008D9D")]
		[Address(RVA = "0x33E7824", Offset = "0x33E7824", VA = "0x33E7824")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008D9E")]
		[Address(RVA = "0x33E782C", Offset = "0x33E782C", VA = "0x33E782C")]
		set
		{
		}
	}

	[Token(Token = "0x6008D9A")]
	[Address(RVA = "0x33E780C", Offset = "0x33E780C", VA = "0x33E780C")]
	public AccountPrefersInfo()
	{
	}
}
