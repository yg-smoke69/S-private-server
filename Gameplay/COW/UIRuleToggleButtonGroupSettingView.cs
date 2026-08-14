using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003987")]
public class UIRuleToggleButtonGroupSettingView : UIBaseView
{
	[Token(Token = "0x4018184")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BG;

	[Token(Token = "0x4018185")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x4018186")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid Container;

	[Token(Token = "0x601703C")]
	[Address(RVA = "0x1425FBC", Offset = "0x1425FBC", VA = "0x1425FBC")]
	public UIRuleToggleButtonGroupSettingView()
	{
	}

	[Token(Token = "0x601703D")]
	[Address(RVA = "0x1425FC4", Offset = "0x1425FC4", VA = "0x1425FC4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601703E")]
	[Address(RVA = "0x142622C", Offset = "0x142622C", VA = "0x142622C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
