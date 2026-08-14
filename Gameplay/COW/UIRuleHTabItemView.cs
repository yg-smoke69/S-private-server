using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003979")]
public class UIRuleHTabItemView : UIBaseView
{
	[Token(Token = "0x4018124")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIRuleHTabItem;

	[Token(Token = "0x4018125")]
	[FieldOffset(Offset = "0x18")]
	public GameObject BtnEnable;

	[Token(Token = "0x4018126")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel EnableLabel;

	[Token(Token = "0x4018127")]
	[FieldOffset(Offset = "0x20")]
	public GameObject BtnDisable;

	[Token(Token = "0x4018128")]
	[FieldOffset(Offset = "0x24")]
	public UILabel DisableLabel;

	[Token(Token = "0x6017012")]
	[Address(RVA = "0x2BF432C", Offset = "0x2BF432C", VA = "0x2BF432C")]
	public UIRuleHTabItemView()
	{
	}

	[Token(Token = "0x6017013")]
	[Address(RVA = "0x2BF4334", Offset = "0x2BF4334", VA = "0x2BF4334", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017014")]
	[Address(RVA = "0x2BF4644", Offset = "0x2BF4644", VA = "0x2BF4644")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
