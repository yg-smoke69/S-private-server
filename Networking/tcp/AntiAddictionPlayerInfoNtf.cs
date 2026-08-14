using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C5D")]
public class AntiAddictionPlayerInfoNtf
{
	[Token(Token = "0x400B470")]
	[FieldOffset(Offset = "0x8")]
	private string _003Cnick_name_003Ek__BackingField;

	[Token(Token = "0x400B471")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Cban_mode_003Ek__BackingField;

	[Token(Token = "0x17000A0F")]
	public string nick_name
	{
		[Token(Token = "0x60082FB")]
		[Address(RVA = "0x33E7C88", Offset = "0x33E7C88", VA = "0x33E7C88")]
		get
		{
			return null;
		}
		[Token(Token = "0x60082FC")]
		[Address(RVA = "0x33E7C80", Offset = "0x33E7C80", VA = "0x33E7C80")]
		set
		{
		}
	}

	[Token(Token = "0x17000A10")]
	public uint ban_mode
	{
		[Token(Token = "0x60082FD")]
		[Address(RVA = "0x33E7C90", Offset = "0x33E7C90", VA = "0x33E7C90")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60082FE")]
		[Address(RVA = "0x33E7C98", Offset = "0x33E7C98", VA = "0x33E7C98")]
		set
		{
		}
	}

	[Token(Token = "0x60082FA")]
	[Address(RVA = "0x33E7BE0", Offset = "0x33E7BE0", VA = "0x33E7BE0")]
	public AntiAddictionPlayerInfoNtf()
	{
	}
}
