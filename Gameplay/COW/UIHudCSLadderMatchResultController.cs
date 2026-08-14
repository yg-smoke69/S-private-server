using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;
using proto;

namespace COW;

[Token(Token = "0x2002233")]
public class UIHudCSLadderMatchResultController : UIPopupWindowController
{
	[Token(Token = "0x2002234")]
	private sealed class _003CPlayUpStarAnim_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D57B")]
		[FieldOffset(Offset = "0x8")]
		internal LadderMatchStarGroup currentStarGroup;

		[Token(Token = "0x400D57C")]
		[FieldOffset(Offset = "0xC")]
		internal LadderMatchStar _003CstarNeedGain_003E__0;

		[Token(Token = "0x400D57D")]
		[FieldOffset(Offset = "0x10")]
		internal Animation _003Clabel_animation_003E__1;

		[Token(Token = "0x400D57E")]
		[FieldOffset(Offset = "0x14")]
		internal UIHudCSLadderMatchResultController _0024this;

		[Token(Token = "0x400D57F")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x400D580")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _0024disposing;

		[Token(Token = "0x400D581")]
		[FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x17001046")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600B98C")]
			[Address(RVA = "0x1F0D29C", Offset = "0x1F0D29C", VA = "0x1F0D29C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001047")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600B98D")]
			[Address(RVA = "0x1F0D2A4", Offset = "0x1F0D2A4", VA = "0x1F0D2A4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B98A")]
		[Address(RVA = "0x1F0C1F0", Offset = "0x1F0C1F0", VA = "0x1F0C1F0")]
		public _003CPlayUpStarAnim_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600B98B")]
		[Address(RVA = "0x1F0D0E0", Offset = "0x1F0D0E0", VA = "0x1F0D0E0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600B98E")]
		[Address(RVA = "0x1F0D2AC", Offset = "0x1F0D2AC", VA = "0x1F0D2AC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600B98F")]
		[Address(RVA = "0x1F0D2C0", Offset = "0x1F0D2C0", VA = "0x1F0D2C0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002235")]
	private sealed class _003CPlayLoseStarAnim_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D582")]
		[FieldOffset(Offset = "0x8")]
		internal LadderMatchStarGroup currentStarGroup;

		[Token(Token = "0x400D583")]
		[FieldOffset(Offset = "0xC")]
		internal LadderMatchStar _003CstarNeedLose_003E__0;

		[Token(Token = "0x400D584")]
		[FieldOffset(Offset = "0x10")]
		internal Animation _003Clabel_animation_003E__1;

		[Token(Token = "0x400D585")]
		[FieldOffset(Offset = "0x14")]
		internal UIHudCSLadderMatchResultController _0024this;

		[Token(Token = "0x400D586")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x400D587")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _0024disposing;

		[Token(Token = "0x400D588")]
		[FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x17001048")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600B992")]
			[Address(RVA = "0x1F0D034", Offset = "0x1F0D034", VA = "0x1F0D034", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001049")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600B993")]
			[Address(RVA = "0x1F0D03C", Offset = "0x1F0D03C", VA = "0x1F0D03C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B990")]
		[Address(RVA = "0x1F0C2E4", Offset = "0x1F0C2E4", VA = "0x1F0C2E4")]
		public _003CPlayLoseStarAnim_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600B991")]
		[Address(RVA = "0x1F0CE74", Offset = "0x1F0CE74", VA = "0x1F0CE74", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600B994")]
		[Address(RVA = "0x1F0D044", Offset = "0x1F0D044", VA = "0x1F0D044", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600B995")]
		[Address(RVA = "0x1F0D058", Offset = "0x1F0D058", VA = "0x1F0D058", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002236")]
	private sealed class _003CStartProtectPointAnimation_003Ec__Iterator2 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D589")]
		[FieldOffset(Offset = "0x8")]
		internal float _003CrollTime_003E__0;

		[Token(Token = "0x400D58A")]
		[FieldOffset(Offset = "0xC")]
		internal uint startPoint;

		[Token(Token = "0x400D58B")]
		[FieldOffset(Offset = "0x10")]
		internal uint endPoint;

		[Token(Token = "0x400D58C")]
		[FieldOffset(Offset = "0x14")]
		internal float _003ClerpValue_003E__1;

		[Token(Token = "0x400D58D")]
		[FieldOffset(Offset = "0x18")]
		internal float _003Cspeed_003E__1;

		[Token(Token = "0x400D58E")]
		[FieldOffset(Offset = "0x1C")]
		internal float _003CcurrentPoint_003E__2;

		[Token(Token = "0x400D58F")]
		[FieldOffset(Offset = "0x20")]
		internal UIHudCSLadderMatchResultController _0024this;

		[Token(Token = "0x400D590")]
		[FieldOffset(Offset = "0x24")]
		internal object _0024current;

		[Token(Token = "0x400D591")]
		[FieldOffset(Offset = "0x28")]
		internal bool _0024disposing;

		[Token(Token = "0x400D592")]
		[FieldOffset(Offset = "0x2C")]
		internal int _0024PC;

		[Token(Token = "0x1700104A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600B998")]
			[Address(RVA = "0x1F0F4D0", Offset = "0x1F0F4D0", VA = "0x1F0F4D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700104B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600B999")]
			[Address(RVA = "0x1F0F4D8", Offset = "0x1F0F4D8", VA = "0x1F0F4D8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B996")]
		[Address(RVA = "0x1F0C404", Offset = "0x1F0C404", VA = "0x1F0C404")]
		public _003CStartProtectPointAnimation_003Ec__Iterator2()
		{
		}

		[Token(Token = "0x600B997")]
		[Address(RVA = "0x1F0EF58", Offset = "0x1F0EF58", VA = "0x1F0EF58", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600B99A")]
		[Address(RVA = "0x1F0F4E0", Offset = "0x1F0F4E0", VA = "0x1F0F4E0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600B99B")]
		[Address(RVA = "0x1F0F4F4", Offset = "0x1F0F4F4", VA = "0x1F0F4F4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002237")]
	private sealed class _003CStartLadderResultAnimation_003Ec__Iterator3 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D593")]
		[FieldOffset(Offset = "0x8")]
		internal ResourceID _003Cres_003E__1;

		[Token(Token = "0x400D594")]
		[FieldOffset(Offset = "0xC")]
		internal string _003CclipName_003E__2;

		[Token(Token = "0x400D595")]
		[FieldOffset(Offset = "0x10")]
		internal UILadderPlayerFullScreenAnimation _003Canim_003E__3;

		[Token(Token = "0x400D596")]
		[FieldOffset(Offset = "0x14")]
		internal int _003CpointsDelta_003E__0;

		[Token(Token = "0x400D597")]
		[FieldOffset(Offset = "0x18")]
		internal bool _003CisUpStar_003E__0;

		[Token(Token = "0x400D598")]
		[FieldOffset(Offset = "0x19")]
		internal bool _003CisLevelChange_003E__0;

		[Token(Token = "0x400D599")]
		[FieldOffset(Offset = "0x1C")]
		internal LadderMatchStarGroup _003CcurrentStarGroup_003E__0;

		[Token(Token = "0x400D59A")]
		[FieldOffset(Offset = "0x20")]
		internal int _003Cstar_003E__4;

		[Token(Token = "0x400D59B")]
		[FieldOffset(Offset = "0x24")]
		internal uint _003CstartPoint_003E__5;

		[Token(Token = "0x400D59C")]
		[FieldOffset(Offset = "0x28")]
		internal uint _003CendPoint_003E__6;

		[Token(Token = "0x400D59D")]
		[FieldOffset(Offset = "0x2C")]
		internal CSRankData _003Cdata_003E__0;

		[Token(Token = "0x400D59E")]
		[FieldOffset(Offset = "0x30")]
		internal UIHudCSLadderMatchResultController _0024this;

		[Token(Token = "0x400D59F")]
		[FieldOffset(Offset = "0x34")]
		internal object _0024current;

		[Token(Token = "0x400D5A0")]
		[FieldOffset(Offset = "0x38")]
		internal bool _0024disposing;

		[Token(Token = "0x400D5A1")]
		[FieldOffset(Offset = "0x3C")]
		internal int _0024PC;

		[Token(Token = "0x1700104C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600B99E")]
			[Address(RVA = "0x1F0EDEC", Offset = "0x1F0EDEC", VA = "0x1F0EDEC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700104D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600B99F")]
			[Address(RVA = "0x1F0EDF4", Offset = "0x1F0EDF4", VA = "0x1F0EDF4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B99C")]
		[Address(RVA = "0x1F0CA00", Offset = "0x1F0CA00", VA = "0x1F0CA00")]
		public _003CStartLadderResultAnimation_003Ec__Iterator3()
		{
		}

		[Token(Token = "0x600B99D")]
		[Address(RVA = "0x1F0D348", Offset = "0x1F0D348", VA = "0x1F0D348", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600B9A0")]
		[Address(RVA = "0x1F0EDFC", Offset = "0x1F0EDFC", VA = "0x1F0EDFC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600B9A1")]
		[Address(RVA = "0x1F0EE10", Offset = "0x1F0EE10", VA = "0x1F0EE10", Slot = "6")]
		public void Reset()
		{
		}

		[Token(Token = "0x600B9A2")]
		[Address(RVA = "0x1F0EE98", Offset = "0x1F0EE98", VA = "0x1F0EE98")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002238")]
	private sealed class _003CPlayAndWaitingForAnimationOver_003Ec__Iterator4 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D5A2")]
		[FieldOffset(Offset = "0x8")]
		internal float _003CaniamtionTime_003E__0;

		[Token(Token = "0x400D5A3")]
		[FieldOffset(Offset = "0xC")]
		internal Animation animationCom;

		[Token(Token = "0x400D5A4")]
		[FieldOffset(Offset = "0x10")]
		internal string animation;

		[Token(Token = "0x400D5A5")]
		[FieldOffset(Offset = "0x14")]
		internal UIHudCSLadderMatchResultController _0024this;

		[Token(Token = "0x400D5A6")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x400D5A7")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _0024disposing;

		[Token(Token = "0x400D5A8")]
		[FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x1700104E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600B9A5")]
			[Address(RVA = "0x1F0CDC8", Offset = "0x1F0CDC8", VA = "0x1F0CDC8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700104F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600B9A6")]
			[Address(RVA = "0x1F0CDD0", Offset = "0x1F0CDD0", VA = "0x1F0CDD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B9A3")]
		[Address(RVA = "0x1F0CB20", Offset = "0x1F0CB20", VA = "0x1F0CB20")]
		public _003CPlayAndWaitingForAnimationOver_003Ec__Iterator4()
		{
		}

		[Token(Token = "0x600B9A4")]
		[Address(RVA = "0x1F0CB40", Offset = "0x1F0CB40", VA = "0x1F0CB40", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600B9A7")]
		[Address(RVA = "0x1F0CDD8", Offset = "0x1F0CDD8", VA = "0x1F0CDD8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600B9A8")]
		[Address(RVA = "0x1F0CDEC", Offset = "0x1F0CDEC", VA = "0x1F0CDEC", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400D560")]
	[FieldOffset(Offset = "0x48")]
	private UIHudCSLadderMatchResultView m_View;

	[Token(Token = "0x400D561")]
	private const string ANIMATION_ENTER = "UILadderCSMatchEnterAnim";

	[Token(Token = "0x400D562")]
	private const string ANIMATION_RANK_UP = "UILadderCSMatchRankUp";

	[Token(Token = "0x400D563")]
	private const string ANIMATION_RANK_DOWN = "UILadderCSMatchRankDown";

	[Token(Token = "0x400D564")]
	private const string ANIMATION_SHIELD = "UIFXShield";

	[Token(Token = "0x400D565")]
	private const string ANIMATION_RANK_GREAT_UP_NEXT = "VFX_UIHudLadderMatchResult_Hide001";

	[Token(Token = "0x400D566")]
	private const float RANK_UPDATE_WAIT_TIME = 0.1f;

	[Token(Token = "0x400D567")]
	private const uint MAX_PROTECT_POINT = 100u;

	[Token(Token = "0x400D568")]
	[FieldOffset(Offset = "0x4C")]
	private DGNDKMLMLPM m_MatchMode;

	[Token(Token = "0x400D569")]
	[FieldOffset(Offset = "0x50")]
	private bool IsWin;

	[Token(Token = "0x400D56A")]
	[FieldOffset(Offset = "0x54")]
	private int RankBefore;

	[Token(Token = "0x400D56B")]
	[FieldOffset(Offset = "0x58")]
	private int RankAfter;

	[Token(Token = "0x400D56C")]
	[FieldOffset(Offset = "0x5C")]
	private int PointsBefore;

	[Token(Token = "0x400D56D")]
	[FieldOffset(Offset = "0x60")]
	private int PointsAfter;

	[Token(Token = "0x400D56E")]
	[FieldOffset(Offset = "0x64")]
	private int PointsVeteran;

	[Token(Token = "0x400D56F")]
	[FieldOffset(Offset = "0x68")]
	private uint PreProtect;

	[Token(Token = "0x400D570")]
	[FieldOffset(Offset = "0x6C")]
	private uint CurProtect;

	[Token(Token = "0x400D571")]
	[FieldOffset(Offset = "0x70")]
	private CSRankData CurrentLevelData;

	[Token(Token = "0x400D572")]
	[FieldOffset(Offset = "0x74")]
	private CSRankData OldLevelData;

	[Token(Token = "0x400D573")]
	[FieldOffset(Offset = "0x78")]
	private LadderMatchStarGroup StarGroupBefore;

	[Token(Token = "0x400D574")]
	[FieldOffset(Offset = "0x7C")]
	private LadderMatchStarGroup StarGroupAfter;

	[Token(Token = "0x400D575")]
	[FieldOffset(Offset = "0x80")]
	private bool CanCloseFlag;

	[Token(Token = "0x400D576")]
	[FieldOffset(Offset = "0x84")]
	private int CurAnimSpeed;

	[Token(Token = "0x400D577")]
	[FieldOffset(Offset = "0x88")]
	private bool IsInProtect;

	[Token(Token = "0x400D578")]
	[FieldOffset(Offset = "0x89")]
	private bool IsInAntiHackProtect;

	[Token(Token = "0x400D579")]
	[FieldOffset(Offset = "0x8C")]
	private uint m_ProtectCompensationPoints;

	[Token(Token = "0x400D57A")]
	[FieldOffset(Offset = "0x90")]
	private bool ShowBigUpgradeAnimation;

	[Token(Token = "0x600B972")]
	[Address(RVA = "0x1F09044", Offset = "0x1F09044", VA = "0x1F09044")]
	public UIHudCSLadderMatchResultController()
	{
	}

	[Token(Token = "0x600B973")]
	[Address(RVA = "0x1F09054", Offset = "0x1F09054", VA = "0x1F09054")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B974")]
	[Address(RVA = "0x1F090FC", Offset = "0x1F090FC", VA = "0x1F090FC")]
	public void SetResultData(MatchIncome incomeData, MatchStats statsData, DGNDKMLMLPM matchMode = DGNDKMLMLPM.EMATCHNODE_CSRANKING)
	{
	}

	[Token(Token = "0x600B975")]
	[Address(RVA = "0x1F0AB10", Offset = "0x1F0AB10", VA = "0x1F0AB10")]
	private void SetCSHeroicStarMaxLabel()
	{
	}

	[Token(Token = "0x600B976")]
	[Address(RVA = "0x1F0B9DC", Offset = "0x1F0B9DC", VA = "0x1F0B9DC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B977")]
	[Address(RVA = "0x1F0BC00", Offset = "0x1F0BC00", VA = "0x1F0BC00", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600B978")]
	[Address(RVA = "0x1F0BEC0", Offset = "0x1F0BEC0", VA = "0x1F0BEC0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B979")]
	[Address(RVA = "0x1F095BC", Offset = "0x1F095BC", VA = "0x1F095BC")]
	private bool IsCSRanking()
	{
		return default(bool);
	}

	[Token(Token = "0x600B97A")]
	[Address(RVA = "0x1F0BF24", Offset = "0x1F0BF24", VA = "0x1F0BF24")]
	private uint GetHeroicRankLevel()
	{
		return default(uint);
	}

	[Token(Token = "0x600B97B")]
	[Address(RVA = "0x1F09628", Offset = "0x1F09628", VA = "0x1F09628")]
	private CSRankData GetRankDataByRank(int rank)
	{
		return null;
	}

	[Token(Token = "0x600B97C")]
	[Address(RVA = "0x1F0C080", Offset = "0x1F0C080", VA = "0x1F0C080")]
	private void OnMaskClick()
	{
	}

	[Token(Token = "0x600B97D")]
	[Address(RVA = "0x1F0C104", Offset = "0x1F0C104", VA = "0x1F0C104")]
	private IEnumerator PlayUpStarAnim(LadderMatchStarGroup currentStarGroup)
	{
		return null;
	}

	[Token(Token = "0x600B97E")]
	[Address(RVA = "0x1F0C1F8", Offset = "0x1F0C1F8", VA = "0x1F0C1F8")]
	private IEnumerator PlayLoseStarAnim(LadderMatchStarGroup currentStarGroup)
	{
		return null;
	}

	[Token(Token = "0x600B97F")]
	[Address(RVA = "0x1F0C2EC", Offset = "0x1F0C2EC", VA = "0x1F0C2EC")]
	private IEnumerator StartProtectPointAnimation(uint startPoint, uint endPoint)
	{
		return null;
	}

	[Token(Token = "0x600B980")]
	[Address(RVA = "0x1F0C40C", Offset = "0x1F0C40C", VA = "0x1F0C40C")]
	private void AfterBigAniMatchresultInit()
	{
	}

	[Token(Token = "0x600B981")]
	[Address(RVA = "0x1F0B910", Offset = "0x1F0B910", VA = "0x1F0B910")]
	private IEnumerator StartLadderResultAnimation()
	{
		return null;
	}

	[Token(Token = "0x600B982")]
	[Address(RVA = "0x1F0CA08", Offset = "0x1F0CA08", VA = "0x1F0CA08")]
	private IEnumerator PlayAndWaitingForAnimationOver(Animation animationCom, string animation)
	{
		return null;
	}

	[Token(Token = "0x600B983")]
	[Address(RVA = "0x1F0B130", Offset = "0x1F0B130", VA = "0x1F0B130")]
	private void SetScoreInfoPanel()
	{
	}

	[Token(Token = "0x600B984")]
	[Address(RVA = "0x1F0A97C", Offset = "0x1F0A97C", VA = "0x1F0A97C")]
	private void SetBigUpgradeRankUIGroup()
	{
	}

	[Token(Token = "0x600B985")]
	[Address(RVA = "0x1F09794", Offset = "0x1F09794", VA = "0x1F09794")]
	private void SetOldRankUIGroup()
	{
	}

	[Token(Token = "0x600B986")]
	[Address(RVA = "0x1F0A100", Offset = "0x1F0A100", VA = "0x1F0A100")]
	private void SetCurrentRankUIGroup()
	{
	}

	[Token(Token = "0x600B987")]
	[Address(RVA = "0x1F0CB28", Offset = "0x1F0CB28", VA = "0x1F0CB28")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B988")]
	[Address(RVA = "0x1F0CB30", Offset = "0x1F0CB30", VA = "0x1F0CB30")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600B989")]
	[Address(RVA = "0x1F0CB38", Offset = "0x1F0CB38", VA = "0x1F0CB38")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
