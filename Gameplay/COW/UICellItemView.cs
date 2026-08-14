using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003408")]
public class UICellItemView : UIBaseView
{
	[Token(Token = "0x4014128")]
	[FieldOffset(Offset = "0x14")]
	public UIButton CellBtn;

	[Token(Token = "0x4014129")]
	[FieldOffset(Offset = "0x18")]
	public UISprite CellIcon;

	[Token(Token = "0x401412A")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject LightEffect;

	[Token(Token = "0x401412B")]
	[FieldOffset(Offset = "0x20")]
	public UISprite HL;

	[Token(Token = "0x401412C")]
	[FieldOffset(Offset = "0x24")]
	public UILabel IndexTxt;

	[Token(Token = "0x6015FCC")]
	[Address(RVA = "0x1458C48", Offset = "0x1458C48", VA = "0x1458C48")]
	public UICellItemView()
	{
	}

	[Token(Token = "0x6015FCD")]
	[Address(RVA = "0x1458C50", Offset = "0x1458C50", VA = "0x1458C50", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FCE")]
	[Address(RVA = "0x1458E94", Offset = "0x1458E94", VA = "0x1458E94")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
