using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200378D")]
public class UIHUDUGC_AddScoreVFXView : UIBaseView
{
	[Token(Token = "0x4016822")]
	[FieldOffset(Offset = "0x14")]
	public GameObject cloneItem;

	[Token(Token = "0x4016823")]
	[FieldOffset(Offset = "0x18")]
	public Transform VfxStartPos;

	[Token(Token = "0x4016824")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject grid;

	[Token(Token = "0x4016825")]
	[FieldOffset(Offset = "0x20")]
	public Transform VfxEndPos;

	[Token(Token = "0x4016826")]
	[FieldOffset(Offset = "0x24")]
	public Transform vfxContainer;

	[Token(Token = "0x4016827")]
	[FieldOffset(Offset = "0x28")]
	public TweenPositionArc vfxTweenPosArc;

	[Token(Token = "0x6016A52")]
	[Address(RVA = "0x22246D0", Offset = "0x22246D0", VA = "0x22246D0")]
	public UIHUDUGC_AddScoreVFXView()
	{
	}

	[Token(Token = "0x6016A53")]
	[Address(RVA = "0x22246D8", Offset = "0x22246D8", VA = "0x22246D8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A54")]
	[Address(RVA = "0x22249D0", Offset = "0x22249D0", VA = "0x22249D0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
