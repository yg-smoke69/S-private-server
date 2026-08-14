using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200347E")]
public class UICommonRulesPopupView : UIBaseView
{
	[Token(Token = "0x40146E1")]
	[FieldOffset(Offset = "0x14")]
	public UIEasyList TabsContainer;

	[Token(Token = "0x40146E2")]
	[FieldOffset(Offset = "0x18")]
	public GameObject RuleScrollViewPrefab;

	[Token(Token = "0x40146E3")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnConfirm;

	[Token(Token = "0x40146E4")]
	[FieldOffset(Offset = "0x20")]
	public UILabel title;

	[Token(Token = "0x601612E")]
	[Address(RVA = "0x1EB2704", Offset = "0x1EB2704", VA = "0x1EB2704")]
	public UICommonRulesPopupView()
	{
	}

	[Token(Token = "0x601612F")]
	[Address(RVA = "0x1EB270C", Offset = "0x1EB270C", VA = "0x1EB270C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016130")]
	[Address(RVA = "0x1EB29C8", Offset = "0x1EB29C8", VA = "0x1EB29C8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
