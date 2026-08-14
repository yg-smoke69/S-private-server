using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2001F20")]
internal class UIModelDigitaluniverseB : UIBaseModel, _Attribute
{
	[Token(Token = "0x2001F21")]
	public class UICommonGuideData
	{
		[Token(Token = "0x400C446")]
		[FieldOffset(Offset = "0x8")]
		public string PlayerPrefKey;

		[Token(Token = "0x400C447")]
		[FieldOffset(Offset = "0xC")]
		public CommonGuideSetting Setting;

		[Token(Token = "0x400C448")]
		[FieldOffset(Offset = "0x10")]
		public UIButton FinishGuideBtn;

		[Token(Token = "0x400C449")]
		[FieldOffset(Offset = "0x14")]
		public UIWidget GuidingWidget;

		[Token(Token = "0x400C44A")]
		[FieldOffset(Offset = "0x18")]
		public Side Side;

		[Token(Token = "0x400C44B")]
		[FieldOffset(Offset = "0x1C")]
		public Transform ParentCtrlTrans;

		[Token(Token = "0x60099DD")]
		[Address(RVA = "0xFAE690", Offset = "0xFAE690", VA = "0xFAE690")]
		public UICommonGuideData()
		{
		}
	}

	[Token(Token = "0x2001F22")]
	public enum DoorAwardState
	{
		[Token(Token = "0x400C44D")]
		None,
		[Token(Token = "0x400C44E")]
		Received,
		[Token(Token = "0x400C44F")]
		Finished,
		[Token(Token = "0x400C450")]
		Awarded
	}

	[Token(Token = "0x2001F23")]
	public enum DoorPageState
	{
		[Token(Token = "0x400C452")]
		None,
		[Token(Token = "0x400C453")]
		Locked,
		[Token(Token = "0x400C454")]
		UnLocked,
		[Token(Token = "0x400C455")]
		Finished,
		[Token(Token = "0x400C456")]
		Awarded,
		[Token(Token = "0x400C457")]
		Lightened
	}

	[Token(Token = "0x2001F24")]
	public class DoorTabData
	{
		[Token(Token = "0x400C458")]
		[FieldOffset(Offset = "0x8")]
		public string TopContent;

		[Token(Token = "0x400C459")]
		[FieldOffset(Offset = "0xC")]
		public string DescContent;

		[Token(Token = "0x400C45A")]
		[FieldOffset(Offset = "0x10")]
		public string tabSpriteName;

		[Token(Token = "0x400C45B")]
		[FieldOffset(Offset = "0x14")]
		public int DoorType;

		[Token(Token = "0x60099DE")]
		[Address(RVA = "0xFAE688", Offset = "0xFAE688", VA = "0xFAE688")]
		public DoorTabData()
		{
		}
	}

	[Token(Token = "0x2001F25")]
	private enum MissionType
	{
		[Token(Token = "0x400C45D")]
		None,
		[Token(Token = "0x400C45E")]
		DailyMission,
		[Token(Token = "0x400C45F")]
		CountDownInprogrsssMission,
		[Token(Token = "0x400C460")]
		CountDownExpiredMission
	}

