using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002653")]
public class UIGachaLimitChestContentController : UIGachaContentBase
{
	[Token(Token = "0x2002654")]
	public enum eUIGachaLimitChestState
	{
		[Token(Token = "0x400ECC4")]
		eUIGachaLimitChestState_None,
		[Token(Token = "0x400ECC5")]
		eUIGachaLimitChestState_SelectAni,
		[Token(Token = "0x400ECC6")]
		eUIGachaLimitChestState_SelectPage1,
		[Token(Token = "0x400ECC7")]
		eUIGachaLimitChestState_SelectPage2,
		[Token(Token = "0x400ECC8")]
		eUIGachaLimitChestState_ShowItemComeOut,
		[Token(Token = "0x400ECC9")]
		eUIGachaLimitChestState_ShowPrize,
		[Token(Token = "0x400ECCA")]
		eUIGachaLimitChestState_ShowGachaLoading,
		[Token(Token = "0x400ECCB")]
		eUIGachaLimitChestState_ShowEffectIdle,
		[Token(Token = "0x400ECCC")]
		eUIGachaLimitChestState_ShowGachaLoadingEndEffect
	}

	[Token(Token = "0x2002655")]
	public enum eUIGachaLimitChestPageNum
	{
		[Token(Token = "0x400ECCE")]
		eUIGachaLimitChestPageNum_1,
		[Token(Token = "0x400ECCF")]
		eUIGachaLimitChestPageNum_2
	}

	[Token(Token = "0x2002656")]
	private sealed class _003COnRewardPopUpCloseNextFrame_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400ECD0")]
		[FieldOffset(Offset = "0x8")]
		internal bool _003CisAllGet_003E__0;

		[Token(Token = "0x400ECD1")]
		[FieldOffset(Offset = "0xC")]
		internal UIGachaLimitChestContentController _0024this;

