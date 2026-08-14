using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200215D")]
public class UILadderMatchHeroicLevelView : MonoBehaviour
{
	[Token(Token = "0x400D188")]
	[FieldOffset(Offset = "0xC")]
	public GameObject m_StarView1;

	[Token(Token = "0x400D189")]
	[FieldOffset(Offset = "0x10")]
	public GameObject m_StarView2;

	[Token(Token = "0x400D18A")]
	[FieldOffset(Offset = "0x14")]
	public GameObject m_StarView3;

	[Token(Token = "0x400D18B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject m_StarView4;

	[Token(Token = "0x400D18C")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject m_StarView5;

	[Token(Token = "0x400D18D")]
	[FieldOffset(Offset = "0x20")]
	private List<GameObject> m_ListGoStars;

	[Token(Token = "0x600B048")]
	[Address(RVA = "0x1AEE03C", Offset = "0x1AEE03C", VA = "0x1AEE03C")]
	public UILadderMatchHeroicLevelView()
	{
	}

	[Token(Token = "0x600B049")]
	[Address(RVA = "0x1AEE0C8", Offset = "0x1AEE0C8", VA = "0x1AEE0C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600B04A")]
	[Address(RVA = "0x1AEE3C8", Offset = "0x1AEE3C8", VA = "0x1AEE3C8")]
	public void SetView(int rank, int rankScore)
	{
	}
}
