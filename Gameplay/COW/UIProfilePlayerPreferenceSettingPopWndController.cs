using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x2002AA5")]
public class UIProfilePlayerPreferenceSettingPopWndController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x2002AA6")]
	private enum EToggle
	{
		[Token(Token = "0x4010649")]
		BasicSetting,
		[Token(Token = "0x401064A")]
		TagShow,
		[Token(Token = "0x401064B")]
		PregameInfo,
		[Token(Token = "0x401064C")]
		PrivateSetting
	}

	[Token(Token = "0x4010612")]
	[FieldOffset(Offset = "0x48")]
	private ulong m_accoutid;

	[Token(Token = "0x4010613")]
	[FieldOffset(Offset = "0x50")]
	private UIProfilePlayerPreferenceSettingPopWndView m_View;

	[Token(Token = "0x4010614")]
	[FieldOffset(Offset = "0x54")]
	private UIModelProfile m_ModelProfile;

	[Token(Token = "0x4010615")]
	[FieldOffset(Offset = "0x58")]
	private LoginRes m_UserData;

	[Token(Token = "0x4010616")]
	[FieldOffset(Offset = "0x5C")]
	private SocialBasicInfo m_SocailBasicInfo;

	[Token(Token = "0x4010617")]
	private const int TOGGLE_GROUP_ID = 117;

	[Token(Token = "0x4010618")]
	[FieldOffset(Offset = "0x60")]
	private LocLang m_SelectedLan;

	[Token(Token = "0x4010619")]
	[FieldOffset(Offset = "0x64")]
	private string m_SelectedSex;

	[Token(Token = "0x401061A")]
	[FieldOffset(Offset = "0x68")]
	private string m_SelectedDefaultShow;

	[Token(Token = "0x401061B")]
	[FieldOffset(Offset = "0x6C")]
	private string m_SelectedOnLineTime;

	[Token(Token = "0x401061C")]
	[FieldOffset(Offset = "0x70")]
	private string m_SelectedActiveTime;

	[Token(Token = "0x401061D")]
	[FieldOffset(Offset = "0x74")]
	private string m_SelectedModePrefer;

	[Token(Token = "0x401061E")]
	[FieldOffset(Offset = "0x78")]
	private string m_Signature;

	[Token(Token = "0x401061F")]
	[FieldOffset(Offset = "0x7C")]
	private string m_DefaultSignature;

	[Token(Token = "0x4010620")]
	[FieldOffset(Offset = "0x80")]
	private List<PopMenuData> m_LanDataList;

	[Token(Token = "0x4010621")]
	[FieldOffset(Offset = "0x84")]
	private List<PopMenuData> m_SexDataList;

	[Token(Token = "0x4010622")]
	[FieldOffset(Offset = "0x88")]
	private List<PopMenuData> m_DefaultShowDataList;

	[Token(Token = "0x4010623")]
	[FieldOffset(Offset = "0x8C")]
	private List<PopMenuData> m_OnLineTimeDataList;

	[Token(Token = "0x4010624")]
	[FieldOffset(Offset = "0x90")]
	private List<PopMenuData> m_ActiveTimeDataList;

	[Token(Token = "0x4010625")]
	[FieldOffset(Offset = "0x94")]
	private List<PopMenuData> m_ModePreferDataList;

	[Token(Token = "0x4010626")]
	[FieldOffset(Offset = "0x98")]
	private List<string> m_SexList;

	[Token(Token = "0x4010627")]
	[FieldOffset(Offset = "0x9C")]
	private List<string> m_DefaultShowList;

	[Token(Token = "0x4010628")]
	[FieldOffset(Offset = "0xA0")]
	private List<string> m_OnLineTimeList;

	[Token(Token = "0x4010629")]
	[FieldOffset(Offset = "0xA4")]
	private List<string> m_ActiveTimeList;

	[Token(Token = "0x401062A")]
	[FieldOffset(Offset = "0xA8")]
	private List<string> m_ModePreferList;

	[Token(Token = "0x401062B")]
	[FieldOffset(Offset = "0xAC")]
	private UIPopMenuSmallControler m_SexPop;

	[Token(Token = "0x401062C")]
	[FieldOffset(Offset = "0xB0")]
	private UIPopMenuSmallControler m_DefaultShowPop;

	[Token(Token = "0x401062D")]
	[FieldOffset(Offset = "0xB4")]
	private UIPopMenuSmallControler m_OnLineTimePop;

	[Token(Token = "0x401062E")]
	[FieldOffset(Offset = "0xB8")]
	private UIPopMenuSmallControler m_ActiveTimePop;

	[Token(Token = "0x401062F")]
	[FieldOffset(Offset = "0xBC")]
	private UIPopMenuSmallControler m_ModePreferPop;

	[Token(Token = "0x4010630")]
	[FieldOffset(Offset = "0xC0")]
	private readonly float GREY_ALPHA;

	[Token(Token = "0x4010631")]
	[FieldOffset(Offset = "0xC4")]
	private UISelectLanguageController m_UISelectLanguageController;

	[Token(Token = "0x4010632")]
	[FieldOffset(Offset = "0xC8")]
	private List<UIProfileTagController> m_SocailTagList;

	[Token(Token = "0x4010633")]
	[FieldOffset(Offset = "0xCC")]
	private List<UIProfileTagController> m_BattleTagList;

	[Token(Token = "0x4010634")]
	[FieldOffset(Offset = "0xD0")]
	private List<UIProfileTagSmallController> m_PreviewTagList;

	[Token(Token = "0x4010635")]
	[FieldOffset(Offset = "0xD4")]
	private bool m_NeedHide;

	[Token(Token = "0x4010636")]
	[FieldOffset(Offset = "0xD5")]
	private bool m_OriginHide;

	[Token(Token = "0x4010637")]
	[FieldOffset(Offset = "0xD8")]
	private UICommonGuideController m_GuideCtrl;

	[Token(Token = "0x4010638")]
	[FieldOffset(Offset = "0xDC")]
	private List<PlayerBattleTagData> m_PlayerBattleTagDataList;

	[Token(Token = "0x4010639")]
	[FieldOffset(Offset = "0xE0")]
	private List<PlayerSocailTagData> m_PlayerSocialTagDataList;

	[Token(Token = "0x401063A")]
	[FieldOffset(Offset = "0xE4")]
	private List<PlayerBattleTagData> m_OriginPlayerBattleTagDataList;

	[Token(Token = "0x401063B")]
	[FieldOffset(Offset = "0xE8")]
	private List<PlayerSocailTagData> m_OrignPlayerSocialTagDataList;

	[Token(Token = "0x401063C")]
	private const string m_EquipShowKey = "T_26_YP_SOCIAL_TAG_SHOW";

	[Token(Token = "0x401063D")]
	private const string m_EquipUnEquipKey = "T_26_YP_SOCIAL_TAG_REMOVE";

	[Token(Token = "0x401063E")]
	private const string m_EquipUnlockKey = "T_26_YP_SOCIAL_TAG_UNLOCK";

	[Token(Token = "0x401063F")]
	[FieldOffset(Offset = "0xEC")]
	private uint m_SelectedBattleId;

	[Token(Token = "0x4010640")]
	[FieldOffset(Offset = "0xF0")]
	private uint m_SelectedSocialId;

	[Token(Token = "0x4010641")]
	[FieldOffset(Offset = "0xF8")]
	private ulong mytime;

	[Token(Token = "0x4010642")]
	private const uint Claimed_COLOR = 1027427583u;

	[Token(Token = "0x4010643")]
	private const uint Lock_COLOR = 1717993727u;

	[Token(Token = "0x4010644")]
	[FieldOffset(Offset = "0x100")]
	private bool m_ClickPrivateDisplay;

	[Token(Token = "0x4010645")]
	[FieldOffset(Offset = "0x104")]
	private UILoadingPlayerInfoController m_LoadingPlayerInfoCtrl;

	[Token(Token = "0x4010646")]
	[FieldOffset(Offset = "0x108")]
	private List<UIProfileSettingPregameInfoDataItemController> m_ListPregameInfoDataCtrl;

	[Token(Token = "0x4010647")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<PlayerBattleTagData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60116C3")]
	[Address(RVA = "0x16ED028", Offset = "0x16ED028", VA = "0x16ED028")]
	public UIProfilePlayerPreferenceSettingPopWndController()
	{
	}

	[Token(Token = "0x60116C4")]
	[Address(RVA = "0x16ED2A8", Offset = "0x16ED2A8", VA = "0x16ED2A8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60116C5")]
	[Address(RVA = "0x16ED34C", Offset = "0x16ED34C", VA = "0x16ED34C", Slot = "31")]
	public override string Rule()
	{
		return null;
	}

	[Token(Token = "0x60116C6")]
	[Address(RVA = "0x16ED470", Offset = "0x16ED470", VA = "0x16ED470", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60116C7")]
	[Address(RVA = "0x16F199C", Offset = "0x16F199C", VA = "0x16F199C")]
	private void InitPrivatePanelOpenState()
	{
	}

	[Token(Token = "0x60116C8")]
	[Address(RVA = "0x16F1FA0", Offset = "0x16F1FA0", VA = "0x16F1FA0")]
	private void OnPublicToogleClick()
	{
	}

	[Token(Token = "0x60116C9")]
	[Address(RVA = "0x16F2070", Offset = "0x16F2070", VA = "0x16F2070")]
	private void OnPrivateToogleClick()
	{
	}

	[Token(Token = "0x60116CA")]
	[Address(RVA = "0x16F2140", Offset = "0x16F2140", VA = "0x16F2140")]
	private void RefreshLoadingPlayerInfo()
	{
	}

	[Token(Token = "0x60116CB")]
	[Address(RVA = "0x16F2678", Offset = "0x16F2678", VA = "0x16F2678")]
	private void RefreshTitleKey()
	{
	}

	[Token(Token = "0x60116CC")]
	[Address(RVA = "0x16EE5C4", Offset = "0x16EE5C4", VA = "0x16EE5C4")]
	private void PreparePregamePlayerInfo()
	{
	}

	[Token(Token = "0x60116CD")]
	[Address(RVA = "0x16F2944", Offset = "0x16F2944", VA = "0x16F2944")]
	private void CreatePregameInfoPreviewController()
	{
	}

	[Token(Token = "0x60116CE")]
	[Address(RVA = "0x16F313C", Offset = "0x16F313C", VA = "0x16F313C")]
	private List<BattleTagInfo> GetListBattleTag()
	{
		return null;
	}

	[Token(Token = "0x60116CF")]
	[Address(RVA = "0x16F2E5C", Offset = "0x16F2E5C", VA = "0x16F2E5C")]
	private void CreatePregameInfoDataItems(List<uint> listData)
	{
	}

	[Token(Token = "0x60116D0")]
	[Address(RVA = "0x16F33D4", Offset = "0x16F33D4", VA = "0x16F33D4")]
	private void OnClickToggleBtnPrivateSetting()
	{
	}

	[Token(Token = "0x60116D1")]
	[Address(RVA = "0x16F3438", Offset = "0x16F3438", VA = "0x16F3438")]
	private void RefreshPrivateInfo()
	{
	}

	[Token(Token = "0x60116D2")]
	[Address(RVA = "0x16F3960", Offset = "0x16F3960", VA = "0x16F3960")]
	public void InitCloseUI()
	{
	}

	[Token(Token = "0x60116D3")]
	[Address(RVA = "0x16F3B30", Offset = "0x16F3B30", VA = "0x16F3B30")]
	private void OnMyClose()
	{
	}

	[Token(Token = "0x60116D4")]
	[Address(RVA = "0x16F3C70", Offset = "0x16F3C70", VA = "0x16F3C70")]
	private void OnBattleToggleClick()
	{
	}

	[Token(Token = "0x60116D5")]
	[Address(RVA = "0x16EE92C", Offset = "0x16EE92C", VA = "0x16EE92C")]
	private void InitTagString()
	{
	}

	[Token(Token = "0x60116D6")]
	[Address(RVA = "0x16EF7C8", Offset = "0x16EF7C8", VA = "0x16EF7C8")]
	private void InitDefaultTagString()
	{
	}

	[Token(Token = "0x60116D7")]
	[Address(RVA = "0x16F0230", Offset = "0x16F0230", VA = "0x16F0230")]
	private void InitPopMenu()
	{
	}

	[Token(Token = "0x60116D8")]
	[Address(RVA = "0x16F3F70", Offset = "0x16F3F70", VA = "0x16F3F70")]
	private int GetOnlineTimeIndex(string str)
	{
		return default(int);
	}

	[Token(Token = "0x60116D9")]
	[Address(RVA = "0x16F3E08", Offset = "0x16F3E08", VA = "0x16F3E08")]
	private int GetActiveTimeIndex(string str)
	{
		return default(int);
	}

	[Token(Token = "0x60116DA")]
	[Address(RVA = "0x16F4240", Offset = "0x16F4240", VA = "0x16F4240")]
	private int GetModelPreferIndex(string str)
	{
		return default(int);
	}

	[Token(Token = "0x60116DB")]
	[Address(RVA = "0x16F43A8", Offset = "0x16F43A8", VA = "0x16F43A8")]
	private int GetModelChooseIndex(string str)
	{
		return default(int);
	}

	[Token(Token = "0x60116DC")]
	[Address(RVA = "0x16F40D8", Offset = "0x16F40D8", VA = "0x16F40D8")]
	private int GetSexIndex(string str)
	{
		return default(int);
	}

	[Token(Token = "0x60116DD")]
	[Address(RVA = "0x16EFD88", Offset = "0x16EFD88", VA = "0x16EFD88")]
	private void InitSelectedState()
	{
	}

	[Token(Token = "0x60116DE")]
	[Address(RVA = "0x16F1948", Offset = "0x16F1948", VA = "0x16F1948")]
	private void TryShowGuide()
	{
	}

	[Token(Token = "0x60116DF")]
	[Address(RVA = "0x16F4510", Offset = "0x16F4510", VA = "0x16F4510")]
	private void OnMainGuideClose()
	{
	}

	[Token(Token = "0x60116E0")]
	[Address(RVA = "0x16EE410", Offset = "0x16EE410", VA = "0x16EE410")]
	private void SetGoRightPanelShow(EToggle eToggle)
	{
	}

	[Token(Token = "0x60116E1")]
	[Address(RVA = "0x16F4564", Offset = "0x16F4564", VA = "0x16F4564")]
	private void OnClickBasicSetting()
	{
	}

	[Token(Token = "0x60116E2")]
	[Address(RVA = "0x16F45C8", Offset = "0x16F45C8", VA = "0x16F45C8")]
	private void OnClickToggleBtnPregameInfo()
	{
	}

	[Token(Token = "0x60116E3")]
	[Address(RVA = "0x16F4A6C", Offset = "0x16F4A6C", VA = "0x16F4A6C")]
	private void OnTagShowClick()
	{
	}

	[Token(Token = "0x60116E4")]
	[Address(RVA = "0x16F4BB4", Offset = "0x16F4BB4", VA = "0x16F4BB4")]
	private void OnSocialToogleCLick()
	{
	}

	[Token(Token = "0x60116E5")]
	[Address(RVA = "0x16F4D18", Offset = "0x16F4D18", VA = "0x16F4D18")]
	private void OnBattleTagClose()
	{
	}

	[Token(Token = "0x60116E6")]
	[Address(RVA = "0x16F4E1C", Offset = "0x16F4E1C", VA = "0x16F4E1C")]
	private void OnSocailTagClose()
	{
	}

	[Token(Token = "0x60116E7")]
	[Address(RVA = "0x16F4F58", Offset = "0x16F4F58", VA = "0x16F4F58")]
	public void PopUpWindowInTagShow(ProfileTagType m_type)
	{
	}

	[Token(Token = "0x60116E8")]
	[Address(RVA = "0x16F5118", Offset = "0x16F5118", VA = "0x16F5118")]
	private void OnGetFocus()
	{
	}

	[Token(Token = "0x60116E9")]
	[Address(RVA = "0x16F52A8", Offset = "0x16F52A8", VA = "0x16F52A8")]
	private void OnLostFocus()
	{
	}

	[Token(Token = "0x60116EA")]
	[Address(RVA = "0x16F53F0", Offset = "0x16F53F0", VA = "0x16F53F0")]
	private bool CheckCanSend()
	{
		return default(bool);
	}

	[Token(Token = "0x60116EB")]
	[Address(RVA = "0x16F6090", Offset = "0x16F6090", VA = "0x16F6090")]
	private bool CheckBattleSend()
	{
		return default(bool);
	}

	[Token(Token = "0x60116EC")]
	[Address(RVA = "0x16F632C", Offset = "0x16F632C", VA = "0x16F632C")]
	private bool CheckSocialSend()
	{
		return default(bool);
	}

	[Token(Token = "0x60116ED")]
	[Address(RVA = "0x16F5B2C", Offset = "0x16F5B2C", VA = "0x16F5B2C")]
	private ESocial.ModePrefer GetPreferBySelect()
	{
		return default(ESocial.ModePrefer);
	}

	[Token(Token = "0x60116EE")]
	[Address(RVA = "0x16F5C40", Offset = "0x16F5C40", VA = "0x16F5C40")]
	private ESocial.Gender GetGenderBySelect()
	{
		return default(ESocial.Gender);
	}

	[Token(Token = "0x60116EF")]
	[Address(RVA = "0x16F5D54", Offset = "0x16F5D54", VA = "0x16F5D54")]
	private ESocial.TimeActive GetActiveBySelect()
	{
		return default(ESocial.TimeActive);
	}

	[Token(Token = "0x60116F0")]
	[Address(RVA = "0x16F5E68", Offset = "0x16F5E68", VA = "0x16F5E68")]
	private ESocial.TimeOnline GetTimeBySelect()
	{
		return default(ESocial.TimeOnline);
	}

	[Token(Token = "0x60116F1")]
	[Address(RVA = "0x16F5F7C", Offset = "0x16F5F7C", VA = "0x16F5F7C")]
	private ESocial.RankShow GetShowBySelect()
	{
		return default(ESocial.RankShow);
	}

	[Token(Token = "0x60116F2")]
	[Address(RVA = "0x16F65C8", Offset = "0x16F65C8", VA = "0x16F65C8", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x60116F3")]
	[Address(RVA = "0x16F6D80", Offset = "0x16F6D80", VA = "0x16F6D80")]
	private bool CheckLoadingPlayerInfoChoiceHasChanged()
	{
		return default(bool);
	}

	[Token(Token = "0x60116F4")]
	[Address(RVA = "0x16F7060", Offset = "0x16F7060", VA = "0x16F7060", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x60116F5")]
	[Address(RVA = "0x16F7288", Offset = "0x16F7288", VA = "0x16F7288")]
	private void OnBtnRenameClick()
	{
	}

	[Token(Token = "0x60116F6")]
	[Address(RVA = "0x16F73D4", Offset = "0x16F73D4", VA = "0x16F73D4")]
	private void OnSelectLanguageClick()
	{
	}

	[Token(Token = "0x60116F7")]
	[Address(RVA = "0x16F753C", Offset = "0x16F753C", VA = "0x16F753C")]
	private void InitLanguageList()
	{
	}

	[Token(Token = "0x60116F8")]
	[Address(RVA = "0x16EFB50", Offset = "0x16EFB50", VA = "0x16EFB50")]
	private void InitTagLevelUpReview()
	{
	}

	[Token(Token = "0x60116F9")]
	[Address(RVA = "0x16F78A0", Offset = "0x16F78A0", VA = "0x16F78A0")]
	private void GenerateSexList()
	{
	}

	[Token(Token = "0x60116FA")]
	[Address(RVA = "0x16F7D44", Offset = "0x16F7D44", VA = "0x16F7D44")]
	private void GenerateDefaultShowList()
	{
	}

	[Token(Token = "0x60116FB")]
	[Address(RVA = "0x16F81E8", Offset = "0x16F81E8", VA = "0x16F81E8")]
	private void GenerateOnLineTimeList()
	{
	}

	[Token(Token = "0x60116FC")]
	[Address(RVA = "0x16F868C", Offset = "0x16F868C", VA = "0x16F868C")]
	private void GenerateActiveTimeList()
	{
	}

	[Token(Token = "0x60116FD")]
	[Address(RVA = "0x16F8B30", Offset = "0x16F8B30", VA = "0x16F8B30")]
	private void GenerateModePreferList()
	{
	}

	[Token(Token = "0x60116FE")]
	[Address(RVA = "0x16F8FD4", Offset = "0x16F8FD4", VA = "0x16F8FD4")]
	private void OnLocLanSelect(object obj)
	{
	}

	[Token(Token = "0x60116FF")]
	[Address(RVA = "0x16F9104", Offset = "0x16F9104", VA = "0x16F9104")]
	private void OnSexSelect(object obj)
	{
	}

	[Token(Token = "0x6011700")]
	[Address(RVA = "0x16F92F0", Offset = "0x16F92F0", VA = "0x16F92F0")]
	private void OnDefaultShowSelect(object obj)
	{
	}

	[Token(Token = "0x6011701")]
	[Address(RVA = "0x16F94DC", Offset = "0x16F94DC", VA = "0x16F94DC")]
	private void OnOnLineTimeSelect(object obj)
	{
	}

	[Token(Token = "0x6011702")]
	[Address(RVA = "0x16F96C8", Offset = "0x16F96C8", VA = "0x16F96C8")]
	private void OnActiveTimeSelect(object obj)
	{
	}

	[Token(Token = "0x6011703")]
	[Address(RVA = "0x16F98B4", Offset = "0x16F98B4", VA = "0x16F98B4")]
	private void OnModePreferSelect(object obj)
	{
	}

	[Token(Token = "0x6011704")]
	[Address(RVA = "0x16F9AA0", Offset = "0x16F9AA0", VA = "0x16F9AA0")]
	private void OnSignatureChange()
	{
	}

	[Token(Token = "0x6011705")]
	[Address(RVA = "0x16F9AF4", Offset = "0x16F9AF4", VA = "0x16F9AF4")]
	private void OnEquipBattleTagClick()
	{
	}

	[Token(Token = "0x6011706")]
	[Address(RVA = "0x16FA754", Offset = "0x16FA754", VA = "0x16FA754")]
	private void OnEquipSocialTagClick()
	{
	}

	[Token(Token = "0x6011707")]
	[Address(RVA = "0x16FB048", Offset = "0x16FB048", VA = "0x16FB048")]
	private void OnUnEquipBattleTagClick()
	{
	}

	[Token(Token = "0x6011708")]
	[Address(RVA = "0x16FB280", Offset = "0x16FB280", VA = "0x16FB280")]
	private void OnUnEquipSocialTagClick()
	{
	}

	[Token(Token = "0x6011709")]
	[Address(RVA = "0x16FA078", Offset = "0x16FA078", VA = "0x16FA078")]
	private uint CalcBattleTagShowNum()
	{
		return default(uint);
	}

	[Token(Token = "0x601170A")]
	[Address(RVA = "0x16FACE0", Offset = "0x16FACE0", VA = "0x16FACE0")]
	private uint CalcSocialTagShowNum()
	{
		return default(uint);
	}

	[Token(Token = "0x601170B")]
	[Address(RVA = "0x16FB4B8", Offset = "0x16FB4B8", VA = "0x16FB4B8")]
	private void UpdateData()
	{
	}

	[Token(Token = "0x601170C")]
	[Address(RVA = "0x16FB880", Offset = "0x16FB880", VA = "0x16FB880")]
	private void OnTagClick(object[] param)
	{
	}

	[Token(Token = "0x601170D")]
	[Address(RVA = "0x16FD02C", Offset = "0x16FD02C", VA = "0x16FD02C")]
	private void RefreshBattleTag()
	{
	}

	[Token(Token = "0x601170E")]
	[Address(RVA = "0x16FDC88", Offset = "0x16FDC88", VA = "0x16FDC88")]
	private void RefreshSocialTag()
	{
	}

	[Token(Token = "0x601170F")]
	[Address(RVA = "0x16FE288", Offset = "0x16FE288", VA = "0x16FE288")]
	public void RefreshAccoutId(ulong accid)
	{
	}

	[Token(Token = "0x6011710")]
	[Address(RVA = "0x16FA3E0", Offset = "0x16FA3E0", VA = "0x16FA3E0")]
	private void RefreshSocialBattleLabel()
	{
	}

	[Token(Token = "0x6011711")]
	[Address(RVA = "0x16FD8A8", Offset = "0x16FD8A8", VA = "0x16FD8A8")]
	private void UpdateBattleTag()
	{
	}

	[Token(Token = "0x6011712")]
	[Address(RVA = "0x16FA1E4", Offset = "0x16FA1E4", VA = "0x16FA1E4")]
	private void RefreshBattleTagL()
	{
	}

	[Token(Token = "0x6011713")]
	[Address(RVA = "0x16FAE4C", Offset = "0x16FAE4C", VA = "0x16FAE4C")]
	private void RefreshSocialTagL()
	{
	}

	[Token(Token = "0x6011714")]
	[Address(RVA = "0x16FBF48", Offset = "0x16FBF48", VA = "0x16FBF48")]
	private void RefreshBattleTagDetailPanel(PlayerBattleTagData data)
	{
	}

	[Token(Token = "0x6011715")]
	[Address(RVA = "0x16FBB1C", Offset = "0x16FBB1C", VA = "0x16FBB1C")]
	private void RefreshSocialTagDetailPanel(PlayerSocailTagData data)
	{
	}

	[Token(Token = "0x6011716")]
	[Address(RVA = "0x16FE528", Offset = "0x16FE528", VA = "0x16FE528")]
	private void OnLevelUpTipsClick()
	{
	}

	[Token(Token = "0x6011717")]
	[Address(RVA = "0x16FE32C", Offset = "0x16FE32C", VA = "0x16FE32C")]
	private void RefreshPreviewTag(PlayerBattleTagData data)
	{
	}

	[Token(Token = "0x6011718")]
	[Address(RVA = "0x16FE770", Offset = "0x16FE770", VA = "0x16FE770", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011719")]
	[Address(RVA = "0x16FEA5C", Offset = "0x16FEA5C", VA = "0x16FEA5C", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x601171A")]
	[Address(RVA = "0x16F0B30", Offset = "0x16F0B30", VA = "0x16F0B30")]
	private void InitTag()
	{
	}

	[Token(Token = "0x601171B")]
	[Address(RVA = "0x16FEB14", Offset = "0x16FEB14", VA = "0x16FEB14")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x601171C")]
	[Address(RVA = "0x16FEB18", Offset = "0x16FEB18", VA = "0x16FEB18")]
	private bool _003CGetPreferBySelect_003Em__1(string X)
	{
		return default(bool);
	}

	[Token(Token = "0x601171D")]
	[Address(RVA = "0x16FEBA8", Offset = "0x16FEBA8", VA = "0x16FEBA8")]
	private bool _003CGetGenderBySelect_003Em__2(string X)
	{
		return default(bool);
	}

	[Token(Token = "0x601171E")]
	[Address(RVA = "0x16FEC38", Offset = "0x16FEC38", VA = "0x16FEC38")]
	private bool _003CGetActiveBySelect_003Em__3(string X)
	{
		return default(bool);
	}

	[Token(Token = "0x601171F")]
	[Address(RVA = "0x16FECC8", Offset = "0x16FECC8", VA = "0x16FECC8")]
	private bool _003CGetTimeBySelect_003Em__4(string X)
	{
		return default(bool);
	}

	[Token(Token = "0x6011720")]
	[Address(RVA = "0x16FED58", Offset = "0x16FED58", VA = "0x16FED58")]
	private bool _003CGetShowBySelect_003Em__5(string X)
	{
		return default(bool);
	}

	[Token(Token = "0x6011721")]
	[Address(RVA = "0x16FEDE8", Offset = "0x16FEDE8", VA = "0x16FEDE8")]
	private static int _003CUpdateBattleTag_003Em__6(PlayerBattleTagData a, PlayerBattleTagData b)
	{
		return default(int);
	}

	[Token(Token = "0x6011722")]
	[Address(RVA = "0x16FEE40", Offset = "0x16FEE40", VA = "0x16FEE40")]
	public string _003C_003EiFixBaseProxy_Rule()
	{
		return null;
	}

	[Token(Token = "0x6011723")]
	[Address(RVA = "0x16FEE48", Offset = "0x16FEE48", VA = "0x16FEE48")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011724")]
	[Address(RVA = "0x16FEE50", Offset = "0x16FEE50", VA = "0x16FEE50")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6011725")]
	[Address(RVA = "0x16FEE58", Offset = "0x16FEE58", VA = "0x16FEE58")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
