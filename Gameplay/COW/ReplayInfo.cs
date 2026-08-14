using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Serializable]
[Token(Token = "0x2000A5D")]
internal class ReplayInfo
{
	[Token(Token = "0x4005BDF")]
	[FieldOffset(Offset = "0x8")]
	public ulong MatchID;

	[Token(Token = "0x4005BE0")]
	[FieldOffset(Offset = "0x10")]
	public int PlayerCount;

	[Token(Token = "0x4005BE1")]
	[FieldOffset(Offset = "0x14")]
	public string MatchDateTime;

	[Token(Token = "0x4005BE2")]
	[FieldOffset(Offset = "0x18")]
	public float GameTotalTime;

	[Token(Token = "0x4005BE3")]
	[FieldOffset(Offset = "0x1C")]
	public uint MapID;

	[Token(Token = "0x4005BE4")]
	[FieldOffset(Offset = "0x20")]
	public uint MatchMode;

	[Token(Token = "0x4005BE5")]
	[FieldOffset(Offset = "0x24")]
	public uint GameMode;

	[Token(Token = "0x4005BE6")]
	[FieldOffset(Offset = "0x28")]
	public uint RoomType;

	[Token(Token = "0x4005BE7")]
	[FieldOffset(Offset = "0x2C")]
	public uint GroupMode;

	[Token(Token = "0x4005BE8")]
	[FieldOffset(Offset = "0x30")]
	public ulong RoomId;

	[Token(Token = "0x4005BE9")]
	[FieldOffset(Offset = "0x38")]
	public string RoomName;

	[Token(Token = "0x4005BEA")]
	[FieldOffset(Offset = "0x3C")]
	public bool IsClientReplay;

	[Token(Token = "0x4005BEB")]
	[FieldOffset(Offset = "0x40")]
	public string FileName;

	[Token(Token = "0x4005BEC")]
	[FieldOffset(Offset = "0x44")]
	public bool EnableFastProto;

	[Token(Token = "0x4005BED")]
	[FieldOffset(Offset = "0x48")]
	public List<ReplayEvent> Events;

	[Token(Token = "0x6005053")]
	[Address(RVA = "0x240104C", Offset = "0x240104C", VA = "0x240104C")]
	public ReplayInfo()
	{
	}
}
