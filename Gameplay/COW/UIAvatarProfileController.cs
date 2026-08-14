using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20024C1")]
public class UIAvatarProfileController : UIBaseController, _Attribute
{
	[Token(Token = "0x20024C2")]
	private sealed class _003CRefreshCommonAvatarNode_003Ec__AnonStorey1
	{
		[Token(Token = "0x400E3FC")]
		[FieldOffset(Offset = "0x8")]
		internal List<ResourceID> res_list;

		[Token(Token = "0x400E3FD")]
		[FieldOffset(Offset = "0xC")]
		internal UIAvatarProfileController _0024this;

		[Token(Token = "0x600D355")]
		[Address(RVA = "0x2B64048", Offset = "0x2B64048", VA = "0x2B64048")]
		public _003CRefreshCommonAvatarNode_003Ec__AnonStorey1()
		{
		}
	}

	[Token(Token = "0x20024C3")]
	private sealed class _003CRefreshCommonAvatarNode_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E3FE")]
		[FieldOffset(Offset = "0x8")]
		internal CSSharedItemData item_data;

		[Token(Token = "0x400E3FF")]
		[FieldOffset(Offset = "0xC")]
		internal _003CRefreshCommonAvatarNode_003Ec__AnonStorey1 _003C_003Ef__ref_00241;

