using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002CDB")]
public class BaseChatMessageView : MonoBehaviour
{
	[Token(Token = "0x4011197")]
	[FieldOffset(Offset = "0xC")]
	public UIEffectSprite m_HeadPic;

	[Token(Token = "0x4011198")]
	[FieldOffset(Offset = "0x10")]
	public UILabel m_NameLabel;

	[Token(Token = "0x4011199")]
	[FieldOffset(Offset = "0x14")]
	public UILabel m_SendTimeLabel;

	[Token(Token = "0x401119A")]
	[FieldOffset(Offset = "0x18")]
	public UISprite m_PinIcon;

	[Token(Token = "0x401119B")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite m_LadderIcon;

	[Token(Token = "0x401119C")]
	[FieldOffset(Offset = "0x20")]
	public UISprite m_BannerBG;

	[Token(Token = "0x401119D")]
	[FieldOffset(Offset = "0x24")]
	public bool m_BriefBanner;

	[Token(Token = "0x401119E")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_Content;

	[Token(Token = "0x401119F")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton m_ResendBtn;

	[Token(Token = "0x40111A0")]
	[FieldOffset(Offset = "0x30")]
	public UIButton m_JoinBtn;

	[Token(Token = "0x40111A1")]
	[FieldOffset(Offset = "0x34")]
	public UISprite m_StickerSprite;

	[Token(Token = "0x40111A2")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_GroupInvite;

	[Token(Token = "0x40111A3")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject m_ClanInvite;

	[Token(Token = "0x40111A4")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_ChampionshipTeamInvite;

	[Token(Token = "0x40111A5")]
	[FieldOffset(Offset = "0x44")]
	public GameObject m_CupMatchTeamInvite;

	[Token(Token = "0x40111A6")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_ClanGroupInvite;

	[Token(Token = "0x40111A7")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject m_TutorInvite;

	[Token(Token = "0x40111A8")]
	[FieldOffset(Offset = "0x50")]
	public UIWidget m_LiftTopMessage;

	[Token(Token = "0x40111A9")]
	[FieldOffset(Offset = "0x54")]
	public UILabel m_ContentSystem;

	[Token(Token = "0x40111AA")]
	[FieldOffset(Offset = "0x58")]
	public UISprite m_ContentSystemIcon;

	[Token(Token = "0x40111AB")]
	[FieldOffset(Offset = "0x5C")]
	private GameObject Icon_Celebrity;

	[Token(Token = "0x40111AC")]
	[FieldOffset(Offset = "0x60")]
	public UILabel m_ModeName;

	[Token(Token = "0x40111AD")]
	[FieldOffset(Offset = "0x64")]
	public UILabel m_MapName;

	[Token(Token = "0x40111AE")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_GroupModeName;

	[Token(Token = "0x40111AF")]
	[FieldOffset(Offset = "0x6C")]
	public UISprite m_ReqRankSprite;

	[Token(Token = "0x40111B0")]
	[FieldOffset(Offset = "0x70")]
	public UISprite m_ModeBg;

	[Token(Token = "0x40111B1")]
	[FieldOffset(Offset = "0x74")]
	public UILabel m_ClanName;

	[Token(Token = "0x40111B2")]
	[FieldOffset(Offset = "0x78")]
	public UILabel m_ClanLevel;

	[Token(Token = "0x40111B3")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel m_ClanDeclaration;

	[Token(Token = "0x40111B4")]
	[FieldOffset(Offset = "0x80")]
	public UILabel m_ClanMemberNum;

	[Token(Token = "0x40111B5")]
	[FieldOffset(Offset = "0x84")]
	public UISprite m_ClanLOGO;

	[Token(Token = "0x40111B6")]
	[FieldOffset(Offset = "0x88")]
	public UILabel m_ClanApplyMethodAuto;

	[Token(Token = "0x40111B7")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel m_ClanApplyMethodApproval;

	[Token(Token = "0x40111B8")]
	[FieldOffset(Offset = "0x90")]
	public UILabel m_ClanApplyLimitLevel;

	[Token(Token = "0x40111B9")]
	[FieldOffset(Offset = "0x94")]
	public UILabel m_ClanApplyLimitRank;

	[Token(Token = "0x40111BA")]
	[FieldOffset(Offset = "0x98")]
	public UILabel m_ClanApplyLimitCSRank;

	[Token(Token = "0x40111BB")]
	[FieldOffset(Offset = "0x9C")]
	public UISprite m_ClanApplyLimitRankIcon;

	[Token(Token = "0x40111BC")]
	[FieldOffset(Offset = "0xA0")]
	public UISprite m_ClanApplyLimitCSRankIcon;

	[Token(Token = "0x40111BD")]
	[FieldOffset(Offset = "0xA4")]
	public UILabel m_TutorLabel;

	[Token(Token = "0x40111BE")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel m_Declartion;

	[Token(Token = "0x40111BF")]
	[FieldOffset(Offset = "0xAC")]
	public UILabel m_ChampionshipName;

	[Token(Token = "0x40111C0")]
	[FieldOffset(Offset = "0xB0")]
	public UILabel m_ChampionshipMember;

	[Token(Token = "0x40111C1")]
	[FieldOffset(Offset = "0xB4")]
	public UISprite m_ChampionshipSprite;

	[Token(Token = "0x40111C2")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel m_CupMatchName;

	[Token(Token = "0x40111C3")]
	[FieldOffset(Offset = "0xBC")]
	public UILabel m_CupMatchMember;

	[Token(Token = "0x40111C4")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel m_CupMatchTeamTier;

	[Token(Token = "0x40111C5")]
	[FieldOffset(Offset = "0xC4")]
	public UILabel m_ClanGroupGroupMember;

	[Token(Token = "0x40111C6")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel m_ClanGroupName;

	[Token(Token = "0x40111C7")]
	[FieldOffset(Offset = "0xCC")]
	public UISprite m_ClanIcon;

	[Token(Token = "0x40111C8")]
	[FieldOffset(Offset = "0xD0")]
	public UISprite m_ClanGroupReqRankSprite1;

	[Token(Token = "0x40111C9")]
	[FieldOffset(Offset = "0xD4")]
	public UISprite m_ClanGroupReqRankSprite2;

	[Token(Token = "0x40111CA")]
	[FieldOffset(Offset = "0xD8")]
	public UIGrid m_ClanGroupReqRankGrid;

	[Token(Token = "0x40111CB")]
	[FieldOffset(Offset = "0xDC")]
	public GameObject m_ActivityMsgOB;

	[Token(Token = "0x40111CC")]
	private const uint DEFAULT_HEAD_ID = 902000003u;

	[Token(Token = "0x40111CD")]
	[FieldOffset(Offset = "0xE0")]
	private Vector3 m_Pos;

	[Token(Token = "0x40111CE")]
	[FieldOffset(Offset = "0xEC")]
	private MessageInfo m_Message;

	[Token(Token = "0x40111CF")]
	[FieldOffset(Offset = "0xF0")]
	private Vector3 m_LadderIconPos;

	[Token(Token = "0x40111D0")]
	[FieldOffset(Offset = "0xFC")]
	private Vector3 m_NameLabelPos;

	[Token(Token = "0x40111D1")]
	private const string LADDER_BG = "SG_UI_Chat_Rank_bg1";

	[Token(Token = "0x40111D2")]
	private const string NORMAL_BG = "SG_UI_Chat_Rank_bg";

	[Token(Token = "0x6012C59")]
	[Address(RVA = "0x2E51458", Offset = "0x2E51458", VA = "0x2E51458")]
	public BaseChatMessageView()
	{
	}

	[Token(Token = "0x6012C5A")]
	[Address(RVA = "0x2E5153C", Offset = "0x2E5153C", VA = "0x2E5153C")]
	public void SetUIData(MessageInfo info)
	{
	}

	[Token(Token = "0x6012C5B")]
	[Address(RVA = "0x2E55FC4", Offset = "0x2E55FC4", VA = "0x2E55FC4")]
	public void UpdateJoinBtn(bool isShowJoinBtn)
	{
	}

	[Token(Token = "0x6012C5C")]
	[Address(RVA = "0x2E55B18", Offset = "0x2E55B18", VA = "0x2E55B18")]
	public void UpdatePin(uint pinId)
	{
	}

	[Token(Token = "0x6012C5D")]
	[Address(RVA = "0x2E56020", Offset = "0x2E56020", VA = "0x2E56020")]
	private void MakeUpPosition()
	{
	}

	[Token(Token = "0x6012C5E")]
	[Address(RVA = "0x2E5638C", Offset = "0x2E5638C", VA = "0x2E5638C")]
	private void MakeUpPositionWithMentoring()
	{
	}

	[Token(Token = "0x6012C5F")]
	[Address(RVA = "0x2E5586C", Offset = "0x2E5586C", VA = "0x2E5586C")]
	private void ResetNameLabelPos()
	{
	}

	[Token(Token = "0x6012C60")]
	[Address(RVA = "0x2E55D88", Offset = "0x2E55D88", VA = "0x2E55D88")]
	private void SetTutorIcon(bool isTutor)
	{
	}
}
