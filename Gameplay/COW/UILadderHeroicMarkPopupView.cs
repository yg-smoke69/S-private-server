using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200380A")]
public class UILadderHeroicMarkPopupView : UIBaseView
{
	[Token(Token = "0x4016C71")]
	[FieldOffset(Offset = "0x14")]
	public Animation EnterAnim;

	[Token(Token = "0x4016C72")]
	[FieldOffset(Offset = "0x18")]
	public GameObject InfoBefore;

	[Token(Token = "0x4016C73")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite IconBeforeSprite;

	[Token(Token = "0x4016C74")]
	[FieldOffset(Offset = "0x20")]
	public GameObject InfoAfter;

	[Token(Token = "0x4016C75")]
	[FieldOffset(Offset = "0x24")]
	public UISprite IconAftereSprite;

	[Token(Token = "0x4016C76")]
	[FieldOffset(Offset = "0x28")]
	public UIButton backBtnMask;

	[Token(Token = "0x4016C77")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel BackBtnLabel;

	[Token(Token = "0x4016C78")]
	[FieldOffset(Offset = "0x30")]
	public GameObject VfxContent;

	[Token(Token = "0x6016BC9")]
	[Address(RVA = "0x1AE6D8C", Offset = "0x1AE6D8C", VA = "0x1AE6D8C")]
	public UILadderHeroicMarkPopupView()
	{
	}

	[Token(Token = "0x6016BCA")]
	[Address(RVA = "0x1AE6D94", Offset = "0x1AE6D94", VA = "0x1AE6D94", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BCB")]
	[Address(RVA = "0x1AE71B8", Offset = "0x1AE71B8", VA = "0x1AE71B8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
