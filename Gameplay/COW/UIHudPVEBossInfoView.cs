using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036EE")]
public class UIHudPVEBossInfoView : UIBaseView
{
	[Token(Token = "0x4016322")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Container;

	[Token(Token = "0x4016323")]
	[FieldOffset(Offset = "0x18")]
	public UILabel WarningTxt;

	[Token(Token = "0x4016324")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject EnterWarningInfo;

	[Token(Token = "0x6016875")]
	[Address(RVA = "0x183B884", Offset = "0x183B884", VA = "0x183B884")]
	public UIHudPVEBossInfoView()
	{
	}

	[Token(Token = "0x6016876")]
	[Address(RVA = "0x183B88C", Offset = "0x183B88C", VA = "0x183B88C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016877")]
	[Address(RVA = "0x183BADC", Offset = "0x183BADC", VA = "0x183BADC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
