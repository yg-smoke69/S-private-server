using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200344B")]
public class UIClanEditView : UIBaseView
{
	[Token(Token = "0x4014452")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget LogoPosDown;

	[Token(Token = "0x4014453")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget LogoPosUp;

	[Token(Token = "0x4014454")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite TeamIcon;

	[Token(Token = "0x4014455")]
	[FieldOffset(Offset = "0x20")]
	public UIButton TeamIconEditBtn;

	[Token(Token = "0x4014456")]
	[FieldOffset(Offset = "0x24")]
	public UISprite TeamIconEditBtnWidget;

	[Token(Token = "0x4014457")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ClanNameEditContainer;

	[Token(Token = "0x4014458")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel LabelClanName;

	[Token(Token = "0x4014459")]
	[FieldOffset(Offset = "0x30")]
	public UIButton ClanNameEditBtn;

	[Token(Token = "0x401445A")]
	[FieldOffset(Offset = "0x34")]
	public GameObject IDContainer;

	[Token(Token = "0x401445B")]
	[FieldOffset(Offset = "0x38")]
	public UILabel IDLabel;

	[Token(Token = "0x401445C")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject TimeContainer;

	[Token(Token = "0x401445D")]
	[FieldOffset(Offset = "0x40")]
	public UILabel TimeLabel;

	[Token(Token = "0x401445E")]
	[FieldOffset(Offset = "0x44")]
	public GameObject ClanNameCreateContainer;

	[Token(Token = "0x401445F")]
	[FieldOffset(Offset = "0x48")]
	public UIInput ClanNameInput;

	[Token(Token = "0x4014460")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject DisbandClanContainer;

	[Token(Token = "0x4014461")]
	[FieldOffset(Offset = "0x50")]
	public UIButton DisbandBtn;

	[Token(Token = "0x4014462")]
	[FieldOffset(Offset = "0x54")]
	public UITable RightTable;

	[Token(Token = "0x4014463")]
	[FieldOffset(Offset = "0x58")]
	public GameObject AreaContainer;

	[Token(Token = "0x4014464")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel AreaLabel;

	[Token(Token = "0x4014465")]
	[FieldOffset(Offset = "0x60")]
	public UIWidget AreaWidget;

	[Token(Token = "0x4014466")]
	[FieldOffset(Offset = "0x64")]
	public GameObject StyleContainer;

	[Token(Token = "0x4014467")]
	[FieldOffset(Offset = "0x68")]
	public UILabel StyleLabel;

	[Token(Token = "0x4014468")]
	[FieldOffset(Offset = "0x6C")]
	public UIWidget StyleWidget;

	[Token(Token = "0x4014469")]
	[FieldOffset(Offset = "0x70")]
	public UITable ApprovalTable;

	[Token(Token = "0x401446A")]
	[FieldOffset(Offset = "0x74")]
	public UIToggleButtonGroup ApprovalToggleGroup;

	[Token(Token = "0x401446B")]
	[FieldOffset(Offset = "0x78")]
	public UIToggleButton AutoToggle;

	[Token(Token = "0x401446C")]
	[FieldOffset(Offset = "0x7C")]
	public UIToggleButton ApproveToggle;

	[Token(Token = "0x401446D")]
	[FieldOffset(Offset = "0x80")]
	public UILabel ApprovalLabel;

	[Token(Token = "0x401446E")]
	[FieldOffset(Offset = "0x84")]
	public GameObject LvContainer;

	[Token(Token = "0x401446F")]
	[FieldOffset(Offset = "0x88")]
	public UILabel LvLabel;

	[Token(Token = "0x4014470")]
	[FieldOffset(Offset = "0x8C")]
	public UIWidget LvWidget;

	[Token(Token = "0x4014471")]
	[FieldOffset(Offset = "0x90")]
	public GameObject BRRankContainer;

	[Token(Token = "0x4014472")]
	[FieldOffset(Offset = "0x94")]
	public UILabel BRRankLabel;

	[Token(Token = "0x4014473")]
	[FieldOffset(Offset = "0x98")]
	public UIWidget BRRankWidget;

	[Token(Token = "0x4014474")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject CSRankContainer;

	[Token(Token = "0x4014475")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel CSRankLabel;

	[Token(Token = "0x4014476")]
	[FieldOffset(Offset = "0xA4")]
	public UIWidget CSRankWidget;

	[Token(Token = "0x4014477")]
	[FieldOffset(Offset = "0xA8")]
	public UISprite ApprovalBG;

	[Token(Token = "0x4014478")]
	[FieldOffset(Offset = "0xAC")]
	public UIButton SloganBtn;

	[Token(Token = "0x4014479")]
	[FieldOffset(Offset = "0xB0")]
	public UIInput SloganInput;

	[Token(Token = "0x401447A")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject NoticeContainer;

	[Token(Token = "0x401447B")]
	[FieldOffset(Offset = "0xB8")]
	public UIButton NoticeBtn;

	[Token(Token = "0x401447C")]
	[FieldOffset(Offset = "0xBC")]
	public UIInput NoticeInput;

	[Token(Token = "0x401447D")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject RightBottom;

	[Token(Token = "0x401447E")]
	[FieldOffset(Offset = "0xC4")]
	public UIToggle SendToWorldToggle;

	[Token(Token = "0x401447F")]
	[FieldOffset(Offset = "0xC8")]
	public UIWidget SendToWorldWidget;

	[Token(Token = "0x4014480")]
	[FieldOffset(Offset = "0xCC")]
	public UILabel orLabel;

	[Token(Token = "0x4014481")]
	[FieldOffset(Offset = "0xD0")]
	public UITable PurchaseTable;

	[Token(Token = "0x4014482")]
	[FieldOffset(Offset = "0xD4")]
	public UIButton CoinButton;

	[Token(Token = "0x4014483")]
	[FieldOffset(Offset = "0xD8")]
	public UILabel CoinCount;

	[Token(Token = "0x4014484")]
	[FieldOffset(Offset = "0xDC")]
	public UIButton GemButton;

	[Token(Token = "0x4014485")]
	[FieldOffset(Offset = "0xE0")]
	public UILabel GemCount;

	[Token(Token = "0x6016095")]
	[Address(RVA = "0x2F3C6BC", Offset = "0x2F3C6BC", VA = "0x2F3C6BC")]
	public UIClanEditView()
	{
	}

	[Token(Token = "0x6016096")]
	[Address(RVA = "0x2F3C6C4", Offset = "0x2F3C6C4", VA = "0x2F3C6C4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016097")]
	[Address(RVA = "0x2F3DAFC", Offset = "0x2F3DAFC", VA = "0x2F3DAFC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
