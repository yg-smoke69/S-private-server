using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CF4")]
public class GroupStartNtf
{
	[Token(Token = "0x400B742")]
	[FieldOffset(Offset = "0x8")]
	private GroupInfo _003Cgroup_info_003Ek__BackingField;

	[Token(Token = "0x400B743")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Cavg_wait_time_sec_003Ek__BackingField;

	[Token(Token = "0x17000BA9")]
	public GroupInfo group_info
	{
		[Token(Token = "0x60086A1")]
		[Address(RVA = "0x33EB668", Offset = "0x33EB668", VA = "0x33EB668")]
		get
		{
			return null;
		}
		[Token(Token = "0x60086A2")]
		[Address(RVA = "0x33EB670", Offset = "0x33EB670", VA = "0x33EB670")]
		set
		{
		}
	}

	[Token(Token = "0x17000BAA")]
	public uint avg_wait_time_sec
	{
		[Token(Token = "0x60086A3")]
		[Address(RVA = "0x33EB678", Offset = "0x33EB678", VA = "0x33EB678")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60086A4")]
		[Address(RVA = "0x33EB680", Offset = "0x33EB680", VA = "0x33EB680")]
		set
		{
		}
	}

	[Token(Token = "0x60086A0")]
	[Address(RVA = "0x33EB660", Offset = "0x33EB660", VA = "0x33EB660")]
	public GroupStartNtf()
	{
	}
}
