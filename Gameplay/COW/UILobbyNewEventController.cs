using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002932")]
internal class UILobbyNewEventController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002933")]
	private sealed class _003CHideFlashStoreEntranceCoroutine_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400FDF8")]
		[FieldOffset(Offset = "0x8")]
		internal ulong _003Ccurrent_003E__1;

		[Token(Token = "0x400FDF9")]
		[FieldOffset(Offset = "0x10")]
		internal ulong entranceCloseTime;

		[Token(Token = "0x400FDFA")]
		[FieldOffset(Offset = "0x18")]
		internal UILobbyNewEventController _0024this;

		[Token(Token = "0x400FDFB")]
		[FieldOffset(Offset = "0x1C")]
		internal object _0024current;

		[Token(Token = "0x400FDFC")]
		[FieldOffset(Offset = "0x20")]
		internal bool _0024disposing;

		[Token(Token = "0x400FDFD")]
		[FieldOffset(Offset = "0x24")]
		internal int _0024PC;

		[Token(Token = "0x17001227")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60106B4")]
			[Address(RVA = "0x1F9987C", Offset = "0x1F9987C", VA = "0x1F9987C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001228")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60106B5")]
			[Address(RVA = "0x1F99884", Offset = "0x1F99884", VA = "0x1F99884", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60106B2")]
		[Address(RVA = "0x1F94FC4", Offset = "0x1F94FC4", VA = "0x1F94FC4")]
		public _003CHideFlashStoreEntranceCoroutine_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x60106B3")]
		[Address(RVA = "0x1F99784", Offset = "0x1F99784", VA = "0x1F99784", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60106B6")]
		[Address(RVA = "0x1F9988C", Offset = "0x1F9988C", VA = "0x1F9988C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60106B7")]
		[Address(RVA = "0x1F998A0", Offset = "0x1F998A0", VA = "0x1F998A0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002934")]
	private sealed class _003CWaitForBigEventEntranceOpen_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400FDFE")]
		[FieldOffset(Offset = "0x8")]
		internal uint openTime;

		[Token(Token = "0x400FDFF")]
		[FieldOffset(Offset = "0x10")]
		internal ulong _003Cduration_003E__0;

		[Token(Token = "0x400FE00")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x400FE01")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _0024disposing;

		[Token(Token = "0x400FE02")]
		[FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x17001229")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60106BA")]
			[Address(RVA = "0x1F99AF8", Offset = "0x1F99AF8", VA = "0x1F99AF8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700122A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60106BB")]
			[Address(RVA = "0x1F99B00", Offset = "0x1F99B00", VA = "0x1F99B00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60106B8")]
		[Address(RVA = "0x1F9522C", Offset = "0x1F9522C", VA = "0x1F9522C")]
		public _003CWaitForBigEventEntranceOpen_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x60106B9")]
		[Address(RVA = "0x1F99928", Offset = "0x1F99928", VA = "0x1F99928", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60106BC")]
		[Address(RVA = "0x1F99B08", Offset = "0x1F99B08", VA = "0x1F99B08", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60106BD")]
		[Address(RVA = "0x1F99B1C", Offset = "0x1F99B1C", VA = "0x1F99B1C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400FDE3")]
	[FieldOffset(Offset = "0x28")]
	private UILobbyNewEventView m_View;

	[Token(Token = "0x400FDE4")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelUser m_ModelUser;

	[Token(Token = "0x400FDE5")]
	[FieldOffset(Offset = "0x30")]
	private UIModelGroup m_ModelGroup;

	[Token(Token = "0x400FDE6")]
	[FieldOffset(Offset = "0x34")]
	private UIModelLobbyEventBubble m_ModelLobbyEventBubble;

	[Token(Token = "0x400FDE7")]
	[FieldOffset(Offset = "0x38")]
	private UIModelBigEvent m_ModelBigEvent;

	[Token(Token = "0x400FDE8")]
	[FieldOffset(Offset = "0x3C")]
	private UICountDownController m_ChampionshipCtrl;

	[Token(Token = "0x400FDE9")]
	[FieldOffset(Offset = "0x40")]
	private UICountDownController m_NewPlayerCountDownCtrl;

	[Token(Token = "0x400FDEA")]
	[FieldOffset(Offset = "0x44")]
	private UICountDownController m_VeteranCountDownCtrl;

	[Token(Token = "0x400FDEB")]
	[FieldOffset(Offset = "0x48")]
	private UICountDownController m_LobbyGachaCountCtrl;

	[Token(Token = "0x400FDEC")]
	[FieldOffset(Offset = "0x4C")]
	private UICountDownController m_PurchaseEventCountCtrl;

	[Token(Token = "0x400FDED")]
	[FieldOffset(Offset = "0x50")]
	private UICountDownController m_BigEventTemplateCountDownCtrl;

	[Token(Token = "0x400FDEE")]
	[FieldOffset(Offset = "0x54")]
	private UICountDownController m_MysteryMallCountCtrl;

	[Token(Token = "0x400FDEF")]
	[FieldOffset(Offset = "0x58")]
	private UIFlashStoreLobbyEntranceController m_FlashStoreEntranceCtrl;

	[Token(Token = "0x400FDF0")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_LobbyGachaIntroHideDelayCall;

	[Token(Token = "0x400FDF1")]
	[FieldOffset(Offset = "0x60")]
	private Coroutine m_WaitForEntranceOpenCoroutine;

	[Token(Token = "0x400FDF2")]
	[FieldOffset(Offset = "0x64")]
	private Coroutine m_HideFlashStoreEntranceCoroutine;

	[Token(Token = "0x400FDF3")]
	[FieldOffset(Offset = "0x68")]
	private uint m_CurRevPriority;

	[Token(Token = "0x400FDF4")]
	[FieldOffset(Offset = "0x6C")]
	private HashSet<GameObject> m_RevBtnsInOpen;

	[Token(Token = "0x400FDF5")]
	[FieldOffset(Offset = "0x70")]
	private Dictionary<GameObject, uint> m_RevBtnsPriority;

	[Token(Token = "0x400FDF6")]
	[FieldOffset(Offset = "0x74")]
	private Dictionary<GameObject, Action> m_RevBtnsDisplayAction;

	[Token(Token = "0x400FDF7")]
	[FieldOffset(Offset = "0x78")]
	private Dictionary<int, UIBigEventLobbyEntranceBaseController> m_BigEventEntranceDict;

	[Token(Token = "0x1700121F")]
	public UIHorizontalBox TopRightTable
	{
		[Token(Token = "0x601065E")]
		[Address(RVA = "0x1F8C6E8", Offset = "0x1F8C6E8", VA = "0x1F8C6E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001220")]
	public UIWidget UIWidgetBtnChampionshipTaskGuide
	{
		[Token(Token = "0x601065F")]
		[Address(RVA = "0x1F8C758", Offset = "0x1F8C758", VA = "0x1F8C758")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001221")]
	public GameObject NewPlayerSigninBtn
	{
		[Token(Token = "0x6010660")]
		[Address(RVA = "0x1F8C7C8", Offset = "0x1F8C7C8", VA = "0x1F8C7C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001222")]
	public GameObject UIButtonBtnChampionship
	{
		[Token(Token = "0x6010661")]
		[Address(RVA = "0x1F8C854", Offset = "0x1F8C854", VA = "0x1F8C854")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001223")]
	public UIWidget UIWidgetBtnChampionship
	{
		[Token(Token = "0x6010662")]
		[Address(RVA = "0x1F8C8E0", Offset = "0x1F8C8E0", VA = "0x1F8C8E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001224")]
	public GameObject HDIAPBundleContainer
	{
		[Token(Token = "0x6010663")]
		[Address(RVA = "0x1F8C950", Offset = "0x1F8C950", VA = "0x1F8C950")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001225")]
	public UIGrid ActivityContainer
	{
		[Token(Token = "0x6010664")]
		[Address(RVA = "0x1F8C9DC", Offset = "0x1F8C9DC", VA = "0x1F8C9DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001226")]
	public TweenPosition TweenPosPanelTopRight
	{
		[Token(Token = "0x6010665")]
		[Address(RVA = "0x1F8CA4C", Offset = "0x1F8CA4C", VA = "0x1F8CA4C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601065D")]
	[Address(RVA = "0x1F8C594", Offset = "0x1F8C594", VA = "0x1F8C594")]
	public UILobbyNewEventController()
	{
	}

	[Token(Token = "0x6010666")]
	[Address(RVA = "0x1F8CABC", Offset = "0x1F8CABC", VA = "0x1F8CABC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010667")]
	[Address(RVA = "0x1F8CB64", Offset = "0x1F8CB64", VA = "0x1F8CB64", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010668")]
	[Address(RVA = "0x1F8DDFC", Offset = "0x1F8DDFC", VA = "0x1F8DDFC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010669")]
	[Address(RVA = "0x1F8DE80", Offset = "0x1F8DE80", VA = "0x1F8DE80")]
	private void OnNewPlayerSigninClick()
	{
	}

	[Token(Token = "0x601066A")]
	[Address(RVA = "0x1F8E1F4", Offset = "0x1F8E1F4", VA = "0x1F8E1F4")]
	private void OnOnlineMatchBtnClick()
	{
	}

	[Token(Token = "0x601066B")]
	[Address(RVA = "0x1F8E4D0", Offset = "0x1F8E4D0", VA = "0x1F8E4D0")]
	private void OnVeteranSigninClick()
	{
	}

	[Token(Token = "0x601066C")]
	[Address(RVA = "0x1F8E6C8", Offset = "0x1F8E6C8", VA = "0x1F8E6C8")]
	private void OnPurchaseEventClick()
	{
	}

	[Token(Token = "0x601066D")]
	[Address(RVA = "0x1F8E940", Offset = "0x1F8E940", VA = "0x1F8E940")]
	private void OnBtnLobbyGachaClick()
	{
	}

	[Token(Token = "0x601066E")]
	[Address(RVA = "0x1F8ED04", Offset = "0x1F8ED04", VA = "0x1F8ED04")]
	private void OnClickBtnBigEventTemplate()
	{
	}

	[Token(Token = "0x601066F")]
	[Address(RVA = "0x1F8EEC0", Offset = "0x1F8EEC0", VA = "0x1F8EEC0")]
	private void OnMysteryMallClick()
	{
	}

	[Token(Token = "0x6010670")]
	[Address(RVA = "0x1F8F04C", Offset = "0x1F8F04C", VA = "0x1F8F04C")]
	private void OnMallQuit(object[] data)
	{
	}

	[Token(Token = "0x6010671")]
	[Address(RVA = "0x1F8FA5C", Offset = "0x1F8FA5C", VA = "0x1F8FA5C")]
	private bool ShowNewPlayerSigninIntroIfNeed()
	{
		return default(bool);
	}

	[Token(Token = "0x6010672")]
	[Address(RVA = "0x1F8F10C", Offset = "0x1F8F10C", VA = "0x1F8F10C")]
	private void RefreshNewPlayerSigninState(object[] data)
	{
	}

	[Token(Token = "0x6010673")]
	[Address(RVA = "0x1F8FDA4", Offset = "0x1F8FDA4", VA = "0x1F8FDA4")]
	private void RefreshOnlineMatchBtnState(object[] data)
	{
	}

	[Token(Token = "0x6010674")]
	[Address(RVA = "0x1F906CC", Offset = "0x1F906CC", VA = "0x1F906CC")]
	private void RefreshVeteranBtnState(object[] data)
	{
	}

	[Token(Token = "0x6010675")]
	[Address(RVA = "0x1F90B4C", Offset = "0x1F90B4C", VA = "0x1F90B4C")]
	private void UpdatePurchaseEventEntrance(object[] data)
	{
	}

	[Token(Token = "0x6010676")]
	[Address(RVA = "0x1F914B8", Offset = "0x1F914B8", VA = "0x1F914B8")]
	private void RefreshLobbyGachaEntrance(object[] Data)
	{
	}

	[Token(Token = "0x6010677")]
	[Address(RVA = "0x1F91B48", Offset = "0x1F91B48", VA = "0x1F91B48")]
	private bool ShowLobbyGachaIntroIfNeed()
	{
		return default(bool);
	}

	[Token(Token = "0x6010678")]
	[Address(RVA = "0x1F92040", Offset = "0x1F92040", VA = "0x1F92040")]
	private void TryDisplayAnotherRevBtn(GameObject curRevBtn)
	{
	}

	[Token(Token = "0x6010679")]
	[Address(RVA = "0x1F92410", Offset = "0x1F92410", VA = "0x1F92410")]
	private void UpdateMysteryMallBtn(object[] Data)
	{
	}

	[Token(Token = "0x601067A")]
	[Address(RVA = "0x1F9105C", Offset = "0x1F9105C", VA = "0x1F9105C")]
	private void RefreshRevBtns(GameObject tarBtn)
	{
	}

	[Token(Token = "0x601067B")]
	[Address(RVA = "0x1F929A4", Offset = "0x1F929A4", VA = "0x1F929A4")]
	private void UpdateBigEventTemplateEntrance(object[] Data)
	{
	}

	[Token(Token = "0x601067C")]
	[Address(RVA = "0x1F92F7C", Offset = "0x1F92F7C", VA = "0x1F92F7C")]
	private void RefreshAllBigEventEnrance(object[] data)
	{
	}

	[Token(Token = "0x601067D")]
	[Address(RVA = "0x1F937D0", Offset = "0x1F937D0", VA = "0x1F937D0")]
	public void RefreshGroupModeUI()
	{
	}

	[Token(Token = "0x601067E")]
	[Address(RVA = "0x1F93B6C", Offset = "0x1F93B6C", VA = "0x1F93B6C")]
	private void RefreshFlashStoreEntrance(object[] data)
	{
	}

	[Token(Token = "0x601067F")]
	[Address(RVA = "0x1F9423C", Offset = "0x1F9423C", VA = "0x1F9423C")]
	private void ShowFlashStoreEntrance()
	{
	}

	[Token(Token = "0x6010680")]
	[Address(RVA = "0x1F93E74", Offset = "0x1F93E74", VA = "0x1F93E74")]
	private void HideFlashStoreEntrance()
	{
	}

	[Token(Token = "0x6010681")]
	[Address(RVA = "0x1F935EC", Offset = "0x1F935EC", VA = "0x1F935EC")]
	private void HideBigEventLocationFlashStoreEntrance()
	{
	}

	[Token(Token = "0x6010682")]
	[Address(RVA = "0x1F94AD0", Offset = "0x1F94AD0", VA = "0x1F94AD0")]
	private void StartHideFlashStoreEntranceCoroutine(ulong entranceCloseTime)
	{
	}

	[Token(Token = "0x6010683")]
	[Address(RVA = "0x1F94EB8", Offset = "0x1F94EB8", VA = "0x1F94EB8")]
	private IEnumerator HideFlashStoreEntranceCoroutine(ulong entranceCloseTime)
	{
		return null;
	}

	[Token(Token = "0x6010684")]
	[Address(RVA = "0x1F8DCB0", Offset = "0x1F8DCB0", VA = "0x1F8DCB0")]
	private void OpenActivityCountDownCtrl(Transform parent, ref UICountDownController countDownCtrl)
	{
	}

	[Token(Token = "0x6010685")]
	[Address(RVA = "0x1F94FCC", Offset = "0x1F94FCC", VA = "0x1F94FCC")]
	private void OnVeteranCountDownEnd()
	{
	}

	[Token(Token = "0x6010686")]
	[Address(RVA = "0x1F8D80C", Offset = "0x1F8D80C", VA = "0x1F8D80C")]
	private void ConfigRevBtns()
	{
	}

	[Token(Token = "0x6010687")]
	[Address(RVA = "0x1F94B8C", Offset = "0x1F94B8C", VA = "0x1F94B8C")]
	private void RegisterRevBtn(GameObject revEntrance, ERevenueEntranceType entranceType, Action displayAction)
	{
	}

	[Token(Token = "0x6010688")]
	[Address(RVA = "0x1F950EC", Offset = "0x1F950EC", VA = "0x1F950EC")]
	private void UnregisterRevBtn(GameObject revEntrance)
	{
	}

	[Token(Token = "0x6010689")]
	[Address(RVA = "0x1F93518", Offset = "0x1F93518", VA = "0x1F93518")]
	private IEnumerator WaitForBigEventEntranceOpen(uint openTime)
	{
		return null;
	}

	[Token(Token = "0x601068A")]
	[Address(RVA = "0x1F95234", Offset = "0x1F95234", VA = "0x1F95234")]
	public void Reposition()
	{
	}

	[Token(Token = "0x601068B")]
	[Address(RVA = "0x1F952FC", Offset = "0x1F952FC", VA = "0x1F952FC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x601068C")]
	[Address(RVA = "0x1F95404", Offset = "0x1F95404", VA = "0x1F95404")]
	private void RefreshOnlineMatchBtnState()
	{
	}

	[Token(Token = "0x601068D")]
	[Address(RVA = "0x1F95C60", Offset = "0x1F95C60", VA = "0x1F95C60")]
	private bool NeedShowCupIntro()
	{
		return default(bool);
	}

	[Token(Token = "0x601068E")]
	[Address(RVA = "0x1F96024", Offset = "0x1F96024", VA = "0x1F96024")]
	private void HideCupMatchIntro()
	{
	}

	[Token(Token = "0x601068F")]
	[Address(RVA = "0x1F96158", Offset = "0x1F96158", VA = "0x1F96158")]
	private bool UpdateCupMatchIntro()
	{
		return default(bool);
	}

	[Token(Token = "0x6010690")]
	[Address(RVA = "0x1F9646C", Offset = "0x1F9646C", VA = "0x1F9646C")]
	private bool NeedShowFlshStoreIntro()
	{
		return default(bool);
	}

	[Token(Token = "0x6010691")]
	[Address(RVA = "0x1F9656C", Offset = "0x1F9656C", VA = "0x1F9656C")]
	public void PlayTweenPosition()
	{
	}

	[Token(Token = "0x6010692")]
	[Address(RVA = "0x1F9662C", Offset = "0x1F9662C", VA = "0x1F9662C")]
	public void ResetTweenPosition()
	{
	}

	[Token(Token = "0x6010693")]
	[Address(RVA = "0x1F96744", Offset = "0x1F96744", VA = "0x1F96744")]
	private bool NeedShowBigEventIntro()
	{
		return default(bool);
	}

	[Token(Token = "0x6010694")]
	[Address(RVA = "0x1F969C8", Offset = "0x1F969C8", VA = "0x1F969C8")]
	public void HandleReturnToLobby()
	{
	}

	[Token(Token = "0x6010695")]
	[Address(RVA = "0x1F96B88", Offset = "0x1F96B88", VA = "0x1F96B88")]
	private void OnEventDataReady(LobbyEventType lobbyEventType)
	{
	}

	[Token(Token = "0x6010696")]
	[Address(RVA = "0x1F9709C", Offset = "0x1F9709C", VA = "0x1F9709C")]
	public void RefreshBubble()
	{
	}

	[Token(Token = "0x6010697")]
	[Address(RVA = "0x1F97400", Offset = "0x1F97400", VA = "0x1F97400", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010698")]
	[Address(RVA = "0x1F97B7C", Offset = "0x1F97B7C", VA = "0x1F97B7C", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010699")]
	[Address(RVA = "0x1F97DD0", Offset = "0x1F97DD0", VA = "0x1F97DD0")]
	private void _003CRefreshNewPlayerSigninState_003Em__0()
	{
	}

	[Token(Token = "0x601069A")]
	[Address(RVA = "0x1F97EA8", Offset = "0x1F97EA8", VA = "0x1F97EA8")]
	private void _003CRefreshOnlineMatchBtnState_003Em__1()
	{
	}

	[Token(Token = "0x601069B")]
	[Address(RVA = "0x1F97F0C", Offset = "0x1F97F0C", VA = "0x1F97F0C")]
	private void _003CUpdatePurchaseEventEntrance_003Em__2()
	{
	}

	[Token(Token = "0x601069C")]
	[Address(RVA = "0x1F98024", Offset = "0x1F98024", VA = "0x1F98024")]
	private void _003CRefreshLobbyGachaEntrance_003Em__3()
	{
	}

	[Token(Token = "0x601069D")]
	[Address(RVA = "0x1F9813C", Offset = "0x1F9813C", VA = "0x1F9813C")]
	private void _003CShowLobbyGachaIntroIfNeed_003Em__4()
	{
	}

	[Token(Token = "0x601069E")]
	[Address(RVA = "0x1F9818C", Offset = "0x1F9818C", VA = "0x1F9818C")]
	private void _003CUpdateMysteryMallBtn_003Em__5()
	{
	}

	[Token(Token = "0x601069F")]
	[Address(RVA = "0x1F98300", Offset = "0x1F98300", VA = "0x1F98300")]
	private void _003CUpdateBigEventTemplateEntrance_003Em__6()
	{
	}

	[Token(Token = "0x60106A0")]
	[Address(RVA = "0x1F983F4", Offset = "0x1F983F4", VA = "0x1F983F4")]
	private void _003CShowFlashStoreEntrance_003Em__7()
	{
	}

	[Token(Token = "0x60106A1")]
	[Address(RVA = "0x1F98464", Offset = "0x1F98464", VA = "0x1F98464")]
	private void _003CConfigRevBtns_003Em__8()
	{
	}

	[Token(Token = "0x60106A2")]
	[Address(RVA = "0x1F984D4", Offset = "0x1F984D4", VA = "0x1F984D4")]
	private void _003CConfigRevBtns_003Em__9()
	{
	}

	[Token(Token = "0x60106A3")]
	[Address(RVA = "0x1F98544", Offset = "0x1F98544", VA = "0x1F98544")]
	private void _003CConfigRevBtns_003Em__A()
	{
	}

	[Token(Token = "0x60106A4")]
	[Address(RVA = "0x1F985B4", Offset = "0x1F985B4", VA = "0x1F985B4")]
	private void _003CRefreshOnlineMatchBtnState_003Em__B()
	{
	}

	[Token(Token = "0x60106A5")]
	[Address(RVA = "0x1F98618", Offset = "0x1F98618", VA = "0x1F98618")]
	private bool _003COnEventDataReady_003Em__C()
	{
		return default(bool);
	}

	[Token(Token = "0x60106A6")]
	[Address(RVA = "0x1F987D4", Offset = "0x1F987D4", VA = "0x1F987D4")]
	private void _003COnEventDataReady_003Em__D()
	{
	}

	[Token(Token = "0x60106A7")]
	[Address(RVA = "0x1F98990", Offset = "0x1F98990", VA = "0x1F98990")]
	private bool _003COnEventDataReady_003Em__E()
	{
		return default(bool);
	}

	[Token(Token = "0x60106A8")]
	[Address(RVA = "0x1F98B4C", Offset = "0x1F98B4C", VA = "0x1F98B4C")]
	private void _003COnEventDataReady_003Em__F()
	{
	}

	[Token(Token = "0x60106A9")]
	[Address(RVA = "0x1F98CE4", Offset = "0x1F98CE4", VA = "0x1F98CE4")]
	private bool _003COnEventDataReady_003Em__10()
	{
		return default(bool);
	}

	[Token(Token = "0x60106AA")]
	[Address(RVA = "0x1F98EA0", Offset = "0x1F98EA0", VA = "0x1F98EA0")]
	private void _003COnEventDataReady_003Em__11()
	{
	}

	[Token(Token = "0x60106AB")]
	[Address(RVA = "0x1F9903C", Offset = "0x1F9903C", VA = "0x1F9903C")]
	private bool _003COnEventDataReady_003Em__12()
	{
		return default(bool);
	}

	[Token(Token = "0x60106AC")]
	[Address(RVA = "0x1F991F8", Offset = "0x1F991F8", VA = "0x1F991F8")]
	private void _003COnEventDataReady_003Em__13()
	{
	}

	[Token(Token = "0x60106AD")]
	[Address(RVA = "0x1F993B4", Offset = "0x1F993B4", VA = "0x1F993B4")]
	private bool _003COnEventDataReady_003Em__14()
	{
		return default(bool);
	}

	[Token(Token = "0x60106AE")]
	[Address(RVA = "0x1F99590", Offset = "0x1F99590", VA = "0x1F99590")]
	private void _003COnEventDataReady_003Em__15()
	{
	}

	[Token(Token = "0x60106AF")]
	[Address(RVA = "0x1F9976C", Offset = "0x1F9976C", VA = "0x1F9976C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60106B0")]
	[Address(RVA = "0x1F99774", Offset = "0x1F99774", VA = "0x1F99774")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60106B1")]
	[Address(RVA = "0x1F9977C", Offset = "0x1F9977C", VA = "0x1F9977C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
