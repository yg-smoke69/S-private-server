using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CDB")]
public class GroupLeaveReq
{
	[Token(Token = "0x400B6CA")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x17000B31")]
	public ulong group_id
	{
		[Token(Token = "0x6008598")]
		[Address(RVA = "0x33EB0CC", Offset = "0x33EB0CC", VA = "0x33EB0CC")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008599")]
		[Address(RVA = "0x33EB0D4", Offset = "0x33EB0D4", VA = "0x33EB0D4")]
		set
		{
		}
	}

	[Token(Token = "0x6008597")]
	[Address(RVA = "0x33EB0C4", Offset = "0x33EB0C4", VA = "0x33EB0C4")]
	public GroupLeaveReq()
	{
	}
}