		[Token(Token = "0x400ECD2")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400ECD3")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400ECD4")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x1700117B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600E50C")]
			[Address(RVA = "0x2E82DE8", Offset = "0x2E82DE8", VA = "0x2E82DE8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700117C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600E50D")]
			[Address(RVA = "0x2E82DF0", Offset = "0x2E82DF0", VA = "0x2E82DF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600E50A")]
		[Address(RVA = "0x2E7FE2C", Offset = "0x2E7FE2C", VA = "0x2E7FE2C")]
		public _003COnRewardPopUpCloseNextFrame_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600E50B")]
		[Address(RVA = "0x2E82C74", Offset = "0x2E82C74", VA = "0x2E82C74", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600E50E")]
		[Address(RVA = "0x2E82DF8", Offset = "0x2E82DF8", VA = "0x2E82DF8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600E50F")]
		[Address(RVA = "0x2E82E0C", Offset = "0x2E82E0C", VA = "0x2E82E0C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002657")]
	private sealed class _003CInitShowOptionalDownloadInfo_003Ec__AnonStorey1
	{
		[Token(Token = "0x400ECD5")]
		[FieldOffset(Offset = "0x8")]
		internal List<ResourceID> resList;

		[Token(Token = "0x400ECD6")]
		[FieldOffset(Offset = "0xC")]
		internal UIGachaLimitChestContentController _0024this;

		[Token(Token = "0x600E510")]
		[Address(RVA = "0x2E815D0", Offset = "0x2E815D0", VA = "0x2E815D0")]
		public _003CInitShowOptionalDownloadInfo_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600E511")]
		[Address(RVA = "0x2E8292C", Offset = "0x2E8292C", VA = "0x2E8292C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400EC99")]
	[FieldOffset(Offset = "0x0")]
	private static eUIGachaLimitChestState m_curState;

	[Token(Token = "0x400EC9A")]
	[FieldOffset(Offset = "0x44")]
	private UIGachaLimitChestContentView m_View;

	[Token(Token = "0x400EC9B")]
	[FieldOffset(Offset = "0x48")]
	private UIModelGacha m_ModelGacha;

	[Token(Token = "0x400EC9C")]
	[FieldOffset(Offset = "0x4C")]
	private GachaLimitInfoData m_GachaInfo;

	[Token(Token = "0x400EC9D")]
	[FieldOffset(Offset = "0x50")]
	private bool m_bIsFilledItemRenderer;

	[Token(Token = "0x400EC9E")]
	[FieldOffset(Offset = "0x54")]
	private UIGachaLimitChestSelectRewardItemController[] m_SelectableItemRenderers;

	[Token(Token = "0x400EC9F")]
	[FieldOffset(Offset = "0x58")]
	private UIGachaLimitChestItemController[] m_itemRenderers;

	[Token(Token = "0x400ECA0")]
	[FieldOffset(Offset = "0x5C")]
	private int m_nFirstSelectIndex;

	[Token(Token = "0x400ECA1")]
	[FieldOffset(Offset = "0x60")]
	private uint m_uFirstSelectID;

	[Token(Token = "0x400ECA2")]
	[FieldOffset(Offset = "0x64")]
	private int m_nSecondSelectIndex;

	[Token(Token = "0x400ECA3")]
	[FieldOffset(Offset = "0x68")]
	private uint m_uSecondSelectID;

	[Token(Token = "0x400ECA4")]
	[FieldOffset(Offset = "0x6C")]
	private int m_nShowItemSelectIndex;

	[Token(Token = "0x400ECA5")]
	[FieldOffset(Offset = "0x70")]
	private float m_fLoadingEndEffectTimer;

	[Token(Token = "0x400ECA6")]
	[FieldOffset(Offset = "0x74")]
	private float m_fLoadingEndEffectAllTimer;

	[Token(Token = "0x400ECA7")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 testPos;

	[Token(Token = "0x400ECA8")]
	[FieldOffset(Offset = "0x84")]
	private float m_fShowSelectEffectTimer;

	[Token(Token = "0x400ECA9")]
	[FieldOffset(Offset = "0x88")]
	private float m_fShowSelectEffectAllTimer;

	[Token(Token = "0x400ECAA")]
	[FieldOffset(Offset = "0x8C")]
	private float m_fShowIdleTimer;

	[Token(Token = "0x400ECAB")]
	[FieldOffset(Offset = "0x90")]
	private float m_fAniCloseItemDescTimer;

	[Token(Token = "0x400ECAC")]
	[FieldOffset(Offset = "0x94")]
	private string m_strDescKey;

	[Token(Token = "0x400ECAD")]
	[FieldOffset(Offset = "0x98")]
	private bool m_bIsShowedSecondSelectPage;

	[Token(Token = "0x400ECAE")]
	[FieldOffset(Offset = "0x9C")]
	private GameObject m_audioSelectAni;

	[Token(Token = "0x400ECAF")]
	[FieldOffset(Offset = "0xA0")]
	private GameObject m_audioShowAni;

	[Token(Token = "0x400ECB0")]
	[FieldOffset(Offset = "0xA4")]
	private bool m_bIsSplashLock;

	[Token(Token = "0x400ECB1")]
	[FieldOffset(Offset = "0xA5")]
	private bool m_bIsTutorialLock;

	[Token(Token = "0x400ECB2")]
	[FieldOffset(Offset = "0xA8")]
	private string m_strRules1PriceKey;

	[Token(Token = "0x400ECB3")]
	[FieldOffset(Offset = "0xAC")]
	private string m_strRules2PriceKey;

	[Token(Token = "0x400ECB4")]
	[FieldOffset(Offset = "0xB0")]
	private string m_strRules3PriceKey;

	[Token(Token = "0x400ECB5")]
	[FieldOffset(Offset = "0xB4")]
	private float m_fShowItemComeOutTimer;

	[Token(Token = "0x400ECB6")]
	[FieldOffset(Offset = "0xB8")]
	private float m_fShowItemComeOutAllTimer;

	[Token(Token = "0x400ECB7")]
	[FieldOffset(Offset = "0xBC")]
	private uint m_unGachaLoadingTarID;

	[Token(Token = "0x400ECB8")]
	[FieldOffset(Offset = "0xC0")]
	private int m_nGachaLoadingTarIndex;

	[Token(Token = "0x400ECB9")]
	[FieldOffset(Offset = "0xC4")]
	private int m_nGachaLoadingResIndex;

	[Token(Token = "0x400ECBA")]
	[FieldOffset(Offset = "0xC8")]
	private List<int> m_gachaLoadingIndexs;

	[Token(Token = "0x400ECBB")]
	[FieldOffset(Offset = "0xCC")]
	private float m_fGachaLoadingAllTimer;

	[Token(Token = "0x400ECBC")]
	[FieldOffset(Offset = "0xD0")]
	private float m_fGachaLoadingTimer;

	[Token(Token = "0x400ECBD")]
	[FieldOffset(Offset = "0xD4")]
	private float m_fGachaLoadingStartVelocity;

	[Token(Token = "0x400ECBE")]
	[FieldOffset(Offset = "0xD8")]
	private float m_fGachaLoadAddVelocity;

	[Token(Token = "0x400ECBF")]
	[FieldOffset(Offset = "0xDC")]
	private int m_nGachaLimitLoadingStartIndex;

	[Token(Token = "0x400ECC0")]
	[FieldOffset(Offset = "0xE0")]
	private int m_nLastIndex;

	[Token(Token = "0x400ECC1")]
	[FieldOffset(Offset = "0xE4")]
	public float[] testTimer;

	[Token(Token = "0x400ECC2")]
	[FieldOffset(Offset = "0xE8")]
	public float[] testStartVelocity;

	[Token(Token = "0x1700117A")]
	public static eUIGachaLimitChestState CurState
	{
		[Token(Token = "0x600E4BA")]
		[Address(RVA = "0x2E77470", Offset = "0x2E77470", VA = "0x2E77470")]
		get
		{
			return default(eUIGachaLimitChestState);
		}
	}

	[Token(Token = "0x600E4B9")]
	[Address(RVA = "0x2E7729C", Offset = "0x2E7729C", VA = "0x2E7729C")]
	public UIGachaLimitChestContentController()
	{
	}

	[Token(Token = "0x600E4BB")]
	[Address(RVA = "0x2E77540", Offset = "0x2E77540", VA = "0x2E77540", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E4BC")]
	[Address(RVA = "0x2E775B8", Offset = "0x2E775B8", VA = "0x2E775B8", Slot = "39")]
	public override void OnShowContent()
	{
	}

	[Token(Token = "0x600E4BD")]
	[Address(RVA = "0x2E7960C", Offset = "0x2E7960C", VA = "0x2E7960C")]
	private void RefreshCountDownLabel()
	{
	}

	[Token(Token = "0x600E4BE")]
	[Address(RVA = "0x2E79A8C", Offset = "0x2E79A8C", VA = "0x2E79A8C", Slot = "38")]
	public override void OnHideContent()
	{
	}

	[Token(Token = "0x600E4BF")]
	[Address(RVA = "0x2E79AF4", Offset = "0x2E79AF4", VA = "0x2E79AF4", Slot = "53")]
	public override Vector3 GetAvatarPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600E4C0")]
	[Address(RVA = "0x2E79C00", Offset = "0x2E79C00", VA = "0x2E79C00")]
	private void FillItemRenderer()
	{
	}

	[Token(Token = "0x600E4C1")]
	[Address(RVA = "0x2E7A3B4", Offset = "0x2E7A3B4", VA = "0x2E7A3B4", Slot = "54")]
	public override UIWidget GetPreviewSceneBorder(uint gachaID)
	{
		return null;
	}

	[Token(Token = "0x600E4C2")]
	[Address(RVA = "0x2E7A46C", Offset = "0x2E7A46C", VA = "0x2E7A46C", Slot = "56")]
	public override FrontendPreviewType GetFrontendPreviewType(uint gachaID)
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x600E4C3")]
	[Address(RVA = "0x2E794E0", Offset = "0x2E794E0", VA = "0x2E794E0")]
	private void OnRewardToggleChanged()
	{
	}

	[Token(Token = "0x600E4C4")]
	[Address(RVA = "0x2E7A4FC", Offset = "0x2E7A4FC", VA = "0x2E7A4FC")]
	private void PlayerLightningEffect()
	{
	}

	[Token(Token = "0x600E4C5")]
	[Address(RVA = "0x2E7A794", Offset = "0x2E7A794", VA = "0x2E7A794")]
	private void OnClickNextBtn()
	{
	}

	[Token(Token = "0x600E4C6")]
	[Address(RVA = "0x2E7A850", Offset = "0x2E7A850", VA = "0x2E7A850")]
	private void OnClickSelectConfirmBtn()
	{
	}

	[Token(Token = "0x600E4C7")]
	[Address(RVA = "0x2E7A9A8", Offset = "0x2E7A9A8", VA = "0x2E7A9A8")]
	private void OnClickSelectReward(int index)
	{
	}

	[Token(Token = "0x600E4C8")]
	[Address(RVA = "0x2E7A054", Offset = "0x2E7A054", VA = "0x2E7A054")]
	private Transform GetSelectNodeByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x600E4C9")]
	[Address(RVA = "0x2E7A204", Offset = "0x2E7A204", VA = "0x2E7A204")]
	private Transform GetItemRendererNodeByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x600E4CA")]
	[Address(RVA = "0x2E7AD6C", Offset = "0x2E7AD6C", VA = "0x2E7AD6C")]
	public void SetItemPreview(BaseItemInfo info)
	{
	}

	[Token(Token = "0x600E4CB")]
	[Address(RVA = "0x2E7AEE0", Offset = "0x2E7AEE0", VA = "0x2E7AEE0", Slot = "33")]
	protected override void InitGachaContentBuyBtn()
	{
	}

	[Token(Token = "0x600E4CC")]
	[Address(RVA = "0x2E7B038", Offset = "0x2E7B038", VA = "0x2E7B038")]
	private void RefreshShowItemPage(bool isShowItemPreview = true, bool isClickShowItem = true)
	{
	}

	[Token(Token = "0x600E4CD")]
	[Address(RVA = "0x2E7B8BC", Offset = "0x2E7B8BC", VA = "0x2E7B8BC")]
	private void CloseItemRendererLightningEffect()
	{
	}

	[Token(Token = "0x600E4CE")]
	[Address(RVA = "0x2E7BA3C", Offset = "0x2E7BA3C", VA = "0x2E7BA3C", Slot = "34")]
	protected override void OnRefreshUIView()
	{
	}

	[Token(Token = "0x600E4CF")]
	[Address(RVA = "0x2E7BFA8", Offset = "0x2E7BFA8", VA = "0x2E7BFA8")]
	private void StateUpdate()
	{
	}

	[Token(Token = "0x600E4D0")]
	[Address(RVA = "0x2E776E0", Offset = "0x2E776E0", VA = "0x2E776E0")]
	private void SwitchState(eUIGachaLimitChestState state, bool isClickShowItem = true)
	{
	}

	[Token(Token = "0x600E4D1")]
	[Address(RVA = "0x2E7E25C", Offset = "0x2E7E25C", VA = "0x2E7E25C")]
	private void Update()
	{
	}

	[Token(Token = "0x600E4D2")]
	[Address(RVA = "0x2E7CAD8", Offset = "0x2E7CAD8", VA = "0x2E7CAD8")]
	private void SetProbabilityAcitive(bool b)
	{
	}

	[Token(Token = "0x600E4D3")]
	[Address(RVA = "0x2E7B558", Offset = "0x2E7B558", VA = "0x2E7B558")]
	private void OnClickShowItemRenderer(int index)
	{
	}

	[Token(Token = "0x600E4D4")]
	[Address(RVA = "0x2E7BCC8", Offset = "0x2E7BCC8", VA = "0x2E7BCC8")]
	private void RefreshTitleCDN()
	{
	}

	[Token(Token = "0x600E4D5")]
	[Address(RVA = "0x2E7B208", Offset = "0x2E7B208", VA = "0x2E7B208")]
	private void RefreshShowItemRenderer()
	{
	}

	[Token(Token = "0x600E4D6")]
	[Address(RVA = "0x2E7D12C", Offset = "0x2E7D12C", VA = "0x2E7D12C")]
	private void RefreshSelectRewardPage(eUIGachaLimitChestPageNum num, bool isClickItem = true)
	{
	}

	[Token(Token = "0x600E4D7")]
	[Address(RVA = "0x2E7EF84", Offset = "0x2E7EF84", VA = "0x2E7EF84", Slot = "62")]
	public override string GetTutorialWndTitleKey()
	{
		return null;
	}

	[Token(Token = "0x600E4D8")]
	[Address(RVA = "0x2E7F028", Offset = "0x2E7F028", VA = "0x2E7F028", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E4D9")]
	[Address(RVA = "0x2E7F7E8", Offset = "0x2E7F7E8", VA = "0x2E7F7E8", Slot = "50")]
	public override void OnSplashCDNOpen()
	{
	}

	[Token(Token = "0x600E4DA")]
	[Address(RVA = "0x2E7F898", Offset = "0x2E7F898", VA = "0x2E7F898", Slot = "51")]
	public override void OnSplashCDNClose()
	{
	}

	[Token(Token = "0x600E4DB")]
	[Address(RVA = "0x2E7F978", Offset = "0x2E7F978", VA = "0x2E7F978", Slot = "48")]
	public override void OnTutorialOpen()
	{
	}

	[Token(Token = "0x600E4DC")]
	[Address(RVA = "0x2E7FA28", Offset = "0x2E7FA28", VA = "0x2E7FA28", Slot = "49")]
	public override void OnTutorialClose()
	{
	}

	[Token(Token = "0x600E4DD")]
	[Address(RVA = "0x2E7FB08", Offset = "0x2E7FB08", VA = "0x2E7FB08", Slot = "44")]
	public override void OnFullScreenAnimOver()
	{
	}

	[Token(Token = "0x600E4DE")]
	[Address(RVA = "0x2E7FC34", Offset = "0x2E7FC34", VA = "0x2E7FC34", Slot = "43")]
	public override void OnSkipFullScreenAnim()
	{
	}

	[Token(Token = "0x600E4DF")]
	[Address(RVA = "0x2E7FD60", Offset = "0x2E7FD60", VA = "0x2E7FD60")]
	private IEnumerator OnRewardPopUpCloseNextFrame()
	{
		return null;
	}

	[Token(Token = "0x600E4E0")]
	[Address(RVA = "0x2E7FE34", Offset = "0x2E7FE34", VA = "0x2E7FE34")]
	private void OnRewardPopWndClose(object[] data)
	{
	}

	[Token(Token = "0x600E4E1")]
	[Address(RVA = "0x2E7FEC8", Offset = "0x2E7FEC8", VA = "0x2E7FEC8")]
	private void OnRareProbabilityClick()
	{
	}

	[Token(Token = "0x600E4E2")]
	[Address(RVA = "0x2E8004C", Offset = "0x2E8004C", VA = "0x2E8004C")]
	private void ShowRareProbabilityTips(object[] param)
	{
	}

	[Token(Token = "0x600E4E3")]
	[Address(RVA = "0x2E80F24", Offset = "0x2E80F24", VA = "0x2E80F24")]
	private void OnClickToggle2(UIToggleButton button)
	{
	}

	[Token(Token = "0x600E4E4")]
	[Address(RVA = "0x2E81080", Offset = "0x2E81080", VA = "0x2E81080")]
	private void OnClickToggle1(UIToggleButton button)
	{
	}

	[Token(Token = "0x600E4E5")]
	[Address(RVA = "0x2E7D930", Offset = "0x2E7D930", VA = "0x2E7D930")]
	private void RefreshAvatarPos()
	{
	}

	[Token(Token = "0x600E4E6")]
	[Address(RVA = "0x2E811DC", Offset = "0x2E811DC", VA = "0x2E811DC")]
	private void RefreshPreviewScene()
	{
	}

	[Token(Token = "0x600E4E7")]
	[Address(RVA = "0x2E812DC", Offset = "0x2E812DC", VA = "0x2E812DC", Slot = "35")]
	public override void InitShowOptionalDownloadInfo(List<ResourceID> resList)
	{
	}

	[Token(Token = "0x600E4E8")]
	[Address(RVA = "0x2E815D8", Offset = "0x2E815D8", VA = "0x2E815D8")]
	private void StartShowItemLoadingEffectAni()
	{
	}

	[Token(Token = "0x600E4E9")]
	[Address(RVA = "0x2E81790", Offset = "0x2E81790", VA = "0x2E81790")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E4EA")]
	[Address(RVA = "0x2E81838", Offset = "0x2E81838", VA = "0x2E81838")]
	public void ClearCache()
	{
	}

	[Token(Token = "0x600E4EB")]
	[Address(RVA = "0x2E8188C", Offset = "0x2E8188C", VA = "0x2E8188C", Slot = "41")]
	public override void OnPurchaseResult(bool isSuccess)
	{
	}

	[Token(Token = "0x600E4EC")]
	[Address(RVA = "0x2E7D71C", Offset = "0x2E7D71C", VA = "0x2E7D71C")]
	private void SetShowRewardSelectIndex(int index)
	{
	}

	[Token(Token = "0x600E4ED")]
	[Address(RVA = "0x2E7CC2C", Offset = "0x2E7CC2C", VA = "0x2E7CC2C")]
	private void ExitGachaLoadingState()
	{
	}

	[Token(Token = "0x600E4EE")]
	[Address(RVA = "0x2E7DA30", Offset = "0x2E7DA30", VA = "0x2E7DA30")]
	private void EnterGachaLoadingState()
	{
	}

	[Token(Token = "0x600E4EF")]
	[Address(RVA = "0x2E7C5DC", Offset = "0x2E7C5DC", VA = "0x2E7C5DC")]
	private void UpdateGachaLoadingState()
	{
	}

	[Token(Token = "0x600E4F0")]
	[Address(RVA = "0x2E81D58", Offset = "0x2E81D58", VA = "0x2E81D58")]
	private void RefreshShowItemStat()
	{
	}

	[Token(Token = "0x600E4F1")]
	[Address(RVA = "0x2E81BA8", Offset = "0x2E81BA8", VA = "0x2E81BA8")]
	private void ShowDrawResult(UIModelGacha.GachaDrawType dType, bool enableAnim = true)
	{
	}

	[Token(Token = "0x600E4F2")]
	[Address(RVA = "0x2E821CC", Offset = "0x2E821CC", VA = "0x2E821CC", Slot = "42")]
	public override void OnSkipAnim()
	{
	}

	[Token(Token = "0x600E4F3")]
	[Address(RVA = "0x2E8241C", Offset = "0x2E8241C", VA = "0x2E8241C", Slot = "59")]
	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E4F4")]
	[Address(RVA = "0x2E824C0", Offset = "0x2E824C0", VA = "0x2E824C0", Slot = "58")]
	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E4F6")]
	[Address(RVA = "0x2E8261C", Offset = "0x2E8261C", VA = "0x2E8261C")]
	private void _003CRefreshCountDownLabel_003Em__0()
	{
	}

	[Token(Token = "0x600E4F7")]
	[Address(RVA = "0x2E827A0", Offset = "0x2E827A0", VA = "0x2E827A0")]
	private void _003CRefreshTitleCDN_003Em__1()
	{
	}

	[Token(Token = "0x600E4F8")]
	[Address(RVA = "0x2E82878", Offset = "0x2E82878", VA = "0x2E82878")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E4F9")]
	[Address(RVA = "0x2E82880", Offset = "0x2E82880", VA = "0x2E82880")]
	public void _003C_003EiFixBaseProxy_OnShowContent()
	{
	}

	[Token(Token = "0x600E4FA")]
	[Address(RVA = "0x2E82888", Offset = "0x2E82888", VA = "0x2E82888")]
	public void _003C_003EiFixBaseProxy_OnHideContent()
	{
	}

	[Token(Token = "0x600E4FB")]
	[Address(RVA = "0x2E82890", Offset = "0x2E82890", VA = "0x2E82890")]
	public Vector3 _003C_003EiFixBaseProxy_GetAvatarPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600E4FC")]
	[Address(RVA = "0x2E828A4", Offset = "0x2E828A4", VA = "0x2E828A4")]
	public UIWidget _003C_003EiFixBaseProxy_GetPreviewSceneBorder(uint P0)
	{
		return null;
	}

	[Token(Token = "0x600E4FD")]
	[Address(RVA = "0x2E828AC", Offset = "0x2E828AC", VA = "0x2E828AC")]
	public FrontendPreviewType _003C_003EiFixBaseProxy_GetFrontendPreviewType(uint P0)
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x600E4FE")]
	[Address(RVA = "0x2E828B4", Offset = "0x2E828B4", VA = "0x2E828B4")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E4FF")]
	[Address(RVA = "0x2E828BC", Offset = "0x2E828BC", VA = "0x2E828BC")]
	public void _003C_003EiFixBaseProxy_OnSplashCDNOpen()
	{
	}

	[Token(Token = "0x600E500")]
	[Address(RVA = "0x2E828C4", Offset = "0x2E828C4", VA = "0x2E828C4")]
	public void _003C_003EiFixBaseProxy_OnSplashCDNClose()
	{
	}

	[Token(Token = "0x600E501")]
	[Address(RVA = "0x2E828CC", Offset = "0x2E828CC", VA = "0x2E828CC")]
	public void _003C_003EiFixBaseProxy_OnTutorialOpen()
	{
	}

	[Token(Token = "0x600E502")]
	[Address(RVA = "0x2E828D4", Offset = "0x2E828D4", VA = "0x2E828D4")]
	public void _003C_003EiFixBaseProxy_OnTutorialClose()
	{
	}

	[Token(Token = "0x600E503")]
	[Address(RVA = "0x2E828DC", Offset = "0x2E828DC", VA = "0x2E828DC")]
	public void _003C_003EiFixBaseProxy_OnFullScreenAnimOver()
	{
	}

	[Token(Token = "0x600E504")]
	[Address(RVA = "0x2E828E4", Offset = "0x2E828E4", VA = "0x2E828E4")]
	public void _003C_003EiFixBaseProxy_OnSkipFullScreenAnim()
	{
	}

	[Token(Token = "0x600E505")]
	[Address(RVA = "0x2E828EC", Offset = "0x2E828EC", VA = "0x2E828EC")]
	public void _003C_003EiFixBaseProxy_InitShowOptionalDownloadInfo(List<ResourceID> P0)
	{
	}

	[Token(Token = "0x600E506")]
	[Address(RVA = "0x2E828F4", Offset = "0x2E828F4", VA = "0x2E828F4")]
	public void _003C_003EiFixBaseProxy_OnPurchaseResult(bool P0)
	{
	}

	[Token(Token = "0x600E507")]
	[Address(RVA = "0x2E828FC", Offset = "0x2E828FC", VA = "0x2E828FC")]
	public void _003C_003EiFixBaseProxy_OnSkipAnim()
	{
	}

	[Token(Token = "0x600E508")]
	[Address(RVA = "0x2E82904", Offset = "0x2E82904", VA = "0x2E82904")]
	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return default(uint);
	}

	[Token(Token = "0x600E509")]
	[Address(RVA = "0x2E8290C", Offset = "0x2E8290C", VA = "0x2E8290C")]
	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}
}
