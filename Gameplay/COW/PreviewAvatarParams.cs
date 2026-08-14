using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002C80")]
public class PreviewAvatarParams
{
	[Token(Token = "0x4010FD0")]
	[FieldOffset(Offset = "0x8")]
	public Vector3 scale;

	[Token(Token = "0x4010FD1")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 pos;

	[Token(Token = "0x4010FD2")]
	[FieldOffset(Offset = "0x20")]
	public FrontEndPreviewComponent.AvatarType avatartype;

	[Token(Token = "0x4010FD3")]
	[FieldOffset(Offset = "0x24")]
	public Vector4 boostavatar;

	[Token(Token = "0x4010FD4")]
	[FieldOffset(Offset = "0x34")]
	public bool PlayPose;

	[Token(Token = "0x4010FD5")]
	[FieldOffset(Offset = "0x35")]
	public bool NeedStopEffect;

	[Token(Token = "0x6012904")]
	[Address(RVA = "0x1C18318", Offset = "0x1C18318", VA = "0x1C18318")]
	public PreviewAvatarParams()
	{
	}
}
