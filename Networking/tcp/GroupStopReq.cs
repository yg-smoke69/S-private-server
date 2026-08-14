using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CDE")]
public class GroupStopReq
{
	[Token(Token = "0x400B6D4")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x17000B3B")]
	public ulong group_id
	{
		[Token(Token = "0x60085AF")]
		[Address(RVA = "0x33EB7F4", Offset = "0x33EB7F4", VA = "0x33EB7F4")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60085B0")]
		[Address(RVA = "0x33EB7FC", Offset = "0x33EB7FC", VA = "0x33EB7FC")]
		set
		{
		}
	}

	[Token(Token = "0x60085AE")]
	[Address(RVA = "0x33EB7EC", Offset = "0x33EB7EC", VA = "0x33EB7EC")]
	public GroupStopReq()
	{
	}
}
