using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002109")]
public class UIGachalegendaryBooyahDayContentController : UIGachaContentBase, _Attribute
{
	[Token(Token = "0x200210A")]
	private sealed class _003CPlayProgressAnim_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400CECE")]
		[FieldOffset(Offset = "0x8")]
		internal int _003Cmax_token_num_003E__0;

		[Token(Token = "0x400CECF")]
		[FieldOffset(Offset = "0xC")]
		internal float _003Cstart_value_003E__0;

		[Token(Token = "0x400CED0")]
		[FieldOffset(Offset = "0x10")]
		internal float _003Cend_value_003E__0;

		[Token(Token = "0x400CED1")]
		[FieldOffset(Offset = "0x14")]
		internal int startPoint;

		[Token(Token = "0x400CED2")]
		[FieldOffset(Offset = "0x18")]
		internal int endPoint;

		[Token(Token = "0x400CED3")]
		[FieldOffset(Offset = "0x1C")]
		internal float _003CperTimeChange_003E__1;

		[Token(Token = "0x400CED4")]
		[FieldOffset(Offset = "0x20")]
		internal float _003Ccur_time_003E__1;

		[Token(Token = "0x400CED5")]
		[FieldOffset(Offset = "0x24")]
		internal UIGachalegendaryBooyahDayContentController _0024this;

		[Token(Token = "0x400CED6")]
		[FieldOffset(Offset = "0x28")]
		internal object _0024current;

		[Token(Token = "0x400CED7")]
		[FieldOffset(Offset = "0x2C")]
		internal bool _0024disposing;

		[Token(Token = "0x400CED8")]
		[FieldOffset(Offset = "0x30")]
		internal int _0024PC;

