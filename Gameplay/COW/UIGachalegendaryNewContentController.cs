using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002641")]
public class UIGachalegendaryNewContentController : UIGachaContentBase, _Attribute
{
	[Token(Token = "0x2002642")]
	private sealed class _003CInitShowOptionalDownloadInfo_003Ec__AnonStorey3
	{
		[Token(Token = "0x400EC46")]
		[FieldOffset(Offset = "0x8")]
		internal List<ResourceID> resList;

		[Token(Token = "0x400EC47")]
		[FieldOffset(Offset = "0xC")]
		internal UIGachalegendaryNewContentController _0024this;

		[Token(Token = "0x600E43E")]
		[Address(RVA = "0x244AE40", Offset = "0x244AE40", VA = "0x244AE40")]
		public _003CInitShowOptionalDownloadInfo_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x600E43F")]
		[Address(RVA = "0x244AE48", Offset = "0x244AE48", VA = "0x244AE48")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002643")]
	private sealed class _003CPlayProgressAnim_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400EC48")]
		[FieldOffset(Offset = "0x8")]
		internal int _003Cmax_token_num_003E__0;

		[Token(Token = "0x400EC49")]
		[FieldOffset(Offset = "0xC")]
		internal float _003Cstart_value_003E__0;

		[Token(Token = "0x400EC4A")]
		[FieldOffset(Offset = "0x10")]
		internal float _003Cend_value_003E__0;

		[Token(Token = "0x400EC4B")]
		[FieldOffset(Offset = "0x14")]
		internal int startPoint;

		[Token(Token = "0x400EC4C")]
		[FieldOffset(Offset = "0x18")]
		internal int endPoint;

		[Token(Token = "0x400EC4D")]
		[FieldOffset(Offset = "0x1C")]
		internal float _003CperTimeChange_003E__1;

		[Token(Token = "0x400EC4E")]
		[FieldOffset(Offset = "0x20")]
		internal float _003Ccur_time_003E__1;

		[Token(Token = "0x400EC4F")]
		[FieldOffset(Offset = "0x24")]
		internal UIGachalegendaryNewContentController _0024this;

		[Token(Token = "0x400EC50")]
		[FieldOffset(Offset = "0x28")]
		internal object _0024current;

		[Token(Token = "0x400EC51")]
		[FieldOffset(Offset = "0x2C")]
		internal bool _0024disposing;

		[Token(Token = "0x400EC52")]
		[FieldOffset(Offset = "0x30")]
		internal int _0024PC;

		[Token(Token = "0x17001174")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600E442")]
			[Address(RVA = "0x244B6EC", Offset = "0x244B6EC", VA = "0x244B6EC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001175")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600E443")]
			[Address(RVA = "0x244B6F4", Offset = "0x244B6F4", VA = "0x244B6F4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600E440")]
		[Address(RVA = "0x244B190", Offset = "0x244B190", VA = "0x244B190")]
		public _003CPlayProgressAnim_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600E441")]
		[Address(RVA = "0x244B198", Offset = "0x244B198", VA = "0x244B198", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600E444")]
		[Address(RVA = "0x244B6FC", Offset = "0x244B6FC", VA = "0x244B6FC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600E445")]
		[Address(RVA = "0x244B710", Offset = "0x244B710", VA = "0x244B710", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002644")]
	private sealed class _003CBagVFXCoroutine_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400EC53")]
		[FieldOffset(Offset = "0x8")]
		internal float _003CmF1_003E__0;

		[Token(Token = "0x400EC54")]
		[FieldOffset(Offset = "0xC")]
		internal float _003CmF2_003E__0;

		[Token(Token = "0x400EC55")]
		[FieldOffset(Offset = "0x10")]
		internal float _003CtimeCounter_003E__0;

		[Token(Token = "0x400EC56")]
		[FieldOffset(Offset = "0x14")]
		internal Vector3 _003CstartPos_003E__0;

		[Token(Token = "0x400EC57")]
		[FieldOffset(Offset = "0x20")]
		internal Vector3 _003CendPos_003E__0;

		[Token(Token = "0x400EC58")]
		[FieldOffset(Offset = "0x2C")]
		internal Vector3 _003Ccenter_003E__1;

		[Token(Token = "0x400EC59")]
		[FieldOffset(Offset = "0x38")]
		internal Vector3 _003CriseRelCenter_003E__1;

		[Token(Token = "0x400EC5A")]
		[FieldOffset(Offset = "0x44")]
		internal Vector3 _003CsetRelCenter_003E__1;

		[Token(Token = "0x400EC5B")]
		[FieldOffset(Offset = "0x50")]
		internal UIGachalegendaryNewContentController _0024this;

		[Token(Token = "0x400EC5C")]
		[FieldOffset(Offset = "0x54")]
		internal object _0024current;

		[Token(Token = "0x400EC5D")]
		[FieldOffset(Offset = "0x58")]
		internal bool _0024disposing;

		[Token(Token = "0x400EC5E")]
		[FieldOffset(Offset = "0x5C")]
		internal int _0024PC;

		[Token(Token = "0x17001176")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600E448")]
			[Address(RVA = "0x244ACFC", Offset = "0x244ACFC", VA = "0x244ACFC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001177")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600E449")]
			[Address(RVA = "0x244AD04", Offset = "0x244AD04", VA = "0x244AD04", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600E446")]
		[Address(RVA = "0x2449E90", Offset = "0x2449E90", VA = "0x2449E90")]
		public _003CBagVFXCoroutine_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600E447")]
		[Address(RVA = "0x2449E98", Offset = "0x2449E98", VA = "0x2449E98", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600E44A")]
		[Address(RVA = "0x244AD0C", Offset = "0x244AD0C", VA = "0x244AD0C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600E44B")]
		[Address(RVA = "0x244AD20", Offset = "0x244AD20", VA = "0x244AD20", Slot = "6")]
		public void Reset()
		{
		}

		[Token(Token = "0x600E44C")]
		[Address(RVA = "0x244ADA8", Offset = "0x244ADA8", VA = "0x244ADA8")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002645")]
	private sealed class _003CTokenVFXCoroutine_003Ec__Iterator2 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400EC5F")]
		[FieldOffset(Offset = "0x8")]
		internal float _003CmF1_003E__0;

		[Token(Token = "0x400EC60")]
		[FieldOffset(Offset = "0xC")]
		internal float _003CmF2_003E__0;

		[Token(Token = "0x400EC61")]
		[FieldOffset(Offset = "0x10")]
		internal float _003CtimeCounter_003E__0;

		[Token(Token = "0x400EC62")]
		[FieldOffset(Offset = "0x14")]
		internal Vector3 _003CstartPos_003E__0;

		[Token(Token = "0x400EC63")]
		[FieldOffset(Offset = "0x20")]
		internal Vector3 _003CendPos_003E__0;

		[Token(Token = "0x400EC64")]
		[FieldOffset(Offset = "0x2C")]
		internal Vector3 _003Ccenter_003E__1;

		[Token(Token = "0x400EC65")]
		[FieldOffset(Offset = "0x38")]
		internal Vector3 _003CriseRelCenter_003E__1;

		[Token(Token = "0x400EC66")]
		[FieldOffset(Offset = "0x44")]
		internal Vector3 _003CsetRelCenter_003E__1;

		[Token(Token = "0x400EC67")]
		[FieldOffset(Offset = "0x50")]
		internal UIGachalegendaryNewContentController _0024this;

		[Token(Token = "0x400EC68")]
		[FieldOffset(Offset = "0x54")]
		internal object _0024current;

		[Token(Token = "0x400EC69")]
		[FieldOffset(Offset = "0x58")]
		internal bool _0024disposing;

		[Token(Token = "0x400EC6A")]
		[FieldOffset(Offset = "0x5C")]
		internal int _0024PC;

		[Token(Token = "0x17001178")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600E44F")]
			[Address(RVA = "0x244BDD4", Offset = "0x244BDD4", VA = "0x244BDD4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001179")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600E450")]
			[Address(RVA = "0x244BDDC", Offset = "0x244BDDC", VA = "0x244BDDC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600E44D")]
		[Address(RVA = "0x244B798", Offset = "0x244B798", VA = "0x244B798")]
		public _003CTokenVFXCoroutine_003Ec__Iterator2()
		{
		}

		[Token(Token = "0x600E44E")]
		[Address(RVA = "0x244B7A0", Offset = "0x244B7A0", VA = "0x244B7A0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600E451")]
		[Address(RVA = "0x244BDE4", Offset = "0x244BDE4", VA = "0x244BDE4", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600E452")]
		[Address(RVA = "0x244BDF8", Offset = "0x244BDF8", VA = "0x244BDF8", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400EC21")]
	[FieldOffset(Offset = "0x44")]
	private List<UICollectionVehicleSkinScoreItemController> m_VeicleSkinScoreList;

	[Token(Token = "0x400EC22")]
	[FieldOffset(Offset = "0x48")]
	private List<UICollectionScoreItemController> m_WeaponSkinScoreItemList;

	[Token(Token = "0x400EC23")]
	private const string DEFAULTBAGICONNAME = "FF_UI_Lottery_Bag_Normal";

	[Token(Token = "0x400EC24")]
	private const string BUBBLEGUIDEKEY = "BubbleGuideKey";

	[Token(Token = "0x400EC25")]
	private const uint m_GrowUpTime = 1u;

	[Token(Token = "0x400EC26")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_SpacingDistance;

	[Token(Token = "0x400EC27")]
	private const uint FIRSTCALIBRATIONLENGTH = 45u;

	[Token(Token = "0x400EC28")]
	private const uint THREEGACHAINTERVAL = 145u;

	[Token(Token = "0x400EC29")]
	private const uint FOURGACHAINTERVAL = 140u;

	[Token(Token = "0x400EC2A")]
	private const uint FIVEGACHAINTERVAL = 120u;

	[Token(Token = "0x400EC2B")]
	private const int PROGRESSHEIGHTWITHTHREEITEM = 335;

	[Token(Token = "0x400EC2C")]
	private const int PROGRESSHEIGHTWITHF0URITEM = 465;

	[Token(Token = "0x400EC2D")]
	private const int PROGRESSHEIGHTWITHFIVEITEM = 525;

	[Token(Token = "0x400EC2E")]
	[FieldOffset(Offset = "0x50")]
	private uint m_CurrentTokenNum;

	[Token(Token = "0x400EC2F")]
	[FieldOffset(Offset = "0x54")]
	private uint m_CurrentExchangingTokenNum;

	[Token(Token = "0x400EC30")]
	[FieldOffset(Offset = "0x58")]
	private uint m_CurrentExchangingGachaID;

	[Token(Token = "0x400EC31")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_DelayCallID;

	[Token(Token = "0x400EC32")]
	[FieldOffset(Offset = "0x60")]
	private bool m_IsLegendClothGacha;

	[Token(Token = "0x400EC33")]
	[FieldOffset(Offset = "0x64")]
	private UIGachalegendaryNewContentView m_View;

	[Token(Token = "0x400EC34")]
	[FieldOffset(Offset = "0x68")]
	private UIModelGacha m_ModelGacha;

	[Token(Token = "0x400EC35")]
	[FieldOffset(Offset = "0x6C")]
	private CSSharedItemDataManager.StoreQuality m_CurrentDropQuality;

	[Token(Token = "0x400EC36")]
	[FieldOffset(Offset = "0x70")]
	private GachaLengendaryInfoData m_GachaInfoData;

	[Token(Token = "0x400EC37")]
	[FieldOffset(Offset = "0x74")]
	private UILegendDrawAnimPopWindowController m_AnimPopWnd;

	[Token(Token = "0x400EC38")]
	[FieldOffset(Offset = "0x78")]
	private GachaDesc m_GachaDesc;

	[Token(Token = "0x400EC39")]
	[FieldOffset(Offset = "0x7C")]
	private List<Transform> m_SpotPosTranList;

	[Token(Token = "0x400EC3A")]
	[FieldOffset(Offset = "0x80")]
	private List<Transform> m_ExtraItemTransList;

	[Token(Token = "0x400EC3B")]
	[FieldOffset(Offset = "0x84")]
	private List<Transform> m_SpotSpriteTranList;

	[Token(Token = "0x400EC3C")]
	[FieldOffset(Offset = "0x88")]
	private List<UIGachaLengendaryExtraListItemController> m_ExtraRewardList;

	[Token(Token = "0x400EC3D")]
	[FieldOffset(Offset = "0x8C")]
	private GameObject m_LegendThemAnimObj;

	[Token(Token = "0x400EC3E")]
	[FieldOffset(Offset = "0x90")]
	private GameObject m_LegendThemExchangeAnimObj;

	[Token(Token = "0x400EC3F")]
	[FieldOffset(Offset = "0x94")]
	private List<uint> m_NewTempBagList;

	[Token(Token = "0x400EC40")]
	[FieldOffset(Offset = "0x98")]
	private Coroutine m_ProgressCoroutine;

	[Token(Token = "0x400EC41")]
	[FieldOffset(Offset = "0x9C")]
	private List<ExchangedAward> Extra_rewards;

	[Token(Token = "0x400EC42")]
	[FieldOffset(Offset = "0xA0")]
	private UILegendGachaAdsController m_LegendGachaAds;

	[Token(Token = "0x400EC43")]
	[FieldOffset(Offset = "0xA4")]
	private uint m_BagVFXDelayCall;

	[Token(Token = "0x400EC44")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<ExchangedAward, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400EC45")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<ExchangedAward, CommonRewardItemInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600E3E0")]
	[Address(RVA = "0x2EA9DEC", Offset = "0x2EA9DEC", VA = "0x2EA9DEC")]
	public UIGachalegendaryNewContentController()
	{
	}

	[Token(Token = "0x600E3E1")]
	[Address(RVA = "0x2EA9FAC", Offset = "0x2EA9FAC", VA = "0x2EA9FAC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E3E2")]
	[Address(RVA = "0x2EAA050", Offset = "0x2EAA050", VA = "0x2EAA050", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E3E3")]
	[Address(RVA = "0x2EAB5B4", Offset = "0x2EAB5B4", VA = "0x2EAB5B4", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600E3E4")]
	[Address(RVA = "0x2EABA24", Offset = "0x2EABA24", VA = "0x2EABA24", Slot = "22")]
	public override void Hide()
	{
	}

	[Token(Token = "0x600E3E5")]
	[Address(RVA = "0x2EABA88", Offset = "0x2EABA88", VA = "0x2EABA88", Slot = "53")]
	public override Vector3 GetAvatarPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600E3E6")]
	[Address(RVA = "0x2EABB28", Offset = "0x2EABB28", VA = "0x2EABB28", Slot = "42")]
	public override void OnSkipAnim()
	{
	}

	[Token(Token = "0x600E3E7")]
	[Address(RVA = "0x2EAA7A4", Offset = "0x2EAA7A4", VA = "0x2EAA7A4")]
	private void SetInitialState()
	{
	}

	[Token(Token = "0x600E3E8")]
	[Address(RVA = "0x2EAC570", Offset = "0x2EAC570", VA = "0x2EAC570", Slot = "35")]
	public override void InitShowOptionalDownloadInfo(List<ResourceID> resList)
	{
	}

	[Token(Token = "0x600E3E9")]
	[Address(RVA = "0x2EAC864", Offset = "0x2EAC864", VA = "0x2EAC864")]
	private void OnLegendAnimPopEnd(object[] data)
	{
	}

	[Token(Token = "0x600E3EA")]
	[Address(RVA = "0x2EACA04", Offset = "0x2EACA04", VA = "0x2EACA04", Slot = "33")]
	protected override void InitGachaContentBuyBtn()
	{
	}

	[Token(Token = "0x600E3EB")]
	[Address(RVA = "0x2EACBE4", Offset = "0x2EACBE4", VA = "0x2EACBE4")]
	private void ProcessAnimEvt(object[] data)
	{
	}

	[Token(Token = "0x600E3EC")]
	[Address(RVA = "0x2EACEAC", Offset = "0x2EACEAC", VA = "0x2EACEAC")]
	private void ShowBubble()
	{
	}

	[Token(Token = "0x600E3ED")]
	[Address(RVA = "0x2EAD168", Offset = "0x2EAD168", VA = "0x2EAD168")]
	private bool HasSpecialToken()
	{
		return default(bool);
	}

	[Token(Token = "0x600E3EE")]
	[Address(RVA = "0x2EAD1DC", Offset = "0x2EAD1DC", VA = "0x2EAD1DC")]
	private bool OnlyHasSpecialToken()
	{
		return default(bool);
	}

	[Token(Token = "0x600E3EF")]
	[Address(RVA = "0x2EAD250", Offset = "0x2EAD250", VA = "0x2EAD250")]
	private bool HasSpecialTokenMoreThanOne()
	{
		return default(bool);
	}

	[Token(Token = "0x600E3F0")]
	[Address(RVA = "0x2EAD2C4", Offset = "0x2EAD2C4", VA = "0x2EAD2C4", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E3F1")]
	[Address(RVA = "0x2EAD3D8", Offset = "0x2EAD3D8", VA = "0x2EAD3D8")]
	public void PlayLengendaryAnim(string anim)
	{
	}

	[Token(Token = "0x600E3F2")]
	[Address(RVA = "0x2EAD518", Offset = "0x2EAD518", VA = "0x2EAD518")]
	private void RefreshProgressValue()
	{
	}

	[Token(Token = "0x600E3F3")]
	[Address(RVA = "0x2EAD900", Offset = "0x2EAD900", VA = "0x2EAD900")]
	private IEnumerator PlayProgressAnim(int startPoint, int endPoint)
	{
		return null;
	}

	[Token(Token = "0x600E3F4")]
	[Address(RVA = "0x2EAAA1C", Offset = "0x2EAAA1C", VA = "0x2EAAA1C")]
	private void SetProgressBarValue(float value)
	{
	}

	[Token(Token = "0x600E3F5")]
	[Address(RVA = "0x2EADA18", Offset = "0x2EADA18", VA = "0x2EADA18")]
	private void OnPreviewClothBtnClick()
	{
	}

	[Token(Token = "0x600E3F6")]
	[Address(RVA = "0x2EADC54", Offset = "0x2EADC54", VA = "0x2EADC54")]
	private void OnBagBtnClick()
	{
	}

	[Token(Token = "0x600E3F7")]
	[Address(RVA = "0x2EADFE8", Offset = "0x2EADFE8", VA = "0x2EADFE8")]
	private void RefreshBagNum(bool hasDraw = false)
	{
	}

	[Token(Token = "0x600E3F8")]
	[Address(RVA = "0x2EAE14C", Offset = "0x2EAE14C", VA = "0x2EAE14C")]
	private void OnBagBtnClickEvent(object[] data)
	{
	}

	[Token(Token = "0x600E3F9")]
	[Address(RVA = "0x2EAE238", Offset = "0x2EAE238", VA = "0x2EAE238")]
	private void OnLuckProgressClick()
	{
	}

	[Token(Token = "0x600E3FA")]
	[Address(RVA = "0x2EAE548", Offset = "0x2EAE548", VA = "0x2EAE548")]
	private void RefreshCountDownLabel()
	{
	}

	[Token(Token = "0x600E3FB")]
	[Address(RVA = "0x2EAE72C", Offset = "0x2EAE72C", VA = "0x2EAE72C")]
	private void RefreshTokenNum()
	{
	}

	[Token(Token = "0x600E3FC")]
	[Address(RVA = "0x2EAEBE0", Offset = "0x2EAEBE0", VA = "0x2EAEBE0")]
	private void RefreshTokenSprite()
	{
	}

	[Token(Token = "0x600E3FD")]
	[Address(RVA = "0x2EAEFF0", Offset = "0x2EAEFF0", VA = "0x2EAEFF0")]
	private void RefreshProgressBarValueOnShowContent()
	{
	}

	[Token(Token = "0x600E3FE")]
	[Address(RVA = "0x2EAF2B8", Offset = "0x2EAF2B8", VA = "0x2EAF2B8")]
	private void RefreshStyle()
	{
	}

	[Token(Token = "0x600E3FF")]
	[Address(RVA = "0x2EAF76C", Offset = "0x2EAF76C", VA = "0x2EAF76C")]
	public void SetCDNTitle()
	{
	}

	[Token(Token = "0x600E400")]
	[Address(RVA = "0x2EAF8DC", Offset = "0x2EAF8DC", VA = "0x2EAF8DC")]
	private void OnLegendGachaAdsClick(object[] data)
	{
	}

	[Token(Token = "0x600E401")]
	[Address(RVA = "0x2EAF960", Offset = "0x2EAF960", VA = "0x2EAF960")]
	private void OnClickRewardPoolBtn()
	{
	}

	[Token(Token = "0x600E402")]
	[Address(RVA = "0x2EAFA98", Offset = "0x2EAFA98", VA = "0x2EAFA98", Slot = "54")]
	public override UIWidget GetPreviewSceneBorder(uint gachaID)
	{
		return null;
	}

	[Token(Token = "0x600E403")]
	[Address(RVA = "0x2EAFB10", Offset = "0x2EAFB10", VA = "0x2EAFB10", Slot = "56")]
	public override FrontendPreviewType GetFrontendPreviewType(uint gachaID)
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x600E404")]
	[Address(RVA = "0x2EAFB74", Offset = "0x2EAFB74", VA = "0x2EAFB74", Slot = "55")]
	public override UIGachaCustomizedPreviewUIData GetCustomizedPreviewUIPosition()
	{
		return null;
	}

	[Token(Token = "0x600E405")]
	[Address(RVA = "0x2EAFC58", Offset = "0x2EAFC58", VA = "0x2EAFC58", Slot = "41")]
	public override void OnPurchaseResult(bool isSuccess)
	{
	}

	[Token(Token = "0x600E406")]
	[Address(RVA = "0x2EB0708", Offset = "0x2EB0708", VA = "0x2EB0708", Slot = "34")]
	protected override void OnRefreshUIView()
	{
	}

	[Token(Token = "0x600E407")]
	[Address(RVA = "0x2EB3134", Offset = "0x2EB3134", VA = "0x2EB3134", Slot = "38")]
	public override void OnHideContent()
	{
	}

	[Token(Token = "0x600E408")]
	[Address(RVA = "0x2EB3398", Offset = "0x2EB3398", VA = "0x2EB3398", Slot = "39")]
	public override void OnShowContent()
	{
	}

	[Token(Token = "0x600E409")]
	[Address(RVA = "0x2EAC054", Offset = "0x2EAC054", VA = "0x2EAC054")]
	public void ShowDrawResult(UIModelGacha.GachaDrawType dType, bool enableAnim = true)
	{
	}

	[Token(Token = "0x600E40A")]
	[Address(RVA = "0x2EB38A0", Offset = "0x2EB38A0", VA = "0x2EB38A0")]
	private void ShowExchangeResultWnd(object[] data)
	{
	}

	[Token(Token = "0x600E40B")]
	[Address(RVA = "0x2EB3DC0", Offset = "0x2EB3DC0", VA = "0x2EB3DC0")]
	private void OnCloseCommonRewardWindow(object[] param)
	{
	}

	[Token(Token = "0x600E40C")]
	[Address(RVA = "0x2EB4250", Offset = "0x2EB4250", VA = "0x2EB4250")]
	private void OnItemBagPackClose(object[] param)
	{
	}

	[Token(Token = "0x600E40D")]
	[Address(RVA = "0x2EB41C0", Offset = "0x2EB41C0", VA = "0x2EB41C0")]
	private void ResetInfoState()
	{
	}

	[Token(Token = "0x600E40E")]
	[Address(RVA = "0x2EB4140", Offset = "0x2EB4140", VA = "0x2EB4140")]
	private void ShowTokenVfx()
	{
	}

	[Token(Token = "0x600E40F")]
	[Address(RVA = "0x2EB3F78", Offset = "0x2EB3F78", VA = "0x2EB3F78")]
	private void ShowBagVfx()
	{
	}

	[Token(Token = "0x600E410")]
	[Address(RVA = "0x2EB4488", Offset = "0x2EB4488", VA = "0x2EB4488")]
	private IEnumerator BagVFXCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600E411")]
	[Address(RVA = "0x2EB43BC", Offset = "0x2EB43BC", VA = "0x2EB43BC")]
	private IEnumerator TokenVFXCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600E412")]
	[Address(RVA = "0x2EB0318", Offset = "0x2EB0318", VA = "0x2EB0318")]
	private void BeginPlayDrawAnim()
	{
	}

	[Token(Token = "0x600E413")]
	[Address(RVA = "0x2EB47A4", Offset = "0x2EB47A4", VA = "0x2EB47A4")]
	private void PlayNormalAnim()
	{
	}

	[Token(Token = "0x600E414")]
	[Address(RVA = "0x2EB49DC", Offset = "0x2EB49DC", VA = "0x2EB49DC")]
	private void EndPlayDropBoxDrawAnim()
	{
	}

	[Token(Token = "0x600E415")]
	[Address(RVA = "0x2EB4554", Offset = "0x2EB4554", VA = "0x2EB4554")]
	private void PlayLegendThemeAnim()
	{
	}

	[Token(Token = "0x600E416")]
	[Address(RVA = "0x2EB4A6C", Offset = "0x2EB4A6C", VA = "0x2EB4A6C")]
	private ResourceID GetLegendDrawAnimResId()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E417")]
	[Address(RVA = "0x2EB4BB4", Offset = "0x2EB4BB4", VA = "0x2EB4BB4")]
	private void EndPlayLegendThemeAnim()
	{
	}

	[Token(Token = "0x600E418")]
	[Address(RVA = "0x2EB345C", Offset = "0x2EB345C", VA = "0x2EB345C")]
	private void OnEndPlayDrawAnim()
	{
	}

	[Token(Token = "0x600E419")]
	[Address(RVA = "0x2EAB0A8", Offset = "0x2EAB0A8", VA = "0x2EAB0A8")]
	private void InitExtraRewardItems()
	{
	}

	[Token(Token = "0x600E41A")]
	[Address(RVA = "0x2EABD44", Offset = "0x2EABD44", VA = "0x2EABD44")]
	private void OnExchangeAnimInterfaceMaskClick()
	{
	}

	[Token(Token = "0x600E41B")]
	[Address(RVA = "0x2EB08C8", Offset = "0x2EB08C8", VA = "0x2EB08C8")]
	public void RefreshExtraRewardList(uint chestID)
	{
	}

	[Token(Token = "0x600E41C")]
	[Address(RVA = "0x2EB4D0C", Offset = "0x2EB4D0C", VA = "0x2EB4D0C")]
	private void OnShowExchangeAnim(object[] data)
	{
	}

	[Token(Token = "0x600E41D")]
	[Address(RVA = "0x2EB1918", Offset = "0x2EB1918", VA = "0x2EB1918")]
	private void RefreshGachaAds()
	{
	}

	[Token(Token = "0x600E41E")]
	[Address(RVA = "0x2EAACB0", Offset = "0x2EAACB0", VA = "0x2EAACB0")]
	private void InitSpotSpriteTranList()
	{
	}

	[Token(Token = "0x600E41F")]
	[Address(RVA = "0x2EAAAB4", Offset = "0x2EAAAB4", VA = "0x2EAAAB4")]
	private void InitPosTransList()
	{
	}

	[Token(Token = "0x600E420")]
	[Address(RVA = "0x2EAAEAC", Offset = "0x2EAAEAC", VA = "0x2EAAEAC")]
	private void InitTransList()
	{
	}

	[Token(Token = "0x600E421")]
	[Address(RVA = "0x2EB54E8", Offset = "0x2EB54E8", VA = "0x2EB54E8", Slot = "59")]
	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E422")]
	[Address(RVA = "0x2EB557C", Offset = "0x2EB557C", VA = "0x2EB557C", Slot = "58")]
	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E423")]
	[Address(RVA = "0x2EB5828", Offset = "0x2EB5828", VA = "0x2EB5828")]
	public void ClearCache()
	{
	}

	[Token(Token = "0x600E424")]
	[Address(RVA = "0x2EB59D4", Offset = "0x2EB59D4", VA = "0x2EB59D4", Slot = "62")]
	public override string GetTutorialWndTitleKey()
	{
		return null;
	}

	[Token(Token = "0x600E425")]
	[Address(RVA = "0x2EB1710", Offset = "0x2EB1710", VA = "0x2EB1710")]
	private void RefreshNewTip()
	{
	}

	[Token(Token = "0x600E426")]
	[Address(RVA = "0x2EAB238", Offset = "0x2EAB238", VA = "0x2EAB238")]
	private void InitWeaponScoreItem()
	{
	}

	[Token(Token = "0x600E427")]
	[Address(RVA = "0x2EB5A78", Offset = "0x2EB5A78", VA = "0x2EB5A78")]
	private void OnPropertyBtnClick()
	{
	}

	[Token(Token = "0x600E428")]
	[Address(RVA = "0x2EB5C78", Offset = "0x2EB5C78", VA = "0x2EB5C78", Slot = "63")]
	public override void OnGachaSceneShowTypeChange(UIGachaSceneShowType type)
	{
	}

	[Token(Token = "0x600E429")]
	[Address(RVA = "0x2EB1D2C", Offset = "0x2EB1D2C", VA = "0x2EB1D2C")]
	private void RefreshShowWeaponOrVehicle()
	{
	}

	[Token(Token = "0x600E42A")]
	[Address(RVA = "0x2EB5CF0", Offset = "0x2EB5CF0", VA = "0x2EB5CF0")]
	private void _003CShowBubble_003Em__0()
	{
	}

	[Token(Token = "0x600E42B")]
	[Address(RVA = "0x2EB5D54", Offset = "0x2EB5D54", VA = "0x2EB5D54")]
	private static CommonRewardItemInfo _003CShowDrawResult_003Em__1(ExchangedAward item)
	{
		return null;
	}

	[Token(Token = "0x600E42C")]
	[Address(RVA = "0x2EB5D5C", Offset = "0x2EB5D5C", VA = "0x2EB5D5C")]
	private static CommonRewardItemInfo _003CShowExchangeResultWnd_003Em__2(ExchangedAward item)
	{
		return null;
	}

	[Token(Token = "0x600E42D")]
	[Address(RVA = "0x2EB5D64", Offset = "0x2EB5D64", VA = "0x2EB5D64")]
	private void _003CShowExchangeResultWnd_003Em__3()
	{
	}

	[Token(Token = "0x600E42E")]
	[Address(RVA = "0x2EB5EEC", Offset = "0x2EB5EEC", VA = "0x2EB5EEC")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E42F")]
	[Address(RVA = "0x2EB5EF4", Offset = "0x2EB5EF4", VA = "0x2EB5EF4")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600E430")]
	[Address(RVA = "0x2EB5EFC", Offset = "0x2EB5EFC", VA = "0x2EB5EFC")]
	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	[Token(Token = "0x600E431")]
	[Address(RVA = "0x2EB5F04", Offset = "0x2EB5F04", VA = "0x2EB5F04")]
	public Vector3 _003C_003EiFixBaseProxy_GetAvatarPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600E432")]
	[Address(RVA = "0x2EB5F18", Offset = "0x2EB5F18", VA = "0x2EB5F18")]
	public void _003C_003EiFixBaseProxy_OnSkipAnim()
	{
	}

	[Token(Token = "0x600E433")]
	[Address(RVA = "0x2EB5F20", Offset = "0x2EB5F20", VA = "0x2EB5F20")]
	public void _003C_003EiFixBaseProxy_InitShowOptionalDownloadInfo(List<ResourceID> P0)
	{
	}

	[Token(Token = "0x600E434")]
	[Address(RVA = "0x2EB5F28", Offset = "0x2EB5F28", VA = "0x2EB5F28")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E435")]
	[Address(RVA = "0x2EB5F30", Offset = "0x2EB5F30", VA = "0x2EB5F30")]
	public UIWidget _003C_003EiFixBaseProxy_GetPreviewSceneBorder(uint P0)
	{
		return null;
	}

	[Token(Token = "0x600E436")]
	[Address(RVA = "0x2EB5F38", Offset = "0x2EB5F38", VA = "0x2EB5F38")]
	public FrontendPreviewType _003C_003EiFixBaseProxy_GetFrontendPreviewType(uint P0)
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x600E437")]
	[Address(RVA = "0x2EB5F40", Offset = "0x2EB5F40", VA = "0x2EB5F40")]
	public UIGachaCustomizedPreviewUIData _003C_003EiFixBaseProxy_GetCustomizedPreviewUIPosition()
	{
		return null;
	}

	[Token(Token = "0x600E438")]
	[Address(RVA = "0x2EB5F48", Offset = "0x2EB5F48", VA = "0x2EB5F48")]
	public void _003C_003EiFixBaseProxy_OnPurchaseResult(bool P0)
	{
	}

	[Token(Token = "0x600E439")]
	[Address(RVA = "0x2EB5F50", Offset = "0x2EB5F50", VA = "0x2EB5F50")]
	public void _003C_003EiFixBaseProxy_OnHideContent()
	{
	}

	[Token(Token = "0x600E43A")]
	[Address(RVA = "0x2EB5F58", Offset = "0x2EB5F58", VA = "0x2EB5F58")]
	public void _003C_003EiFixBaseProxy_OnShowContent()
	{
	}

	[Token(Token = "0x600E43B")]
	[Address(RVA = "0x2EB5F60", Offset = "0x2EB5F60", VA = "0x2EB5F60")]
	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return default(uint);
	}

	[Token(Token = "0x600E43C")]
	[Address(RVA = "0x2EB5F68", Offset = "0x2EB5F68", VA = "0x2EB5F68")]
	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}

	[Token(Token = "0x600E43D")]
	[Address(RVA = "0x2EB5F88", Offset = "0x2EB5F88", VA = "0x2EB5F88")]
	public void _003C_003EiFixBaseProxy_OnGachaSceneShowTypeChange(UIGachaSceneShowType P0)
	{
	}
}
