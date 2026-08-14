using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000AA6")]
public class EnvSkybox
{
	[Token(Token = "0x4005D33")]
	[FieldOffset(Offset = "0x8")]
	public Color tint;

	[Token(Token = "0x4005D34")]
	[FieldOffset(Offset = "0x18")]
	public Texture frontTex;

	[Token(Token = "0x4005D35")]
	[FieldOffset(Offset = "0x1C")]
	public Texture backTex;

	[Token(Token = "0x4005D36")]
	[FieldOffset(Offset = "0x20")]
	public Texture leftTex;

	[Token(Token = "0x4005D37")]
	[FieldOffset(Offset = "0x24")]
	public Texture rightTex;

	[Token(Token = "0x4005D38")]
	[FieldOffset(Offset = "0x28")]
	public Texture upTex;

	[Token(Token = "0x4005D39")]
	[FieldOffset(Offset = "0x2C")]
	public Texture downTex;

	[Token(Token = "0x4005D3A")]
	[FieldOffset(Offset = "0x30")]
	public bool nightMode;

	[Token(Token = "0x600519A")]
	[Address(RVA = "0x32081CC", Offset = "0x32081CC", VA = "0x32081CC")]
	public EnvSkybox()
	{
	}
}
