using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002239")]
public class UIHudLadderMatchResultController : UIPopupWindowController
{
	[Token(Token = "0x200223A")]
	private struct ProgressInfo
	{
		[Token(Token = "0x400D5C8")]
		[FieldOffset(Offset = "0x0")]
		public float CurPercentage;

		[Token(Token = "0x400D5C9")]
		[FieldOffset(Offset = "0x4")]
		public float StartProgressValue;

		[Token(Token = "0x400D5CA")]
		[FieldOffset(Offset = "0x8")]
		public float EndProgressValue;

		[Token(Token = "0x400D5CB")]
		[FieldOffset(Offset = "0xC")]
		public float speedValue;
	}

	[Token(Token = "0x200223B")]
	private sealed class _003CStartLadderResultAnimation_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D5CC")]
		[FieldOffset(Offset = "0x8")]
		internal ResourceID _003Cres_003E__1;

		[Token(Token = "0x400D5CD")]
		[FieldOffset(Offset = "0xC")]
		internal string _003CclipName_003E__2;

		[Token(Token = "0x400D5CE")]
		[FieldOffset(Offset = "0x10")]
		internal UILadderPlayerFullScreenAnimation _003Canim_003E__3;

		[Token(Token = "0x400D5CF")]
		[FieldOffset(Offset = "0x14")]
		internal ProgressInfo _003Cinfo_003E__4;

		[Token(Token = "0x400D5D0")]
		[FieldOffset(Offset = "0x24")]
		internal bool _003Cupgrade_003E__5;

		[Token(Token = "0x400D5D1")]
		[FieldOffset(Offset = "0x28")]
		internal int _003Ci_003E__6;

		[Token(Token = "0x400D5D2")]
		[FieldOffset(Offset = "0x2C")]
		internal ProgressInfo _003Cinfo_003E__7;

		[Token(Token = "0x400D5D3")]
		[FieldOffset(Offset = "0x3C")]
		internal ProgressInfo _003Cinfo_003E__8;

		[Token(Token = "0x400D5D4")]
		[FieldOffset(Offset = "0x4C")]
		internal ProgressInfo _003Cinfo_003E__9;

		[Token(Token = "0x400D5D5")]
		[FieldOffset(Offset = "0x5C")]
		internal int _003Ci_003E__10;

		[Token(Token = "0x400D5D6")]
		[FieldOffset(Offset = "0x60")]
		internal ProgressInfo _003Cinfo_003E__11;

		[Token(Token = "0x400D5D7")]
		[FieldOffset(Offset = "0x70")]
		internal ProgressInfo _003Cinfo_003E__12;

		[Token(Token = "0x400D5D8")]
		[FieldOffset(Offset = "0x80")]
		internal ProgressInfo _003Cinfo_003E__13;

		[Token(Token = "0x400D5D9")]
		[FieldOffset(Offset = "0x90")]
		internal UIHudLadderMatchResultController _0024this;

		[Token(Token = "0x400D5DA")]
		[FieldOffset(Offset = "0x94")]
		internal object _0024current;

		[Token(Token = "0x400D5DB")]
		[FieldOffset(Offset = "0x98")]
		internal bool _0024disposing;

		[Token(Token = "0x400D5DC")]
		[FieldOffset(Offset = "0x9C")]
		internal int _0024PC;