	[Token(Token = "0x2001F26")]
	private sealed class _003CHasFinishMissionInCha_003Ec__AnonStorey0
	{
		[Token(Token = "0x400C461")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x400C462")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelDigitaluniverseB _0024this;

		[Token(Token = "0x60099DF")]
		[Address(RVA = "0xFACB84", Offset = "0xFACB84", VA = "0xFACB84")]
		public _003CHasFinishMissionInCha_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60099E0")]
		[Address(RVA = "0xFACB8C", Offset = "0xFACB8C", VA = "0xFACB8C")]
		internal bool _003C_003Em__0(DigitaluniverseBCharMissionDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001F27")]
	private sealed class _003CIncreaseProgress_003Ec__AnonStorey1
	{
		[Token(Token = "0x400C463")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x400C464")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelDigitaluniverseB _0024this;

		[Token(Token = "0x60099E1")]
		[Address(RVA = "0xFACC48", Offset = "0xFACC48", VA = "0xFACC48")]
		public _003CIncreaseProgress_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60099E2")]
		[Address(RVA = "0xFACC50", Offset = "0xFACC50", VA = "0xFACC50")]
		internal bool _003C_003Em__0(DigitaluniverseBCharMissionDesc x)
		{
			return default(bool);
		}

		[Token(Token = "0x60099E3")]
		[Address(RVA = "0xFACD0C", Offset = "0xFACD0C", VA = "0xFACD0C")]
		internal bool _003C_003Em__1(DigitaluniverseBMapMissionDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001F28")]
	private sealed class _003CGetStoryGroupCountByGroupId_003Ec__AnonStorey2
	{
		[Token(Token = "0x400C465")]
		[FieldOffset(Offset = "0x8")]
		internal uint groupId;

		[Token(Token = "0x60099E4")]
		[Address(RVA = "0xFACA10", Offset = "0xFACA10", VA = "0xFACA10")]
		public _003CGetStoryGroupCountByGroupId_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x60099E5")]
		[Address(RVA = "0xFACA18", Offset = "0xFACA18", VA = "0xFACA18")]
		internal bool _003C_003Em__0(DigitaluniverseBCharStoryDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001F29")]
	private sealed class _003CGetProgressValueByContent_003Ec__AnonStorey3
	{
		[Token(Token = "0x400C466")]
		[FieldOffset(Offset = "0x8")]
		internal uint missionContent;

		[Token(Token = "0x60099E6")]
		[Address(RVA = "0xFAC958", Offset = "0xFAC958", VA = "0xFAC958")]
		public _003CGetProgressValueByContent_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x60099E7")]
		[Address(RVA = "0xFAC960", Offset = "0xFAC960", VA = "0xFAC960")]
		internal bool _003C_003Em__0(DigitaluniverseBCharMissionDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001F2A")]
	private sealed class _003CGetMissionDescById_003Ec__AnonStorey4
	{
		[Token(Token = "0x400C467")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x60099E8")]
		[Address(RVA = "0xFAC8C4", Offset = "0xFAC8C4", VA = "0xFAC8C4")]
		public _003CGetMissionDescById_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x60099E9")]
		[Address(RVA = "0xFAC8CC", Offset = "0xFAC8CC", VA = "0xFAC8CC")]
		internal bool _003C_003Em__0(DigitaluniverseBCharMissionDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001F2B")]
	private sealed class _003CGetStoryDescByStoryIdAndGroupId_003Ec__AnonStorey5
	{
		[Token(Token = "0x400C468")]
		[FieldOffset(Offset = "0x8")]
		internal uint groupId;

		[Token(Token = "0x400C469")]
		[FieldOffset(Offset = "0xC")]
		internal uint storyId;

		[Token(Token = "0x60099EA")]
		[Address(RVA = "0xFAC998", Offset = "0xFAC998", VA = "0xFAC998")]
		public _003CGetStoryDescByStoryIdAndGroupId_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x60099EB")]
		[Address(RVA = "0xFAC9A0", Offset = "0xFAC9A0", VA = "0xFAC9A0")]
		internal bool _003C_003Em__0(DigitaluniverseBCharStoryDesc x)
		{
			return default(bool);
		}

		[Token(Token = "0x60099EC")]
		[Address(RVA = "0xFAC9D8", Offset = "0xFAC9D8", VA = "0xFAC9D8")]
		internal bool _003C_003Em__1(DigitaluniverseBCharStoryDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001F2C")]
	private sealed class _003CGetMissionRewardDescById_003Ec__AnonStorey6
	{
		[Token(Token = "0x400C46A")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x400C46B")]
		[FieldOffset(Offset = "0xC")]
		internal int gateType;

		[Token(Token = "0x60099ED")]
		[Address(RVA = "0xFAC904", Offset = "0xFAC904", VA = "0xFAC904")]
		public _003CGetMissionRewardDescById_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x60099EE")]
		[Address(RVA = "0xFAC90C", Offset = "0xFAC90C", VA = "0xFAC90C")]
		internal bool _003C_003Em__0(DigitaluniverseBMissionRewardDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001F2D")]
	private sealed class _003CGetAwardIdByProgress_003Ec__AnonStorey7
	{
		[Token(Token = "0x400C46C")]
		[FieldOffset(Offset = "0x8")]
		internal uint progress;

		[Token(Token = "0x400C46D")]
		[FieldOffset(Offset = "0xC")]
		internal int gateType;

		[Token(Token = "0x60099EF")]
		[Address(RVA = "0xFAC7B0", Offset = "0xFAC7B0", VA = "0xFAC7B0")]
		public _003CGetAwardIdByProgress_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x60099F0")]
		[Address(RVA = "0xFAC7B8", Offset = "0xFAC7B8", VA = "0xFAC7B8")]
		internal bool _003C_003Em__0(DigitaluniverseBMissionRewardDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001F2E")]
	private sealed class _003CGetAwardSortIDByProgress_003Ec__AnonStorey8
	{
		[Token(Token = "0x400C46E")]
		[FieldOffset(Offset = "0x8")]
		internal int gateType;

		[Token(Token = "0x400C46F")]
		[FieldOffset(Offset = "0xC")]
		internal uint progress;

		[Token(Token = "0x60099F1")]
		[Address(RVA = "0xFAC804", Offset = "0xFAC804", VA = "0xFAC804")]
		public _003CGetAwardSortIDByProgress_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x60099F2")]
		[Address(RVA = "0xFAC80C", Offset = "0xFAC80C", VA = "0xFAC80C")]
		internal bool _003C_003Em__0(DigitaluniverseBMissionRewardDesc x)
		{
			return default(bool);
		}

		[Token(Token = "0x60099F3")]
		[Address(RVA = "0xFAC844", Offset = "0xFAC844", VA = "0xFAC844")]
		internal bool _003C_003Em__1(DigitaluniverseBMissionRewardDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001F2F")]
	private sealed class _003CGetClothesDoorTabList_003Ec__AnonStorey9
	{
		[Token(Token = "0x400C470")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x60099F4")]
		[Address(RVA = "0xFAC87C", Offset = "0xFAC87C", VA = "0xFAC87C")]
		public _003CGetClothesDoorTabList_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x60099F5")]
		[Address(RVA = "0xFAC884", Offset = "0xFAC884", VA = "0xFAC884")]
		internal bool _003C_003Em__0(CSGetDigitaluniverseBPlayReviewRes.ClothReviewData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001F30")]
	private sealed class _003CGetThreeMissionDescListByTypeInternal_003Ec__AnonStoreyA
	{
		[Token(Token = "0x400C471")]
		[FieldOffset(Offset = "0x8")]
		internal List<DigitaluniverseBThreeDesc> threeDescList;

		[Token(Token = "0x60099F6")]
		[Address(RVA = "0xFACA50", Offset = "0xFACA50", VA = "0xFACA50")]
		public _003CGetThreeMissionDescListByTypeInternal_003Ec__AnonStoreyA()
		{
		}
	}

	[Token(Token = "0x2001F31")]
	private sealed class _003CGetThreeMissionDescListByTypeInternal_003Ec__AnonStoreyB
	{
		[Token(Token = "0x400C472")]
		[FieldOffset(Offset = "0x8")]
		internal int index;

		[Token(Token = "0x60099F7")]
		[Address(RVA = "0xFACA58", Offset = "0xFACA58", VA = "0xFACA58")]
		public _003CGetThreeMissionDescListByTypeInternal_003Ec__AnonStoreyB()
		{
		}
	}

	[Token(Token = "0x2001F32")]
	private sealed class _003CGetThreeMissionDescListByTypeInternal_003Ec__AnonStoreyC
	{
		[Token(Token = "0x400C473")]
		[FieldOffset(Offset = "0x8")]
		internal int j;

		[Token(Token = "0x400C474")]
		[FieldOffset(Offset = "0xC")]
		internal _003CGetThreeMissionDescListByTypeInternal_003Ec__AnonStoreyA _003C_003Ef__ref_002410;

		[Token(Token = "0x400C475")]
		[FieldOffset(Offset = "0x10")]
		internal _003CGetThreeMissionDescListByTypeInternal_003Ec__AnonStoreyB _003C_003Ef__ref_002411;

		[Token(Token = "0x60099F8")]
		[Address(RVA = "0xFACA60", Offset = "0xFACA60", VA = "0xFACA60")]
		public _003CGetThreeMissionDescListByTypeInternal_003Ec__AnonStoreyC()
		{
		}

		[Token(Token = "0x60099F9")]
		[Address(RVA = "0xFACA68", Offset = "0xFACA68", VA = "0xFACA68")]
		internal bool _003C_003Em__0(ClientActivityDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001F33")]
	private sealed class _003CInitCoreNodeInfo_003Ec__AnonStoreyD
	{
		[Token(Token = "0x400C476")]
		[FieldOffset(Offset = "0x8")]
		internal uint tmp;

		[Token(Token = "0x60099FA")]
		[Address(RVA = "0xFACDC8", Offset = "0xFACDC8", VA = "0xFACDC8")]
		public _003CInitCoreNodeInfo_003Ec__AnonStoreyD()
		{
		}

		[Token(Token = "0x60099FB")]
		[Address(RVA = "0xFACDD0", Offset = "0xFACDD0", VA = "0xFACDD0")]
		internal bool _003C_003Em__0(DigitaluniverseBStarCraftValueDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001F34")]
	private sealed class _003CUdpateTrackAccountDic_003Ec__AnonStoreyE
	{
		[Token(Token = "0x400C477")]
		[FieldOffset(Offset = "0x8")]
		internal CoreNode upgradeNode;

		[Token(Token = "0x400C478")]
		[FieldOffset(Offset = "0xC")]
		internal CoreNode minNode;

		[Token(Token = "0x60099FC")]
		[Address(RVA = "0xFAE438", Offset = "0xFAE438", VA = "0xFAE438")]
		public _003CUdpateTrackAccountDic_003Ec__AnonStoreyE()
		{
		}

		[Token(Token = "0x60099FD")]
		[Address(RVA = "0xFAE440", Offset = "0xFAE440", VA = "0xFAE440")]
		internal bool _003C_003Em__0(ulong x)
		{
			return default(bool);
		}

		[Token(Token = "0x60099FE")]
		[Address(RVA = "0xFAE480", Offset = "0xFAE480", VA = "0xFAE480")]
		internal bool _003C_003Em__1(ulong x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001F35")]
	private sealed class _003CRequestDigitaluniverseBProgressAward_003Ec__AnonStoreyF
	{
		[Token(Token = "0x400C479")]
		[FieldOffset(Offset = "0x8")]
		internal int gateType;

		[Token(Token = "0x400C47A")]
		[FieldOffset(Offset = "0xC")]
		internal uint progress;

		[Token(Token = "0x400C47B")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelDigitaluniverseB _0024this;

		[Token(Token = "0x60099FF")]
		[Address(RVA = "0xFAE0E0", Offset = "0xFAE0E0", VA = "0xFAE0E0")]
		public _003CRequestDigitaluniverseBProgressAward_003Ec__AnonStoreyF()
		{
		}

		[Token(Token = "0x6009A00")]
		[Address(RVA = "0xFAE0E8", Offset = "0xFAE0E8", VA = "0xFAE0E8")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2001F36")]
	private sealed class _003CProcessCacheFriendsInfo_003Ec__AnonStorey10
	{
		[Token(Token = "0x400C47C")]
		[FieldOffset(Offset = "0x8")]
		internal UIModelFriends modelFriend;

		[Token(Token = "0x400C47D")]
		[FieldOffset(Offset = "0xC")]
		internal Dictionary<ulong, DigitalUniverseBStarCraftPlayerInitInfo> initDic;

		[Token(Token = "0x400C47E")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelDigitaluniverseB _0024this;

		[Token(Token = "0x6009A01")]
		[Address(RVA = "0xFACE08", Offset = "0xFACE08", VA = "0xFACE08")]
		public _003CProcessCacheFriendsInfo_003Ec__AnonStorey10()
		{
		}

		[Token(Token = "0x6009A02")]
		[Address(RVA = "0xFACE10", Offset = "0xFACE10", VA = "0xFACE10")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2001F37")]
	private sealed class _003CUpdateDigitalUniverseBStarCraftMessage_003Ec__AnonStorey11
	{
		[Token(Token = "0x400C47F")]
		[FieldOffset(Offset = "0x8")]
		internal string messageText;

		[Token(Token = "0x400C480")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelDigitaluniverseB _0024this;

		[Token(Token = "0x6009A03")]
		[Address(RVA = "0xFAE4C0", Offset = "0xFAE4C0", VA = "0xFAE4C0")]
		public _003CUpdateDigitalUniverseBStarCraftMessage_003Ec__AnonStorey11()
		{
		}

		[Token(Token = "0x6009A04")]
		[Address(RVA = "0xFAE4C8", Offset = "0xFAE4C8", VA = "0xFAE4C8")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2001F38")]
	private sealed class _003CUpvoteDigitalUniverseBStarCraftMessage_003Ec__AnonStorey12
	{
		[Token(Token = "0x400C481")]
		[FieldOffset(Offset = "0x8")]
		internal ulong accountId;

		[Token(Token = "0x400C482")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelDigitaluniverseB _0024this;

		[Token(Token = "0x6009A05")]
		[Address(RVA = "0xFAE51C", Offset = "0xFAE51C", VA = "0xFAE51C")]
		public _003CUpvoteDigitalUniverseBStarCraftMessage_003Ec__AnonStorey12()
		{
		}

		[Token(Token = "0x6009A06")]
		[Address(RVA = "0xFAE524", Offset = "0xFAE524", VA = "0xFAE524")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2001F39")]
	private sealed class _003CRequestAssistStarMapPlayer_003Ec__AnonStorey13
	{
		[Token(Token = "0x400C483")]
		[FieldOffset(Offset = "0x8")]
		internal CSDigitalUniverseBStarCraftInfoRes.PlayerInfo playerInfo;

		[Token(Token = "0x400C484")]
		[FieldOffset(Offset = "0x10")]
		internal ulong accountId;

		[Token(Token = "0x400C485")]
		[FieldOffset(Offset = "0x18")]
		internal UIModelDigitaluniverseB _0024this;

		[Token(Token = "0x6009A07")]
		[Address(RVA = "0xFAD0D8", Offset = "0xFAD0D8", VA = "0xFAD0D8")]
		public _003CRequestAssistStarMapPlayer_003Ec__AnonStorey13()
		{
		}

		[Token(Token = "0x6009A08")]
		[Address(RVA = "0xFAD0E0", Offset = "0xFAD0E0", VA = "0xFAD0E0")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2001F3A")]
	private sealed class _003CRequestClaimStarMapTargetAward_003Ec__AnonStorey14
	{
		[Token(Token = "0x400C486")]
		[FieldOffset(Offset = "0x8")]
		internal DigitaluniverseBStarCraftTargetDesc target;

		[Token(Token = "0x400C487")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelDigitaluniverseB _0024this;

		[Token(Token = "0x6009A09")]
		[Address(RVA = "0xFADC90", Offset = "0xFADC90", VA = "0xFADC90")]
		public _003CRequestClaimStarMapTargetAward_003Ec__AnonStorey14()
		{
		}

		[Token(Token = "0x6009A0A")]
		[Address(RVA = "0xFADC98", Offset = "0xFADC98", VA = "0xFADC98")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x400C3DD")]
	[FieldOffset(Offset = "0x0")]
	public static ulong guideAccountId;

	[Token(Token = "0x400C3DE")]
	public const int ROWLINENUM = 15;

	[Token(Token = "0x400C3DF")]
	public const int COLLINENUM = 15;

	[Token(Token = "0x400C3E0")]
	[FieldOffset(Offset = "0x8")]
	public static int TrackNums;

	[Token(Token = "0x400C3E1")]
	[FieldOffset(Offset = "0xC")]
	public static int GroupNums;

	[Token(Token = "0x400C3E2")]
	public const float DELAYCALL_GAP = 0.1f;

	[Token(Token = "0x400C3E3")]
	public const int INIT_MIN_PLAYERCOUNT = 2;

	[Token(Token = "0x400C3E4")]
	public const float DELAYCALL_GUIDE_TIME = 4f;

	[Token(Token = "0x400C3E5")]
	public const float LONGPRESSTIME = 0.5f;

	[Token(Token = "0x400C3E6")]
	public const float PRESS_TOTAL_TIME = 0.7f;

	[Token(Token = "0x400C3E7")]
	public const float CLICK_PROTECT_TIME = 0.2f;

	[Token(Token = "0x400C3E8")]
	public const float TWO_PI = (float)Math.PI * 2f;

	[Token(Token = "0x400C3E9")]
	[FieldOffset(Offset = "0xC")]
	private bool m_HasAssignedSpecifcPoint;

	[Token(Token = "0x400C3EA")]
	[FieldOffset(Offset = "0xD")]
	public bool HasShownStarMapNewbieGuide;

	[Token(Token = "0x400C3EB")]
	[FieldOffset(Offset = "0xE")]
	public bool CanInitDataFirstNewbieGuide;

	[Token(Token = "0x400C3EC")]
	[FieldOffset(Offset = "0xF")]
	public bool IsTabGuide;

	[Token(Token = "0x400C3ED")]
	[FieldOffset(Offset = "0x10")]
	public bool IsPressGuide;

	[Token(Token = "0x400C3EE")]
	public const float ANIMATIONTIME = 0.5f;

	[Token(Token = "0x400C3EF")]
	[FieldOffset(Offset = "0x11")]
	private bool m_FirstLogin;

	[Token(Token = "0x400C3F0")]
	[FieldOffset(Offset = "0x14")]
	private CSDigitalUniverseBStarCraftInfoRes m_StarMapInfo;

	[Token(Token = "0x400C3F1")]
	public const int MAX_TARGET_NUM = 3;

	[Token(Token = "0x400C3F2")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<uint, int> m_StarMapAchieveTargetPlayersNumDic;

	[Token(Token = "0x400C3F3")]
	private const int DOORNUM = 5;

	[Token(Token = "0x400C3F4")]
	[FieldOffset(Offset = "0x1C")]
	private bool m_NeedShowExplodeAnim;

	[Token(Token = "0x400C3F5")]
	[FieldOffset(Offset = "0x1D")]
	private bool m_PlayMainAnim;

	[Token(Token = "0x400C3F6")]
	[FieldOffset(Offset = "0x20")]
	private List<Track> m_CacheTrackList;

	[Token(Token = "0x400C3F7")]
	[FieldOffset(Offset = "0x24")]
	private List<Track> m_TrackList;

	[Token(Token = "0x400C3F8")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<int, List<ulong>> m_TrackAccountDic;

	[Token(Token = "0x400C3F9")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<int, LinkedList<ulong>> m_GroupAccountDic;

	[Token(Token = "0x400C3FA")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<int, ulong> m_TrackMinGravityAccountDic;

	[Token(Token = "0x400C3FB")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<ulong, CoreNode> m_AccountInfoNodeDic;

	[Token(Token = "0x400C3FC")]
	[FieldOffset(Offset = "0x38")]
	private DigitalUniverseBStarMapGuide m_StarMapGuideState;

	[Token(Token = "0x400C3FD")]
	[FieldOffset(Offset = "0x3C")]
	public bool IsStarMapCorePanelOpen;

	[Token(Token = "0x400C3FE")]
	[FieldOffset(Offset = "0x40")]
	private DigitalUniverseBGuide m_GuideState;

	[Token(Token = "0x400C3FF")]
	private const string COLLECTOIN_DOOR_GUN_NAME_KEY = "T_35_FH_BATTLECAPSULE_MISSIONTITLE";

	[Token(Token = "0x400C400")]
	public const string PLAYERPRESKEY_ACTIVITYDOOR_ISLIGHTCARD = "Playerpreskey_ActivityDoor_Islightcard_{0}_{1}";

	[Token(Token = "0x400C401")]
	public const string PlayerPresKey_DoorTabTips = "DigitaluniverseB_Tab_TipsShow_{0}_{1}_{2}";

	[Token(Token = "0x400C402")]
	private const int COLLECTIONTABCOUNT = 7;

	[Token(Token = "0x400C403")]
	private const int CLOTHTABCOUNT = 5;

	[Token(Token = "0x400C404")]
	[FieldOffset(Offset = "0x44")]
	private List<DigitaluniverseBPostcardDesc> m_ListPostCardDesc;

	[Token(Token = "0x400C405")]
	[FieldOffset(Offset = "0x48")]
	private readonly Dictionary<int, List<DigitaluniverseBThreeDesc>> m_DicThreeGateMissionDesc;

	[Token(Token = "0x400C406")]
	[FieldOffset(Offset = "0x4C")]
	private readonly Dictionary<string, List<ClientActivityDesc>> m_DicGateIndexToActivityDesc;

	[Token(Token = "0x400C407")]
	[FieldOffset(Offset = "0x50")]
	private List<CSGetDigitaluniverseBPlayReviewRes.EventReviewData> m_EventReviewDataLIst;

	[Token(Token = "0x400C408")]
	[FieldOffset(Offset = "0x54")]
	private List<CSGetDigitaluniverseBPlayReviewRes.CollectionReviewData> m_CollectionReviewDataLIst;

	[Token(Token = "0x400C409")]
	[FieldOffset(Offset = "0x58")]
	private readonly List<string> ACTIVITY_DOOR_TAB_SPRITE_LIST;

	[Token(Token = "0x400C40A")]
	[FieldOffset(Offset = "0x5C")]
	public readonly List<string> ACTIVITY_DOOR_CARD_SPRITE_LIST;

	[Token(Token = "0x400C40B")]
	[FieldOffset(Offset = "0x60")]
	public readonly List<string> COLLECTION_DOOR_TAB_GUN_SPRITE_LIST;

	[Token(Token = "0x400C40C")]
	[FieldOffset(Offset = "0x64")]
	public readonly List<string> COLLECTION_DOOR_TAB_GUN_NAME_LIST;

	[Token(Token = "0x400C40D")]
	[FieldOffset(Offset = "0x68")]
	public readonly List<int> COLLECTION_DETAIL_GUN_ID;

	[Token(Token = "0x400C40E")]
	[FieldOffset(Offset = "0x6C")]
	public readonly List<int> COLLECTION_HOLD_GUN_ID;

	[Token(Token = "0x400C40F")]
	[FieldOffset(Offset = "0x70")]
	public readonly List<string> CLOTH_DOOR_TAB_BGSPRITE_NAME_LIST;

	[Token(Token = "0x400C410")]
	[FieldOffset(Offset = "0x74")]
	public readonly List<string> CLOTH_DOOR_SHARE_LABEL_ICON_LIST;

	[Token(Token = "0x400C411")]
	[FieldOffset(Offset = "0x78")]
	public readonly List<string> CLOTH_DOOR_TAB_TITLE_NAME_LIST;

	[Token(Token = "0x400C412")]
	[FieldOffset(Offset = "0x7C")]
	private readonly List<uint> ACTIVITY_EVENTID_SORTLIST;

	[Token(Token = "0x400C413")]
	[FieldOffset(Offset = "0x80")]
	private readonly List<uint> COLLECTION_GUNID_SORTLIST;

	[Token(Token = "0x400C414")]
	[FieldOffset(Offset = "0x84")]
	public List<ResourceID> STAR_MAP_TIPS_ICON_LIST;

	[Token(Token = "0x400C415")]
	public const uint PropID_GetDigiSetting = 2u;

	[Token(Token = "0x400C416")]
	public const uint PropID_GetDigiInfo = 4u;

	[Token(Token = "0x400C417")]
	public const uint PropID_ReadStory = 8u;

	[Token(Token = "0x400C418")]
	public const uint PropID_ClaimAward = 16u;

	[Token(Token = "0x400C419")]
	public const uint PropID_RefreshMissionView = 32u;

	[Token(Token = "0x400C41A")]
	public const uint PropID_GetPlayReview = 256u;

	[Token(Token = "0x400C41B")]
	public const uint PropID_PlayerTrackUp = 512u;

	[Token(Token = "0x400C41C")]
	public const uint PropID_PlayerTrackExchange = 1024u;

	[Token(Token = "0x400C41D")]
	public const uint PropID_GetStarMapSelfInfo = 2048u;

	[Token(Token = "0x400C41E")]
	public const uint PropID_StarMapAssistPlayer = 4096u;

	[Token(Token = "0x400C41F")]
	public const uint PropID_StarMapClaimAward = 8192u;

	[Token(Token = "0x400C420")]
	public const uint PropID_StarMapTargetPlayerInfo = 16384u;

	[Token(Token = "0x400C421")]
	public const uint PropID_StarMapTokenChange = 32768u;

	[Token(Token = "0x400C422")]
	public const uint PropID_PlayerNoneInit = 131072u;

	[Token(Token = "0x400C423")]
	public const uint PropID_PlayerAlreadyInit = 262144u;

	[Token(Token = "0x400C424")]
	public const uint PropID_StarMapRefreshAssistTimeStamp = 524288u;

	[Token(Token = "0x400C425")]
	public const uint PropID_StarMapFriendsInit = 1048576u;

	[Token(Token = "0x400C426")]
	public const uint PropID_ShareAward = 65536u;

	[Token(Token = "0x400C427")]
	public const uint CameraCheckType_Main = 2u;

	[Token(Token = "0x400C428")]
	public const uint CameraCheckType_StarSea = 4u;

	[Token(Token = "0x400C429")]
	[FieldOffset(Offset = "0x88")]
	private uint CameraCheckType;

	[Token(Token = "0x400C42A")]
	[FieldOffset(Offset = "0x8C")]
	public bool ShowingGuide;

	[Token(Token = "0x400C42B")]
	[FieldOffset(Offset = "0x90")]
	private CSGetDigitaluniverseSettingsBRes m_DigitaluniverseBSetting;

	[Token(Token = "0x400C42C")]
	[FieldOffset(Offset = "0x94")]
	private CSGetDigitaluniverseBInfoRes m_DigitaluniverseBInfo;

	[Token(Token = "0x400C42D")]
	[FieldOffset(Offset = "0x98")]
	private CSGetDigitaluniverseBPlayReviewRes m_DigitaluniverseBPlayReview;

	[Token(Token = "0x400C42E")]
	[FieldOffset(Offset = "0x9C")]
	private Dictionary<uint, string> m_DicRoleDoorPlayerName;

	[Token(Token = "0x400C42F")]
	[FieldOffset(Offset = "0xA0")]
	private List<uint> m_ListDailyMissionId;

	[Token(Token = "0x400C430")]
	[FieldOffset(Offset = "0xA4")]
	private List<uint> m_ListFinishMissionId;

	[Token(Token = "0x400C431")]
	[FieldOffset(Offset = "0xA8")]
	private Dictionary<uint, List<DigitaluniverseBMapMissionDesc>> m_MapDoorMissions;

	[Token(Token = "0x400C432")]
	[FieldOffset(Offset = "0xAC")]
	private readonly Dictionary<int, List<uint>> m_DicGateTypeToClaimedAwardProgress;

	[Token(Token = "0x400C433")]
	[FieldOffset(Offset = "0xB0")]
	private uint m_MaxGroupId;

	[Token(Token = "0x400C434")]
	[FieldOffset(Offset = "0xB4")]
	private uint m_CountDownMissionOnTimeId;

	[Token(Token = "0x400C435")]
	[FieldOffset(Offset = "0xB8")]
	private uint m_CountDownMissionOutTimeId;

	[Token(Token = "0x400C436")]
	[FieldOffset(Offset = "0xBC")]
	private uint m_MissionCharacterId;

	[Token(Token = "0x400C437")]
	[FieldOffset(Offset = "0xC0")]
	private MissionStateType m_LastMissionStateType;

	[Token(Token = "0x400C438")]
	[FieldOffset(Offset = "0xC4")]
	private bool m_IsRotating;

	[Token(Token = "0x400C439")]
	[FieldOffset(Offset = "0xC5")]
	private bool m_CanRotate;

	[Token(Token = "0x400C43A")]
	[FieldOffset(Offset = "0xC6")]
	private bool m_PlayStoreAnim;

	[Token(Token = "0x400C43B")]
	[FieldOffset(Offset = "0xC7")]
	private bool m_PlayStarMapAnim;

	[Token(Token = "0x400C43C")]
	[FieldOffset(Offset = "0x10")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400C43D")]
	[FieldOffset(Offset = "0x14")]
	private static Comparison<DigitaluniverseBMissionRewardDesc> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400C43E")]
	[FieldOffset(Offset = "0x18")]
	private static Predicate<DigitaluniverseBCharMissionDesc> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x400C43F")]
	[FieldOffset(Offset = "0x1C")]
	private static Predicate<DigitaluniverseBCharMissionDesc> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x400C440")]
	[FieldOffset(Offset = "0x20")]
	private static Predicate<DigitaluniverseBCharMissionDesc> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x400C441")]
	[FieldOffset(Offset = "0x24")]
	private static Comparison<DigitaluniverseBThreeDesc> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x400C442")]
	[FieldOffset(Offset = "0x28")]
	private static Comparison<DigitaluniverseBPostcardDesc> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x400C443")]
	[FieldOffset(Offset = "0x2C")]
	private static Comparison<DigitaluniverseBStarCraftTargetDesc> _003C_003Ef__am_0024cache7;

	[Token(Token = "0x400C444")]
	[FieldOffset(Offset = "0x30")]
	private static Comparison<CSDigitalUniverseBStarCraftInfoRes.PlayerInfo> _003C_003Ef__am_0024cache8;

	[Token(Token = "0x400C445")]
	[FieldOffset(Offset = "0x34")]
	private static Comparison<CSDigitalUniverseBStarCraftInfoRes.PlayerInfo> _003C_003Ef__am_0024cache9;

	[Token(Token = "0x17000F81")]
	public bool showExplodeAnim
	{
		[Token(Token = "0x6009937")]
		[Address(RVA = "0x15E1858", Offset = "0x15E1858", VA = "0x15E1858")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009938")]
		[Address(RVA = "0x15E18B0", Offset = "0x15E18B0", VA = "0x15E18B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000F82")]
	public bool PlayMainAnim
	{
		[Token(Token = "0x6009939")]
		[Address(RVA = "0x15E1910", Offset = "0x15E1910", VA = "0x15E1910")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600993A")]
		[Address(RVA = "0x15E1968", Offset = "0x15E1968", VA = "0x15E1968")]
		set
		{
		}
	}

	[Token(Token = "0x17000F83")]
	public Dictionary<int, List<ulong>> TrackInfoDic
	{
		[Token(Token = "0x600993B")]
		[Address(RVA = "0x15E19C8", Offset = "0x15E19C8", VA = "0x15E19C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F84")]
	public Dictionary<int, LinkedList<ulong>> GroupAccountDic
	{
		[Token(Token = "0x600993C")]
		[Address(RVA = "0x15E1AA0", Offset = "0x15E1AA0", VA = "0x15E1AA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F85")]
	public Dictionary<ulong, CoreNode> AccountInfoNodeDic
	{
		[Token(Token = "0x600993D")]
		[Address(RVA = "0x15E1B78", Offset = "0x15E1B78", VA = "0x15E1B78")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F86")]
	public DigitalUniverseBStarMapGuide StarMapGuideState
	{
		[Token(Token = "0x600993E")]
		[Address(RVA = "0x15E1C50", Offset = "0x15E1C50", VA = "0x15E1C50")]
		get
		{
			return default(DigitalUniverseBStarMapGuide);
		}
		[Token(Token = "0x600993F")]
		[Address(RVA = "0x15E1CA8", Offset = "0x15E1CA8", VA = "0x15E1CA8")]
		set
		{
		}
	}

	[Token(Token = "0x17000F87")]
	public DigitalUniverseBGuide GuideState
	{
		[Token(Token = "0x6009940")]
		[Address(RVA = "0x15E1D08", Offset = "0x15E1D08", VA = "0x15E1D08")]
		get
		{
			return default(DigitalUniverseBGuide);
		}
		[Token(Token = "0x6009941")]
		[Address(RVA = "0x15E1D60", Offset = "0x15E1D60", VA = "0x15E1D60")]
		set
		{
		}
	}

	[Token(Token = "0x17000F88")]
	public uint MaxGrouPId
	{
		[Token(Token = "0x6009942")]
		[Address(RVA = "0x15E1DC0", Offset = "0x15E1DC0", VA = "0x15E1DC0")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17000F89")]
	public uint CountDownMissionId
	{
		[Token(Token = "0x6009943")]
		[Address(RVA = "0x15E1E18", Offset = "0x15E1E18", VA = "0x15E1E18")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17000F8A")]
	public uint CountDownMissionOutTimeId
	{
		[Token(Token = "0x6009944")]
		[Address(RVA = "0x15E1E70", Offset = "0x15E1E70", VA = "0x15E1E70")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17000F8B")]
	public uint MissionCharacterId
	{
		[Token(Token = "0x6009945")]
		[Address(RVA = "0x15E1EC8", Offset = "0x15E1EC8", VA = "0x15E1EC8")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17000F8C")]
	public MissionStateType LastMissionStateType
	{
		[Token(Token = "0x6009946")]
		[Address(RVA = "0x15E1F20", Offset = "0x15E1F20", VA = "0x15E1F20")]
		get
		{
			return default(MissionStateType);
		}
		[Token(Token = "0x6009947")]
		[Address(RVA = "0x15E1F78", Offset = "0x15E1F78", VA = "0x15E1F78")]
		set
		{
		}
	}

	[Token(Token = "0x17000F8D")]
	public bool IsRotating
	{
		[Token(Token = "0x6009948")]
		[Address(RVA = "0x15E1FD8", Offset = "0x15E1FD8", VA = "0x15E1FD8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009949")]
		[Address(RVA = "0x15E2030", Offset = "0x15E2030", VA = "0x15E2030")]
		set
		{
		}
	}

	[Token(Token = "0x17000F8E")]
	public bool CanRotate
	{
		[Token(Token = "0x600994A")]
		[Address(RVA = "0x15E2090", Offset = "0x15E2090", VA = "0x15E2090")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600994B")]
		[Address(RVA = "0x15E20E8", Offset = "0x15E20E8", VA = "0x15E20E8")]
		set
		{
		}
	}

	[Token(Token = "0x17000F8F")]
	public bool PlayStoreAnim
	{
		[Token(Token = "0x600994C")]
		[Address(RVA = "0x15E2148", Offset = "0x15E2148", VA = "0x15E2148")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600994D")]
		[Address(RVA = "0x15E21A0", Offset = "0x15E21A0", VA = "0x15E21A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000F90")]
	public bool PlayStarMapAnim
	{
		[Token(Token = "0x600994E")]
		[Address(RVA = "0x15E2200", Offset = "0x15E2200", VA = "0x15E2200")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600994F")]
		[Address(RVA = "0x15E2258", Offset = "0x15E2258", VA = "0x15E2258")]
		set
		{
		}
	}

	[Token(Token = "0x6009936")]
	[Address(RVA = "0x15DFD44", Offset = "0x15DFD44", VA = "0x15DFD44")]
	public UIModelDigitaluniverseB()
	{
	}

	[Token(Token = "0x6009950")]
	[Address(RVA = "0x15E22B8", Offset = "0x15E22B8", VA = "0x15E22B8", Slot = "15")]
	public UIBigEventLobbyEnterWndControler GetBigEventLobbyEnterWnd()
	{
		return null;
	}

	[Token(Token = "0x6009951")]
	[Address(RVA = "0x15E23C8", Offset = "0x15E23C8", VA = "0x15E23C8", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6009952")]
	[Address(RVA = "0x15E2774", Offset = "0x15E2774", VA = "0x15E2774", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6009953")]
	[Address(RVA = "0x15E27CC", Offset = "0x15E27CC", VA = "0x15E27CC", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x6009954")]
	[Address(RVA = "0x15E29D8", Offset = "0x15E29D8", VA = "0x15E29D8", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x6009955")]
	[Address(RVA = "0x15E2BD8", Offset = "0x15E2BD8", VA = "0x15E2BD8")]
	public Camera GetCamera()
	{
		return null;
	}

	[Token(Token = "0x6009956")]
	[Address(RVA = "0x15E2D0C", Offset = "0x15E2D0C", VA = "0x15E2D0C")]
	public void CloseCamera()
	{
	}

	[Token(Token = "0x6009957")]
	[Address(RVA = "0x15E2E44", Offset = "0x15E2E44", VA = "0x15E2E44")]
	public void DealFlag(uint flag, bool addFlag)
	{
	}

	[Token(Token = "0x6009958")]
	[Address(RVA = "0x15E2EE8", Offset = "0x15E2EE8", VA = "0x15E2EE8")]
	public string GetPlayerNameById(uint id)
	{
		return null;
	}

	[Token(Token = "0x6009959")]
	[Address(RVA = "0x15E3014", Offset = "0x15E3014", VA = "0x15E3014")]
	public CSGetDigitaluniverseSettingsBRes GetMainSetting()
	{
		return null;
	}

	[Token(Token = "0x600995A")]
	[Address(RVA = "0x15E306C", Offset = "0x15E306C", VA = "0x15E306C")]
	public bool HasFinishMissionInCha()
	{
		return default(bool);
	}

	[Token(Token = "0x600995B")]
	[Address(RVA = "0x15E3260", Offset = "0x15E3260", VA = "0x15E3260")]
	public bool GetDoorHasOpenByGateType(uint gateType)
	{
		return default(bool);
	}

	[Token(Token = "0x600995C")]
	[Address(RVA = "0x15E3468", Offset = "0x15E3468", VA = "0x15E3468")]
	public void IncreaseProgress()
	{
	}

	[Token(Token = "0x600995D")]
	[Address(RVA = "0x15E37D0", Offset = "0x15E37D0", VA = "0x15E37D0")]
	public bool IsExchangeStoreLocked(uint storeId)
	{
		return default(bool);
	}

	[Token(Token = "0x600995E")]
	[Address(RVA = "0x15E39C0", Offset = "0x15E39C0", VA = "0x15E39C0")]
	public void ClaimAwards(AwardData awards)
	{
	}

	[Token(Token = "0x600995F")]
	[Address(RVA = "0x15E3D68", Offset = "0x15E3D68", VA = "0x15E3D68")]
	public uint GetStoryGroupCountByGroupId(uint groupId)
	{
		return default(uint);
	}

	[Token(Token = "0x6009960")]
	[Address(RVA = "0x15E3EDC", Offset = "0x15E3EDC", VA = "0x15E3EDC")]
	public uint GetProgress(int gateType = 0)
	{
		return default(uint);
	}

	[Token(Token = "0x6009961")]
	[Address(RVA = "0x15E3FA4", Offset = "0x15E3FA4", VA = "0x15E3FA4")]
	public bool IsSignInRewardClaimable()
	{
		return default(bool);
	}

	[Token(Token = "0x6009962")]
	[Address(RVA = "0x15E418C", Offset = "0x15E418C", VA = "0x15E418C")]
	public void UpdateProgress(int index, int gateType)
	{
	}

	[Token(Token = "0x6009963")]
	[Address(RVA = "0x15E44AC", Offset = "0x15E44AC", VA = "0x15E44AC")]
	public bool HasGetBigAward(uint gateId)
	{
		return default(bool);
	}

	[Token(Token = "0x6009964")]
	[Address(RVA = "0x15E4980", Offset = "0x15E4980", VA = "0x15E4980")]
	public DigitaluniverseBStoreRecommendDesc GetDisplayStoreDesc()
	{
		return null;
	}

	[Token(Token = "0x6009965")]
	[Address(RVA = "0x15E4CBC", Offset = "0x15E4CBC", VA = "0x15E4CBC")]
	public uint GetProgressValueByContent(uint missionContent)
	{
		return default(uint);
	}

	[Token(Token = "0x6009966")]
	[Address(RVA = "0x15E4E10", Offset = "0x15E4E10", VA = "0x15E4E10")]
	public bool HasAwardCanClaim(uint progress, int gateType = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x6009967")]
	[Address(RVA = "0x15E4758", Offset = "0x15E4758", VA = "0x15E4758")]
	public bool HasClaimAwardByProgress(uint progress, int gateType = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x6009968")]
	[Address(RVA = "0x15E5038", Offset = "0x15E5038", VA = "0x15E5038")]
	public CSGetDigitaluniverseBInfoRes GetDigitaluniverseBInfo()
	{
		return null;
	}

	[Token(Token = "0x6009969")]
	[Address(RVA = "0x15E5090", Offset = "0x15E5090", VA = "0x15E5090")]
	public DigitaluniverseBCharMissionDesc GetMissionDescById(uint id)
	{
		return null;
	}

	[Token(Token = "0x600996A")]
	[Address(RVA = "0x15E51EC", Offset = "0x15E51EC", VA = "0x15E51EC")]
	public uint GetStoryId()
	{
		return default(uint);
	}

	[Token(Token = "0x600996B")]
	[Address(RVA = "0x15E5374", Offset = "0x15E5374", VA = "0x15E5374")]
	public DigitaluniverseBCharStoryDesc GetStoryDescByStoryIdAndGroupId(uint storyId, uint groupId)
	{
		return null;
	}

	[Token(Token = "0x600996C")]
	[Address(RVA = "0x15E556C", Offset = "0x15E556C", VA = "0x15E556C")]
	public DigitaluniverseBMissionRewardDesc GetMissionRewardDescById(uint id, int gateType)
	{
		return null;
	}

	[Token(Token = "0x600996D")]
	[Address(RVA = "0x15E56F0", Offset = "0x15E56F0", VA = "0x15E56F0")]
	public bool GetAwardIdByProgress(uint progress, int gateType, out uint awardID)
	{
		return default(bool);
	}

	[Token(Token = "0x600996E")]
	[Address(RVA = "0x15E5890", Offset = "0x15E5890", VA = "0x15E5890")]
	public bool GetAwardSortIDByProgress(uint progress, int gateType, out int sortID)
	{
		return default(bool);
	}

	[Token(Token = "0x600996F")]
	[Address(RVA = "0x15E5AC0", Offset = "0x15E5AC0", VA = "0x15E5AC0")]
	public MissionStateType GetMissionState()
	{
		return default(MissionStateType);
	}

	[Token(Token = "0x6009970")]
	[Address(RVA = "0x15E5B50", Offset = "0x15E5B50", VA = "0x15E5B50")]
	public List<uint> GetListDailyMissionId()
	{
		return null;
	}

	[Token(Token = "0x6009971")]
	[Address(RVA = "0x15E5BA8", Offset = "0x15E5BA8", VA = "0x15E5BA8")]
	public Dictionary<uint, List<DigitaluniverseBMapMissionDesc>> GetMapDoorMissions()
	{
		return null;
	}

	[Token(Token = "0x6009972")]
	[Address(RVA = "0x15E5C00", Offset = "0x15E5C00", VA = "0x15E5C00", Slot = "14")]
	public void OnProcessEventOpenInfo()
	{
	}

	[Token(Token = "0x6009973")]
	[Address(RVA = "0x15E62C4", Offset = "0x15E62C4", VA = "0x15E62C4")]
	public bool ConcertModeHasOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6009974")]
	[Address(RVA = "0x15E63DC", Offset = "0x15E63DC", VA = "0x15E63DC")]
	public bool IsOpenShowEnable()
	{
		return default(bool);
	}

	[Token(Token = "0x6009975")]
	[Address(RVA = "0x15E6460", Offset = "0x15E6460", VA = "0x15E6460")]
	public List<DigitaluniverseBMissionRewardDesc> GetMissionAwardsByGateType(ELimitedEvent.DigitaluniverseBGateType type)
	{
		return null;
	}

	[Token(Token = "0x6009976")]
	[Address(RVA = "0x15E42B4", Offset = "0x15E42B4", VA = "0x15E42B4")]
	public uint GetProgreeByGateTypeAndIndex(int type, int index)
	{
		return default(uint);
	}

	[Token(Token = "0x6009977")]
	[Address(RVA = "0x15E6848", Offset = "0x15E6848", VA = "0x15E6848")]
	public List<DigitaluniverseBPostcardDesc> GetPostCardDescList()
	{
		return null;
	}

	[Token(Token = "0x6009978")]
	[Address(RVA = "0x15E68A0", Offset = "0x15E68A0", VA = "0x15E68A0")]
	public List<DoorTabData> GetActivityDoorTabList()
	{
		return null;
	}

	[Token(Token = "0x6009979")]
	[Address(RVA = "0x15E6B38", Offset = "0x15E6B38", VA = "0x15E6B38")]
	public List<DoorTabData> GetCollectionDoorTabList()
	{
		return null;
	}

	[Token(Token = "0x600997A")]
	[Address(RVA = "0x15E6EBC", Offset = "0x15E6EBC", VA = "0x15E6EBC")]
	public List<DoorTabData> GetClothesDoorTabList()
	{
		return null;
	}

	[Token(Token = "0x600997B")]
	[Address(RVA = "0x15E74FC", Offset = "0x15E74FC", VA = "0x15E74FC")]
	public int GetLatestDoorTabIndex(int type)
	{
		return default(int);
	}

	[Token(Token = "0x600997C")]
	[Address(RVA = "0x15E7880", Offset = "0x15E7880", VA = "0x15E7880")]
	public DoorPageState GetDoorPageState(int type, int index)
	{
		return default(DoorPageState);
	}

	[Token(Token = "0x600997D")]
	[Address(RVA = "0x15E831C", Offset = "0x15E831C", VA = "0x15E831C")]
	public bool GetDoorMissionUnlockTimeByIndex(int type, int index, out string date)
	{
		return default(bool);
	}

	[Token(Token = "0x600997E")]
	[Address(RVA = "0x15E869C", Offset = "0x15E869C", VA = "0x15E869C")]
	public List<CSGetDigitaluniverseBPlayReviewRes.EventReviewData> GetActivityStaticData()
	{
		return null;
	}

	[Token(Token = "0x600997F")]
	[Address(RVA = "0x15E8B48", Offset = "0x15E8B48", VA = "0x15E8B48")]
	public List<CSGetDigitaluniverseBPlayReviewRes.CollectionReviewData> GetCollectionStaticData()
	{
		return null;
	}

	[Token(Token = "0x6009980")]
	[Address(RVA = "0x15E7408", Offset = "0x15E7408", VA = "0x15E7408")]
	public List<CSGetDigitaluniverseBPlayReviewRes.ClothReviewData> GetClothStaticData()
	{
		return null;
	}

	[Token(Token = "0x6009981")]
	[Address(RVA = "0x15E8FF4", Offset = "0x15E8FF4", VA = "0x15E8FF4")]
	public bool GetThreeMissionDescListByIndex(int type, int index, out List<ClientActivityDesc> threeMissionList)
	{
		return default(bool);
	}

	[Token(Token = "0x6009982")]
	[Address(RVA = "0x15E92DC", Offset = "0x15E92DC", VA = "0x15E92DC")]
	public bool CheckIsThreeMissionAllInOneState(int type, int index, EActivity.State activityState)
	{
		return default(bool);
	}

	[Token(Token = "0x6009983")]
	[Address(RVA = "0x15E936C", Offset = "0x15E936C", VA = "0x15E936C")]
	public uint GetClaimedBigAwardNum()
	{
		return default(uint);
	}

	[Token(Token = "0x6009984")]
	[Address(RVA = "0x15E93EC", Offset = "0x15E93EC", VA = "0x15E93EC")]
	public bool ShowRedPointByGateType(int type)
	{
		return default(bool);
	}

	[Token(Token = "0x6009985")]
	[Address(RVA = "0x15E96E8", Offset = "0x15E96E8", VA = "0x15E96E8")]
	private bool HasRedPointInMap(int type)
	{
		return default(bool);
	}

	[Token(Token = "0x6009986")]
	[Address(RVA = "0x15E99DC", Offset = "0x15E99DC", VA = "0x15E99DC")]
	private bool HasRedPointInCharacter(int type)
	{
		return default(bool);
	}

	[Token(Token = "0x6009987")]
	[Address(RVA = "0x15E9D5C", Offset = "0x15E9D5C", VA = "0x15E9D5C")]
	private bool HasRedPointInCore()
	{
		return default(bool);
	}

	[Token(Token = "0x6009988")]
	[Address(RVA = "0x15E3410", Offset = "0x15E3410", VA = "0x15E3410")]
	private ELimitedEvent.EventID GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x6009989")]
	[Address(RVA = "0x15EA798", Offset = "0x15EA798", VA = "0x15EA798")]
	private bool HasNewUnLockMap()
	{
		return default(bool);
	}

	[Token(Token = "0x600998A")]
	[Address(RVA = "0x15EA2FC", Offset = "0x15EA2FC", VA = "0x15EA2FC")]
	private bool HasClaimMissionRewardInMap()
	{
		return default(bool);
	}

	[Token(Token = "0x600998B")]
	[Address(RVA = "0x15EAB98", Offset = "0x15EAB98", VA = "0x15EAB98")]
	private bool HasClaimMissionRewardInCharacter(uint missionID)
	{
		return default(bool);
	}

	[Token(Token = "0x600998C")]
	[Address(RVA = "0x15EACE0", Offset = "0x15EACE0", VA = "0x15EACE0")]
	public bool HasFirstTabFirstMissoinDone(int type)
	{
		return default(bool);
	}

	[Token(Token = "0x600998D")]
	[Address(RVA = "0x15EAF84", Offset = "0x15EAF84", VA = "0x15EAF84")]
	public int GetDoorPageLightendNum(int type)
	{
		return default(int);
	}

	[Token(Token = "0x600998E")]
	[Address(RVA = "0x15EB2DC", Offset = "0x15EB2DC", VA = "0x15EB2DC")]
	public bool CheckCanMissionClaim(int type, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600998F")]
	[Address(RVA = "0x15EB570", Offset = "0x15EB570", VA = "0x15EB570")]
	public bool IsFirstPageFirstMissionAwardCanClaim(int type)
	{
		return default(bool);
	}

	[Token(Token = "0x6009990")]
	[Address(RVA = "0x15E801C", Offset = "0x15E801C", VA = "0x15E801C")]
	private bool CheckIsThreeMissionAllInOneStateInternal(int type, int index, EActivity.State activityState)
	{
		return default(bool);
	}

	[Token(Token = "0x6009991")]
	[Address(RVA = "0x15EB850", Offset = "0x15EB850", VA = "0x15EB850")]
	private EActivity.SubType GetSubActivityTypeByGateType(int type)
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x6009992")]
	[Address(RVA = "0x15EB8D8", Offset = "0x15EB8D8", VA = "0x15EB8D8")]
	private void SetActicityDesc()
	{
	}

	[Token(Token = "0x6009993")]
	[Address(RVA = "0x15EB954", Offset = "0x15EB954", VA = "0x15EB954")]
	private void GetThreeMissionDescListByTypeInternal(int type)
	{
	}

	[Token(Token = "0x6009994")]
	[Address(RVA = "0x15EC22C", Offset = "0x15EC22C", VA = "0x15EC22C")]
	public List<DigitaluniverseBStarCraftValueDesc> GetStarMapCraftValueDesc()
	{
		return null;
	}

	[Token(Token = "0x6009995")]
	[Address(RVA = "0x15EC298", Offset = "0x15EC298", VA = "0x15EC298")]
	public DigitaluniverseBStarCraftConfigDesc GetStarMapConfigDesc()
	{
		return null;
	}

	[Token(Token = "0x6009996")]
	[Address(RVA = "0x15EC304", Offset = "0x15EC304", VA = "0x15EC304")]
	public List<DigitaluniverseBStarCraftTargetDesc> GetStarMapTargetDesc()
	{
		return null;
	}

	[Token(Token = "0x6009997")]
	[Address(RVA = "0x15EC370", Offset = "0x15EC370", VA = "0x15EC370")]
	public List<DigitaluniverseBStarCraftCdFreshDesc> GetStarMapCdRreshDesc()
	{
		return null;
	}

	[Token(Token = "0x6009998")]
	[Address(RVA = "0x15EC3DC", Offset = "0x15EC3DC", VA = "0x15EC3DC")]
	public CSDigitalUniverseBStarCraftInfoRes GetStarMapInfo()
	{
		return null;
	}

	[Token(Token = "0x6009999")]
	[Address(RVA = "0x15EC434", Offset = "0x15EC434", VA = "0x15EC434")]
	public bool IsPlayerAssisted(CSDigitalUniverseBStarCraftInfoRes.PlayerInfo playerInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x600999A")]
	[Address(RVA = "0x15EC71C", Offset = "0x15EC71C", VA = "0x15EC71C")]
	private void SortAssistHistory()
	{
	}

	[Token(Token = "0x600999B")]
	[Address(RVA = "0x15EC550", Offset = "0x15EC550", VA = "0x15EC550")]
	public uint GetLightTimeByGravityValue(uint gravityValue)
	{
		return default(uint);
	}

	[Token(Token = "0x600999C")]
	[Address(RVA = "0x15EC838", Offset = "0x15EC838", VA = "0x15EC838")]
	public bool IsPlayerVoted(ulong accountId)
	{
		return default(bool);
	}

	[Token(Token = "0x600999D")]
	[Address(RVA = "0x15ECA08", Offset = "0x15ECA08", VA = "0x15ECA08")]
	public ulong GetPlayerAccountCanLightLeftTime(ulong accountId)
	{
		return default(ulong);
	}

	[Token(Token = "0x600999E")]
	[Address(RVA = "0x15ECBC0", Offset = "0x15ECBC0", VA = "0x15ECBC0")]
	public bool IsPlayerAccountInLightenCD(ulong accountId)
	{
		return default(bool);
	}

	[Token(Token = "0x600999F")]
	[Address(RVA = "0x15ECD80", Offset = "0x15ECD80", VA = "0x15ECD80")]
	public bool IsOutAssitTimesLimit()
	{
		return default(bool);
	}

	[Token(Token = "0x60099A0")]
	[Address(RVA = "0x15ECDFC", Offset = "0x15ECDFC", VA = "0x15ECDFC")]
	public CSDigitalUniverseBStarCraftInfoRes.PlayerInfo GetStarMapPlayerInfoById(ulong accountId)
	{
		return null;
	}

	[Token(Token = "0x60099A1")]
	[Address(RVA = "0x15ECF10", Offset = "0x15ECF10", VA = "0x15ECF10")]
	public void RecoverAssistTime(uint deltaNum)
	{
	}

	[Token(Token = "0x60099A2")]
	[Address(RVA = "0x15ECFD4", Offset = "0x15ECFD4", VA = "0x15ECFD4")]
	private void CorrectAssistTime()
	{
	}

	[Token(Token = "0x60099A3")]
	[Address(RVA = "0x15ED15C", Offset = "0x15ED15C", VA = "0x15ED15C")]
	private void UpdateStarMapAchieveTargetPlayersNumDic()
	{
	}

	[Token(Token = "0x60099A4")]
	[Address(RVA = "0x15ED59C", Offset = "0x15ED59C", VA = "0x15ED59C")]
	public int GetStarMapAchieveTargetPlayersNum(uint targetId)
	{
		return default(int);
	}

	[Token(Token = "0x60099A5")]
	[Address(RVA = "0x15ED680", Offset = "0x15ED680", VA = "0x15ED680")]
	private void ResetPointsToOriginOnAllTracks()
	{
	}

	[Token(Token = "0x60099A6")]
	[Address(RVA = "0x15ED898", Offset = "0x15ED898", VA = "0x15ED898")]
	private void GeneratePointsCoordinatesOnAllTracks()
	{
	}

	[Token(Token = "0x60099A7")]
	[Address(RVA = "0x15EE480", Offset = "0x15EE480", VA = "0x15EE480")]
	public CoreNode GetCoreNodeInfoByAccountId(ulong accountId)
	{
		return null;
	}

	[Token(Token = "0x60099A8")]
	[Address(RVA = "0x15EE58C", Offset = "0x15EE58C", VA = "0x15EE58C")]
	private void InitStarMapCoresInfo(bool isFirstEnter = false)
	{
	}

	[Token(Token = "0x60099A9")]
	[Address(RVA = "0x15EF0EC", Offset = "0x15EF0EC", VA = "0x15EF0EC")]
	private bool InitCoreNodeInfo(ref CoreNode node, CSDigitalUniverseBStarCraftInfoRes.PlayerInfo playerInfo, List<DigitaluniverseBStarCraftValueDesc> listDesc, bool isFirstEnter = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60099AA")]
	[Address(RVA = "0x15EF7A0", Offset = "0x15EF7A0", VA = "0x15EF7A0")]
	private void CreateGroupLinkListClockWise(LinkedList<ulong> accountLinkList, CoreNode node)
	{
	}

	[Token(Token = "0x60099AB")]
	[Address(RVA = "0x15EFADC", Offset = "0x15EFADC", VA = "0x15EFADC")]
	public ulong[] GetNodeNeighborAccountIdForLine(ulong accountId)
	{
		return null;
	}

	[Token(Token = "0x60099AC")]
	[Address(RVA = "0x15EFDC8", Offset = "0x15EFDC8", VA = "0x15EFDC8")]
	public ulong GetNodePreNeighborAccountIdForLine(ulong accountId)
	{
		return default(ulong);
	}

	[Token(Token = "0x60099AD")]
	[Address(RVA = "0x15EFFB4", Offset = "0x15EFFB4", VA = "0x15EFFB4")]
	public ulong GetNodeNextNeighborAccountIdForLine(ulong accountId)
	{
		return default(ulong);
	}

	[Token(Token = "0x60099AE")]
	[Address(RVA = "0x15F01A0", Offset = "0x15F01A0", VA = "0x15F01A0")]
	private void ExchangeCoreNodeData(ref CoreNode minNode, ref CoreNode upgradeNode)
	{
	}

	[Token(Token = "0x60099AF")]
	[Address(RVA = "0x15F0364", Offset = "0x15F0364", VA = "0x15F0364")]
	private void UpdateAccountDics(CoreNode minNode, CoreNode upgradeNode)
	{
	}

	[Token(Token = "0x60099B0")]
	[Address(RVA = "0x15F0464", Offset = "0x15F0464", VA = "0x15F0464")]
	private void UdpateTrackAccountDic(CoreNode minNode, CoreNode upgradeNode, int beforeUpgradeTrack, int afterUpgradeTrack)
	{
	}

	[Token(Token = "0x60099B1")]
	[Address(RVA = "0x15F07D0", Offset = "0x15F07D0", VA = "0x15F07D0")]
	private void UpdateMinGravityAccountDic(int beforeUpgradeTrack, int afterUpgradeTrack)
	{
	}

	[Token(Token = "0x60099B2")]
	[Address(RVA = "0x15F0E38", Offset = "0x15F0E38", VA = "0x15F0E38")]
	private void UpdateGroupAccountDic(CoreNode minNode, CoreNode upgradeNode, int beforeUpgradeGroup, int afterUpgradeGroup)
	{
	}

	[Token(Token = "0x60099B3")]
	[Address(RVA = "0x15F1070", Offset = "0x15F1070", VA = "0x15F1070")]
	public void UpdateCoreNodeInfo(ulong AccountId)
	{
	}

	[Token(Token = "0x60099B4")]
	[Address(RVA = "0x15F3C48", Offset = "0x15F3C48", VA = "0x15F3C48")]
	public bool IsThreeDoorTabTipsNeedShow(int type, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x60099B5")]
	[Address(RVA = "0x15F3F4C", Offset = "0x15F3F4C", VA = "0x15F3F4C")]
	public bool IsAwardCanClaim(int type, uint awardProgress)
	{
		return default(bool);
	}

	[Token(Token = "0x60099B6")]
	[Address(RVA = "0x15E94E0", Offset = "0x15E94E0", VA = "0x15E94E0")]
	private bool IsThreeDoorTipsShow(ELimitedEvent.DigitaluniverseBGateType type)
	{
		return default(bool);
	}

	[Token(Token = "0x60099B7")]
	[Address(RVA = "0x15E605C", Offset = "0x15E605C", VA = "0x15E605C")]
	public void RequestDigitaluniverseBSetting()
	{
	}

	[Token(Token = "0x60099B8")]
	[Address(RVA = "0x15F3FF4", Offset = "0x15F3FF4", VA = "0x15F3FF4")]
	public void RequestDigitaluniverseBInfo()
	{
	}

	[Token(Token = "0x60099B9")]
	[Address(RVA = "0x15F4304", Offset = "0x15F4304", VA = "0x15F4304")]
	public void RequestDigitaluniverseBProgressAward(uint progress, int gateType = 4)
	{
	}

	[Token(Token = "0x60099BA")]
	[Address(RVA = "0x15F45E0", Offset = "0x15F45E0", VA = "0x15F45E0")]
	public void RequestDigitaluniverseBCharacterGateStory(uint storyGroupId)
	{
	}

	[Token(Token = "0x60099BB")]
	[Address(RVA = "0x15F481C", Offset = "0x15F481C", VA = "0x15F481C")]
	public void RequestDigitaluniverseBPlayReviewDesc()
	{
	}

	[Token(Token = "0x60099BC")]
	[Address(RVA = "0x15F4A84", Offset = "0x15F4A84", VA = "0x15F4A84")]
	public void NotifyStarMapFriendsInit()
	{
	}

	[Token(Token = "0x60099BD")]
	[Address(RVA = "0x15F4B4C", Offset = "0x15F4B4C", VA = "0x15F4B4C")]
	public void ProcessCacheFriendsInfo()
	{
	}

	[Token(Token = "0x60099BE")]
	[Address(RVA = "0x15F5580", Offset = "0x15F5580", VA = "0x15F5580")]
	private void RequestStarMapFirstOpenInfoSend(List<DigitalUniverseBStarCraftPlayerInitInfo> initList)
	{
	}

	[Token(Token = "0x60099BF")]
	[Address(RVA = "0x15F57BC", Offset = "0x15F57BC", VA = "0x15F57BC")]
	public void RequestStarMapInfo()
	{
	}

	[Token(Token = "0x60099C0")]
	[Address(RVA = "0x15F5A88", Offset = "0x15F5A88", VA = "0x15F5A88")]
	public void UpdateDigitalUniverseBStarCraftMessage(string messageText)
	{
	}

	[Token(Token = "0x60099C1")]
	[Address(RVA = "0x15F5D28", Offset = "0x15F5D28", VA = "0x15F5D28")]
	public void UpvoteDigitalUniverseBStarCraftMessage(ulong accountId)
	{
	}

	[Token(Token = "0x60099C2")]
	[Address(RVA = "0x15F5FE4", Offset = "0x15F5FE4", VA = "0x15F5FE4")]
	public void RequestStarMapPlayerInfo(ulong accountId)
	{
	}

	[Token(Token = "0x60099C3")]
	[Address(RVA = "0x15F622C", Offset = "0x15F622C", VA = "0x15F622C")]
	public bool RequestAssistStarMapPlayer(ulong accountId, CSDigitalUniverseBStarCraftInfoRes.PlayerInfo playerInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x60099C4")]
	[Address(RVA = "0x15F69A0", Offset = "0x15F69A0", VA = "0x15F69A0")]
	public void RequestClaimStarMapTargetAward(DigitaluniverseBStarCraftTargetDesc target)
	{
	}

	[Token(Token = "0x60099C5")]
	[Address(RVA = "0x15F6C70", Offset = "0x15F6C70", VA = "0x15F6C70")]
	public void RequestActivityAward(uint activityId)
	{
	}

	[Token(Token = "0x60099C6")]
	[Address(RVA = "0x15F6E6C", Offset = "0x15F6E6C", VA = "0x15F6E6C")]
	public void NotifyRefreshMissionView(long countDownTime, bool showHint)
	{
	}

	[Token(Token = "0x60099C8")]
	[Address(RVA = "0x15F7094", Offset = "0x15F7094", VA = "0x15F7094")]
	private static CommonRewardItemInfo _003CClaimAwards_003Em__0(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x60099C9")]
	[Address(RVA = "0x15F709C", Offset = "0x15F709C", VA = "0x15F709C")]
	private static int _003CGetMissionAwardsByGateType_003Em__1(DigitaluniverseBMissionRewardDesc awardA, DigitaluniverseBMissionRewardDesc awardB)
	{
		return default(int);
	}

	[Token(Token = "0x60099CA")]
	[Address(RVA = "0x15F70E4", Offset = "0x15F70E4", VA = "0x15F70E4")]
	private int _003CSortAssistHistory_003Em__2(CSDigitalUniverseBStarCraftInfoRes.AssistanceInfo a, CSDigitalUniverseBStarCraftInfoRes.AssistanceInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x60099CB")]
	[Address(RVA = "0x15F7190", Offset = "0x15F7190", VA = "0x15F7190")]
	private void _003CRequestDigitaluniverseBSetting_003Em__3(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60099CC")]
	[Address(RVA = "0x15F8880", Offset = "0x15F8880", VA = "0x15F8880")]
	private void _003CRequestDigitaluniverseBInfo_003Em__4(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60099CD")]
	[Address(RVA = "0x15F8C1C", Offset = "0x15F8C1C", VA = "0x15F8C1C")]
	private void _003CRequestDigitaluniverseBCharacterGateStory_003Em__5(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60099CE")]
	[Address(RVA = "0x15F8CA8", Offset = "0x15F8CA8", VA = "0x15F8CA8")]
	private void _003CRequestDigitaluniverseBPlayReviewDesc_003Em__6(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60099CF")]
	[Address(RVA = "0x15F8DD8", Offset = "0x15F8DD8", VA = "0x15F8DD8")]
	private void _003CRequestStarMapFirstOpenInfoSend_003Em__7(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60099D0")]
	[Address(RVA = "0x15F9210", Offset = "0x15F9210", VA = "0x15F9210")]
	private void _003CRequestStarMapInfo_003Em__8(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60099D1")]
	[Address(RVA = "0x15F9658", Offset = "0x15F9658", VA = "0x15F9658")]
	private void _003CRequestStarMapPlayerInfo_003Em__9(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60099D2")]
	[Address(RVA = "0x15F9904", Offset = "0x15F9904", VA = "0x15F9904")]
	private static bool _003CRequestDigitaluniverseBSetting_003Em__A(DigitaluniverseBCharMissionDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x60099D3")]
	[Address(RVA = "0x15F9930", Offset = "0x15F9930", VA = "0x15F9930")]
	private static bool _003CRequestDigitaluniverseBSetting_003Em__B(DigitaluniverseBCharMissionDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x60099D4")]
	[Address(RVA = "0x15F9960", Offset = "0x15F9960", VA = "0x15F9960")]
	private static bool _003CRequestDigitaluniverseBSetting_003Em__C(DigitaluniverseBCharMissionDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x60099D5")]
	[Address(RVA = "0x15F9990", Offset = "0x15F9990", VA = "0x15F9990")]
	private static int _003CRequestDigitaluniverseBSetting_003Em__D(DigitaluniverseBThreeDesc descA, DigitaluniverseBThreeDesc descB)
	{
		return default(int);
	}

	[Token(Token = "0x60099D6")]
	[Address(RVA = "0x15F99D8", Offset = "0x15F99D8", VA = "0x15F99D8")]
	private static int _003CRequestDigitaluniverseBSetting_003Em__E(DigitaluniverseBPostcardDesc A, DigitaluniverseBPostcardDesc B)
	{
		return default(int);
	}

	[Token(Token = "0x60099D7")]
	[Address(RVA = "0x15F9A20", Offset = "0x15F9A20", VA = "0x15F9A20")]
	private static int _003CRequestDigitaluniverseBSetting_003Em__F(DigitaluniverseBStarCraftTargetDesc a, DigitaluniverseBStarCraftTargetDesc b)
	{
		return default(int);
	}

	[Token(Token = "0x60099D8")]
	[Address(RVA = "0x15F9A68", Offset = "0x15F9A68", VA = "0x15F9A68")]
	private static int _003CRequestStarMapFirstOpenInfoSend_003Em__10(CSDigitalUniverseBStarCraftInfoRes.PlayerInfo a, CSDigitalUniverseBStarCraftInfoRes.PlayerInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x60099D9")]
	[Address(RVA = "0x15F9AE4", Offset = "0x15F9AE4", VA = "0x15F9AE4")]
	private static int _003CRequestStarMapInfo_003Em__11(CSDigitalUniverseBStarCraftInfoRes.PlayerInfo a, CSDigitalUniverseBStarCraftInfoRes.PlayerInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x60099DA")]
	[Address(RVA = "0x15F9B60", Offset = "0x15F9B60", VA = "0x15F9B60")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	[Token(Token = "0x60099DB")]
	[Address(RVA = "0x15F9B68", Offset = "0x15F9B68", VA = "0x15F9B68")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x60099DC")]
	[Address(RVA = "0x15F9B70", Offset = "0x15F9B70", VA = "0x15F9B70")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}
