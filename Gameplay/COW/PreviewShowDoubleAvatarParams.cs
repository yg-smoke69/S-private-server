using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C89")]
public struct PreviewShowDoubleAvatarParams
{
	[Token(Token = "0x4010FF4")]
	[FieldOffset(Offset = "0x0")]
	public FullScreenAnimParams DoubleParams;

	[Token(Token = "0x4010FF5")]
	[FieldOffset(Offset = "0x4")]
	public bool ClearPool;
}
