using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CDC")]
public class GroupLeaveNtf
{
	[Token(Token = "0x400B6CB")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cleaver_id_003Ek__BackingField;

	[Token(Token = "0x400B6CC")]
	[FieldOffset(Offset = "0x10")]
	private EGroup.LeaveReason _003Creason_003Ek__BackingField;

	[Token(Token = "0x400B6CD")]
	[FieldOffset(Offset = "0x14")]
	private GroupInfo _003Cgroup_info_003Ek__BackingField;

	[Token(Token = "0x17000B32")]
	public ulong leaver_id
	{
		[Token(Token = "0x600859B")]
		[Address(RVA = "0x33EB08C", Offset = "0x33EB08C", VA = "0x33EB08C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600859C")]
		[Address(RVA = "0x33EB094", Offset = "0x33EB094", VA = "0x33EB094")]
		set
		{
		}
	}

	[Token(Token = "0x17000B33")]
	public EGroup.LeaveReason reason
	{
		[Token(Token = "0x600859D")]
		[Address(RVA = "0x33EB0A4", Offset = "0x33EB0A4", VA = "0x33EB0A4")]
		get
		{
			return default(EGroup.LeaveReason);
		}
		[Token(Token = "0x600859E")]
		[Address(RVA = "0x33EB0AC", Offset = "0x33EB0AC", VA = "0x33EB0AC")]
		set
		{
		}
	}

	[Token(Token = "0x17000B34")]
	public GroupInfo group_info
	{
		[Token(Token = "0x600859F")]
		[Address(RVA = "0x33EB0B4", Offset = "0x33EB0B4", VA = "0x33EB0B4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60085A0")]
		[Address(RVA = "0x33EB0BC", Offset = "0x33EB0BC", VA = "0x33EB0BC")]
		set
		{
		}
	}

	[Token(Token = "0x600859A")]
	[Address(RVA = "0x33EB084", Offset = "0x33EB084", VA = "0x33EB084")]
	public GroupLeaveNtf()
	{
	}
}
