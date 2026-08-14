using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003734")]
public class UIHudSceneEditModeEditWndView : UIBaseView
{
	[Token(Token = "0x4016501")]
	[FieldOffset(Offset = "0x14")]
	public UIEasyList TabsContainer;

	[Token(Token = "0x4016502")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ModeRules;

	[Token(Token = "0x4016503")]
	[FieldOffset(Offset = "0x1C")]
	public UITable ModeRulesContainer;

	[Token(Token = "0x4016504")]
	[FieldOffset(Offset = "0x20")]
	public GameObject GeneralRules;

	[Token(Token = "0x4016505")]
	[FieldOffset(Offset = "0x24")]
	public UITable GeneralRulesContainer;

	[Token(Token = "0x4016506")]
	[FieldOffset(Offset = "0x28")]
	public UIButton ResetBtn;

	[Token(Token = "0x6016947")]
	[Address(RVA = "0x24E3028", Offset = "0x24E3028", VA = "0x24E3028")]
	public UIHudSceneEditModeEditWndView()
	{
	}

	[Token(Token = "0x6016948")]
	[Address(RVA = "0x24E3030", Offset = "0x24E3030", VA = "0x24E3030", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016949")]
	[Address(RVA = "0x24E33A0", Offset = "0x24E33A0", VA = "0x24E33A0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
