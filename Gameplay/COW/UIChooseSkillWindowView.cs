using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200343E")]
public class UIChooseSkillWindowView : UIBaseView
{
	[Token(Token = "0x40143C3")]
	[FieldOffset(Offset = "0x14")]
	public GameObject PasivePart;

	[Token(Token = "0x40143C4")]
	[FieldOffset(Offset = "0x18")]
	public GameObject NoPasiveSkillTips;

	[Token(Token = "0x40143C5")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton RecommendBuyBtn1;

	[Token(Token = "0x40143C6")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ActivePart;

	[Token(Token = "0x40143C7")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ActiveReason2;

	[Token(Token = "0x40143C8")]
	[FieldOffset(Offset = "0x28")]
	public UIButton RecommendBuyBtn;

	[Token(Token = "0x40143C9")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject SkillTip2;

	[Token(Token = "0x40143CA")]
	[FieldOffset(Offset = "0x30")]
	public UIPanel HelpPanel;

	[Token(Token = "0x40143CB")]
	[FieldOffset(Offset = "0x34")]
	public Transform TipsTr;

	[Token(Token = "0x40143CC")]
	[FieldOffset(Offset = "0x38")]
	public UIPanel PositiveSkillScrollView;

	[Token(Token = "0x40143CD")]
	[FieldOffset(Offset = "0x3C")]
	public UITable2 PositiveSkillList;

	[Token(Token = "0x40143CE")]
	[FieldOffset(Offset = "0x40")]
	public UITable2Item PositiveSkillSplit;

	[Token(Token = "0x40143CF")]
	[FieldOffset(Offset = "0x44")]
	public UIButton GuideButton;

	[Token(Token = "0x40143D0")]
	[FieldOffset(Offset = "0x48")]
	public UIWidget GuideWidget;

	[Token(Token = "0x40143D1")]
	[FieldOffset(Offset = "0x4C")]
	public UIPanel ActiveSkillScrollView;

	[Token(Token = "0x40143D2")]
	[FieldOffset(Offset = "0x50")]
	public UITable2 ActiveSkillList;

	[Token(Token = "0x40143D3")]
	[FieldOffset(Offset = "0x54")]
	public UITable2Item EquippedActiveSkill;

	[Token(Token = "0x40143D4")]
	[FieldOffset(Offset = "0x58")]
	public Transform SkillIcon;

	[Token(Token = "0x40143D5")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite AvatarIcon;

	[Token(Token = "0x40143D6")]
	[FieldOffset(Offset = "0x60")]
	public UILabel AlreadyEquipTip;

	[Token(Token = "0x40143D7")]
	[FieldOffset(Offset = "0x64")]
	public GameObject ActiveSkillTip;

	[Token(Token = "0x40143D8")]
	[FieldOffset(Offset = "0x68")]
	public UITable2Item ActiveSkillSplit;

	[Token(Token = "0x40143D9")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject LoveNode;

	[Token(Token = "0x40143DA")]
	[FieldOffset(Offset = "0x70")]
	public UIToggleButton ActiveSkilMenu;

	[Token(Token = "0x40143DB")]
	[FieldOffset(Offset = "0x74")]
	public UIToggleButton CommonSkillMenu;

	[Token(Token = "0x40143DC")]
	[FieldOffset(Offset = "0x78")]
	public GameObject RightArrowButton;

	[Token(Token = "0x601606E")]
	[Address(RVA = "0x2F1E8E4", Offset = "0x2F1E8E4", VA = "0x2F1E8E4")]
	public UIChooseSkillWindowView()
	{
	}

	[Token(Token = "0x601606F")]
	[Address(RVA = "0x2F1E8EC", Offset = "0x2F1E8EC", VA = "0x2F1E8EC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016070")]
	[Address(RVA = "0x2F1F344", Offset = "0x2F1F344", VA = "0x2F1F344")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
