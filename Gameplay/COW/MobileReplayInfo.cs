using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000815")]
public class MobileReplayInfo
{
	[Token(Token = "0x40050C8")]
	[FieldOffset(Offset = "0x8")]
	public string Version;

	[Token(Token = "0x40050C9")]
	[FieldOffset(Offset = "0x10")]
	public ulong AccountID;

	[Token(Token = "0x40050CA")]
	[FieldOffset(Offset = "0x18")]
	public ulong MatchID;

	[Token(Token = "0x40050CB")]
	[FieldOffset(Offset = "0x20")]
	public string MatchDateTime;

	[Token(Token = "0x40050CC")]
	[FieldOffset(Offset = "0x24")]
	public float GameTotalTime;

	[Token(Token = "0x40050CD")]
	[FieldOffset(Offset = "0x28")]
	public uint MapID;

	[Token(Token = "0x40050CE")]
	[FieldOffset(Offset = "0x2C")]
	public uint MatchMode;

	[Token(Token = "0x40050CF")]
	[FieldOffset(Offset = "0x30")]
	public uint GameMode;

	[Token(Token = "0x40050D0")]
	[FieldOffset(Offset = "0x34")]
	public uint GroupMode;

	[Token(Token = "0x40050D1")]
	[FieldOffset(Offset = "0x38")]
	public string FileName;

	[Token(Token = "0x40050D2")]
	[FieldOffset(Offset = "0x3C")]
	public uint PlayerCount;

	[Token(Token = "0x40050D3")]
	[FieldOffset(Offset = "0x40")]
	public byte Rank;

	[Token(Token = "0x40050D4")]
	[FieldOffset(Offset = "0x44")]
	public uint Kill;

	[Token(Token = "0x40050D5")]
	[FieldOffset(Offset = "0x48")]
	public int RankingPointsAfter;

	[Token(Token = "0x40050D6")]
	[FieldOffset(Offset = "0x4C")]
	public int RankingPointsDelta;

	[Token(Token = "0x40050D7")]
	[FieldOffset(Offset = "0x50")]
	public List<MobileReplayEvent> Events;

	[Token(Token = "0x40050D8")]
	[FieldOffset(Offset = "0x54")]
	public string WorkshopBytes;

	[Token(Token = "0x40050D9")]
	[FieldOffset(Offset = "0x58")]
	public bool EnableFastProto;

	[Token(Token = "0x40050DA")]
	[FieldOffset(Offset = "0x59")]
	public bool IsSaved;

	[Token(Token = "0x40050DB")]
	[FieldOffset(Offset = "0x5C")]
	public uint HighlightScore;

	[Token(Token = "0x40050DC")]
	[FieldOffset(Offset = "0x60")]
	public List<MobileReplayHighlightEvent> HighlightEvents;

	[Token(Token = "0x6003360")]
	[Address(RVA = "0x227883C", Offset = "0x227883C", VA = "0x227883C")]
	public MobileReplayInfo()
	{
	}
}
