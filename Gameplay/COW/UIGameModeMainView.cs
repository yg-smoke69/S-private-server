using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035A7")]
public class UIGameModeMainView : UIBaseView
{
	[Token(Token = "0x40156BB")]
	[FieldOffset(Offset = "0x14")]
	public UIButton roomBtn;

	[Token(Token = "0x40156BC")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView ScrollView;

	[Token(Token = "0x40156BD")]
	[FieldOffset(Offset = "0x1C")]
	public UICustomSortTable table;

	[Token(Token = "0x40156BE")]
	[FieldOffset(Offset = "0x20")]
	public UIToggleButtonGroup ModeBtnGroup;

	[Token(Token = "0x40156BF")]
	[FieldOffset(Offset = "0x24")]
	public Transform ranked;

	[Token(Token = "0x40156C0")]
	[FieldOffset(Offset = "0x28")]
	public Transform csrank;

	[Token(Token = "0x40156C1")]
	[FieldOffset(Offset = "0x2C")]
	public Transform classic;

	[Token(Token = "0x40156C2")]
	[FieldOffset(Offset = "0x30")]
	public UICustomSortTable hot;

	[Token(Token = "0x40156C3")]
	[FieldOffset(Offset = "0x34")]
	public Transform hot1;

	[Token(Token = "0x40156C4")]
	[FieldOffset(Offset = "0x38")]
	public Transform hot2;

	[Token(Token = "0x40156C5")]
	[FieldOffset(Offset = "0x3C")]
	public UIGrid casualGrid;

	[Token(Token = "0x40156C6")]
	[FieldOffset(Offset = "0x40")]
	public Animation Ani;

	[Token(Token = "0x40156C7")]
	[FieldOffset(Offset = "0x44")]
	public UIGrid GridMediumItems;

	[Token(Token = "0x40156C8")]
	[FieldOffset(Offset = "0x48")]
	public Transform TargetY;

	[Token(Token = "0x40156C9")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject Centerhelpter;

	[Token(Token = "0x60164A3")]
	[Address(RVA = "0x21871B0", Offset = "0x21871B0", VA = "0x21871B0")]
	public UIGameModeMainView()
	{
	}

	[Token(Token = "0x60164A4")]
	[Address(RVA = "0x21871B8", Offset = "0x21871B8", VA = "0x21871B8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164A5")]
	[Address(RVA = "0x21877A4", Offset = "0x21877A4", VA = "0x21877A4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
