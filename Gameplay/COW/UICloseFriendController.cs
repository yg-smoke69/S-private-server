using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200256D")]
internal class UICloseFriendController : UIBaseController, _Attribute, IConvertible
{
	[Token(Token = "0x200256E")]
	private sealed class _003CStartProgressBarChange_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400E7AF")]
		[FieldOffset(Offset = "0x8")]
		internal float _003CupdateTime_003E__0;

		[Token(Token = "0x400E7B0")]
		[FieldOffset(Offset = "0xC")]
		internal int _003ColdValue_003E__0;

		[Token(Token = "0x400E7B1")]
		[FieldOffset(Offset = "0x10")]
		internal uint _003CnewValue_003E__0;

		[Token(Token = "0x400E7B2")]
		[FieldOffset(Offset = "0x14")]
		internal float _003CcurrentValue_003E__0;

		[Token(Token = "0x400E7B3")]
		[FieldOffset(Offset = "0x18")]
		internal float _003CchangeValue_003E__1;

		[Token(Token = "0x400E7B4")]
		[FieldOffset(Offset = "0x1C")]
		internal float IntimacyMax;

		[Token(Token = "0x400E7B5")]
		[FieldOffset(Offset = "0x20")]
		internal UICloseFriendController _0024this;

		[Token(Token = "0x400E7B6")]
		[FieldOffset(Offset = "0x24")]
		internal object _0024current;

		[Token(Token = "0x400E7B7")]
		[FieldOffset(Offset = "0x28")]
		internal bool _0024disposing;

		[Token(Token = "0x400E7B8")]
		[FieldOffset(Offset = "0x2C")]
		internal int _0024PC;

