using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CDF")]
public class GroupStopNtf
{
	[Token(Token = "0x400B6D5")]
	[FieldOffset(Offset = "0x8")]
	private GroupMemberInfo _003Cstoper_info_003Ek__BackingField;

	[Token(Token = "0x400B6D6")]
	[FieldOffset(Offset = "0xC")]
	private GroupInfo _003Cgroup_info_003Ek__BackingField;

	[Token(Token = "0x17000B3C")]
	public GroupMemberInfo stoper_info
	{
		[Token(Token = "0x60085B2")]
		[Address(RVA = "0x33EB7CC", Offset = "0x33EB7CC", VA = "0x33EB7CC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60085B3")]
		[Address(RVA = "0x33EB7D4", Offset = "0x33EB7D4", VA = "0x33EB7D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000B3D")]
	public GroupInfo group_info
	{
		[Token(Token = "0x60085B4")]
		[Address(RVA = "0x33EB7DC", Offset = "0x33EB7DC", VA = "0x33EB7DC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60085B5")]
		[Address(RVA = "0x33EB7E4", Offset = "0x33EB7E4", VA = "0x33EB7E4")]
		set
		{
		}
	}

	[Token(Token = "0x60085B1")]
	[Address(RVA = "0x33EB7C4", Offset = "0x33EB7C4", VA = "0x33EB7C4")]
	public GroupStopNtf()
	{
	}
}
