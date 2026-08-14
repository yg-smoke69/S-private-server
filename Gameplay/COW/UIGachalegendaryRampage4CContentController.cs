using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002110")]
internal class UIGachalegendaryRampage4CContentController : UIGachaContentBase, _Attribute
{
	[Token(Token = "0x2002111")]
	private sealed class _003CSet3DUIpanel_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400CF26")]
		[FieldOffset(Offset = "0x8")]
		internal Transform[] _0024locvar0;

		[Token(Token = "0x400CF27")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024locvar1;

		[Token(Token = "0x400CF28")]
		[FieldOffset(Offset = "0x10")]
		internal UIGachalegendaryRampage4CContentController _0024this;

		[Token(Token = "0x400CF29")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x400CF2A")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x400CF2B")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x17000FFA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600ACFD")]
			[Address(RVA = "0x245B39C", Offset = "0x245B39C", VA = "0x245B39C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FFB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600ACFE")]
			[Address(RVA = "0x245B3A4", Offset = "0x245B3A4", VA = "0x245B3A4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600ACFB")]
		[Address(RVA = "0x244FEB4", Offset = "0x244FEB4", VA = "0x244FEB4")]
		public _003CSet3DUIpanel_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600ACFC")]
		[Address(RVA = "0x245B0E4", Offset = "0x245B0E4", VA = "0x245B0E4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600ACFF")]
		[Address(RVA = "0x245B3AC", Offset = "0x245B3AC", VA = "0x245B3AC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600AD00")]
		[Address(RVA = "0x245B3C0", Offset = "0x245B3C0", VA = "0x245B3C0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002112")]
	private sealed class _003CPlayProgressAnim_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400CF2C")]
		[FieldOffset(Offset = "0x8")]
		internal int _003Cmax_token_num_003E__0;

		[Token(Token = "0x400CF2D")]
		[FieldOffset(Offset = "0xC")]
		internal float _003Cstart_value_003E__0;

		[Token(Token = "0x400CF2E")]
		[FieldOffset(Offset = "0x10")]
		internal float _003Cend_value_003E__0;

		[Token(Token = "0x400CF2F")]
		[FieldOffset(Offset = "0x14")]
		internal int startPoint;

		[Token(Token = "0x400CF30")]
		[FieldOffset(Offset = "0x18")]
		internal int endPoint;

		[Token(Token = "0x400CF31")]
		[FieldOffset(Offset = "0x1C")]
		internal float _003CperTimeChange_003E__1;

		[Token(Token = "0x400CF32")]
		[FieldOffset(Offset = "0x20")]
		internal float _003Ccur_time_003E__1;

		[Token(Token = "0x400CF33")]
		[FieldOffset(Offset = "0x24")]
		internal UIGachalegendaryRampage4CContentController _0024this;

		[Token(Token = "0x400CF34")]
		[FieldOffset(Offset = "0x28")]
		internal object _0024current;

		[Token(Token = "0x400CF35")]
		[FieldOffset(Offset = "0x2C")]
		internal bool _0024disposing;

		[Token(Token = "0x400CF36")]
		[FieldOffset(Offset = "0x30")]
		internal int _0024PC;

		[Token(Token = "0x17000FFC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600AD03")]
			[Address(RVA = "0x245B038", Offset = "0x245B038", VA = "0x245B038", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FFD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600AD04")]
			[Address(RVA = "0x245B040", Offset = "0x245B040", VA = "0x245B040", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600AD01")]
		[Address(RVA = "0x2451398", Offset = "0x2451398", VA = "0x2451398")]
		public _003CPlayProgressAnim_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600AD02")]
		[Address(RVA = "0x245AA40", Offset = "0x245AA40", VA = "0x245AA40", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600AD05")]
		[Address(RVA = "0x245B048", Offset = "0x245B048", VA = "0x245B048", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600AD06")]
		[Address(RVA = "0x245B05C", Offset = "0x245B05C", VA = "0x245B05C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002113")]
	private sealed class _003CBagVFXCoroutine_003Ec__Iterator2 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400CF37")]
		[FieldOffset(Offset = "0x8")]
		internal float _003CmF1_003E__0;

		[Token(Token = "0x400CF38")]
		[FieldOffset(Offset = "0xC")]
		internal float _003CmF2_003E__0;

		[Token(Token = "0x400CF39")]
		[FieldOffset(Offset = "0x10")]
		internal float _003CtimeCounter_003E__0;

		[Token(Token = "0x400CF3A")]
		[FieldOffset(Offset = "0x14")]
		internal Vector3 _003CstartPos_003E__0;

		[Token(Token = "0x400CF3B")]
		[FieldOffset(Offset = "0x20")]
		internal Vector3 _003CendPos_003E__0;

		[Token(Token = "0x400CF3C")]
		[FieldOffset(Offset = "0x2C")]
		internal Vector3 _003Ccenter_003E__1;

		[Token(Token = "0x400CF3D")]
		[FieldOffset(Offset = "0x38")]
		internal Vector3 _003CriseRelCenter_003E__1;

		[Token(Token = "0x400CF3E")]
		[FieldOffset(Offset = "0x44")]
		internal Vector3 _003CsetRelCenter_003E__1;

		[Token(Token = "0x400CF3F")]
		[FieldOffset(Offset = "0x50")]
		internal UIGachalegendaryRampage4CContentController _0024this;

		[Token(Token = "0x400CF40")]
		[FieldOffset(Offset = "0x54")]
		internal object _0024current;

		[Token(Token = "0x400CF41")]
		[FieldOffset(Offset = "0x58")]
		internal bool _0024disposing;

		[Token(Token = "0x400CF42")]
		[FieldOffset(Offset = "0x5C")]
		internal int _0024PC;

		[Token(Token = "0x17000FFE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600AD09")]
			[Address(RVA = "0x245A8FC", Offset = "0x245A8FC", VA = "0x245A8FC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FFF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600AD0A")]
			[Address(RVA = "0x245A904", Offset = "0x245A904", VA = "0x245A904", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600AD07")]
		[Address(RVA = "0x2457E30", Offset = "0x2457E30", VA = "0x2457E30")]
		public _003CBagVFXCoroutine_003Ec__Iterator2()
		{
		}

		[Token(Token = "0x600AD08")]
		[Address(RVA = "0x24599C0", Offset = "0x24599C0", VA = "0x24599C0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600AD0B")]
		[Address(RVA = "0x245A90C", Offset = "0x245A90C", VA = "0x245A90C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600AD0C")]
		[Address(RVA = "0x245A920", Offset = "0x245A920", VA = "0x245A920", Slot = "6")]
		public void Reset()
		{
		}

		[Token(Token = "0x600AD0D")]
		[Address(RVA = "0x245A9A8", Offset = "0x245A9A8", VA = "0x245A9A8")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002114")]
	private sealed class _003CTokenVFXCoroutine_003Ec__Iterator3 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400CF43")]
		[FieldOffset(Offset = "0x8")]
		internal float _003CmF1_003E__0;

		[Token(Token = "0x400CF44")]
		[FieldOffset(Offset = "0xC")]
		internal float _003CmF2_003E__0;

		[Token(Token = "0x400CF45")]
		[FieldOffset(Offset = "0x10")]
		internal float _003CtimeCounter_003E__0;

		[Token(Token = "0x400CF46")]
		[FieldOffset(Offset = "0x14")]
		internal Vector3 _003CstartPos_003E__0;

		[Token(Token = "0x400CF47")]
		[FieldOffset(Offset = "0x20")]
		internal Vector3 _003CendPos_003E__0;

		[Token(Token = "0x400CF48")]
		[FieldOffset(Offset = "0x2C")]
		internal Vector3 _003Ccenter_003E__1;

		[Token(Token = "0x400CF49")]
		[FieldOffset(Offset = "0x38")]
		internal Vector3 _003CriseRelCenter_003E__1;

		[Token(Token = "0x400CF4A")]
		[FieldOffset(Offset = "0x44")]
		internal Vector3 _003CsetRelCenter_003E__1;

		[Token(Token = "0x400CF4B")]
		[FieldOffset(Offset = "0x50")]
		internal UIGachalegendaryRampage4CContentController _0024this;

		[Token(Token = "0x400CF4C")]
		[FieldOffset(Offset = "0x54")]
		internal object _0024current;

		[Token(Token = "0x400CF4D")]
		[FieldOffset(Offset = "0x58")]
		internal bool _0024disposing;

		[Token(Token = "0x400CF4E")]
		[FieldOffset(Offset = "0x5C")]
		internal int _0024PC;

		[Token(Token = "0x17001000")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600AD10")]
			[Address(RVA = "0x245BA7C", Offset = "0x245BA7C", VA = "0x245BA7C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001001")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600AD11")]
			[Address(RVA = "0x245BA84", Offset = "0x245BA84", VA = "0x245BA84", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600AD0E")]
		[Address(RVA = "0x2457E38", Offset = "0x2457E38", VA = "0x2457E38")]
		public _003CTokenVFXCoroutine_003Ec__Iterator3()
		{
		}

		[Token(Token = "0x600AD0F")]
		[Address(RVA = "0x245B448", Offset = "0x245B448", VA = "0x245B448", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600AD12")]
		[Address(RVA = "0x245BA8C", Offset = "0x245BA8C", VA = "0x245BA8C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600AD13")]
		[Address(RVA = "0x245BAA0", Offset = "0x245BAA0", VA = "0x245BAA0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400CF01")]
	[FieldOffset(Offset = "0x44")]
	private List<UICollectionVehicleSkinScoreItemController> m_VeicleSkinScoreList;

	[Token(Token = "0x400CF02")]
	[FieldOffset(Offset = "0x48")]
	private List<UICollectionScoreItemController> m_WeaponSkinScoreItemList;

	[Token(Token = "0x400CF03")]
	private const string DEFAULTBAGICONNAME = "UI_Rampage4C_Backpack";

	[Token(Token = "0x400CF04")]
	private const string BUBBLEGUIDEKEY = "BubbleGuideKey";

	[Token(Token = "0x400CF05")]
	private const uint m_GrowUpTime = 1u;

	[Token(Token = "0x400CF06")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_SpacingDistance;

	[Token(Token = "0x400CF07")]
	private const uint FIRSTCALIBRATIONLENGTH = 92u;

	[Token(Token = "0x400CF08")]
	private const uint THREEGACHAINTERVAL = 145u;

	[Token(Token = "0x400CF09")]
	private const uint FOURGACHAINTERVAL = 140u;

	[Token(Token = "0x400CF0A")]
	private const uint FIVEGACHAINTERVAL = 92u;

	[Token(Token = "0x400CF0B")]
	private const int PROGRESSHEIGHTWITHTHREEITEM = 460;

	[Token(Token = "0x400CF0C")]
	private const int PROGRESSHEIGHTWITHF0URITEM = 460;

	[Token(Token = "0x400CF0D")]
	private const int PROGRESSHEIGHTWITHFIVEITEM = 460;

	[Token(Token = "0x400CF0E")]
	[FieldOffset(Offset = "0x50")]
	private uint m_CurrentTokenNum;

	[Token(Token = "0x400CF0F")]
	[FieldOffset(Offset = "0x54")]
	private uint m_CurrentExchangingTokenNum;

	[Token(Token = "0x400CF10")]
	[FieldOffset(Offset = "0x58")]
	private uint m_CurrentExchangingGachaID;

	[Token(Token = "0x400CF11")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_DelayCallID;

	[Token(Token = "0x400CF12")]
	[FieldOffset(Offset = "0x60")]
	private bool m_IsLegendClothGacha;

	[Token(Token = "0x400CF13")]
	[FieldOffset(Offset = "0x64")]
	private UIGachalegendaryRampage4CContentView m_View;

	[Token(Token = "0x400CF14")]
	[FieldOffset(Offset = "0x68")]
	private UIModelGacha m_ModelGacha;

	[Token(Token = "0x400CF15")]
	[FieldOffset(Offset = "0x6C")]
	private CSSharedItemDataManager.StoreQuality m_CurrentDropQuality;

	[Token(Token = "0x400CF16")]
	[FieldOffset(Offset = "0x70")]
	private GachaLengendaryInfoData m_GachaInfoData;

	[Token(Token = "0x400CF17")]
	[FieldOffset(Offset = "0x74")]
	private UILegendDrawAnimPopWindowController m_AnimPopWnd;

	[Token(Token = "0x400CF18")]
	[FieldOffset(Offset = "0x78")]
	private GachaDesc m_GachaDesc;

	[Token(Token = "0x400CF19")]
	[FieldOffset(Offset = "0x7C")]
	private List<Transform> m_SpotPosTranList;

	[Token(Token = "0x400CF1A")]
	[FieldOffset(Offset = "0x80")]
	private List<Transform> m_ExtraItemTransList;

	[Token(Token = "0x400CF1B")]
	[FieldOffset(Offset = "0x84")]
	private List<UIGachaLengendaryRampage4CExtraListItemController> m_ExtraRewardList;

	[Token(Token = "0x400CF1C")]
	[FieldOffset(Offset = "0x88")]
	private GameObject m_LegendThemAnimObj;

	[Token(Token = "0x400CF1D")]
	[FieldOffset(Offset = "0x8C")]
	private GameObject m_LegendThemExchangeAnimObj;

	[Token(Token = "0x400CF1E")]
	[FieldOffset(Offset = "0x90")]
	private List<uint> m_NewTempBagList;

	[Token(Token = "0x400CF1F")]
	[FieldOffset(Offset = "0x94")]
	private Coroutine m_ProgressCoroutine;

	[Token(Token = "0x400CF20")]
	[FieldOffset(Offset = "0x98")]
	private List<ExchangedAward> Extra_rewards;

	[Token(Token = "0x400CF21")]
	[FieldOffset(Offset = "0x9C")]
	private UILegendGachaAdsController m_LegendGachaAds;

	[Token(Token = "0x400CF22")]
	[FieldOffset(Offset = "0xA0")]
	private uint m_BagVFXDelayCall;

	[Token(Token = "0x400CF23")]
	[FieldOffset(Offset = "0xA4")]
	private uint m_BagDescVFXDelayCall;

	[Token(Token = "0x400CF24")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<ExchangedAward, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400CF25")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<ExchangedAward, CommonRewardItemInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600AC97")]
	[Address(RVA = "0x244D290", Offset = "0x244D290", VA = "0x244D290")]
	public UIGachalegendaryRampage4CContentController()
	{
	}

	[Token(Token = "0x600AC98")]
	[Address(RVA = "0x244D438", Offset = "0x244D438", VA = "0x244D438")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AC99")]
	[Address(RVA = "0x244D4E0", Offset = "0x244D4E0", VA = "0x244D4E0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AC9A")]
	[Address(RVA = "0x244E840", Offset = "0x244E840", VA = "0x244E840", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600AC9B")]
	[Address(RVA = "0x244EF50", Offset = "0x244EF50", VA = "0x244EF50", Slot = "22")]
	public override void Hide()
	{
	}

	[Token(Token = "0x600AC9C")]
	[Address(RVA = "0x244EFB4", Offset = "0x244EFB4", VA = "0x244EFB4", Slot = "53")]
	public override Vector3 GetAvatarPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600AC9D")]
	[Address(RVA = "0x244F054", Offset = "0x244F054", VA = "0x244F054", Slot = "64")]
	public override void SetFrontendPreviewComponent(FrontEndPreviewComponent_Gacha frontEndPreviewComponent)
	{
	}

	[Token(Token = "0x600AC9E")]
	[Address(RVA = "0x244F3A0", Offset = "0x244F3A0", VA = "0x244F3A0", Slot = "42")]
	public override void OnSkipAnim()
	{
	}

	[Token(Token = "0x600AC9F")]
	[Address(RVA = "0x244FDE8", Offset = "0x244FDE8", VA = "0x244FDE8")]
	private IEnumerator Set3DUIpanel()
	{
		return null;
	}

	[Token(Token = "0x600ACA0")]
	[Address(RVA = "0x244FEBC", Offset = "0x244FEBC", VA = "0x244FEBC")]
	private Camera TryGetContent3DCamera()
	{
		return null;
	}

	[Token(Token = "0x600ACA1")]
	[Address(RVA = "0x244F0CC", Offset = "0x244F0CC", VA = "0x244F0CC")]
	private void RegisterPostEffectExtraCameras()
	{
	}

	[Token(Token = "0x600ACA2")]
	[Address(RVA = "0x244ECB8", Offset = "0x244ECB8", VA = "0x244ECB8")]
	private void UnRegisterPostEffectExtraCameras()
	{
	}

	[Token(Token = "0x600ACA3")]
	[Address(RVA = "0x244DC2C", Offset = "0x244DC2C", VA = "0x244DC2C")]
	private void SetInitialState()
	{
	}

	[Token(Token = "0x600ACA4")]
	[Address(RVA = "0x244FFF8", Offset = "0x244FFF8", VA = "0x244FFF8")]
	private void OnLegendAnimPopEnd(object[] data)
	{
	}

	[Token(Token = "0x600ACA5")]
	[Address(RVA = "0x2450198", Offset = "0x2450198", VA = "0x2450198", Slot = "33")]
	protected override void InitGachaContentBuyBtn()
	{
	}

	[Token(Token = "0x600ACA6")]
	[Address(RVA = "0x2450378", Offset = "0x2450378", VA = "0x2450378")]
	private void ProcessAnimEvt(object[] data)
	{
	}

	[Token(Token = "0x600ACA7")]
	[Address(RVA = "0x2450640", Offset = "0x2450640", VA = "0x2450640")]
	private void ShowBubble()
	{
	}

	[Token(Token = "0x600ACA8")]
	[Address(RVA = "0x2450A74", Offset = "0x2450A74", VA = "0x2450A74")]
	private bool HasSpecialToken()
	{
		return default(bool);
	}

	[Token(Token = "0x600ACA9")]
	[Address(RVA = "0x2450AE8", Offset = "0x2450AE8", VA = "0x2450AE8")]
	private bool OnlyHasSpecialToken()
	{
		return default(bool);
	}

	[Token(Token = "0x600ACAA")]
	[Address(RVA = "0x2450B5C", Offset = "0x2450B5C", VA = "0x2450B5C")]
	private bool HasSpecialTokenMoreThanOne()
	{
		return default(bool);
	}

	[Token(Token = "0x600ACAB")]
	[Address(RVA = "0x2450BD0", Offset = "0x2450BD0", VA = "0x2450BD0", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600ACAC")]
	[Address(RVA = "0x2450D58", Offset = "0x2450D58", VA = "0x2450D58")]
	public void PlayLengendaryAnim(string anim)
	{
	}

	[Token(Token = "0x600ACAD")]
	[Address(RVA = "0x2450E98", Offset = "0x2450E98", VA = "0x2450E98")]
	private void RefreshProgressValue()
	{
	}

	[Token(Token = "0x600ACAE")]
	[Address(RVA = "0x2451280", Offset = "0x2451280", VA = "0x2451280")]
	private IEnumerator PlayProgressAnim(int startPoint, int endPoint)
	{
		return null;
	}

	[Token(Token = "0x600ACAF")]
	[Address(RVA = "0x244DEA4", Offset = "0x244DEA4", VA = "0x244DEA4")]
	private void SetProgressBarValue(float value)
	{
	}

	[Token(Token = "0x600ACB0")]
	[Address(RVA = "0x24513A0", Offset = "0x24513A0", VA = "0x24513A0")]
	private void OnPreviewClothBtnClick()
	{
	}

	[Token(Token = "0x600ACB1")]
	[Address(RVA = "0x24515DC", Offset = "0x24515DC", VA = "0x24515DC")]
	private void OnBagBtnClick()
	{
	}

	[Token(Token = "0x600ACB2")]
	[Address(RVA = "0x2451970", Offset = "0x2451970", VA = "0x2451970")]
	private void RefreshBagNum(bool hasDraw = false)
	{
	}

	[Token(Token = "0x600ACB3")]
	[Address(RVA = "0x2451AD4", Offset = "0x2451AD4", VA = "0x2451AD4")]
	private void OnBagBtnClickEvent(object[] data)
	{
	}

	[Token(Token = "0x600ACB4")]
	[Address(RVA = "0x2451BC0", Offset = "0x2451BC0", VA = "0x2451BC0")]
	private void OnLuckProgressClick()
	{
	}

	[Token(Token = "0x600ACB5")]
	[Address(RVA = "0x2451ED0", Offset = "0x2451ED0", VA = "0x2451ED0")]
	private void RefreshCountDownLabel()
	{
	}

	[Token(Token = "0x600ACB6")]
	[Address(RVA = "0x24520B4", Offset = "0x24520B4", VA = "0x24520B4")]
	private void RefreshTokenNum()
	{
	}

	[Token(Token = "0x600ACB7")]
	[Address(RVA = "0x2452568", Offset = "0x2452568", VA = "0x2452568")]
	private void RefreshTokenSprite()
	{
	}

	[Token(Token = "0x600ACB8")]
	[Address(RVA = "0x2452978", Offset = "0x2452978", VA = "0x2452978")]
	private void RefreshProgressBarValueOnShowContent()
	{
	}

	[Token(Token = "0x600ACB9")]
	[Address(RVA = "0x2452C40", Offset = "0x2452C40", VA = "0x2452C40")]
	private void RefreshStyle()
	{
	}

	[Token(Token = "0x600ACBA")]
	[Address(RVA = "0x24530F4", Offset = "0x24530F4", VA = "0x24530F4")]
	public void SetCDNTitle()
	{
	}

	[Token(Token = "0x600ACBB")]
	[Address(RVA = "0x2453290", Offset = "0x2453290", VA = "0x2453290")]
	private void OnLegendGachaAdsClick(object[] data)
	{
	}

	[Token(Token = "0x600ACBC")]
	[Address(RVA = "0x2453314", Offset = "0x2453314", VA = "0x2453314")]
	private void OnClickRewardPoolBtn()
	{
	}

	[Token(Token = "0x600ACBD")]
	[Address(RVA = "0x245344C", Offset = "0x245344C", VA = "0x245344C", Slot = "54")]
	public override UIWidget GetPreviewSceneBorder(uint gachaID)
	{
		return null;
	}

	[Token(Token = "0x600ACBE")]
	[Address(RVA = "0x24534C4", Offset = "0x24534C4", VA = "0x24534C4", Slot = "56")]
	public override FrontendPreviewType GetFrontendPreviewType(uint gachaID)
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x600ACBF")]
	[Address(RVA = "0x2453528", Offset = "0x2453528", VA = "0x2453528", Slot = "55")]
	public override UIGachaCustomizedPreviewUIData GetCustomizedPreviewUIPosition()
	{
		return null;
	}

	[Token(Token = "0x600ACC0")]
	[Address(RVA = "0x245360C", Offset = "0x245360C", VA = "0x245360C", Slot = "41")]
	public override void OnPurchaseResult(bool isSuccess)
	{
	}

	[Token(Token = "0x600ACC1")]
	[Address(RVA = "0x24540BC", Offset = "0x24540BC", VA = "0x24540BC", Slot = "34")]
	protected override void OnRefreshUIView()
	{
	}

	[Token(Token = "0x600ACC2")]
	[Address(RVA = "0x2456988", Offset = "0x2456988", VA = "0x2456988", Slot = "38")]
	public override void OnHideContent()
	{
	}

	[Token(Token = "0x600ACC3")]
	[Address(RVA = "0x2456BEC", Offset = "0x2456BEC", VA = "0x2456BEC", Slot = "39")]
	public override void OnShowContent()
	{
	}

	[Token(Token = "0x600ACC4")]
	[Address(RVA = "0x2456CC8", Offset = "0x2456CC8", VA = "0x2456CC8", Slot = "52")]
	public override void OnRecoverPreview()
	{
	}

	[Token(Token = "0x600ACC5")]
	[Address(RVA = "0x244F8CC", Offset = "0x244F8CC", VA = "0x244F8CC")]
	public void ShowDrawResult(UIModelGacha.GachaDrawType dType, bool enableAnim = true)
	{
	}

	[Token(Token = "0x600ACC6")]
	[Address(RVA = "0x245717C", Offset = "0x245717C", VA = "0x245717C")]
	private void ShowExchangeResultWnd(object[] data)
	{
	}

	[Token(Token = "0x600ACC7")]
	[Address(RVA = "0x245769C", Offset = "0x245769C", VA = "0x245769C")]
	private void OnCloseCommonRewardWindow(object[] param)
	{
	}

	[Token(Token = "0x600ACC8")]
	[Address(RVA = "0x2457B2C", Offset = "0x2457B2C", VA = "0x2457B2C")]
	private void OnItemBagPackClose(object[] param)
	{
	}

	[Token(Token = "0x600ACC9")]
	[Address(RVA = "0x2457A9C", Offset = "0x2457A9C", VA = "0x2457A9C")]
	private void ResetInfoState()
	{
	}

	[Token(Token = "0x600ACCA")]
	[Address(RVA = "0x2457A1C", Offset = "0x2457A1C", VA = "0x2457A1C")]
	private void ShowTokenVfx()
	{
	}

	[Token(Token = "0x600ACCB")]
	[Address(RVA = "0x2457854", Offset = "0x2457854", VA = "0x2457854")]
	private void ShowBagVfx()
	{
	}

	[Token(Token = "0x600ACCC")]
	[Address(RVA = "0x2457D64", Offset = "0x2457D64", VA = "0x2457D64")]
	private IEnumerator BagVFXCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600ACCD")]
	[Address(RVA = "0x2457C98", Offset = "0x2457C98", VA = "0x2457C98")]
	private IEnumerator TokenVFXCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600ACCE")]
	[Address(RVA = "0x2453CCC", Offset = "0x2453CCC", VA = "0x2453CCC")]
	private void BeginPlayDrawAnim()
	{
	}

	[Token(Token = "0x600ACCF")]
	[Address(RVA = "0x2458090", Offset = "0x2458090", VA = "0x2458090")]
	private void PlayNormalAnim()
	{
	}

	[Token(Token = "0x600ACD0")]
	[Address(RVA = "0x24582C8", Offset = "0x24582C8", VA = "0x24582C8")]
	private void EndPlayDropBoxDrawAnim()
	{
	}

	[Token(Token = "0x600ACD1")]
	[Address(RVA = "0x2457E40", Offset = "0x2457E40", VA = "0x2457E40")]
	private void PlayLegendThemeAnim()
	{
	}

	[Token(Token = "0x600ACD2")]
	[Address(RVA = "0x2458358", Offset = "0x2458358", VA = "0x2458358")]
	private ResourceID GetLegendDrawAnimResId()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600ACD3")]
	[Address(RVA = "0x24584BC", Offset = "0x24584BC", VA = "0x24584BC")]
	private void EndPlayLegendThemeAnim()
	{
	}

	[Token(Token = "0x600ACD4")]
	[Address(RVA = "0x2456D38", Offset = "0x2456D38", VA = "0x2456D38")]
	private void OnEndPlayDrawAnim()
	{
	}

	[Token(Token = "0x600ACD5")]
	[Address(RVA = "0x244E334", Offset = "0x244E334", VA = "0x244E334")]
	private void InitExtraRewardItems()
	{
	}

	[Token(Token = "0x600ACD6")]
	[Address(RVA = "0x244F5BC", Offset = "0x244F5BC", VA = "0x244F5BC")]
	private void OnExchangeAnimInterfaceMaskClick()
	{
	}

	[Token(Token = "0x600ACD7")]
	[Address(RVA = "0x24543EC", Offset = "0x24543EC", VA = "0x24543EC")]
	public void RefreshExtraRewardList(uint chestID)
	{
	}

	[Token(Token = "0x600ACD8")]
	[Address(RVA = "0x2458614", Offset = "0x2458614", VA = "0x2458614")]
	private void OnShowExchangeAnim(object[] data)
	{
	}

	[Token(Token = "0x600ACD9")]
	[Address(RVA = "0x245517C", Offset = "0x245517C", VA = "0x245517C")]
	private void RefreshGachaAds()
	{
	}

	[Token(Token = "0x600ACDA")]
	[Address(RVA = "0x244DF3C", Offset = "0x244DF3C", VA = "0x244DF3C")]
	private void InitPosTransList()
	{
	}

	[Token(Token = "0x600ACDB")]
	[Address(RVA = "0x244E138", Offset = "0x244E138", VA = "0x244E138")]
	private void InitTransList()
	{
	}

	[Token(Token = "0x600ACDC")]
	[Address(RVA = "0x2458DF0", Offset = "0x2458DF0", VA = "0x2458DF0", Slot = "59")]
	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600ACDD")]
	[Address(RVA = "0x2458E84", Offset = "0x2458E84", VA = "0x2458E84", Slot = "58")]
	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600ACDE")]
	[Address(RVA = "0x2459130", Offset = "0x2459130", VA = "0x2459130")]
	public void ClearCache()
	{
	}

	[Token(Token = "0x600ACDF")]
	[Address(RVA = "0x24592DC", Offset = "0x24592DC", VA = "0x24592DC", Slot = "62")]
	public override string GetTutorialWndTitleKey()
	{
		return null;
	}

	[Token(Token = "0x600ACE0")]
	[Address(RVA = "0x2454F74", Offset = "0x2454F74", VA = "0x2454F74")]
	private void RefreshNewTip()
	{
	}

	[Token(Token = "0x600ACE1")]
	[Address(RVA = "0x244E4C4", Offset = "0x244E4C4", VA = "0x244E4C4")]
	private void InitWeaponScoreItem()
	{
	}

	[Token(Token = "0x600ACE2")]
	[Address(RVA = "0x2459380", Offset = "0x2459380", VA = "0x2459380")]
	private void OnPropertyBtnClick()
	{
	}

	[Token(Token = "0x600ACE3")]
	[Address(RVA = "0x2459580", Offset = "0x2459580", VA = "0x2459580", Slot = "63")]
	public override void OnGachaSceneShowTypeChange(UIGachaSceneShowType type)
	{
	}

	[Token(Token = "0x600ACE4")]
	[Address(RVA = "0x2455554", Offset = "0x2455554", VA = "0x2455554")]
	private void RefreshShowWeaponOrVehicle()
	{
	}

	[Token(Token = "0x600ACE5")]
	[Address(RVA = "0x2459658", Offset = "0x2459658", VA = "0x2459658")]
	private void _003CShowBubble_003Em__0()
	{
	}

	[Token(Token = "0x600ACE6")]
	[Address(RVA = "0x24596BC", Offset = "0x24596BC", VA = "0x24596BC")]
	private void _003CShowBubble_003Em__1()
	{
	}

	[Token(Token = "0x600ACE7")]
	[Address(RVA = "0x245977C", Offset = "0x245977C", VA = "0x245977C")]
	private static CommonRewardItemInfo _003CShowDrawResult_003Em__2(ExchangedAward item)
	{
		return null;
	}

	[Token(Token = "0x600ACE8")]
	[Address(RVA = "0x2459784", Offset = "0x2459784", VA = "0x2459784")]
	private static CommonRewardItemInfo _003CShowExchangeResultWnd_003Em__3(ExchangedAward item)
	{
		return null;
	}

	[Token(Token = "0x600ACE9")]
	[Address(RVA = "0x245978C", Offset = "0x245978C", VA = "0x245978C")]
	private void _003CShowExchangeResultWnd_003Em__4()
	{
	}

	[Token(Token = "0x600ACEA")]
	[Address(RVA = "0x2459914", Offset = "0x2459914", VA = "0x2459914")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600ACEB")]
	[Address(RVA = "0x245991C", Offset = "0x245991C", VA = "0x245991C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600ACEC")]
	[Address(RVA = "0x2459924", Offset = "0x2459924", VA = "0x2459924")]
	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	[Token(Token = "0x600ACED")]
	[Address(RVA = "0x245992C", Offset = "0x245992C", VA = "0x245992C")]
	public Vector3 _003C_003EiFixBaseProxy_GetAvatarPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600ACEE")]
	[Address(RVA = "0x2459940", Offset = "0x2459940", VA = "0x2459940")]
	public void _003C_003EiFixBaseProxy_SetFrontendPreviewComponent(FrontEndPreviewComponent_Gacha P0)
	{
	}

	[Token(Token = "0x600ACEF")]
	[Address(RVA = "0x2459948", Offset = "0x2459948", VA = "0x2459948")]
	public void _003C_003EiFixBaseProxy_OnSkipAnim()
	{
	}

	[Token(Token = "0x600ACF0")]
	[Address(RVA = "0x2459950", Offset = "0x2459950", VA = "0x2459950")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600ACF1")]
	[Address(RVA = "0x2459958", Offset = "0x2459958", VA = "0x2459958")]
	public UIWidget _003C_003EiFixBaseProxy_GetPreviewSceneBorder(uint P0)
	{
		return null;
	}

	[Token(Token = "0x600ACF2")]
	[Address(RVA = "0x2459960", Offset = "0x2459960", VA = "0x2459960")]
	public FrontendPreviewType _003C_003EiFixBaseProxy_GetFrontendPreviewType(uint P0)
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x600ACF3")]
	[Address(RVA = "0x2459968", Offset = "0x2459968", VA = "0x2459968")]
	public UIGachaCustomizedPreviewUIData _003C_003EiFixBaseProxy_GetCustomizedPreviewUIPosition()
	{
		return null;
	}

	[Token(Token = "0x600ACF4")]
	[Address(RVA = "0x2459970", Offset = "0x2459970", VA = "0x2459970")]
	public void _003C_003EiFixBaseProxy_OnPurchaseResult(bool P0)
	{
	}

	[Token(Token = "0x600ACF5")]
	[Address(RVA = "0x2459978", Offset = "0x2459978", VA = "0x2459978")]
	public void _003C_003EiFixBaseProxy_OnHideContent()
	{
	}

	[Token(Token = "0x600ACF6")]
	[Address(RVA = "0x2459980", Offset = "0x2459980", VA = "0x2459980")]
	public void _003C_003EiFixBaseProxy_OnShowContent()
	{
	}

	[Token(Token = "0x600ACF7")]
	[Address(RVA = "0x2459988", Offset = "0x2459988", VA = "0x2459988")]
	public void _003C_003EiFixBaseProxy_OnRecoverPreview()
	{
	}

	[Token(Token = "0x600ACF8")]
	[Address(RVA = "0x2459990", Offset = "0x2459990", VA = "0x2459990")]
	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return default(uint);
	}

	[Token(Token = "0x600ACF9")]
	[Address(RVA = "0x2459998", Offset = "0x2459998", VA = "0x2459998")]
	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}

	[Token(Token = "0x600ACFA")]
	[Address(RVA = "0x24599B8", Offset = "0x24599B8", VA = "0x24599B8")]
	public void _003C_003EiFixBaseProxy_OnGachaSceneShowTypeChange(UIGachaSceneShowType P0)
	{
	}
}
