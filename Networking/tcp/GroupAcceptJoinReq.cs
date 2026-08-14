using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CD4")]
public class GroupAcceptJoinReq
{
	[Token(Token = "0x400B6A8")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x400B6A9")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Cjoiner_account_id_003Ek__BackingField;

	[Token(Token = "0x400B6AA")]
	[FieldOffset(Offset = "0x18")]
	private EGroup.InviteeType _003Cinvitee_type_003Ek__BackingField;

	[Token(Token = "0x17000B0F")]
	public ulong group_id
	{
		[Token(Token = "0x600854D")]
		[Address(RVA = "0x33EA090", Offset = "0x33EA090", VA = "0x33EA090")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600854E")]
		[Address(RVA = "0x33EA098", Offset = "0x33EA098", VA = "0x33EA098")]
		set
		{
		}
	}

	[Token(Token = "0x17000B10")]
	public ulong joiner_account_id
	{
		[Token(Token = "0x600854F")]
		[Address(RVA = "0x33EA0A8", Offset = "0x33EA0A8", VA = "0x33EA0A8")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008550")]
		[Address(RVA = "0x33EA0B0", Offset = "0x33EA0B0", VA = "0x33EA0B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B11")]
	public EGroup.InviteeType invitee_type
	{
		[Token(Token = "0x6008551")]
		[Address(RVA = "0x33EA0C0", Offset = "0x33EA0C0", VA = "0x33EA0C0")]
		get
		{
			return default(EGroup.InviteeType);
		}
		[Token(Token = "0x6008552")]
		[Address(RVA = "0x33EA0C8", Offset = "0x33EA0C8", VA = "0x33EA0C8")]
		set
		{
		}
	}

	[Token(Token = "0x600854C")]
	[Address(RVA = "0x33EA088", Offset = "0x33EA088", VA = "0x33EA088")]
	public GroupAcceptJoinReq()
	{
	}
}
