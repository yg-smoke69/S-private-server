using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CE0")]
public class GroupReadyReq
{
	[Token(Token = "0x400B6D7")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x400B6D8")]
	[FieldOffset(Offset = "0x10")]
	private bool _003Cready_003Ek__BackingField;

	[Token(Token = "0x17000B3E")]
	public ulong group_id
	{
		[Token(Token = "0x60085B7")]
		[Address(RVA = "0x33EB518", Offset = "0x33EB518", VA = "0x33EB518")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60085B8")]
		[Address(RVA = "0x33EB520", Offset = "0x33EB520", VA = "0x33EB520")]
		set
		{
		}
	}

	[Token(Token = "0x17000B3F")]
	public bool ready
	{
		[Token(Token = "0x60085B9")]
		[Address(RVA = "0x33EB530", Offset = "0x33EB530", VA = "0x33EB530")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60085BA")]
		[Address(RVA = "0x33EB538", Offset = "0x33EB538", VA = "0x33EB538")]
		set
		{
		}
	}

	[Token(Token = "0x60085B6")]
	[Address(RVA = "0x33EB510", Offset = "0x33EB510", VA = "0x33EB510")]
	public GroupReadyReq()
	{
	}
}
