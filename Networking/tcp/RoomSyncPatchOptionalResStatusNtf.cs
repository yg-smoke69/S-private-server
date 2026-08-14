using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D71")]
public class RoomSyncPatchOptionalResStatusNtf
{
	[Token(Token = "0x400B9ED")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Caccount_id_003Ek__BackingField;

	[Token(Token = "0x400B9EE")]
	[FieldOffset(Offset = "0x10")]
	private ERoom.PlayerPatchOptionalResStatus _003Cstatus_003Ek__BackingField;

	[Token(Token = "0x17000D2D")]
	public ulong account_id
	{
		[Token(Token = "0x6008A03")]
		[Address(RVA = "0x435EF58", Offset = "0x435EF58", VA = "0x435EF58")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008A04")]
		[Address(RVA = "0x435EF60", Offset = "0x435EF60", VA = "0x435EF60")]
		set
		{
		}
	}

	[Token(Token = "0x17000D2E")]
	public ERoom.PlayerPatchOptionalResStatus status
	{
		[Token(Token = "0x6008A05")]
		[Address(RVA = "0x435EF70", Offset = "0x435EF70", VA = "0x435EF70")]
		get
		{
			return default(ERoom.PlayerPatchOptionalResStatus);
		}
		[Token(Token = "0x6008A06")]
		[Address(RVA = "0x435EF78", Offset = "0x435EF78", VA = "0x435EF78")]
		set
		{
		}
	}

	[Token(Token = "0x6008A02")]
	[Address(RVA = "0x435EF50", Offset = "0x435EF50", VA = "0x435EF50")]
	public RoomSyncPatchOptionalResStatusNtf()
	{
	}
}