		[Token(Token = "0x17001145")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600DAC4")]
			[Address(RVA = "0x2917298", Offset = "0x2917298", VA = "0x2917298", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001146")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600DAC5")]
			[Address(RVA = "0x29172A0", Offset = "0x29172A0", VA = "0x29172A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600DAC2")]
		[Address(RVA = "0x2916360", Offset = "0x2916360", VA = "0x2916360")]
		public _003CStartProgressBarChange_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600DAC3")]
		[Address(RVA = "0x2916F68", Offset = "0x2916F68", VA = "0x2916F68", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600DAC6")]
		[Address(RVA = "0x29172A8", Offset = "0x29172A8", VA = "0x29172A8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600DAC7")]
		[Address(RVA = "0x29172BC", Offset = "0x29172BC", VA = "0x29172BC", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400E7A3")]
	public const float IntimacyAwardShowAwardPaddingX = 1.15f;

	[Token(Token = "0x400E7A4")]
	[FieldOffset(Offset = "0x28")]
	private UICloseFriendView m_View;

	[Token(Token = "0x400E7A5")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelRelationShip m_RelationshipModel;

	[Token(Token = "0x400E7A6")]
	[FieldOffset(Offset = "0x30")]
	private FriendAccountInfo m_CurrentInviteFriend;

	[Token(Token = "0x400E7A7")]
	[FieldOffset(Offset = "0x34")]
	private RelationshipInfo m_CurrentRelationshipInfo;

	[Token(Token = "0x400E7A8")]
	[FieldOffset(Offset = "0x38")]
	private RelationTypeInfoData m_ConfigRelationshipData;

	[Token(Token = "0x400E7A9")]
	[FieldOffset(Offset = "0x3C")]
	private Dictionary<uint, UIRelationshipRewardItemController> m_ItemList;

	[Token(Token = "0x400E7AA")]
	[FieldOffset(Offset = "0x40")]
	private bool m_isDismissApplicant;

	[Token(Token = "0x400E7AB")]
	[FieldOffset(Offset = "0x41")]
	private bool m_GroupBuildInCurPage;

	[Token(Token = "0x400E7AC")]
	[FieldOffset(Offset = "0x0")]
	private static OnFinished _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400E7AD")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400E7AE")]
	[FieldOffset(Offset = "0x8")]
	private static Converter<ExchangedAward, CommonRewardItemInfo> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x600DA9A")]
	[Address(RVA = "0x290D75C", Offset = "0x290D75C", VA = "0x290D75C")]
	public UICloseFriendController()
	{
	}

	[Token(Token = "0x600DA9B")]
	[Address(RVA = "0x290D814", Offset = "0x290D814", VA = "0x290D814")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DA9C")]
	[Address(RVA = "0x290D8B8", Offset = "0x290D8B8", VA = "0x290D8B8", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600DA9D")]
	[Address(RVA = "0x290DD48", Offset = "0x290DD48", VA = "0x290DD48", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DA9E")]
	[Address(RVA = "0x290EAE8", Offset = "0x290EAE8", VA = "0x290EAE8")]
	public void UpdateCheckboxforNotify()
	{
	}

	[Token(Token = "0x600DA9F")]
	[Address(RVA = "0x290EC48", Offset = "0x290EC48", VA = "0x290EC48")]
	private void OnShowInviteWnd(object[] param)
	{
	}

	[Token(Token = "0x600DAA0")]
	[Address(RVA = "0x290EE6C", Offset = "0x290EE6C", VA = "0x290EE6C")]
	private void OnClickSettingBtn()
	{
	}

	[Token(Token = "0x600DAA1")]
	[Address(RVA = "0x290EF1C", Offset = "0x290EF1C", VA = "0x290EF1C")]
	private void OnClickAnniversaryTips()
	{
	}

	[Token(Token = "0x600DAA2")]
	[Address(RVA = "0x290F164", Offset = "0x290F164", VA = "0x290F164")]
	private void OnNotifyCheckboxChange()
	{
	}

	[Token(Token = "0x600DAA3")]
	[Address(RVA = "0x290F2C0", Offset = "0x290F2C0", VA = "0x290F2C0")]
	private void OnClickDescTips()
	{
	}

	[Token(Token = "0x600DAA4")]
	[Address(RVA = "0x290F3F4", Offset = "0x290F3F4", VA = "0x290F3F4")]
	private void OnClickRequestBreakBtn()
	{
	}

	[Token(Token = "0x600DAA5")]
	[Address(RVA = "0x290F824", Offset = "0x290F824", VA = "0x290F824")]
	private void OnClickChatBtn()
	{
	}

	[Token(Token = "0x600DAA6")]
	[Address(RVA = "0x290FC48", Offset = "0x290FC48", VA = "0x290FC48")]
	private void OnClickRequestGroup()
	{
	}

	[Token(Token = "0x600DAA7")]
	[Address(RVA = "0x2910478", Offset = "0x2910478", VA = "0x2910478")]
	private void OnShowRewardWnd(object[] param)
	{
	}

	[Token(Token = "0x600DAA8")]
	[Address(RVA = "0x2910684", Offset = "0x2910684", VA = "0x2910684")]
	private void OnChooseFriend(object[] param)
	{
	}

	[Token(Token = "0x600DAA9")]
	[Address(RVA = "0x2910B48", Offset = "0x2910B48", VA = "0x2910B48")]
	private void OnClickCallBackBtn()
	{
	}

	[Token(Token = "0x600DAAA")]
	[Address(RVA = "0x2910CCC", Offset = "0x2910CCC", VA = "0x2910CCC")]
	private void OnClickMaskBtn()
	{
	}

	[Token(Token = "0x600DAAB")]
	[Address(RVA = "0x2910D7C", Offset = "0x2910D7C", VA = "0x2910D7C")]
	private void OnClickMaskBtn_2()
	{
	}

	[Token(Token = "0x600DAAC")]
	[Address(RVA = "0x2910E2C", Offset = "0x2910E2C", VA = "0x2910E2C")]
	private void OnClickBreakRelationshipBtn()
	{
	}

	[Token(Token = "0x600DAAD")]
	[Address(RVA = "0x2911010", Offset = "0x2911010", VA = "0x2911010")]
	private void OnClickSendGift()
	{
	}

	[Token(Token = "0x600DAAE")]
	[Address(RVA = "0x2911138", Offset = "0x2911138", VA = "0x2911138")]
	private void OnClickInvite()
	{
	}

	[Token(Token = "0x600DAAF")]
	[Address(RVA = "0x29118B0", Offset = "0x29118B0", VA = "0x29118B0")]
	private void OnClickSelectFriend()
	{
	}

	[Token(Token = "0x600DAB0")]
	[Address(RVA = "0x2911A0C", Offset = "0x2911A0C", VA = "0x2911A0C")]
	private void OnClickInvitationList()
	{
	}

	[Token(Token = "0x600DAB1")]
	[Address(RVA = "0x2911B64", Offset = "0x2911B64", VA = "0x2911B64")]
	public void ShowContent(RelationshipInfo CurrentInfo)
	{
	}

	[Token(Token = "0x600DAB2")]
	[Address(RVA = "0x2912304", Offset = "0x2912304", VA = "0x2912304")]
	private void RefreshStateNone()
	{
	}

	[Token(Token = "0x600DAB3")]
	[Address(RVA = "0x2912940", Offset = "0x2912940", VA = "0x2912940")]
	private void RefreshStateSent()
	{
	}

	[Token(Token = "0x600DAB4")]
	[Address(RVA = "0x2913288", Offset = "0x2913288", VA = "0x2913288")]
	private void RefreshStateAlreadyBe()
	{
	}

	[Token(Token = "0x600DAB5")]
	[Address(RVA = "0x29145BC", Offset = "0x29145BC", VA = "0x29145BC")]
	private void RefreshIntimacyState()
	{
	}

	[Token(Token = "0x600DAB6")]
	[Address(RVA = "0x2913F68", Offset = "0x2913F68", VA = "0x2913F68")]
	private void RefreshStateWaitBroken()
	{
	}

	[Token(Token = "0x600DAB7")]
	[Address(RVA = "0x2914AA0", Offset = "0x2914AA0", VA = "0x2914AA0")]
	private void RefreshRewardList(object[] param)
	{
	}

	[Token(Token = "0x600DAB8")]
	[Address(RVA = "0x2916264", Offset = "0x2916264", VA = "0x2916264")]
	private IEnumerator StartProgressBarChange(float IntimacyMax)
	{
		return null;
	}

	[Token(Token = "0x600DAB9")]
	[Address(RVA = "0x2916368", Offset = "0x2916368", VA = "0x2916368")]
	private void OnReceivedIntimacyRewards(List<CommonRewardItemInfo> rewardData)
	{
	}

	[Token(Token = "0x600DABA")]
	[Address(RVA = "0x29165B4", Offset = "0x29165B4", VA = "0x29165B4", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600DABB")]
	[Address(RVA = "0x2916C30", Offset = "0x2916C30", VA = "0x2916C30", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600DABC")]
	[Address(RVA = "0x2916D30", Offset = "0x2916D30", VA = "0x2916D30", Slot = "33")]
	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	[Token(Token = "0x600DABD")]
	[Address(RVA = "0x2916E8C", Offset = "0x2916E8C", VA = "0x2916E8C")]
	private static void _003CRefreshStateWaitBroken_003Em__0()
	{
	}

	[Token(Token = "0x600DABE")]
	[Address(RVA = "0x2916E90", Offset = "0x2916E90", VA = "0x2916E90")]
	private static void _003COnReceivedIntimacyRewards_003Em__1()
	{
	}

	[Token(Token = "0x600DABF")]
	[Address(RVA = "0x2916F50", Offset = "0x2916F50", VA = "0x2916F50")]
	private static CommonRewardItemInfo _003COnDataChanged_003Em__2(ExchangedAward item)
	{
		return null;
	}

	[Token(Token = "0x600DAC0")]
	[Address(RVA = "0x2916F58", Offset = "0x2916F58", VA = "0x2916F58")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x600DAC1")]
	[Address(RVA = "0x2916F60", Offset = "0x2916F60", VA = "0x2916F60")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