		[Token(Token = "0x17001050")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600B9C3")]
			[Address(RVA = "0x1BD5E1C", Offset = "0x1BD5E1C", VA = "0x1BD5E1C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001051")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600B9C4")]
			[Address(RVA = "0x1BD5E24", Offset = "0x1BD5E24", VA = "0x1BD5E24", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B9C1")]
		[Address(RVA = "0x1BD3E20", Offset = "0x1BD3E20", VA = "0x1BD3E20")]
		public _003CStartLadderResultAnimation_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600B9C2")]
		[Address(RVA = "0x1BD4CC8", Offset = "0x1BD4CC8", VA = "0x1BD4CC8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600B9C5")]
		[Address(RVA = "0x1BD5E2C", Offset = "0x1BD5E2C", VA = "0x1BD5E2C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600B9C6")]
		[Address(RVA = "0x1BD5E40", Offset = "0x1BD5E40", VA = "0x1BD5E40", Slot = "6")]
		public void Reset()
		{
		}

		[Token(Token = "0x600B9C7")]
		[Address(RVA = "0x1BD5EC8", Offset = "0x1BD5EC8", VA = "0x1BD5EC8")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x200223C")]
	private sealed class _003CPlayScoreAnimation_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D5DD")]
		[FieldOffset(Offset = "0x8")]
		internal int _003Cnum_003E__0;

		[Token(Token = "0x400D5DE")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudLadderMatchResultController _0024this;

		[Token(Token = "0x400D5DF")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400D5E0")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400D5E1")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x17001052")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600B9CA")]
			[Address(RVA = "0x1BD4C18", Offset = "0x1BD4C18", VA = "0x1BD4C18", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001053")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600B9CB")]
			[Address(RVA = "0x1BD4C20", Offset = "0x1BD4C20", VA = "0x1BD4C20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B9C8")]
		[Address(RVA = "0x1BD3EF4", Offset = "0x1BD3EF4", VA = "0x1BD3EF4")]
		public _003CPlayScoreAnimation_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600B9C9")]
		[Address(RVA = "0x1BD4954", Offset = "0x1BD4954", VA = "0x1BD4954", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600B9CC")]
		[Address(RVA = "0x1BD4C28", Offset = "0x1BD4C28", VA = "0x1BD4C28", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600B9CD")]
		[Address(RVA = "0x1BD4C3C", Offset = "0x1BD4C3C", VA = "0x1BD4C3C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200223D")]
	private sealed class _003CPlayProgressAnimation_003Ec__Iterator2 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D5E2")]
		[FieldOffset(Offset = "0x8")]
		internal ProgressInfo info;

		[Token(Token = "0x400D5E3")]
		[FieldOffset(Offset = "0x18")]
		internal bool _003CprogressUp_003E__0;

		[Token(Token = "0x400D5E4")]
		[FieldOffset(Offset = "0x1C")]
		internal float _003CoffsetX_003E__1;

		[Token(Token = "0x400D5E5")]
		[FieldOffset(Offset = "0x20")]
		internal UIHudLadderMatchResultController _0024this;

		[Token(Token = "0x400D5E6")]
		[FieldOffset(Offset = "0x24")]
		internal object _0024current;

		[Token(Token = "0x400D5E7")]
		[FieldOffset(Offset = "0x28")]
		internal bool _0024disposing;

		[Token(Token = "0x400D5E8")]
		[FieldOffset(Offset = "0x2C")]
		internal int _0024PC;

		[Token(Token = "0x17001054")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600B9D0")]
			[Address(RVA = "0x1BD48A8", Offset = "0x1BD48A8", VA = "0x1BD48A8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001055")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600B9D1")]
			[Address(RVA = "0x1BD48B0", Offset = "0x1BD48B0", VA = "0x1BD48B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B9CE")]
		[Address(RVA = "0x1BD400C", Offset = "0x1BD400C", VA = "0x1BD400C")]
		public _003CPlayProgressAnimation_003Ec__Iterator2()
		{
		}

		[Token(Token = "0x600B9CF")]
		[Address(RVA = "0x1BD43E8", Offset = "0x1BD43E8", VA = "0x1BD43E8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600B9D2")]
		[Address(RVA = "0x1BD48B8", Offset = "0x1BD48B8", VA = "0x1BD48B8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600B9D3")]
		[Address(RVA = "0x1BD48CC", Offset = "0x1BD48CC", VA = "0x1BD48CC", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200223E")]
	private sealed class _003CPlayAndWaitingForAnimationOver_003Ec__Iterator3 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D5E9")]
		[FieldOffset(Offset = "0x8")]
		internal float _003CaniamtionTime_003E__0;

		[Token(Token = "0x400D5EA")]
		[FieldOffset(Offset = "0xC")]
		internal Animation animationCom;

		[Token(Token = "0x400D5EB")]
		[FieldOffset(Offset = "0x10")]
		internal string animation;

		[Token(Token = "0x400D5EC")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x400D5ED")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x400D5EE")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x17001056")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600B9D6")]
			[Address(RVA = "0x1BD433C", Offset = "0x1BD433C", VA = "0x1BD433C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001057")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600B9D7")]
			[Address(RVA = "0x1BD4344", Offset = "0x1BD4344", VA = "0x1BD4344", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B9D4")]
		[Address(RVA = "0x1BD4118", Offset = "0x1BD4118", VA = "0x1BD4118")]
		public _003CPlayAndWaitingForAnimationOver_003Ec__Iterator3()
		{
		}

		[Token(Token = "0x600B9D5")]
		[Address(RVA = "0x1BD4140", Offset = "0x1BD4140", VA = "0x1BD4140", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600B9D8")]
		[Address(RVA = "0x1BD434C", Offset = "0x1BD434C", VA = "0x1BD434C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600B9D9")]
		[Address(RVA = "0x1BD4360", Offset = "0x1BD4360", VA = "0x1BD4360", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400D5A9")]
	[FieldOffset(Offset = "0x48")]
	private UIHudLadderMatchResultView m_View;

	[Token(Token = "0x400D5AA")]
	private const int SCORE_ADD_NUM = 1;

	[Token(Token = "0x400D5AB")]
	private const float PROGRESS_ANIM_SPEED_1 = 2f;

	[Token(Token = "0x400D5AC")]
	private const float PROGRESS_ANIM_SPEED_2 = 4f;

	[Token(Token = "0x400D5AD")]
	private const uint PROGRESS_OFFSET = 30u;

	[Token(Token = "0x400D5AE")]
	private const string ANIMATION_ENTER = "UILadderMatchEnterAnim";

	[Token(Token = "0x400D5AF")]
	private const string ANIMATION_RANK_UP = "UILadderMatchRankUp";

	[Token(Token = "0x400D5B0")]
	private const string ANIMATION_RANK_DOWN = "UILadderMatchRankDown";

	[Token(Token = "0x400D5B1")]
	private const string ANIMATION_RANK_STAR = "UILadderMatchRankStar";

	[Token(Token = "0x400D5B2")]
	private const string ANIMATION_RANK_GREAT_UP_NEXT = "VFX_UIHudLadderMatchResult_Hide001";

	[Token(Token = "0x400D5B3")]
	[FieldOffset(Offset = "0x4C")]
	private int DeltaPoint;

	[Token(Token = "0x400D5B4")]
	[FieldOffset(Offset = "0x50")]
	private string DeltaStr;

	[Token(Token = "0x400D5B5")]
	[FieldOffset(Offset = "0x54")]
	private uint TokenMax;

	[Token(Token = "0x400D5B6")]
	[FieldOffset(Offset = "0x58")]
	private int BeforePoint;

	[Token(Token = "0x400D5B7")]
	[FieldOffset(Offset = "0x5C")]
	private uint BeforeRank;

	[Token(Token = "0x400D5B8")]
	[FieldOffset(Offset = "0x60")]
	private uint BeforeRankBRStar;

	[Token(Token = "0x400D5B9")]
	[FieldOffset(Offset = "0x64")]
	private float BeforeProgressValue;

	[Token(Token = "0x400D5BA")]
	[FieldOffset(Offset = "0x68")]
	private LadderLevelData BeforeLevelData;

	[Token(Token = "0x400D5BB")]
	[FieldOffset(Offset = "0x6C")]
	private bool IsBeforeMaxRank;

	[Token(Token = "0x400D5BC")]
	[FieldOffset(Offset = "0x70")]
	private int AfterPoint;

	[Token(Token = "0x400D5BD")]
	[FieldOffset(Offset = "0x74")]
	private uint AfterRank;

	[Token(Token = "0x400D5BE")]
	[FieldOffset(Offset = "0x78")]
	private uint AfterRankBRStar;

	[Token(Token = "0x400D5BF")]
	[FieldOffset(Offset = "0x7C")]
	private float AfterProgressValue;

	[Token(Token = "0x400D5C0")]
	[FieldOffset(Offset = "0x80")]
	private LadderLevelData AfterLevelData;

	[Token(Token = "0x400D5C1")]
	[FieldOffset(Offset = "0x84")]
	private bool IsAfterMaxRank;

	[Token(Token = "0x400D5C2")]
	[FieldOffset(Offset = "0x88")]
	private int TimesUpgrade;

	[Token(Token = "0x400D5C3")]
	[FieldOffset(Offset = "0x8C")]
	private bool CanCloseFlag;

	[Token(Token = "0x400D5C4")]
	[FieldOffset(Offset = "0x90")]
	private UIHudCommonlTipsController m_TokenTipCtrl;

	[Token(Token = "0x400D5C5")]
	[FieldOffset(Offset = "0x94")]
	private bool ShowBigUpgradeAnimation;

	[Token(Token = "0x400D5C6")]
	[FieldOffset(Offset = "0x98")]
	private GameObject[] BeforeStar;

	[Token(Token = "0x400D5C7")]
	[FieldOffset(Offset = "0x9C")]
	private GameObject[] AfterStar;

	[Token(Token = "0x600B9A9")]
	[Address(RVA = "0x1BCFE7C", Offset = "0x1BCFE7C", VA = "0x1BCFE7C")]
	public UIHudLadderMatchResultController()
	{
	}

	[Token(Token = "0x600B9AA")]
	[Address(RVA = "0x1BCFEE8", Offset = "0x1BCFEE8", VA = "0x1BCFEE8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B9AB")]
	[Address(RVA = "0x1BCFF90", Offset = "0x1BCFF90", VA = "0x1BCFF90")]
	public void SetResultData(MatchIncome incomeData, MatchStats statsData)
	{
	}

	[Token(Token = "0x600B9AC")]
	[Address(RVA = "0x1BD2C4C", Offset = "0x1BD2C4C", VA = "0x1BD2C4C")]
	private void InitAntiHackProtect(MatchIncome income)
	{
	}

	[Token(Token = "0x600B9AD")]
	[Address(RVA = "0x1BD30D4", Offset = "0x1BD30D4", VA = "0x1BD30D4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B9AE")]
	[Address(RVA = "0x1BD3758", Offset = "0x1BD3758", VA = "0x1BD3758", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600B9AF")]
	[Address(RVA = "0x1BD3900", Offset = "0x1BD3900", VA = "0x1BD3900", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B9B0")]
	[Address(RVA = "0x1BD3A08", Offset = "0x1BD3A08", VA = "0x1BD3A08", Slot = "34")]
	public override int GlassDelay()
	{
		return default(int);
	}

	[Token(Token = "0x600B9B1")]
	[Address(RVA = "0x1BD2E10", Offset = "0x1BD2E10", VA = "0x1BD2E10")]
	private void SendLog()
	{
	}

	[Token(Token = "0x600B9B2")]
	[Address(RVA = "0x1BD3A60", Offset = "0x1BD3A60", VA = "0x1BD3A60")]
	private void OnClickMask()
	{
	}

	[Token(Token = "0x600B9B3")]
	[Address(RVA = "0x1BD3AD0", Offset = "0x1BD3AD0", VA = "0x1BD3AD0")]
	private void OnClickTokenDetail()
	{
	}

	[Token(Token = "0x600B9B4")]
	[Address(RVA = "0x1BD0084", Offset = "0x1BD0084", VA = "0x1BD0084")]
	private void InitRankInfo(MatchIncome income)
	{
	}

	[Token(Token = "0x600B9B5")]
	[Address(RVA = "0x1BD1538", Offset = "0x1BD1538", VA = "0x1BD1538")]
	private void InitScoreInfo(MatchIncome income, uint rank)
	{
	}

	[Token(Token = "0x600B9B6")]
	[Address(RVA = "0x1BD20C4", Offset = "0x1BD20C4", VA = "0x1BD20C4")]
	private void InitTokenInfo(MatchIncome income)
	{
	}

	[Token(Token = "0x600B9B7")]
	[Address(RVA = "0x1BD236C", Offset = "0x1BD236C", VA = "0x1BD236C")]
	private void InitSurvivalTimeInfo(MatchStats stats)
	{
	}

	[Token(Token = "0x600B9B8")]
	[Address(RVA = "0x1BD25CC", Offset = "0x1BD25CC", VA = "0x1BD25CC")]
	private void InitBonusInfo(MatchIncome income)
	{
	}

	[Token(Token = "0x600B9B9")]
	[Address(RVA = "0x1BD2B80", Offset = "0x1BD2B80", VA = "0x1BD2B80")]
	private IEnumerator StartLadderResultAnimation()
	{
		return null;
	}

	[Token(Token = "0x600B9BA")]
	[Address(RVA = "0x1BD3E28", Offset = "0x1BD3E28", VA = "0x1BD3E28")]
	private IEnumerator PlayScoreAnimation()
	{
		return null;
	}

	[Token(Token = "0x600B9BB")]
	[Address(RVA = "0x1BD3EFC", Offset = "0x1BD3EFC", VA = "0x1BD3EFC")]
	private IEnumerator PlayProgressAnimation(ProgressInfo info)
	{
		return null;
	}

	[Token(Token = "0x600B9BC")]
	[Address(RVA = "0x1BD4014", Offset = "0x1BD4014", VA = "0x1BD4014")]
	private IEnumerator PlayAndWaitingForAnimationOver(Animation animationCom, string animation)
	{
		return null;
	}

	[Token(Token = "0x600B9BD")]
	[Address(RVA = "0x1BD4120", Offset = "0x1BD4120", VA = "0x1BD4120")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B9BE")]
	[Address(RVA = "0x1BD4128", Offset = "0x1BD4128", VA = "0x1BD4128")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600B9BF")]
	[Address(RVA = "0x1BD4130", Offset = "0x1BD4130", VA = "0x1BD4130")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600B9C0")]
	[Address(RVA = "0x1BD4138", Offset = "0x1BD4138", VA = "0x1BD4138")]
	public int _003C_003EiFixBaseProxy_GlassDelay()
	{
		return default(int);
	}
}
