using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000A7C")]
public class PVESceneState
{
	[Token(Token = "0x4005C62")]
	[FieldOffset(Offset = "0x8")]
	public int index;

	[Token(Token = "0x4005C63")]
	[FieldOffset(Offset = "0xC")]
	public List<GameObject> ActiveObjects;

	[Token(Token = "0x4005C64")]
	[FieldOffset(Offset = "0x10")]
	public List<GameObject> DisActiveObjects;

	[Token(Token = "0x4005C65")]
	[FieldOffset(Offset = "0x14")]
	public bool IsChangeWheather;

	[Token(Token = "0x4005C66")]
	[FieldOffset(Offset = "0x18")]
	public int WheatherIndex;

	[Token(Token = "0x4005C67")]
	[FieldOffset(Offset = "0x1C")]
	public float WheatherDuration;

	[Token(Token = "0x60050BD")]
	[Address(RVA = "0x1C79388", Offset = "0x1C79388", VA = "0x1C79388")]
	public PVESceneState()
	{
	}

	[Token(Token = "0x60050BE")]
	[Address(RVA = "0x1C79390", Offset = "0x1C79390", VA = "0x1C79390")]
	public void InitData()
	{
	}

	[Token(Token = "0x60050BF")]
	[Address(RVA = "0x1C79394", Offset = "0x1C79394", VA = "0x1C79394")]
	public void EnterState()
	{
	}
}
