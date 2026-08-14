using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CF1")]
public class GetGroupCodeReq
{
	[Token(Token = "0x400B73F")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x17000BA6")]
	public ulong group_id
	{
		[Token(Token = "0x6008698")]
		[Address(RVA = "0x33E9F38", Offset = "0x33E9F38", VA = "0x33E9F38")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008699")]
		[Address(RVA = "0x33E9F40", Offset = "0x33E9F40", VA = "0x33E9F40")]
		set
		{
		}
	}

	[Token(Token = "0x6008697")]
	[Address(RVA = "0x33E9F30", Offset = "0x33E9F30", VA = "0x33E9F30")]
	public GetGroupCodeReq()
	{
	}
}
