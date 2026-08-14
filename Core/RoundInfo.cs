using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000710")]
public class RoundInfo
{
	[Token(Token = "0x4004C03")]
	[FieldOffset(Offset = "0x8")]
	public int RoundID;

	[Token(Token = "0x4004C04")]
	[FieldOffset(Offset = "0xC")]
	public float RoundTime;

	[Token(Token = "0x4004C05")]
	[FieldOffset(Offset = "0x10")]
	public float GeneralHPScaleOnBase;

	[Token(Token = "0x4004C06")]
	[FieldOffset(Offset = "0x14")]
	public bool IsRoundNeedTeleport;

	[Token(Token = "0x4004C07")]
	[FieldOffset(Offset = "0x18")]
	public float RoundAISpawnInterval;

	[Token(Token = "0x4004C08")]
	[FieldOffset(Offset = "0x1C")]
	public List<AISpawnInfo> AISpawnInfos;

	[Token(Token = "0x6002CD6")]
	[Address(RVA = "0x316D514", Offset = "0x316D514", VA = "0x316D514")]
	public RoundInfo()
	{
	}
}
