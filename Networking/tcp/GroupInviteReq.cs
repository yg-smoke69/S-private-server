using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CD0")]
public class GroupInviteReq
{
	[Token(Token = "0x400B682")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cinvitee_id_003Ek__BackingField;

	[Token(Token = "0x400B683")]
	[FieldOffset(Offset = "0x10")]
	private string _003Cinvitee_region_003Ek__BackingField;

	[Token(Token = "0x400B684")]
	[FieldOffset(Offset = "0x14")]
	private EGroup.InviteChannelType _003Cchannel_type_003Ek__BackingField;

	[Token(Token = "0x400B685")]
	[FieldOffset(Offset = "0x18")]
	private EGroup.InviteeType _003Cinvitee_type_003Ek__BackingField;

	[Token(Token = "0x17000AE9")]
	public ulong invitee_id
	{
		[Token(Token = "0x60084FD")]
		[Address(RVA = "0x33EAAC0", Offset = "0x33EAAC0", VA = "0x33EAAC0")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60084FE")]
		[Address(RVA = "0x33EAAC8", Offset = "0x33EAAC8", VA = "0x33EAAC8")]
		set
		{
		}
	}

	[Token(Token = "0x17000AEA")]
	public string invitee_region
	{
		[Token(Token = "0x60084FF")]
		[Address(RVA = "0x33EAAD8", Offset = "0x33EAAD8", VA = "0x33EAAD8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008500")]
		[Address(RVA = "0x33EAAB8", Offset = "0x33EAAB8", VA = "0x33EAAB8")]
		set
		{
		}
	}

	[Token(Token = "0x17000AEB")]
	public EGroup.InviteChannelType channel_type
	{
		[Token(Token = "0x6008501")]
		[Address(RVA = "0x33EAAE0", Offset = "0x33EAAE0", VA = "0x33EAAE0")]
		get
		{
			return default(EGroup.InviteChannelType);
		}
		[Token(Token = "0x6008502")]
		[Address(RVA = "0x33EAAE8", Offset = "0x33EAAE8", VA = "0x33EAAE8")]
		set
		{
		}
	}

	[Token(Token = "0x17000AEC")]
	public EGroup.InviteeType invitee_type
	{
		[Token(Token = "0x6008503")]
		[Address(RVA = "0x33EAAF0", Offset = "0x33EAAF0", VA = "0x33EAAF0")]
		get
		{
			return default(EGroup.InviteeType);
		}
		[Token(Token = "0x6008504")]
		[Address(RVA = "0x33EAAF8", Offset = "0x33EAAF8", VA = "0x33EAAF8")]
		set
		{
		}
	}

	[Token(Token = "0x60084FC")]
	[Address(RVA = "0x33EAA18", Offset = "0x33EAA18", VA = "0x33EAA18")]
	public GroupInviteReq()
	{
	}
}
