using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000ADD")]
internal class SceneEditObjectCustomPoint : SceneEditObjectBase
{
	[Token(Token = "0x4005E93")]
	[FieldOffset(Offset = "0x8C")]
	public UGCLevelCustomPath LevelPath;

	[Token(Token = "0x4005E94")]
	[FieldOffset(Offset = "0x90")]
	private int AKJBNLKPKEF;

	[Token(Token = "0x4005E95")]
	[FieldOffset(Offset = "0x94")]
	private TextMesh EDHEOMMIKGK;

	[Token(Token = "0x4005E96")]
	[FieldOffset(Offset = "0x98")]
	private ResourceID FMEHFOGLPDI;

	[Token(Token = "0x4005E97")]
	[FieldOffset(Offset = "0x9C")]
	private ResourceID AOAAOMKBMKL;

	[Token(Token = "0x4005E98")]
	[FieldOffset(Offset = "0xA0")]
	private GameObject OCKFIGLBHID;

	[Token(Token = "0x4005E99")]
	[FieldOffset(Offset = "0xA4")]
	private GameObject NJBBDDDBICA;

	[Token(Token = "0x4005E9A")]
	[FieldOffset(Offset = "0xA8")]
	public int MaxPointCount;

	[Token(Token = "0x4005E9B")]
	[FieldOffset(Offset = "0xAC")]
	private bool BFLNHJFOFOB;

	[Token(Token = "0x170006A1")]
	public int AONFANOPBFE
	{
		[Token(Token = "0x6005388")]
		[Address(RVA = "0x1D652E4", Offset = "0x1D652E4", VA = "0x1D652E4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005389")]
		[Address(RVA = "0x1D655F4", Offset = "0x1D655F4", VA = "0x1D655F4")]
		set
		{
		}
	}

	[Token(Token = "0x170006A2")]
	public bool AKCNJJLIMII
	{
		[Token(Token = "0x600538A")]
		[Address(RVA = "0x1D6C67C", Offset = "0x1D6C67C", VA = "0x1D6C67C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6005387")]
	[Address(RVA = "0x1D6BEA4", Offset = "0x1D6BEA4", VA = "0x1D6BEA4")]
	public SceneEditObjectCustomPoint()
	{
	}

	[Token(Token = "0x600538B")]
	[Address(RVA = "0x1D6C6D4", Offset = "0x1D6C6D4", VA = "0x1D6C6D4", Slot = "5")]
	public override void OnRemove(bool MMOHANJKPBG)
	{
	}

	[Token(Token = "0x600538C")]
	[Address(RVA = "0x1D6C7F4", Offset = "0x1D6C7F4", VA = "0x1D6C7F4", Slot = "8")]
	public override void RemoveIfAllowed(Action HLLGOKLLGEH)
	{
	}

	[Token(Token = "0x600538D")]
	[Address(RVA = "0x1D6CC2C", Offset = "0x1D6CC2C", VA = "0x1D6CC2C", Slot = "6")]
	public override NANKDCKDDIG GetExtraInfo()
	{
		return null;
	}

	[Token(Token = "0x600538E")]
	[Address(RVA = "0x1D6CD18", Offset = "0x1D6CD18", VA = "0x1D6CD18", Slot = "7")]
	public override void ApplyExtraInfo(NANKDCKDDIG PKAHCEKFHIA, bool MMOHANJKPBG = false)
	{
	}

	[Token(Token = "0x600538F")]
	[Address(RVA = "0x1D6BF30", Offset = "0x1D6BF30", VA = "0x1D6BF30")]
	public void UpdataNumberIndex()
	{
	}

	[Token(Token = "0x6005390")]
	[Address(RVA = "0x1D6CF84", Offset = "0x1D6CF84", VA = "0x1D6CF84")]
	public void _003C_003EiFixBaseProxy_OnRemove(bool P0)
	{
	}

	[Token(Token = "0x6005391")]
	[Address(RVA = "0x1D6CF88", Offset = "0x1D6CF88", VA = "0x1D6CF88")]
	public void _003C_003EiFixBaseProxy_RemoveIfAllowed(Action P0)
	{
	}

	[Token(Token = "0x6005392")]
	[Address(RVA = "0x1D6CF8C", Offset = "0x1D6CF8C", VA = "0x1D6CF8C")]
	public NANKDCKDDIG _003C_003EiFixBaseProxy_GetExtraInfo()
	{
		return null;
	}

	[Token(Token = "0x6005393")]
	[Address(RVA = "0x1D6CF90", Offset = "0x1D6CF90", VA = "0x1D6CF90")]
	public void _003C_003EiFixBaseProxy_ApplyExtraInfo(NANKDCKDDIG P0, bool P1)
	{
	}
}
