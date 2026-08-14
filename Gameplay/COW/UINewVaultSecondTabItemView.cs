using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038D5")]
public class UINewVaultSecondTabItemView : UIBaseView
{
	[Token(Token = "0x40178D9")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Select;

	[Token(Token = "0x40178DA")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Label;

	[Token(Token = "0x40178DB")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject UnSelect;

	[Token(Token = "0x40178DC")]
	[FieldOffset(Offset = "0x20")]
	public UILabel UnSelectLabel;

	[Token(Token = "0x40178DD")]
	[FieldOffset(Offset = "0x24")]
	public UITipsButton RedPoint;

	[Token(Token = "0x40178DE")]
	[FieldOffset(Offset = "0x28")]
	public BaseItemView2 Icon;

	[Token(Token = "0x40178DF")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite DefaultIcon;

	[Token(Token = "0x40178E0")]
	[FieldOffset(Offset = "0x30")]
	public UIButton Button;

	[Token(Token = "0x40178E1")]
	[FieldOffset(Offset = "0x34")]
	public UILabel NumLabel;

	[Token(Token = "0x6016E28")]
	[Address(RVA = "0x26CF300", Offset = "0x26CF300", VA = "0x26CF300")]
	public UINewVaultSecondTabItemView()
	{
	}

	[Token(Token = "0x6016E29")]
	[Address(RVA = "0x26CF308", Offset = "0x26CF308", VA = "0x26CF308", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E2A")]
	[Address(RVA = "0x26CF798", Offset = "0x26CF798", VA = "0x26CF798")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
