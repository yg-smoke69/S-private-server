using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CE2")]
public class GroupInfoReq
{
	[Token(Token = "0x400B6DC")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x17000B43")]
	public ulong group_id
	{
		[Token(Token = "0x60085C3")]
		[Address(RVA = "0x33EA8E8", Offset = "0x33EA8E8", VA = "0x33EA8E8")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60085C4")]
		[Address(RVA = "0x33EA8F0", Offset = "0x33EA8F0", VA = "0x33EA8F0")]
		set
		{
		}
	}

	[Token(Token = "0x60085C2")]
	[Address(RVA = "0x33EA8E0", Offset = "0x33EA8E0", VA = "0x33EA8E0")]
	public GroupInfoReq()
	{
	}
}
