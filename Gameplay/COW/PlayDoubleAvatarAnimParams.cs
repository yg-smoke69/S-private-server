using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002C7D")]
public class PlayDoubleAvatarAnimParams
{
	[Token(Token = "0x2002C7E")]
	public class AvatarAnimParams
	{
		[Token(Token = "0x4010FC8")]
		[FieldOffset(Offset = "0x8")]
		public List<uint> clothIDList;

		[Token(Token = "0x4010FC9")]
		[FieldOffset(Offset = "0xC")]
		public int animID;

		[Token(Token = "0x4010FCA")]
		[FieldOffset(Offset = "0x10")]
		public string specialAnim;

		[Token(Token = "0x4010FCB")]
		[FieldOffset(Offset = "0x14")]
		public string idleAnim;

		[Token(Token = "0x4010FCC")]
		[FieldOffset(Offset = "0x18")]
		public AvatarTransformInfo avatarInfo;

		[Token(Token = "0x6012902")]
		[Address(RVA = "0x1C07444", Offset = "0x1C07444", VA = "0x1C07444")]
		public AvatarAnimParams()
		{
		}
	}

	[Token(Token = "0x4010FC4")]
	[FieldOffset(Offset = "0x8")]
	public AvatarAnimParams avatarAnimParmsA;

	[Token(Token = "0x4010FC5")]
	[FieldOffset(Offset = "0xC")]
	public AvatarAnimParams avatarAnimParmsB;

	[Token(Token = "0x4010FC6")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 cameraRotation;

	[Token(Token = "0x4010FC7")]
	[FieldOffset(Offset = "0x1C")]
	public bool inputDisable;

	[Token(Token = "0x6012901")]
	[Address(RVA = "0x1C073B8", Offset = "0x1C073B8", VA = "0x1C073B8")]
	public PlayDoubleAvatarAnimParams()
	{
	}
}
