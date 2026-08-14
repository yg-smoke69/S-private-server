using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20030FB")]
public class LobbyEventBubbleData
{
	[Token(Token = "0x4012A0D")]
	[FieldOffset(Offset = "0x8")]
	public LobbyEventType LobbyEventType;

	[Token(Token = "0x4012A0E")]
	[FieldOffset(Offset = "0xC")]
	public Func<bool> CanShow;

	[Token(Token = "0x4012A0F")]
	[FieldOffset(Offset = "0x10")]
	public Func<bool> EventShowInContainer;

	[Token(Token = "0x4012A10")]
	[FieldOffset(Offset = "0x14")]
	public Action ResetBubble;

	[Token(Token = "0x4012A11")]
	[FieldOffset(Offset = "0x18")]
	public bool IsShowing;

	[Token(Token = "0x601486D")]
	[Address(RVA = "0xECFF10", Offset = "0xECFF10", VA = "0xECFF10")]
	public LobbyEventBubbleData()
	{
	}
}
