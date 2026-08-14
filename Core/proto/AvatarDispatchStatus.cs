using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200138C")]
public class AvatarDispatchStatus
{
	[Token(Token = "0x40089E8")]
	[FieldOffset(Offset = "0x8")]
	public uint avatar_id;

	[Token(Token = "0x40089E9")]
	[FieldOffset(Offset = "0xC")]
	public EProfile.DispatchLine status;

	[Token(Token = "0x6007A88")]
	[Address(RVA = "0x317B17C", Offset = "0x317B17C", VA = "0x317B17C")]
	public AvatarDispatchStatus()
	{
	}
}
