using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002C84")]
public class FrontEndPreviewAvatarParams
{
	[Token(Token = "0x4010FE0")]
	[FieldOffset(Offset = "0x8")]
	public Vector3 scale;

	[Token(Token = "0x4010FE1")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 pos;

	[Token(Token = "0x4010FE2")]
	[FieldOffset(Offset = "0x20")]
	public FrontEndPreviewComponent.AvatarType avatartype;

	[Token(Token = "0x4010FE3")]
	[FieldOffset(Offset = "0x24")]
	public Vector4 boostavatar;

	[Token(Token = "0x4010FE4")]
	[FieldOffset(Offset = "0x34")]
	public bool PlayPose;

	[Token(Token = "0x4010FE5")]
	[FieldOffset(Offset = "0x35")]
	public bool NeedStopEffect;

	[Token(Token = "0x4010FE6")]
	[FieldOffset(Offset = "0x38")]
	public ShowBoostAvatarParams ShowBoostAvatarParams;

	[Token(Token = "0x6012920")]
	[Address(RVA = "0xDFAF94", Offset = "0xDFAF94", VA = "0xDFAF94")]
	public FrontEndPreviewAvatarParams()
	{
	}
}
