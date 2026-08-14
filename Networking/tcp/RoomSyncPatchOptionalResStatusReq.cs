using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D70")]
public class RoomSyncPatchOptionalResStatusReq
{
	[Token(Token = "0x400B9EC")]
	[FieldOffset(Offset = "0x8")]
	private ERoom.PlayerPatchOptionalResStatus _003Cstatus_003Ek__BackingField;

	[Token(Token = "0x17000D2C")]
	public ERoom.PlayerPatchOptionalResStatus status
	{
		[Token(Token = "0x6008A00")]
		[Address(RVA = "0x435EF88", Offset = "0x435EF88", VA = "0x435EF88")]
		get
		{
			return default(ERoom.PlayerPatchOptionalResStatus);
		}
		[Token(Token = "0x6008A01")]
		[Address(RVA = "0x435EF90", Offset = "0x435EF90", VA = "0x435EF90")]
		set
		{
		}
	}

	[Token(Token = "0x60089FF")]
	[Address(RVA = "0x435EF80", Offset = "0x435EF80", VA = "0x435EF80")]
	public RoomSyncPatchOptionalResStatusReq()
	{
	}
}