		[Token(Token = "0x17000FF2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600AC60")]
			[Address(RVA = "0x2EA791C", Offset = "0x2EA791C", VA = "0x2EA791C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FF3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600AC61")]
			[Address(RVA = "0x2EA7924", Offset = "0x2EA7924", VA = "0x2EA7924", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600AC5E")]
		[Address(RVA = "0x2E9F00C", Offset = "0x2E9F00C", VA = "0x2E9F00C")]
		public _003CPlayProgressAnim_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600AC5F")]
		[Address(RVA = "0x2EA7504", Offset = "0x2EA7504", VA = "0x2EA7504", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600AC62")]
		[Address(RVA = "0x2EA792C", Offset = "0x2EA792C", VA = "0x2EA792C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600AC63")]
		[Address(RVA = "0x2EA7940", Offset = "0x2EA7940", VA = "0x2EA7940", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200210B")]
	private sealed class _003CBagVFXCoroutine_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400CED9")]
		[FieldOffset(Offset = "0x8")]
		internal float _003CmF1_003E__0;

		[Token(Token = "0x400CEDA")]
		[FieldOffset(Offset = "0xC")]
		internal float _003CmF2_003E__0;

		[Token(Token = "0x400CEDB")]
		[FieldOffset(Offset = "0x10")]
		internal float _003CtimeCounter_003E__0;

		[Token(Token = "0x400CEDC")]
		[FieldOffset(Offset = "0x14")]
		internal Vector3 _003CstartPos_003E__0;

		[Token(Token = "0x400CEDD")]
		[FieldOffset(Offset = "0x20")]
		internal Vector3 _003CendPos_003E__0;

		[Token(Token = "0x400CEDE")]
		[FieldOffset(Offset = "0x2C")]
		internal Vector3 _003Ccenter_003E__1;

		[Token(Token = "0x400CEDF")]
		[FieldOffset(Offset = "0x38")]
		internal Vector3 _003CriseRelCenter_003E__1;

		[Token(Token = "0x400CEE0")]
		[FieldOffset(Offset = "0x44")]
		internal Vector3 _003CsetRelCenter_003E__1;

		[Token(Token = "0x400CEE1")]
		[FieldOffset(Offset = "0x50")]
		internal UIGachalegendaryBooyahDayContentController _0024this;

		[Token(Token = "0x400CEE2")]
		[FieldOffset(Offset = "0x54")]
		internal object _0024current;

		[Token(Token = "0x400CEE3")]
		[FieldOffset(Offset = "0x58")]
		internal bool _0024disposing;

		[Token(Token = "0x400CEE4")]
		[FieldOffset(Offset = "0x5C")]
		internal int _0024PC;

		[Token(Token = "0x17000FF4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600AC66")]
			[Address(RVA = "0x2EA70D8", Offset = "0x2EA70D8", VA = "0x2EA70D8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FF5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600AC67")]
			[Address(RVA = "0x2EA70E0", Offset = "0x2EA70E0", VA = "0x2EA70E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600AC64")]
		[Address(RVA = "0x2EA4B30", Offset = "0x2EA4B30", VA = "0x2EA4B30")]
		public _003CBagVFXCoroutine_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600AC65")]
		[Address(RVA = "0x2EA6274", Offset = "0x2EA6274", VA = "0x2EA6274", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600AC68")]
		[Address(RVA = "0x2EA70E8", Offset = "0x2EA70E8", VA = "0x2EA70E8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600AC69")]
		[Address(RVA = "0x2EA70FC", Offset = "0x2EA70FC", VA = "0x2EA70FC", Slot = "6")]
		public void Reset()
		{
		}

		[Token(Token = "0x600AC6A")]
		[Address(RVA = "0x2EA7184", Offset = "0x2EA7184", VA = "0x2EA7184")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x200210C")]
	private sealed class _003CTokenVFXCoroutine_003Ec__Iterator2 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400CEE5")]
		[FieldOffset(Offset = "0x8")]
		internal float _003CmF1_003E__0;

		[Token(Token = "0x400CEE6")]
		[FieldOffset(Offset = "0xC")]
		internal float _003CmF2_003E__0;

		[Token(Token = "0x400CEE7")]
		[FieldOffset(Offset = "0x10")]
		internal float _003CtimeCounter_003E__0;

		[Token(Token = "0x400CEE8")]
		[FieldOffset(Offset = "0x14")]
		internal Vector3 _003CstartPos_003E__0;

		[Token(Token = "0x400CEE9")]
		[FieldOffset(Offset = "0x20")]
		internal Vector3 _003CendPos_003E__0;

		[Token(Token = "0x400CEEA")]
		[FieldOffset(Offset = "0x2C")]
		internal Vector3 _003Ccenter_003E__1;

		[Token(Token = "0x400CEEB")]
		[FieldOffset(Offset = "0x38")]
		internal Vector3 _003CriseRelCenter_003E__1;

		[Token(Token = "0x400CEEC")]
		[FieldOffset(Offset = "0x44")]
		internal Vector3 _003CsetRelCenter_003E__1;

		[Token(Token = "0x400CEED")]
		[FieldOffset(Offset = "0x50")]
		internal UIGachalegendaryBooyahDayContentController _0024this;

		[Token(Token = "0x400CEEE")]
		[FieldOffset(Offset = "0x54")]
		internal object _0024current;

		[Token(Token = "0x400CEEF")]
		[FieldOffset(Offset = "0x58")]
		internal bool _0024disposing;

		[Token(Token = "0x400CEF0")]
		[FieldOffset(Offset = "0x5C")]
		internal int _0024PC;

		[Token(Token = "0x17000FF6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600AC6D")]
			[Address(RVA = "0x2EA7FFC", Offset = "0x2EA7FFC", VA = "0x2EA7FFC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FF7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600AC6E")]
			[Address(RVA = "0x2EA8004", Offset = "0x2EA8004", VA = "0x2EA8004", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600AC6B")]
		[Address(RVA = "0x2EA4B38", Offset = "0x2EA4B38", VA = "0x2EA4B38")]
		public _003CTokenVFXCoroutine_003Ec__Iterator2()
		{
		}

		[Token(Token = "0x600AC6C")]
		[Address(RVA = "0x2EA79C8", Offset = "0x2EA79C8", VA = "0x2EA79C8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600AC6F")]
		[Address(RVA = "0x2EA800C", Offset = "0x2EA800C", VA = "0x2EA800C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600AC70")]
		[Address(RVA = "0x2EA8020", Offset = "0x2EA8020", VA = "0x2EA8020", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200210D")]
	private sealed class _003CPlayExtraRewardListEnterAnim_003Ec__Iterator3 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400CEF1")]
		[FieldOffset(Offset = "0x8")]
		internal int _003Ci_003E__1;

		[Token(Token = "0x400CEF2")]
		[FieldOffset(Offset = "0xC")]
		internal UIGachalegendaryBooyahDayContentController _0024this;

		[Token(Token = "0x400CEF3")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400CEF4")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400CEF5")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x17000FF8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600AC73")]
			[Address(RVA = "0x2EA7458", Offset = "0x2EA7458", VA = "0x2EA7458", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FF9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600AC74")]
			[Address(RVA = "0x2EA7460", Offset = "0x2EA7460", VA = "0x2EA7460", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600AC71")]
		[Address(RVA = "0x2EA510C", Offset = "0x2EA510C", VA = "0x2EA510C")]
		public _003CPlayExtraRewardListEnterAnim_003Ec__Iterator3()
		{
		}

		[Token(Token = "0x600AC72")]
		[Address(RVA = "0x2EA721C", Offset = "0x2EA721C", VA = "0x2EA721C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600AC75")]
		[Address(RVA = "0x2EA7468", Offset = "0x2EA7468", VA = "0x2EA7468", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600AC76")]
		[Address(RVA = "0x2EA747C", Offset = "0x2EA747C", VA = "0x2EA747C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400CEAD")]
	[FieldOffset(Offset = "0x44")]
	private List<UICollectionVehicleSkinScoreItemController> m_VeicleSkinScoreList;

	[Token(Token = "0x400CEAE")]
	[FieldOffset(Offset = "0x48")]
	private List<UICollectionScoreItemController> m_WeaponSkinScoreItemList;

	[Token(Token = "0x400CEAF")]
	private const string DEFAULTBAGICONNAME = "FF_UI_Lottery_Bag_Normal";

	[Token(Token = "0x400CEB0")]
	private const string BUBBLEGUIDEKEY = "BubbleGuideKey";

	[Token(Token = "0x400CEB1")]
	private const uint m_GrowUpTime = 1u;

	[Token(Token = "0x400CEB2")]
	private const float ProgressBarBottomGap = 0.04f;

	[Token(Token = "0x400CEB3")]
	private const float ProgressBarTopGap = 0.04f;

	[Token(Token = "0x400CEB4")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_CurrentTokenNum;

	[Token(Token = "0x400CEB5")]
	[FieldOffset(Offset = "0x50")]
	private uint m_CurrentExchangingTokenNum;

	[Token(Token = "0x400CEB6")]
	[FieldOffset(Offset = "0x54")]
	private uint m_CurrentExchangingGachaID;

	[Token(Token = "0x400CEB7")]
	[FieldOffset(Offset = "0x58")]
	private uint m_DelayCallID;

	[Token(Token = "0x400CEB8")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_IsLegendClothGacha;

	[Token(Token = "0x400CEB9")]
	[FieldOffset(Offset = "0x5D")]
	private bool m_IsLobbyGacha;

	[Token(Token = "0x400CEBA")]
	[FieldOffset(Offset = "0x60")]
	private UIGachalegendaryBooyahDayContentView m_View;

	[Token(Token = "0x400CEBB")]
	[FieldOffset(Offset = "0x64")]
	private UIModelGacha m_ModelGacha;

	[Token(Token = "0x400CEBC")]
	[FieldOffset(Offset = "0x68")]
	private CSSharedItemDataManager.StoreQuality m_CurrentDropQuality;

	[Token(Token = "0x400CEBD")]
	[FieldOffset(Offset = "0x6C")]
	private GachaLengendaryInfoData m_GachaInfoData;

	[Token(Token = "0x400CEBE")]
	[FieldOffset(Offset = "0x70")]
	private UILegendDrawAnimPopWindowController m_AnimPopWnd;

	[Token(Token = "0x400CEBF")]
	[FieldOffset(Offset = "0x74")]
	private GachaDesc m_GachaDesc;

	[Token(Token = "0x400CEC0")]
	[FieldOffset(Offset = "0x78")]
	private List<Transform> m_ExtraItemTransList;

	[Token(Token = "0x400CEC1")]
	[FieldOffset(Offset = "0x7C")]
	private List<UIToggleButton> m_ToggleList;

	[Token(Token = "0x400CEC2")]
	[FieldOffset(Offset = "0x80")]
	private List<UIGachaLengendaryExtraListBooyahDayItemController> m_ExtraRewardList;

	[Token(Token = "0x400CEC3")]
	[FieldOffset(Offset = "0x84")]
	private GameObject m_LegendThemAnimObj;

	[Token(Token = "0x400CEC4")]
	[FieldOffset(Offset = "0x88")]
	private GameObject m_LegendThemExchangeAnimObj;

	[Token(Token = "0x400CEC5")]
	[FieldOffset(Offset = "0x8C")]
	private List<uint> m_NewTempBagList;

	[Token(Token = "0x400CEC6")]
	[FieldOffset(Offset = "0x90")]
	private Coroutine m_ProgressCoroutine;

	[Token(Token = "0x400CEC7")]
	[FieldOffset(Offset = "0x94")]
	private List<ExchangedAward> Extra_rewards;

	[Token(Token = "0x400CEC8")]
	[FieldOffset(Offset = "0x98")]
	private UIGachaLegendaryBooyahAdsController m_AdsCtrl;

	[Token(Token = "0x400CEC9")]
	[FieldOffset(Offset = "0x9C")]
	private bool m_UIEnterAnimPlayed;

	[Token(Token = "0x400CECA")]
	[FieldOffset(Offset = "0xA0")]
	private int m_ExtraRewardItemEnterPlayedCnt;

	[Token(Token = "0x400CECB")]
	[FieldOffset(Offset = "0xA4")]
	private uint m_BagVFXDelayCall;

	[Token(Token = "0x400CECC")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<ExchangedAward, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400CECD")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<ExchangedAward, CommonRewardItemInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600AC07")]
	[Address(RVA = "0x2E9B5FC", Offset = "0x2E9B5FC", VA = "0x2E9B5FC")]
	public UIGachalegendaryBooyahDayContentController()
	{
	}

	[Token(Token = "0x600AC08")]
	[Address(RVA = "0x2E9B7C0", Offset = "0x2E9B7C0", VA = "0x2E9B7C0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AC09")]
	[Address(RVA = "0x2E9B864", Offset = "0x2E9B864", VA = "0x2E9B864", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AC0A")]
	[Address(RVA = "0x2E9CA0C", Offset = "0x2E9CA0C", VA = "0x2E9CA0C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600AC0B")]
	[Address(RVA = "0x2E9CE7C", Offset = "0x2E9CE7C", VA = "0x2E9CE7C")]
	private void ChangeLayer(Transform trans, string targetLayer)
	{
	}

	[Token(Token = "0x600AC0C")]
	[Address(RVA = "0x2E9D264", Offset = "0x2E9D264", VA = "0x2E9D264", Slot = "53")]
	public override Vector3 GetAvatarPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600AC0D")]
	[Address(RVA = "0x2E9D304", Offset = "0x2E9D304", VA = "0x2E9D304", Slot = "42")]
	public override void OnSkipAnim()
	{
	}

	[Token(Token = "0x600AC0E")]
	[Address(RVA = "0x2E9BFA8", Offset = "0x2E9BFA8", VA = "0x2E9BFA8")]
	private void SetInitialState()
	{
	}

	[Token(Token = "0x600AC0F")]
	[Address(RVA = "0x2E9DD4C", Offset = "0x2E9DD4C", VA = "0x2E9DD4C")]
	private void OnLegendAnimPopEnd(object[] data)
	{
	}

	[Token(Token = "0x600AC10")]
	[Address(RVA = "0x2E9DE94", Offset = "0x2E9DE94", VA = "0x2E9DE94", Slot = "33")]
	protected override void InitGachaContentBuyBtn()
	{
	}

	[Token(Token = "0x600AC11")]
	[Address(RVA = "0x2E9E074", Offset = "0x2E9E074", VA = "0x2E9E074")]
	private void ProcessAnimEvt(object[] data)
	{
	}

	[Token(Token = "0x600AC12")]
	[Address(RVA = "0x2E9E33C", Offset = "0x2E9E33C", VA = "0x2E9E33C")]
	private void ShowBubble()
	{
	}

	[Token(Token = "0x600AC13")]
	[Address(RVA = "0x2E9E5F8", Offset = "0x2E9E5F8", VA = "0x2E9E5F8")]
	private bool HasSpecialToken()
	{
		return default(bool);
	}

	[Token(Token = "0x600AC14")]
	[Address(RVA = "0x2E9E66C", Offset = "0x2E9E66C", VA = "0x2E9E66C")]
	private bool OnlyHasSpecialToken()
	{
		return default(bool);
	}

	[Token(Token = "0x600AC15")]
	[Address(RVA = "0x2E9E6E0", Offset = "0x2E9E6E0", VA = "0x2E9E6E0")]
	private bool HasSpecialTokenMoreThanOne()
	{
		return default(bool);
	}

	[Token(Token = "0x600AC16")]
	[Address(RVA = "0x2E9E754", Offset = "0x2E9E754", VA = "0x2E9E754", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600AC17")]
	[Address(RVA = "0x2E9E868", Offset = "0x2E9E868", VA = "0x2E9E868")]
	public void PlayLengendaryAnim(string anim)
	{
	}

	[Token(Token = "0x600AC18")]
	[Address(RVA = "0x2E9EB44", Offset = "0x2E9EB44", VA = "0x2E9EB44")]
	private void RefreshProgressValue()
	{
	}

	[Token(Token = "0x600AC19")]
	[Address(RVA = "0x2E9EEF4", Offset = "0x2E9EEF4", VA = "0x2E9EEF4")]
	private IEnumerator PlayProgressAnim(int startPoint, int endPoint)
	{
		return null;
	}

	[Token(Token = "0x600AC1A")]
	[Address(RVA = "0x2E9C220", Offset = "0x2E9C220", VA = "0x2E9C220")]
	private void SetProgressBarValue(float value)
	{
	}

	[Token(Token = "0x600AC1B")]
	[Address(RVA = "0x2E9F014", Offset = "0x2E9F014", VA = "0x2E9F014")]
	private void OnPreviewClothBtnClick()
	{
	}

	[Token(Token = "0x600AC1C")]
	[Address(RVA = "0x2E9F250", Offset = "0x2E9F250", VA = "0x2E9F250")]
	private void OnBagBtnClick()
	{
	}

	[Token(Token = "0x600AC1D")]
	[Address(RVA = "0x2E9F5E4", Offset = "0x2E9F5E4", VA = "0x2E9F5E4")]
	private void RefreshBagNum(bool hasDraw = false)
	{
	}

	[Token(Token = "0x600AC1E")]
	[Address(RVA = "0x2E9F748", Offset = "0x2E9F748", VA = "0x2E9F748")]
	private void OnBagBtnClickEvent(object[] data)
	{
	}

	[Token(Token = "0x600AC1F")]
	[Address(RVA = "0x2E9F7B0", Offset = "0x2E9F7B0", VA = "0x2E9F7B0")]
	private void OnLuckProgressClick()
	{
	}

	[Token(Token = "0x600AC20")]
	[Address(RVA = "0x2E9FAC0", Offset = "0x2E9FAC0", VA = "0x2E9FAC0")]
	private void RefreshCountDownLabel()
	{
	}

	[Token(Token = "0x600AC21")]
	[Address(RVA = "0x2E9FCA4", Offset = "0x2E9FCA4", VA = "0x2E9FCA4")]
	private void RefreshTokenNum()
	{
	}

	[Token(Token = "0x600AC22")]
	[Address(RVA = "0x2EA0158", Offset = "0x2EA0158", VA = "0x2EA0158")]
	private void RefreshTokenSprite()
	{
	}

	[Token(Token = "0x600AC23")]
	[Address(RVA = "0x2EA0568", Offset = "0x2EA0568", VA = "0x2EA0568")]
	private void RefreshProgressBarValueOnShowContent()
	{
	}

	[Token(Token = "0x600AC24")]
	[Address(RVA = "0x2EA076C", Offset = "0x2EA076C", VA = "0x2EA076C")]
	private void RefreshStyle()
	{
	}

	[Token(Token = "0x600AC25")]
	[Address(RVA = "0x2EA0C6C", Offset = "0x2EA0C6C", VA = "0x2EA0C6C")]
	public void SetCDNTitle()
	{
	}

	[Token(Token = "0x600AC26")]
	[Address(RVA = "0x2EA0F0C", Offset = "0x2EA0F0C", VA = "0x2EA0F0C")]
	private void OnLegendGachaAdsClick(object[] data)
	{
	}

	[Token(Token = "0x600AC27")]
	[Address(RVA = "0x2EA0F74", Offset = "0x2EA0F74", VA = "0x2EA0F74")]
	private void OnClickRewardPoolBtn()
	{
	}

	[Token(Token = "0x600AC28")]
	[Address(RVA = "0x2EA10AC", Offset = "0x2EA10AC", VA = "0x2EA10AC", Slot = "55")]
	public override UIGachaCustomizedPreviewUIData GetCustomizedPreviewUIPosition()
	{
		return null;
	}

	[Token(Token = "0x600AC29")]
	[Address(RVA = "0x2EA1190", Offset = "0x2EA1190", VA = "0x2EA1190", Slot = "41")]
	public override void OnPurchaseResult(bool isSuccess)
	{
	}

	[Token(Token = "0x600AC2A")]
	[Address(RVA = "0x2EA1C48", Offset = "0x2EA1C48", VA = "0x2EA1C48", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600AC2B")]
	[Address(RVA = "0x2EA1CA4", Offset = "0x2EA1CA4", VA = "0x2EA1CA4", Slot = "34")]
	protected override void OnRefreshUIView()
	{
	}

	[Token(Token = "0x600AC2C")]
	[Address(RVA = "0x2EA3718", Offset = "0x2EA3718", VA = "0x2EA3718", Slot = "38")]
	public override void OnHideContent()
	{
	}

	[Token(Token = "0x600AC2D")]
	[Address(RVA = "0x2EA397C", Offset = "0x2EA397C", VA = "0x2EA397C", Slot = "39")]
	public override void OnShowContent()
	{
	}

	[Token(Token = "0x600AC2E")]
	[Address(RVA = "0x2E9D830", Offset = "0x2E9D830", VA = "0x2E9D830")]
	public void ShowDrawResult(UIModelGacha.GachaDrawType dType, bool enableAnim = true)
	{
	}

	[Token(Token = "0x600AC2F")]
	[Address(RVA = "0x2EA3E7C", Offset = "0x2EA3E7C", VA = "0x2EA3E7C")]
	private void ShowExchangeResultWnd(object[] data)
	{
	}

	[Token(Token = "0x600AC30")]
	[Address(RVA = "0x2EA439C", Offset = "0x2EA439C", VA = "0x2EA439C")]
	private void OnCloseCommonRewardWindow(object[] param)
	{
	}

	[Token(Token = "0x600AC31")]
	[Address(RVA = "0x2EA482C", Offset = "0x2EA482C", VA = "0x2EA482C")]
	private void OnItemBagPackClose(object[] param)
	{
	}

	[Token(Token = "0x600AC32")]
	[Address(RVA = "0x2EA479C", Offset = "0x2EA479C", VA = "0x2EA479C")]
	private void ResetInfoState()
	{
	}

	[Token(Token = "0x600AC33")]
	[Address(RVA = "0x2EA471C", Offset = "0x2EA471C", VA = "0x2EA471C")]
	private void ShowTokenVfx()
	{
	}

	[Token(Token = "0x600AC34")]
	[Address(RVA = "0x2EA4554", Offset = "0x2EA4554", VA = "0x2EA4554")]
	private void ShowBagVfx()
	{
	}

	[Token(Token = "0x600AC35")]
	[Address(RVA = "0x2EA4A64", Offset = "0x2EA4A64", VA = "0x2EA4A64")]
	private IEnumerator BagVFXCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600AC36")]
	[Address(RVA = "0x2EA4998", Offset = "0x2EA4998", VA = "0x2EA4998")]
	private IEnumerator TokenVFXCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600AC37")]
	[Address(RVA = "0x2EA1850", Offset = "0x2EA1850", VA = "0x2EA1850")]
	private void BeginPlayDrawAnim()
	{
	}

	[Token(Token = "0x600AC38")]
	[Address(RVA = "0x2EA4CEC", Offset = "0x2EA4CEC", VA = "0x2EA4CEC")]
	private void PlayNormalAnim()
	{
	}

	[Token(Token = "0x600AC39")]
	[Address(RVA = "0x2EA4F24", Offset = "0x2EA4F24", VA = "0x2EA4F24")]
	private void EndPlayDropBoxDrawAnim()
	{
	}

	[Token(Token = "0x600AC3A")]
	[Address(RVA = "0x2EA4B40", Offset = "0x2EA4B40", VA = "0x2EA4B40")]
	private void PlayLegendThemeAnim()
	{
	}

	[Token(Token = "0x600AC3B")]
	[Address(RVA = "0x2EA4FB4", Offset = "0x2EA4FB4", VA = "0x2EA4FB4")]
	private void EndPlayLegendThemeAnim()
	{
	}

	[Token(Token = "0x600AC3C")]
	[Address(RVA = "0x2EA3A38", Offset = "0x2EA3A38", VA = "0x2EA3A38")]
	private void OnEndPlayDrawAnim()
	{
	}

	[Token(Token = "0x600AC3D")]
	[Address(RVA = "0x2E9C524", Offset = "0x2E9C524", VA = "0x2E9C524")]
	private void InitExtraRewardItems()
	{
	}

	[Token(Token = "0x600AC3E")]
	[Address(RVA = "0x2E9D520", Offset = "0x2E9D520", VA = "0x2E9D520")]
	private void OnExchangeAnimInterfaceMaskClick()
	{
	}

	[Token(Token = "0x600AC3F")]
	[Address(RVA = "0x2EA1E64", Offset = "0x2EA1E64", VA = "0x2EA1E64")]
	public void RefreshExtraRewardList(uint chestID)
	{
	}

	[Token(Token = "0x600AC40")]
	[Address(RVA = "0x2E9EA78", Offset = "0x2E9EA78", VA = "0x2E9EA78")]
	private IEnumerator PlayExtraRewardListEnterAnim()
	{
		return null;
	}

	[Token(Token = "0x600AC41")]
	[Address(RVA = "0x2EA5114", Offset = "0x2EA5114", VA = "0x2EA5114")]
	private void OnShowExchangeAnim(object[] data)
	{
	}

	[Token(Token = "0x600AC42")]
	[Address(RVA = "0x2EA2388", Offset = "0x2EA2388", VA = "0x2EA2388")]
	private void RefreshGachaAds()
	{
	}

	[Token(Token = "0x600AC43")]
	[Address(RVA = "0x2E9C328", Offset = "0x2E9C328", VA = "0x2E9C328")]
	private void InitTransList()
	{
	}

	[Token(Token = "0x600AC44")]
	[Address(RVA = "0x2EA57BC", Offset = "0x2EA57BC", VA = "0x2EA57BC", Slot = "59")]
	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600AC45")]
	[Address(RVA = "0x2EA5850", Offset = "0x2EA5850", VA = "0x2EA5850", Slot = "58")]
	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600AC46")]
	[Address(RVA = "0x2EA5A50", Offset = "0x2EA5A50", VA = "0x2EA5A50")]
	public void ClearCache()
	{
	}

	[Token(Token = "0x600AC47")]
	[Address(RVA = "0x2EA5BFC", Offset = "0x2EA5BFC", VA = "0x2EA5BFC", Slot = "62")]
	public override string GetTutorialWndTitleKey()
	{
		return null;
	}

	[Token(Token = "0x600AC48")]
	[Address(RVA = "0x2EA2180", Offset = "0x2EA2180", VA = "0x2EA2180")]
	private void RefreshNewTip()
	{
	}

	[Token(Token = "0x600AC49")]
	[Address(RVA = "0x2E9C6B4", Offset = "0x2E9C6B4", VA = "0x2E9C6B4")]
	private void InitWeaponScoreItem()
	{
	}

	[Token(Token = "0x600AC4A")]
	[Address(RVA = "0x2EA5CA0", Offset = "0x2EA5CA0", VA = "0x2EA5CA0")]
	private void OnPropertyBtnClick()
	{
	}

	[Token(Token = "0x600AC4B")]
	[Address(RVA = "0x2EA5EA0", Offset = "0x2EA5EA0", VA = "0x2EA5EA0")]
	private void OnBtnRuleClick()
	{
	}

	[Token(Token = "0x600AC4C")]
	[Address(RVA = "0x2EA2508", Offset = "0x2EA2508", VA = "0x2EA2508")]
	private void RefreshShowWeaponOrVehicle()
	{
	}

	[Token(Token = "0x600AC4D")]
	[Address(RVA = "0x2EA5FB0", Offset = "0x2EA5FB0", VA = "0x2EA5FB0")]
	private void _003CShowBubble_003Em__0()
	{
	}

	[Token(Token = "0x600AC4E")]
	[Address(RVA = "0x2EA6014", Offset = "0x2EA6014", VA = "0x2EA6014")]
	private void _003CSetCDNTitle_003Em__1()
	{
	}

	[Token(Token = "0x600AC4F")]
	[Address(RVA = "0x2EA6058", Offset = "0x2EA6058", VA = "0x2EA6058")]
	private static CommonRewardItemInfo _003CShowDrawResult_003Em__2(ExchangedAward item)
	{
		return null;
	}

	[Token(Token = "0x600AC50")]
	[Address(RVA = "0x2EA6060", Offset = "0x2EA6060", VA = "0x2EA6060")]
	private static CommonRewardItemInfo _003CShowExchangeResultWnd_003Em__3(ExchangedAward item)
	{
		return null;
	}

	[Token(Token = "0x600AC51")]
	[Address(RVA = "0x2EA6068", Offset = "0x2EA6068", VA = "0x2EA6068")]
	private void _003CShowExchangeResultWnd_003Em__4()
	{
	}

	[Token(Token = "0x600AC52")]
	[Address(RVA = "0x2EA61F0", Offset = "0x2EA61F0", VA = "0x2EA61F0")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AC53")]
	[Address(RVA = "0x2EA61F8", Offset = "0x2EA61F8", VA = "0x2EA61F8")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600AC54")]
	[Address(RVA = "0x2EA6200", Offset = "0x2EA6200", VA = "0x2EA6200")]
	public Vector3 _003C_003EiFixBaseProxy_GetAvatarPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600AC55")]
	[Address(RVA = "0x2EA6214", Offset = "0x2EA6214", VA = "0x2EA6214")]
	public void _003C_003EiFixBaseProxy_OnSkipAnim()
	{
	}

	[Token(Token = "0x600AC56")]
	[Address(RVA = "0x2EA621C", Offset = "0x2EA621C", VA = "0x2EA621C")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600AC57")]
	[Address(RVA = "0x2EA6224", Offset = "0x2EA6224", VA = "0x2EA6224")]
	public UIGachaCustomizedPreviewUIData _003C_003EiFixBaseProxy_GetCustomizedPreviewUIPosition()
	{
		return null;
	}

	[Token(Token = "0x600AC58")]
	[Address(RVA = "0x2EA622C", Offset = "0x2EA622C", VA = "0x2EA622C")]
	public void _003C_003EiFixBaseProxy_OnPurchaseResult(bool P0)
	{
	}

	[Token(Token = "0x600AC59")]
	[Address(RVA = "0x2EA6234", Offset = "0x2EA6234", VA = "0x2EA6234")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600AC5A")]
	[Address(RVA = "0x2EA623C", Offset = "0x2EA623C", VA = "0x2EA623C")]
	public void _003C_003EiFixBaseProxy_OnHideContent()
	{
	}

	[Token(Token = "0x600AC5B")]
	[Address(RVA = "0x2EA6244", Offset = "0x2EA6244", VA = "0x2EA6244")]
	public void _003C_003EiFixBaseProxy_OnShowContent()
	{
	}

	[Token(Token = "0x600AC5C")]
	[Address(RVA = "0x2EA624C", Offset = "0x2EA624C", VA = "0x2EA624C")]
	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return default(uint);
	}

	[Token(Token = "0x600AC5D")]
	[Address(RVA = "0x2EA6254", Offset = "0x2EA6254", VA = "0x2EA6254")]
	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}
}