		[Token(Token = "0x600D356")]
		[Address(RVA = "0x2B64050", Offset = "0x2B64050", VA = "0x2B64050")]
		public _003CRefreshCommonAvatarNode_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600D357")]
		[Address(RVA = "0x2B712C0", Offset = "0x2B712C0", VA = "0x2B712C0")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x20024C4")]
	private sealed class _003CRefreshAwakenAvatarNode_003Ec__AnonStorey3
	{
		[Token(Token = "0x400E400")]
		[FieldOffset(Offset = "0x8")]
		internal List<ResourceID> res_list;

		[Token(Token = "0x400E401")]
		[FieldOffset(Offset = "0xC")]
		internal UIAvatarProfileController _0024this;

		[Token(Token = "0x600D358")]
		[Address(RVA = "0x2B67820", Offset = "0x2B67820", VA = "0x2B67820")]
		public _003CRefreshAwakenAvatarNode_003Ec__AnonStorey3()
		{
		}
	}

	[Token(Token = "0x20024C5")]
	private sealed class _003CRefreshAwakenAvatarNode_003Ec__AnonStorey2
	{
		[Token(Token = "0x400E402")]
		[FieldOffset(Offset = "0x8")]
		internal CSSharedItemData item_data;

		[Token(Token = "0x400E403")]
		[FieldOffset(Offset = "0xC")]
		internal _003CRefreshAwakenAvatarNode_003Ec__AnonStorey3 _003C_003Ef__ref_00243;

		[Token(Token = "0x600D359")]
		[Address(RVA = "0x2B67828", Offset = "0x2B67828", VA = "0x2B67828")]
		public _003CRefreshAwakenAvatarNode_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x600D35A")]
		[Address(RVA = "0x2B70C70", Offset = "0x2B70C70", VA = "0x2B70C70")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400E3DD")]
	[FieldOffset(Offset = "0x28")]
	private AvatarProfile m_Profile;

	[Token(Token = "0x400E3DE")]
	[FieldOffset(Offset = "0x2C")]
	private UIAvatarProfileView m_View;

	[Token(Token = "0x400E3DF")]
	[FieldOffset(Offset = "0x30")]
	private Transform[] m_SlotList;

	[Token(Token = "0x400E3E0")]
	[FieldOffset(Offset = "0x34")]
	private Transform[] m_SlotCommonList;

	[Token(Token = "0x400E3E1")]
	[FieldOffset(Offset = "0x38")]
	private List<UIAvatarSkillSlotController> m_SlotCommonCtrlList;

	[Token(Token = "0x400E3E2")]
	[FieldOffset(Offset = "0x3C")]
	private List<UIAvatarSkillSlotController> m_SlotCommonCtrlListSpecial;

	[Token(Token = "0x400E3E3")]
	[FieldOffset(Offset = "0x40")]
	private bool m_SlotCommonCtrlListInitFlag;

	[Token(Token = "0x400E3E4")]
	[FieldOffset(Offset = "0x44")]
	private Transform[] m_SlotAwakenList;

	[Token(Token = "0x400E3E5")]
	[FieldOffset(Offset = "0x48")]
	private List<UIAvatarSkillSlotController> m_SlotAwakenCtrlList;

	[Token(Token = "0x400E3E6")]
	[FieldOffset(Offset = "0x4C")]
	private List<UIAvatarSkillSlotController> m_SlotCtrlList;

	[Token(Token = "0x400E3E7")]
	[FieldOffset(Offset = "0x50")]
	private UIModelAvatarProfile m_Model;

	[Token(Token = "0x400E3E8")]
	[FieldOffset(Offset = "0x54")]
	private UIAvatarSkillSlotController m_skillCtrl;

	[Token(Token = "0x400E3E9")]
	[FieldOffset(Offset = "0x58")]
	private UINewDownloadInfoController m_DownloadCtrl;

	[Token(Token = "0x400E3EA")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_MaxLevel;

	[Token(Token = "0x400E3EB")]
	[FieldOffset(Offset = "0x60")]
	private AvatarSkillData m_SkillData;

	[Token(Token = "0x400E3EC")]
	[FieldOffset(Offset = "0x64")]
	private AvatarSkillData m_OriginSkillData;

	[Token(Token = "0x400E3ED")]
	[FieldOffset(Offset = "0x68")]
	private Color32 Blue;

	[Token(Token = "0x400E3EE")]
	[FieldOffset(Offset = "0x6C")]
	private Color32 Green;

	[Token(Token = "0x400E3EF")]
	[FieldOffset(Offset = "0x70")]
	private Color32 UnAwakenColor;

	[Token(Token = "0x400E3F0")]
	[FieldOffset(Offset = "0x74")]
	private Color32 UnAwakenIconColor;

	[Token(Token = "0x400E3F1")]
	[FieldOffset(Offset = "0x78")]
	private Color32 AwakenColor;

	[Token(Token = "0x400E3F2")]
	[FieldOffset(Offset = "0x7C")]
	private UIAvatarSkillTipsController m_SkillTipsCtrl;

	[Token(Token = "0x400E3F3")]
	[FieldOffset(Offset = "0x80")]
	private bool m_NeedAvatarGuide;

	[Token(Token = "0x400E3F4")]
	[FieldOffset(Offset = "0x81")]
	private bool m_IsShowGuide;

	[Token(Token = "0x400E3F5")]
	[FieldOffset(Offset = "0x84")]
	private UICommonGuideController m_GuideCtrl;

	[Token(Token = "0x400E3F6")]
	private const int GUIDEOFFSET = 30;

	[Token(Token = "0x400E3F7")]
	[FieldOffset(Offset = "0x88")]
	private UIAvatarProfileLoveController m_DefaultLovectrl;

	[Token(Token = "0x400E3F8")]
	[FieldOffset(Offset = "0x8C")]
	private UIAvatarProfileLoveController m_CommonLovectrl;

	[Token(Token = "0x400E3F9")]
	[FieldOffset(Offset = "0x90")]
	private UIAvatarProfileLoveController m_Awakenlovectrl;

	[Token(Token = "0x400E3FA")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<AvatarSuit> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400E3FB")]
	[FieldOffset(Offset = "0x4")]
	private static Func<AssistantAudioData, ResourceID> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600D305")]
	[Address(RVA = "0x2B5DB50", Offset = "0x2B5DB50", VA = "0x2B5DB50")]
	public UIAvatarProfileController()
	{
	}

	[Token(Token = "0x600D306")]
	[Address(RVA = "0x2B5DD3C", Offset = "0x2B5DD3C", VA = "0x2B5DD3C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D307")]
	[Address(RVA = "0x2B5DDE0", Offset = "0x2B5DDE0", VA = "0x2B5DDE0", Slot = "32")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D308")]
	[Address(RVA = "0x2B5DE98", Offset = "0x2B5DE98", VA = "0x2B5DE98")]
	private bool CheckSuitIsABReady(uint suitid)
	{
		return default(bool);
	}

	[Token(Token = "0x600D309")]
	[Address(RVA = "0x2B5E018", Offset = "0x2B5E018", VA = "0x2B5E018")]
	private void StartSuitPreview(uint avatarId, uint[] clothsIds)
	{
	}

	[Token(Token = "0x600D30A")]
	[Address(RVA = "0x2B5E3C0", Offset = "0x2B5E3C0", VA = "0x2B5E3C0", Slot = "31")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D30B")]
	[Address(RVA = "0x2B5F1E0", Offset = "0x2B5F1E0", VA = "0x2B5F1E0")]
	private void RefreshDefaultAvatarNode(bool flag = true)
	{
	}

	[Token(Token = "0x600D30C")]
	[Address(RVA = "0x2B606A8", Offset = "0x2B606A8", VA = "0x2B606A8")]
	private void RefreshCommonAvatarNode(bool flag = true)
	{
	}

	[Token(Token = "0x600D30D")]
	[Address(RVA = "0x2B64690", Offset = "0x2B64690", VA = "0x2B64690")]
	private void SetAvatarGuide(UIBaseController ctrl, Vector3 pos, bool isSingle)
	{
	}

	[Token(Token = "0x600D30E")]
	[Address(RVA = "0x2B649CC", Offset = "0x2B649CC", VA = "0x2B649CC")]
	private void ShowAvatarGuide(string guideLabel, int guideDelay)
	{
	}

	[Token(Token = "0x600D30F")]
	[Address(RVA = "0x2B64D4C", Offset = "0x2B64D4C", VA = "0x2B64D4C")]
	private void SendAvatarGuideLog(bool unlockGuideComplete, bool equipGuideComplete)
	{
	}

	[Token(Token = "0x600D310")]
	[Address(RVA = "0x2B6504C", Offset = "0x2B6504C", VA = "0x2B6504C")]
	private void OnUpdateSkillGuide(object[] param)
	{
	}

	[Token(Token = "0x600D311")]
	[Address(RVA = "0x2B64F74", Offset = "0x2B64F74", VA = "0x2B64F74")]
	private bool CheckHasTips(AvatarProfile profile)
	{
		return default(bool);
	}

	[Token(Token = "0x600D312")]
	[Address(RVA = "0x2B65C30", Offset = "0x2B65C30", VA = "0x2B65C30")]
	public void SetCurrentAwakenSelect(uint avatarID, bool flag = true)
	{
	}

	[Token(Token = "0x600D313")]
	[Address(RVA = "0x2B66000", Offset = "0x2B66000", VA = "0x2B66000")]
	private bool CheckHasAwakenTips(AvatarProfile profile)
	{
		return default(bool);
	}

	[Token(Token = "0x600D314")]
	[Address(RVA = "0x2B5F18C", Offset = "0x2B5F18C", VA = "0x2B5F18C")]
	private void RefreshAwakenEntranceBtn()
	{
	}

	[Token(Token = "0x600D315")]
	[Address(RVA = "0x2B66194", Offset = "0x2B66194", VA = "0x2B66194")]
	private void RefreshAwakenAvatarNode(bool flag = true, bool refresh = true, bool fromSwitch = false)
	{
	}

	[Token(Token = "0x600D316")]
	[Address(RVA = "0x2B643F8", Offset = "0x2B643F8", VA = "0x2B643F8")]
	private uint GetAvatarDebrisLockCout(uint avatarid, uint level)
	{
		return default(uint);
	}

	[Token(Token = "0x600D317")]
	[Address(RVA = "0x2B67BD0", Offset = "0x2B67BD0", VA = "0x2B67BD0")]
	private void StoryClick()
	{
	}

	[Token(Token = "0x600D318")]
	[Address(RVA = "0x2B5ECD0", Offset = "0x2B5ECD0", VA = "0x2B5ECD0")]
	private void RefreshOnlyAvatar(uint avarid)
	{
	}

	[Token(Token = "0x600D319")]
	[Address(RVA = "0x2B67E84", Offset = "0x2B67E84", VA = "0x2B67E84")]
	private void OnDefaultStoryBtnClick()
	{
	}

	[Token(Token = "0x600D31A")]
	[Address(RVA = "0x2B67EE4", Offset = "0x2B67EE4", VA = "0x2B67EE4")]
	private void OnCommonStoryBtnClick()
	{
	}

	[Token(Token = "0x600D31B")]
	[Address(RVA = "0x2B67F44", Offset = "0x2B67F44", VA = "0x2B67F44")]
	private void OnAwakenStoryBtnClick()
	{
	}

	[Token(Token = "0x600D31C")]
	[Address(RVA = "0x2B67FA4", Offset = "0x2B67FA4", VA = "0x2B67FA4")]
	private void OnDefaultVoicePlayBtnClick()
	{
	}

	[Token(Token = "0x600D31D")]
	[Address(RVA = "0x2B68004", Offset = "0x2B68004", VA = "0x2B68004")]
	private void DefaultPlayRandomVoice()
	{
	}

	[Token(Token = "0x600D31E")]
	[Address(RVA = "0x2B68204", Offset = "0x2B68204", VA = "0x2B68204")]
	private void StopDefaultVoicePlayingAnim()
	{
	}

	[Token(Token = "0x600D31F")]
	[Address(RVA = "0x2B603E0", Offset = "0x2B603E0", VA = "0x2B603E0")]
	private void ShowDefaultVoicePlayingAnim(bool show)
	{
	}

	[Token(Token = "0x600D320")]
	[Address(RVA = "0x2B6834C", Offset = "0x2B6834C", VA = "0x2B6834C")]
	private void OnCommonVoicePlayBtnClick()
	{
	}

	[Token(Token = "0x600D321")]
	[Address(RVA = "0x2B641F8", Offset = "0x2B641F8", VA = "0x2B641F8")]
	private void CommonPlayRandomVoice()
	{
	}

	[Token(Token = "0x600D322")]
	[Address(RVA = "0x2B683AC", Offset = "0x2B683AC", VA = "0x2B683AC")]
	private void StopCommonVoicePlayingAnim()
	{
	}

	[Token(Token = "0x600D323")]
	[Address(RVA = "0x2B64058", Offset = "0x2B64058", VA = "0x2B64058")]
	private void ShowCommonVoicePlayingAnim(bool show)
	{
	}

	[Token(Token = "0x600D324")]
	[Address(RVA = "0x2B684F4", Offset = "0x2B684F4", VA = "0x2B684F4")]
	private void OnAwakenVoicePlayBtnClick()
	{
	}

	[Token(Token = "0x600D325")]
	[Address(RVA = "0x2B679D0", Offset = "0x2B679D0", VA = "0x2B679D0")]
	private void AwakenPlayRandomVoice()
	{
	}

	[Token(Token = "0x600D326")]
	[Address(RVA = "0x2B68554", Offset = "0x2B68554", VA = "0x2B68554")]
	private void StopAwakenVoicePlayingAnim()
	{
	}

	[Token(Token = "0x600D327")]
	[Address(RVA = "0x2B67830", Offset = "0x2B67830", VA = "0x2B67830")]
	private void ShowAwakenVoicePlayingAnim(bool show)
	{
	}

	[Token(Token = "0x600D328")]
	[Address(RVA = "0x2B6869C", Offset = "0x2B6869C", VA = "0x2B6869C")]
	private void OnLevelUpClick()
	{
	}

	[Token(Token = "0x600D329")]
	[Address(RVA = "0x2B68DDC", Offset = "0x2B68DDC", VA = "0x2B68DDC")]
	private void OnCommonSwitchBtnClick()
	{
	}

	[Token(Token = "0x600D32A")]
	[Address(RVA = "0x2B69110", Offset = "0x2B69110", VA = "0x2B69110")]
	private void OnAwakenSwitchBtnClick()
	{
	}

	[Token(Token = "0x600D32B")]
	[Address(RVA = "0x2B69444", Offset = "0x2B69444", VA = "0x2B69444")]
	private void OnAwakenEntranceBtnClick()
	{
	}

	[Token(Token = "0x600D32C")]
	[Address(RVA = "0x2B696C8", Offset = "0x2B696C8", VA = "0x2B696C8")]
	private void OnExchangeToAwakenAvatar()
	{
	}

	[Token(Token = "0x600D32D")]
	[Address(RVA = "0x2B6A08C", Offset = "0x2B6A08C", VA = "0x2B6A08C")]
	private void OnExchangeToOriAvatar()
	{
	}

	[Token(Token = "0x600D32E")]
	[Address(RVA = "0x2B6A700", Offset = "0x2B6A700", VA = "0x2B6A700", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D32F")]
	[Address(RVA = "0x2B6C2E8", Offset = "0x2B6C2E8", VA = "0x2B6C2E8")]
	private void OnDownloadBtnClick()
	{
	}

	[Token(Token = "0x600D330")]
	[Address(RVA = "0x2B6C700", Offset = "0x2B6C700", VA = "0x2B6C700")]
	private void RefreshGuide()
	{
	}

	[Token(Token = "0x600D331")]
	[Address(RVA = "0x2B6D088", Offset = "0x2B6D088", VA = "0x2B6D088")]
	private void OnRelationBtn1Click()
	{
	}

	[Token(Token = "0x600D332")]
	[Address(RVA = "0x2B6D35C", Offset = "0x2B6D35C", VA = "0x2B6D35C")]
	private void OnRelationBtn2Click()
	{
	}

	[Token(Token = "0x600D333")]
	[Address(RVA = "0x2B6D630", Offset = "0x2B6D630", VA = "0x2B6D630")]
	private void OnEmtpySkillClick()
	{
	}

	[Token(Token = "0x600D334")]
	[Address(RVA = "0x2B6D98C", Offset = "0x2B6D98C", VA = "0x2B6D98C")]
	private void OnRelationBtn3Click()
	{
	}

	[Token(Token = "0x600D335")]
	[Address(RVA = "0x2B6DC60", Offset = "0x2B6DC60", VA = "0x2B6DC60")]
	private void OnAwakenTipClick()
	{
	}

	[Token(Token = "0x600D336")]
	[Address(RVA = "0x2B6DFF4", Offset = "0x2B6DFF4", VA = "0x2B6DFF4")]
	private void OnCommonTipClick()
	{
	}

	[Token(Token = "0x600D337")]
	[Address(RVA = "0x2B6E378", Offset = "0x2B6E378", VA = "0x2B6E378")]
	public void SetData(AvatarProfile profile, bool flag = true, bool fromSwitch = false)
	{
	}

	[Token(Token = "0x600D338")]
	[Address(RVA = "0x2B6E414", Offset = "0x2B6E414", VA = "0x2B6E414")]
	public void RefreshData(bool flag, bool refresh = true, bool fromSwitch = false)
	{
	}

	[Token(Token = "0x600D339")]
	[Address(RVA = "0x2B6E514", Offset = "0x2B6E514", VA = "0x2B6E514")]
	private void OnVoiceDownloadBtnClick()
	{
	}

	[Token(Token = "0x600D33A")]
	[Address(RVA = "0x2B5E7C4", Offset = "0x2B5E7C4", VA = "0x2B5E7C4")]
	private void RefreshVoiceBtnState()
	{
	}

	[Token(Token = "0x600D33B")]
	[Address(RVA = "0x2B6EA8C", Offset = "0x2B6EA8C", VA = "0x2B6EA8C")]
	private bool CheckAvatarVoiceABIsReady(uint avatarID)
	{
		return default(bool);
	}

	[Token(Token = "0x600D33C")]
	[Address(RVA = "0x2B6EDF8", Offset = "0x2B6EDF8", VA = "0x2B6EDF8")]
	private void SetPveWeaponInfo(CSSharedAvatarData basicInfo)
	{
	}

	[Token(Token = "0x600D33D")]
	[Address(RVA = "0x2B6F0D8", Offset = "0x2B6F0D8", VA = "0x2B6F0D8", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600D33E")]
	[Address(RVA = "0x2B6F178", Offset = "0x2B6F178", VA = "0x2B6F178")]
	private void onSliderChangeNew()
	{
	}

	[Token(Token = "0x600D33F")]
	[Address(RVA = "0x2B600E0", Offset = "0x2B600E0", VA = "0x2B600E0")]
	private void onSliderChange()
	{
	}

	[Token(Token = "0x600D340")]
	[Address(RVA = "0x2B6F4B0", Offset = "0x2B6F4B0", VA = "0x2B6F4B0")]
	private void onSliderThumbPress(GameObject go, bool state)
	{
	}

	[Token(Token = "0x600D341")]
	[Address(RVA = "0x2B6F520", Offset = "0x2B6F520", VA = "0x2B6F520")]
	private void OnTipBtnClick()
	{
	}

	[Token(Token = "0x600D342")]
	[Address(RVA = "0x2B6F62C", Offset = "0x2B6F62C", VA = "0x2B6F62C")]
	private void OnSkillLevelUpClick()
	{
	}

	[Token(Token = "0x600D343")]
	[Address(RVA = "0x2B6F680", Offset = "0x2B6F680", VA = "0x2B6F680")]
	private void OnAlignmentBtnClick()
	{
	}

	[Token(Token = "0x600D344")]
	[Address(RVA = "0x2B6F9A0", Offset = "0x2B6F9A0", VA = "0x2B6F9A0")]
	private void OnAwakenSkillUpgradeClick()
	{
	}

	[Token(Token = "0x600D345")]
	[Address(RVA = "0x2B6FAEC", Offset = "0x2B6FAEC", VA = "0x2B6FAEC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D346")]
	[Address(RVA = "0x2B6FF1C", Offset = "0x2B6FF1C", VA = "0x2B6FF1C")]
	private void OnUpdateRedTips(object[] param)
	{
	}

	[Token(Token = "0x600D347")]
	[Address(RVA = "0x2B70084", Offset = "0x2B70084", VA = "0x2B70084")]
	private void OnUpdateLevelMax(object[] param)
	{
	}

	[Token(Token = "0x600D348")]
	[Address(RVA = "0x2B704CC", Offset = "0x2B704CC", VA = "0x2B704CC")]
	private void OnUpdateTips(object[] param)
	{
	}

	[Token(Token = "0x600D349")]
	[Address(RVA = "0x2B70530", Offset = "0x2B70530", VA = "0x2B70530")]
	private void OnAvatarShowListCloseBtnClick(object[] param)
	{
	}

	[Token(Token = "0x600D34A")]
	[Address(RVA = "0x2B70644", Offset = "0x2B70644", VA = "0x2B70644")]
	private void OnUpdateAwakenData(object[] param)
	{
	}

	[Token(Token = "0x600D34B")]
	[Address(RVA = "0x2B702A0", Offset = "0x2B702A0", VA = "0x2B702A0")]
	private void PlayAnimOneShotEvt(string voice_resourceid)
	{
	}

	[Token(Token = "0x600D34C")]
	[Address(RVA = "0x2B707D0", Offset = "0x2B707D0", VA = "0x2B707D0")]
	private void OnTouchLocalAvatar(object[] param)
	{
	}

	[Token(Token = "0x600D34D")]
	[Address(RVA = "0x2B7099C", Offset = "0x2B7099C", VA = "0x2B7099C")]
	public void SetSlotCount()
	{
	}

	[Token(Token = "0x600D34E")]
	[Address(RVA = "0x2B70B70", Offset = "0x2B70B70", VA = "0x2B70B70")]
	private static bool _003CRefreshOnlyAvatar_003Em__0(AvatarSuit x)
	{
		return default(bool);
	}

	[Token(Token = "0x600D34F")]
	[Address(RVA = "0x2B70B94", Offset = "0x2B70B94", VA = "0x2B70B94")]
	private void _003COnUIInit_003Em__1(int length)
	{
	}

	[Token(Token = "0x600D350")]
	[Address(RVA = "0x2B70BE4", Offset = "0x2B70BE4", VA = "0x2B70BE4")]
	private void _003COnUIInit_003Em__2(int length)
	{
	}

	[Token(Token = "0x600D351")]
	[Address(RVA = "0x2B70C34", Offset = "0x2B70C34", VA = "0x2B70C34")]
	private static ResourceID _003COnVoiceDownloadBtnClick_003Em__3(AssistantAudioData audio)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D352")]
	[Address(RVA = "0x2B70C58", Offset = "0x2B70C58", VA = "0x2B70C58")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D353")]
	[Address(RVA = "0x2B70C60", Offset = "0x2B70C60", VA = "0x2B70C60")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600D354")]
	[Address(RVA = "0x2B70C68", Offset = "0x2B70C68", VA = "0x2B70C68")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
