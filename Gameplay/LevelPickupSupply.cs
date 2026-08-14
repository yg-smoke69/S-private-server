using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200071E")]
public class LevelPickupSupply : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200071F")]
	public class SupplyInfo
	{
		[Token(Token = "0x4004C2F")]
		[FieldOffset(Offset = "0x8")]
		public uint m_ItemID;

		[Token(Token = "0x4004C30")]
		[FieldOffset(Offset = "0xC")]
		public uint m_ItemNum;

		[Token(Token = "0x6002D09")]
		[Address(RVA = "0x3115FDC", Offset = "0x3115FDC", VA = "0x3115FDC")]
		public SupplyInfo()
		{
		}
	}

	[Token(Token = "0x4004C2C")]
	[FieldOffset(Offset = "0xC")]
	public uint m_RoundID;

	[Token(Token = "0x4004C2D")]
	[FieldOffset(Offset = "0x10")]
	public uint m_SubRoundID;

	[Token(Token = "0x4004C2E")]
	[FieldOffset(Offset = "0x14")]
	public List<SupplyInfo> m_SupplyInfos;

	[Token(Token = "0x6002D07")]
	[Address(RVA = "0x3115F9C", Offset = "0x3115F9C", VA = "0x3115F9C")]
	public LevelPickupSupply()
	{
	}

	[Token(Token = "0x6002D08")]
	[Address(RVA = "0x3115FA4", Offset = "0x3115FA4", VA = "0x3115FA4")]
	private void Start()
	{
	}
}
