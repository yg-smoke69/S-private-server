using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Serializable]
[Token(Token = "0x200086B")]
internal class PCOpeningCam : MonoBehaviour
{
	[Token(Token = "0x40052AA")]
	[FieldOffset(Offset = "0xC")]
	public int clipNum;

	[Token(Token = "0x40052AB")]
	[FieldOffset(Offset = "0x10")]
	private bool m_HasBegun;

	[Token(Token = "0x40052AC")]
	[FieldOffset(Offset = "0x14")]
	private float m_BeginTime;

	[Token(Token = "0x40052AD")]
	[FieldOffset(Offset = "0x18")]
	private float m_TotalTime;

	[Token(Token = "0x40052AE")]
	[FieldOffset(Offset = "0x1C")]
	private string m_ClipKey;

	[Token(Token = "0x40052AF")]
	[FieldOffset(Offset = "0x20")]
	private Animator m_Animator;

	[Token(Token = "0x40052B0")]
	[FieldOffset(Offset = "0x24")]
	private List<string> m_PlayableAnimNameList;

	[Token(Token = "0x40052B1")]
	[FieldOffset(Offset = "0x28")]
	private List<float> m_PlayableAnimTimeList;

	[Token(Token = "0x40052B2")]
	[FieldOffset(Offset = "0x2C")]
	private Queue<int> m_RandomNumQueue;

	[Token(Token = "0x40052B3")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<uint, string> m_ConfigMapDic;

	[Token(Token = "0x6003AE0")]
	[Address(RVA = "0x1647014", Offset = "0x1647014", VA = "0x1647014")]
	public PCOpeningCam()
	{
	}

	[Token(Token = "0x6003AE1")]
	[Address(RVA = "0x1647218", Offset = "0x1647218", VA = "0x1647218")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003AE2")]
	[Address(RVA = "0x164753C", Offset = "0x164753C", VA = "0x164753C")]
	private bool KPEODGNLAPC()
	{
		return default(bool);
	}

	[Token(Token = "0x6003AE3")]
	[Address(RVA = "0x1647B80", Offset = "0x1647B80", VA = "0x1647B80")]
	private void IMDCDHGKCPB()
	{
	}

	[Token(Token = "0x6003AE4")]
	[Address(RVA = "0x1647650", Offset = "0x1647650", VA = "0x1647650")]
	private void AALCMHKNNKL()
	{
	}

	[Token(Token = "0x6003AE5")]
	[Address(RVA = "0x1647D44", Offset = "0x1647D44", VA = "0x1647D44")]
	private void Update()
	{
	}

	[Token(Token = "0x6003AE6")]
	[Address(RVA = "0x1647DC4", Offset = "0x1647DC4", VA = "0x1647DC4")]
	private bool IIIDBKMANKE()
	{
		return default(bool);
	}

	[Token(Token = "0x6003AE7")]
	[Address(RVA = "0x1648020", Offset = "0x1648020", VA = "0x1648020")]
	private void CECNLHAODBA()
	{
	}
}
