using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20020C8")]
public class EnergyStoneMarkScore : MonoBehaviour
{
	[Token(Token = "0x400CD3D")]
	[FieldOffset(Offset = "0xC")]
	public UILabel ScoreLabel;

	[Token(Token = "0x400CD3E")]
	[FieldOffset(Offset = "0x10")]
	public TweenPosition TweenPosition;

	[Token(Token = "0x400CD3F")]
	[FieldOffset(Offset = "0x14")]
	public TweenAlpha TweenAlpha;

	[Token(Token = "0x400CD40")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 m_DefaultToPos;

	[Token(Token = "0x400CD41")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Arrow;

	[Token(Token = "0x400CD42")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid Grid;

	[Token(Token = "0x400CD43")]
	[FieldOffset(Offset = "0x2C")]
	private List<GameObject> m_ArrowList;

	[Token(Token = "0x600A960")]
	[Address(RVA = "0x2536BC8", Offset = "0x2536BC8", VA = "0x2536BC8")]
	public EnergyStoneMarkScore()
	{
	}

	[Token(Token = "0x600A961")]
	[Address(RVA = "0x2536C54", Offset = "0x2536C54", VA = "0x2536C54")]
	private void Awake()
	{
	}

	[Token(Token = "0x600A962")]
	[Address(RVA = "0x2536CD0", Offset = "0x2536CD0", VA = "0x2536CD0")]
	public void ShowScore(string text, Vector3 startPos, byte scoreRegion)
	{
	}

	[Token(Token = "0x600A963")]
	[Address(RVA = "0x2537488", Offset = "0x2537488", VA = "0x2537488")]
	public void SetTweenCallBack(EventDelegate func)
	{
	}
}
