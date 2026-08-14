using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003619")]
public class UIHudControlPointPosMarkView : UIBaseView
{
	[Token(Token = "0x4015A66")]
	[FieldOffset(Offset = "0x14")]
	public UISprite NormalState;

	[Token(Token = "0x4015A67")]
	[FieldOffset(Offset = "0x18")]
	public GameObject TimerEffectRoot;

	[Token(Token = "0x4015A68")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject TimeUpEffect;

	[Token(Token = "0x4015A69")]
	[FieldOffset(Offset = "0x20")]
	public UISprite GeneratorHP;

	[Token(Token = "0x4015A6A")]
	[FieldOffset(Offset = "0x24")]
	public UISprite GeneratorHPBg;

	[Token(Token = "0x4015A6B")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Warehousewaring;

	[Token(Token = "0x4015A6C")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject WarehouseRoot;

	[Token(Token = "0x4015A6D")]
	[FieldOffset(Offset = "0x30")]
	public UISprite WarehouseHPMask;

	[Token(Token = "0x4015A6E")]
	[FieldOffset(Offset = "0x34")]
	public UISprite ScrambleState;

	[Token(Token = "0x4015A6F")]
	[FieldOffset(Offset = "0x38")]
	public UILabel ControlPointName;

	[Token(Token = "0x4015A70")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel PointStatusLabel;

	[Token(Token = "0x4015A71")]
	[FieldOffset(Offset = "0x40")]
	public UILabel Timer;

	[Token(Token = "0x4015A72")]
	[FieldOffset(Offset = "0x44")]
	public GameObject ArrowLeft;

	[Token(Token = "0x4015A73")]
	[FieldOffset(Offset = "0x48")]
	public GameObject ArrowUp;

	[Token(Token = "0x4015A74")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject ArrowDown;

	[Token(Token = "0x4015A75")]
	[FieldOffset(Offset = "0x50")]
	public GameObject ArrowRight;

	[Token(Token = "0x4015A76")]
	[FieldOffset(Offset = "0x54")]
	public UILabel DistanceLabel;

	[Token(Token = "0x4015A77")]
	[FieldOffset(Offset = "0x58")]
	public UIWidget Container;

	[Token(Token = "0x4015A78")]
	[FieldOffset(Offset = "0x5C")]
	public UIWidget MiniContainer;

	[Token(Token = "0x60165FA")]
	[Address(RVA = "0x1368578", Offset = "0x1368578", VA = "0x1368578")]
	public UIHudControlPointPosMarkView()
	{
	}

	[Token(Token = "0x60165FB")]
	[Address(RVA = "0x1368580", Offset = "0x1368580", VA = "0x1368580", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60165FC")]
	[Address(RVA = "0x1368D88", Offset = "0x1368D88", VA = "0x1368D88")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
