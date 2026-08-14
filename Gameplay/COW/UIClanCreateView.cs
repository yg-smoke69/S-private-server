using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003449")]
public class UIClanCreateView : UIBaseView
{
	[Token(Token = "0x401442C")]
	[FieldOffset(Offset = "0x14")]
	public UIInput NameInput;

	[Token(Token = "0x401442D")]
	[FieldOffset(Offset = "0x18")]
	public UIInput SloganInput;

	[Token(Token = "0x401442E")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggle AutoToggle;

	[Token(Token = "0x401442F")]
	[FieldOffset(Offset = "0x20")]
	public UIToggle ApproveToggle;

	[Token(Token = "0x4014430")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ApprovalConditionLevel;

	[Token(Token = "0x4014431")]
	[FieldOffset(Offset = "0x28")]
	public UIButton CondLevelBtn;

	[Token(Token = "0x4014432")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel CondLevelLabel;

	[Token(Token = "0x4014433")]
	[FieldOffset(Offset = "0x30")]
	public UIWidget CondLevelBG;

	[Token(Token = "0x4014434")]
	[FieldOffset(Offset = "0x34")]
	public GameObject ApprovalConditionRank;

	[Token(Token = "0x4014435")]
	[FieldOffset(Offset = "0x38")]
	public UIButton CondRankBtn;

	[Token(Token = "0x4014436")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel CondRankLabel;

	[Token(Token = "0x4014437")]
	[FieldOffset(Offset = "0x40")]
	public UIWidget CondRankBG;

	[Token(Token = "0x4014438")]
	[FieldOffset(Offset = "0x44")]
	public GameObject ApprovalConditionUnselectBG;

	[Token(Token = "0x4014439")]
	[FieldOffset(Offset = "0x48")]
	public UITable ContainerTable;

	[Token(Token = "0x401443A")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject AreaContainer;

	[Token(Token = "0x401443B")]
	[FieldOffset(Offset = "0x50")]
	public UIButton AreaBtn;

	[Token(Token = "0x401443C")]
	[FieldOffset(Offset = "0x54")]
	public UILabel AreaLabel;

	[Token(Token = "0x401443D")]
	[FieldOffset(Offset = "0x58")]
	public UIWidget AreaBG;

	[Token(Token = "0x401443E")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton TagBtn;

	[Token(Token = "0x401443F")]
	[FieldOffset(Offset = "0x60")]
	public UILabel TagLabel;

	[Token(Token = "0x4014440")]
	[FieldOffset(Offset = "0x64")]
	public UIWidget TagBG;

	[Token(Token = "0x4014441")]
	[FieldOffset(Offset = "0x68")]
	public UIToggle SendToWorldToggle;

	[Token(Token = "0x4014442")]
	[FieldOffset(Offset = "0x6C")]
	public UIWidget SendToWorldWidget;

	[Token(Token = "0x4014443")]
	[FieldOffset(Offset = "0x70")]
	public UILabel orLabel;

	[Token(Token = "0x4014444")]
	[FieldOffset(Offset = "0x74")]
	public UITable PurchaseTable;

	[Token(Token = "0x4014445")]
	[FieldOffset(Offset = "0x78")]
	public UIButton CoinButton;

	[Token(Token = "0x4014446")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel CoinCount;

	[Token(Token = "0x4014447")]
	[FieldOffset(Offset = "0x80")]
	public UIButton GemButton;

	[Token(Token = "0x4014448")]
	[FieldOffset(Offset = "0x84")]
	public UILabel GemCount;

	[Token(Token = "0x601608F")]
	[Address(RVA = "0x2F336C8", Offset = "0x2F336C8", VA = "0x2F336C8")]
	public UIClanCreateView()
	{
	}

	[Token(Token = "0x6016090")]
	[Address(RVA = "0x2F336D0", Offset = "0x2F336D0", VA = "0x2F336D0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016091")]
	[Address(RVA = "0x2F342C8", Offset = "0x2F342C8", VA = "0x2F342C8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
