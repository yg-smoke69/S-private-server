using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C8D")]
public class InviteToClanReq
{
	[Token(Token = "0x400B524")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cinviter_id_003Ek__BackingField;

	[Token(Token = "0x400B525")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Cclan_id_003Ek__BackingField;

	[Token(Token = "0x400B526")]
	[FieldOffset(Offset = "0x18")]
	private string _003Cclan_name_003Ek__BackingField;

	[Token(Token = "0x400B527")]
	[FieldOffset(Offset = "0x1C")]
	private string _003Cinviter_name_003Ek__BackingField;

	[Token(Token = "0x17000A5E")]
	public ulong inviter_id
	{
		[Token(Token = "0x60083BA")]
		[Address(RVA = "0x33EBD50", Offset = "0x33EBD50", VA = "0x33EBD50")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60083BB")]
		[Address(RVA = "0x33EBD58", Offset = "0x33EBD58", VA = "0x33EBD58")]
		set
		{
		}
	}

	[Token(Token = "0x17000A5F")]
	public ulong clan_id
	{
		[Token(Token = "0x60083BC")]
		[Address(RVA = "0x33EBD68", Offset = "0x33EBD68", VA = "0x33EBD68")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60083BD")]
		[Address(RVA = "0x33EBD70", Offset = "0x33EBD70", VA = "0x33EBD70")]
		set
		{
		}
	}

	[Token(Token = "0x17000A60")]
	public string clan_name
	{
		[Token(Token = "0x60083BE")]
		[Address(RVA = "0x33EBD80", Offset = "0x33EBD80", VA = "0x33EBD80")]
		get
		{
			return null;
		}
		[Token(Token = "0x60083BF")]
		[Address(RVA = "0x33EBD40", Offset = "0x33EBD40", VA = "0x33EBD40")]
		set
		{
		}
	}

	[Token(Token = "0x17000A61")]
	public string inviter_name
	{
		[Token(Token = "0x60083C0")]
		[Address(RVA = "0x33EBD88", Offset = "0x33EBD88", VA = "0x33EBD88")]
		get
		{
			return null;
		}
		[Token(Token = "0x60083C1")]
		[Address(RVA = "0x33EBD48", Offset = "0x33EBD48", VA = "0x33EBD48")]
		set
		{
		}
	}

	[Token(Token = "0x60083B9")]
	[Address(RVA = "0x33EBC94", Offset = "0x33EBC94", VA = "0x33EBC94")]
	public InviteToClanReq()
	{
	}
}
