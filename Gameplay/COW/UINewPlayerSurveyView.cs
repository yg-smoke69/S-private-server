using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038C4")]
public class UINewPlayerSurveyView : UIBaseView
{
	[Token(Token = "0x4017854")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnSurvey;

	[Token(Token = "0x4017855")]
	[FieldOffset(Offset = "0x18")]
	public GameObject VFX;

	[Token(Token = "0x4017856")]
	[FieldOffset(Offset = "0x1C")]
	public Animator UINewPlayerSurvey;

	[Token(Token = "0x4017857")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ImgRedDot;

	[Token(Token = "0x6016DF7")]
	[Address(RVA = "0x27AEA10", Offset = "0x27AEA10", VA = "0x27AEA10")]
	public UINewPlayerSurveyView()
	{
	}

	[Token(Token = "0x6016DF8")]
	[Address(RVA = "0x27AEA18", Offset = "0x27AEA18", VA = "0x27AEA18", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016DF9")]
	[Address(RVA = "0x27AECC8", Offset = "0x27AECC8", VA = "0x27AECC8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
