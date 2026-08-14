using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003985")]
public class UIRuleSubTableContainerView : UIBaseView
{
	[Token(Token = "0x4018176")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget Self;

	[Token(Token = "0x4018177")]
	[FieldOffset(Offset = "0x18")]
	public UISprite CContainer;

	[Token(Token = "0x4018178")]
	[FieldOffset(Offset = "0x1C")]
	public UITable ContainerTitle;

	[Token(Token = "0x4018179")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget Label;

	[Token(Token = "0x401817A")]
	[FieldOffset(Offset = "0x24")]
	public UILabel SubLabel;

	[Token(Token = "0x401817B")]
	[FieldOffset(Offset = "0x28")]
	public UILabel TitlelessSpace;

	[Token(Token = "0x401817C")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel BG;

	[Token(Token = "0x6017036")]
	[Address(RVA = "0x1423398", Offset = "0x1423398", VA = "0x1423398")]
	public UIRuleSubTableContainerView()
	{
	}

	[Token(Token = "0x6017037")]
	[Address(RVA = "0x14233A0", Offset = "0x14233A0", VA = "0x14233A0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017038")]
	[Address(RVA = "0x1423788", Offset = "0x1423788", VA = "0x1423788")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
