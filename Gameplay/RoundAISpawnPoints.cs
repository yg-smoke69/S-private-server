using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using message;

[Token(Token = "0x2000720")]
public class RoundAISpawnPoints : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000721")]
	public class RoundAIInfo
	{
		[Token(Token = "0x4004C32")]
		[FieldOffset(Offset = "0x8")]
		public int RoundID;

		[Token(Token = "0x4004C33")]
		[FieldOffset(Offset = "0xC")]
		public int SubRoundID;

		[Token(Token = "0x4004C34")]
		[FieldOffset(Offset = "0x10")]
		public LAKANBFBEOK AIType;

		[Token(Token = "0x6002D0C")]
		[Address(RVA = "0x316CF90", Offset = "0x316CF90", VA = "0x316CF90")]
		public RoundAIInfo()
		{
		}
	}

	[Token(Token = "0x4004C31")]
	[FieldOffset(Offset = "0xC")]
	public List<RoundAIInfo> m_SpawnInfoList;

	[Token(Token = "0x6002D0A")]
	[Address(RVA = "0x316CF50", Offset = "0x316CF50", VA = "0x316CF50")]
	public RoundAISpawnPoints()
	{
	}

	[Token(Token = "0x6002D0B")]
	[Address(RVA = "0x316CF58", Offset = "0x316CF58", VA = "0x316CF58")]
	private void Start()
	{
	}
}
