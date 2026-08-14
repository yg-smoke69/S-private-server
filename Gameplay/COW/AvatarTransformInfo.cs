using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002C82")]
public class AvatarTransformInfo
{
	[Token(Token = "0x4010FDA")]
	[FieldOffset(Offset = "0x8")]
	public Vector3 avatarPos;

	[Token(Token = "0x4010FDB")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 avatarScale;

	[Token(Token = "0x4010FDC")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 avatarRotation;

	[Token(Token = "0x6012906")]
	[Address(RVA = "0x2362834", Offset = "0x2362834", VA = "0x2362834")]
	public AvatarTransformInfo()
	{
	}
}
