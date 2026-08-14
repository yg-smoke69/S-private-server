using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003826")]
public class UILevelUpView : UIBaseView
{
	[Token(Token = "0x4016E23")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BG;

	[Token(Token = "0x4016E24")]
	[FieldOffset(Offset = "0x18")]
	public GameObject LevelUpResult;

	[Token(Token = "0x4016E25")]
	[FieldOffset(Offset = "0x1C")]
	public Animation LevelUpAnim;

	[Token(Token = "0x4016E26")]
	[FieldOffset(Offset = "0x20")]
	public GameObject LabelNone;

	[Token(Token = "0x4016E27")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelBless;

	[Token(Token = "0x4016E28")]
	[FieldOffset(Offset = "0x28")]
	public GameObject CurLevelInfo;

	[Token(Token = "0x4016E29")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite IconCurEntrance;

	[Token(Token = "0x4016E2A")]
	[FieldOffset(Offset = "0x30")]
	public UILabel LabelCurEntrance;

	[Token(Token = "0x4016E2B")]
	[FieldOffset(Offset = "0x34")]
	public GameObject NextLevelInfo;

	[Token(Token = "0x4016E2C")]
	[FieldOffset(Offset = "0x38")]
	public UISprite IconNextEntrance;

	[Token(Token = "0x4016E2D")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel LabelNextEntrance;

	[Token(Token = "0x4016E2E")]
	[FieldOffset(Offset = "0x40")]
	public UILabel LabelNextLevel;

	[Token(Token = "0x4016E2F")]
	[FieldOffset(Offset = "0x44")]
	public UILabel LabelCurLevel;

	[Token(Token = "0x4016E30")]
	[FieldOffset(Offset = "0x48")]
	public UILabel CurLevelLabel02;

	[Token(Token = "0x4016E31")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton BtnShowChest;

	[Token(Token = "0x4016E32")]
	[FieldOffset(Offset = "0x50")]
	public GameObject RewardResult;

	[Token(Token = "0x4016E33")]
	[FieldOffset(Offset = "0x54")]
	public Animation RewardAnim;

	[Token(Token = "0x4016E34")]
	[FieldOffset(Offset = "0x58")]
	public Transform LeftAwardGrid;

	[Token(Token = "0x4016E35")]
	[FieldOffset(Offset = "0x5C")]
	public Transform MidAwardGrid;

	[Token(Token = "0x4016E36")]
	[FieldOffset(Offset = "0x60")]
	public Transform RightAwardGrid;

	[Token(Token = "0x4016E37")]
	[FieldOffset(Offset = "0x64")]
	public Transform FirstAwardGrid;

	[Token(Token = "0x4016E38")]
	[FieldOffset(Offset = "0x68")]
	public Transform SecondAwardGrid;

	[Token(Token = "0x4016E39")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject RewardTitle;

	[Token(Token = "0x4016E3A")]
	[FieldOffset(Offset = "0x70")]
	public UIButton BtnChest;

	[Token(Token = "0x4016E3B")]
	[FieldOffset(Offset = "0x74")]
	public UISprite IconChest;

	[Token(Token = "0x4016E3C")]
	[FieldOffset(Offset = "0x78")]
	public UIButton OKBtn;

	[Token(Token = "0x4016E3D")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel NextTargetLevel;

	[Token(Token = "0x6016C1D")]
	[Address(RVA = "0x254D9B8", Offset = "0x254D9B8", VA = "0x254D9B8")]
	public UILevelUpView()
	{
	}

	[Token(Token = "0x6016C1E")]
	[Address(RVA = "0x254D9C0", Offset = "0x254D9C0", VA = "0x254D9C0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C1F")]
	[Address(RVA = "0x254E418", Offset = "0x254E418", VA = "0x254E418")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
