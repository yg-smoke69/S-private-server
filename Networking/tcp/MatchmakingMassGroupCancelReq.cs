using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D29")]
public class MatchmakingMassGroupCancelReq
{
	[Token(Token = "0x400B841")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x17000C2E")]
	public ulong group_id
	{
		[Token(Token = "0x60087D0")]
		[Address(RVA = "0x435C160", Offset = "0x435C160", VA = "0x435C160")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60087D1")]
		[Address(RVA = "0x435C168", Offset = "0x435C168", VA = "0x435C168")]
		set
		{
		}
	}

	[Token(Token = "0x60087CF")]
	[Address(RVA = "0x435C158", Offset = "0x435C158", VA = "0x435C158")]
	public MatchmakingMassGroupCancelReq()
	{
	}
}
