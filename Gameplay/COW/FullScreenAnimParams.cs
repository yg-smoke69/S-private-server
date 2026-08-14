using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002C81")]
public class FullScreenAnimParams
{
	[Token(Token = "0x4010FD6")]
	[FieldOffset(Offset = "0x8")]
	public FullscreenCgDesc animData;

	[Token(Token = "0x4010FD7")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 cameraRotation;

	[Token(Token = "0x4010FD8")]
	[FieldOffset(Offset = "0x18")]
	public AvatarTransformInfo avatarInfoA;

	[Token(Token = "0x4010FD9")]
	[FieldOffset(Offset = "0x1C")]
	public AvatarTransformInfo avatarInfoB;

	[Token(Token = "0x6012905")]
	[Address(RVA = "0x104FD98", Offset = "0x104FD98", VA = "0x104FD98")]
	public FullScreenAnimParams()
	{
	}
}
