using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20005AF")]
public class BillboardAnimTrigger : MonoBehaviour
{
	[Token(Token = "0x4004385")]
	[FieldOffset(Offset = "0xC")]
	public Transform[] SpawnAnimPrefabPos;

	[Token(Token = "0x4004386")]
	[FieldOffset(Offset = "0x10")]
	private bool HadTrigger;

	[Token(Token = "0x4004387")]
	[FieldOffset(Offset = "0x14")]
	private List<GameObject> m_CacheGo;

	[Token(Token = "0x4004388")]
	[FieldOffset(Offset = "0x18")]
	private ResourceID m_ResId;

	[Token(Token = "0x60022A9")]
	[Address(RVA = "0x180A748", Offset = "0x180A748", VA = "0x180A748")]
	public BillboardAnimTrigger()
	{
	}

	[Token(Token = "0x60022AA")]
	[Address(RVA = "0x180A7D4", Offset = "0x180A7D4", VA = "0x180A7D4")]
	public void OnLocalPlayerEnter()
	{
	}

	[Token(Token = "0x60022AB")]
	[Address(RVA = "0x180ADC4", Offset = "0x180ADC4", VA = "0x180ADC4")]
	private void DelayDestroy()
	{
	}

	[Token(Token = "0x60022AC")]
	[Address(RVA = "0x180AF10", Offset = "0x180AF10", VA = "0x180AF10")]
	private void _003CDelayDestroy_003Em__0()
	{
	}
}
