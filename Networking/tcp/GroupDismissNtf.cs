using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CE1")]
public class GroupDismissNtf
{
	[Token(Token = "0x400B6D9")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cleaver_id_003Ek__BackingField;

	[Token(Token = "0x400B6DA")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x400B6DB")]
	[FieldOffset(Offset = "0x18")]
	private EGroup.LeaveReason _003Creason_003Ek__BackingField;

	[Token(Token = "0x17000B40")]
	public ulong leaver_id
	{
		[Token(Token = "0x60085BC")]
		[Address(RVA = "0x33EA630", Offset = "0x33EA630", VA = "0x33EA630")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60085BD")]
		[Address(RVA = "0x33EA638", Offset = "0x33EA638", VA = "0x33EA638")]
		set
		{
		}
	}

	[Token(Token = "0x17000B41")]
	public ulong group_id
	{
		[Token(Token = "0x60085BE")]
		[Address(RVA = "0x33EA648", Offset = "0x33EA648", VA = "0x33EA648")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60085BF")]
		[Address(RVA = "0x33EA650", Offset = "0x33EA650", VA = "0x33EA650")]
		set
		{
		}
	}

	[Token(Token = "0x17000B42")]
	public EGroup.LeaveReason reason
	{
		[Token(Token = "0x60085C0")]
		[Address(RVA = "0x33EA660", Offset = "0x33EA660", VA = "0x33EA660")]
		get
		{
			return default(EGroup.LeaveReason);
		}
		[Token(Token = "0x60085C1")]
		[Address(RVA = "0x33EA668", Offset = "0x33EA668", VA = "0x33EA668")]
		set
		{
		}
	}

	[Token(Token = "0x60085BB")]
	[Address(RVA = "0x33EA628", Offset = "0x33EA628", VA = "0x33EA628")]
	public GroupDismissNtf()
	{
	}
}
