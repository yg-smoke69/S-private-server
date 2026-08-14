using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CDA")]
public class GroupRefuseReq
{
	[Token(Token = "0x400B6C9")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x17000B30")]
	public ulong group_id
	{
		[Token(Token = "0x6008595")]
		[Address(RVA = "0x33EB548", Offset = "0x33EB548", VA = "0x33EB548")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008596")]
		[Address(RVA = "0x33EB550", Offset = "0x33EB550", VA = "0x33EB550")]
		set
		{
		}
	}

	[Token(Token = "0x6008594")]
	[Address(RVA = "0x33EB540", Offset = "0x33EB540", VA = "0x33EB540")]
	public GroupRefuseReq()
	{
	}
}
