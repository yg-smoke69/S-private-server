using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200399A")]
public class UISceneEditSubscriptionInfoView : UIBaseView
{
	[Token(Token = "0x401825A")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView CenterSV;

	[Token(Token = "0x401825B")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget CenterScrollable;

	[Token(Token = "0x401825C")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget ContentContainer;

	[Token(Token = "0x401825D")]
	[FieldOffset(Offset = "0x20")]
	public UITable Table;

	[Token(Token = "0x401825E")]
	[FieldOffset(Offset = "0x24")]
	public UIWidget TitleContainer;

	[Token(Token = "0x401825F")]
	[FieldOffset(Offset = "0x28")]
	public UIInput SearchInput;

	[Token(Token = "0x4018260")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnSearch;

	[Token(Token = "0x4018261")]
	[FieldOffset(Offset = "0x30")]
	public UIGrid SubGrid;

	[Token(Token = "0x4018262")]
	[FieldOffset(Offset = "0x34")]
	public UISprite SubEmpty;

	[Token(Token = "0x4018263")]
	[FieldOffset(Offset = "0x38")]
	public UIGrid UpdatedGrid;

	[Token(Token = "0x4018264")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite UpdatedEmpty;

	[Token(Token = "0x6017075")]
	[Address(RVA = "0x2DB244C", Offset = "0x2DB244C", VA = "0x2DB244C")]
	public UISceneEditSubscriptionInfoView()
	{
	}

	[Token(Token = "0x6017076")]
	[Address(RVA = "0x2DB2454", Offset = "0x2DB2454", VA = "0x2DB2454", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017077")]
	[Address(RVA = "0x2DB29BC", Offset = "0x2DB29BC", VA = "0x2DB29BC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
