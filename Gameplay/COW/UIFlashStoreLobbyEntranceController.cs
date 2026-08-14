using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20020FA")]
public class UIFlashStoreLobbyEntranceController : UIBaseController
{
	[Token(Token = "0x20020FB")]
	public enum EntranceLocation
	{
		[Token(Token = "0x400CE47")]
		ActivityContainer = 1,
		[Token(Token = "0x400CE48")]
		BigEvent,
		[Token(Token = "0x400CE49")]
		RevBtn
	}

	[Token(Token = "0x20020FC")]
	private sealed class _003CHideIntroBubbleCoroutine_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400CE4A")]
		[FieldOffset(Offset = "0x8")]
		internal float duration;

		[Token(Token = "0x400CE4B")]
		[FieldOffset(Offset = "0xC")]
		internal UIFlashStoreLobbyEntranceController _0024this;

		[Token(Token = "0x400CE4C")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400CE4D")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400CE4E")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x17000FEE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600AB42")]
			[Address(RVA = "0x1B4FD90", Offset = "0x1B4FD90", VA = "0x1B4FD90", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FEF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600AB43")]
			[Address(RVA = "0x1B4FD98", Offset = "0x1B4FD98", VA = "0x1B4FD98", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600AB40")]
		[Address(RVA = "0x1B4E544", Offset = "0x1B4E544", VA = "0x1B4E544")]
		public _003CHideIntroBubbleCoroutine_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600AB41")]
		[Address(RVA = "0x1B4FC30", Offset = "0x1B4FC30", VA = "0x1B4FC30", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600AB44")]
		[Address(RVA = "0x1B4FDA0", Offset = "0x1B4FDA0", VA = "0x1B4FDA0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600AB45")]
		[Address(RVA = "0x1B4FDB4", Offset = "0x1B4FDB4", VA = "0x1B4FDB4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400CE3C")]
	private const string FLASH_STORE_ACTIVITY_ENTRANCE_DISPLAYED_KEY = "FlashStore{0}_EntranceDisplayed_{1}";

	[Token(Token = "0x400CE3D")]
	private const string NEW_ACTIVITY_BUBBLE_DISPLAYED_KEY = "FlashStore{0}_NewActivityBubbleDisplayed_{1}";

	[Token(Token = "0x400CE3E")]
	private const string AWARD_TIPS_BUBBLE_DISPLAYED_KEY = "FlashStore{0}_AwardTipsDisplayed_{1}";

	[Token(Token = "0x400CE3F")]
	private const string NEW_FLASH_STORE_ACTIVITY_BUBBLE_KEY = "T_35_LC_FLASHSTORE_BUBBLE1";

	[Token(Token = "0x400CE40")]
	private const string HAS_FINISHED_ACTIVITY_BUBBLE_KEY = "T_35_LC_FLASHSTORE_BUBBLE2";

	[Token(Token = "0x400CE41")]
	[FieldOffset(Offset = "0x28")]
	private uint m_FlashStoreActivityID;

	[Token(Token = "0x400CE42")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_IsAwardBubbleDisplaying;

	[Token(Token = "0x400CE43")]
	[FieldOffset(Offset = "0x30")]
	private Coroutine m_HideIntroBubbleCoroutine;

	[Token(Token = "0x400CE44")]
	[FieldOffset(Offset = "0x34")]
	private UIFlashStoreLobbyEntranceView m_View;

	[Token(Token = "0x400CE45")]
	[FieldOffset(Offset = "0x38")]
	private UIModelLobbyEventBubble m_UIModelLobbyEventBubble;

	[Token(Token = "0x17000FED")]
	private bool IsReady
	{
		[Token(Token = "0x600AB28")]
		[Address(RVA = "0x1B4CFCC", Offset = "0x1B4CFCC", VA = "0x1B4CFCC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600AB27")]
	[Address(RVA = "0x1B4CF48", Offset = "0x1B4CF48", VA = "0x1B4CF48")]
	public UIFlashStoreLobbyEntranceController()
	{
	}

	[Token(Token = "0x600AB29")]
	[Address(RVA = "0x1B4D030", Offset = "0x1B4D030", VA = "0x1B4D030")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AB2A")]
	[Address(RVA = "0x1B4D0D8", Offset = "0x1B4D0D8", VA = "0x1B4D0D8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AB2B")]
	[Address(RVA = "0x1B4D574", Offset = "0x1B4D574", VA = "0x1B4D574", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600AB2C")]
	[Address(RVA = "0x1B4D5EC", Offset = "0x1B4D5EC", VA = "0x1B4D5EC")]
	private bool IsCurrentFlashStoreActivityDisplayed()
	{
		return default(bool);
	}

	[Token(Token = "0x600AB2D")]
	[Address(RVA = "0x1B4D7FC", Offset = "0x1B4D7FC", VA = "0x1B4D7FC")]
	private bool IsCurrentFlashStoreActivityBubbleDisplayed()
	{
		return default(bool);
	}

	[Token(Token = "0x600AB2E")]
	[Address(RVA = "0x1B4DA0C", Offset = "0x1B4DA0C", VA = "0x1B4DA0C")]
	private bool IsAwardBubbleDisplayedToday()
	{
		return default(bool);
	}

	[Token(Token = "0x600AB2F")]
	[Address(RVA = "0x1B4DCCC", Offset = "0x1B4DCCC", VA = "0x1B4DCCC")]
	private void SetCurrentFlashStoreActivityDisplayed()
	{
	}

	[Token(Token = "0x600AB30")]
	[Address(RVA = "0x1B4DED4", Offset = "0x1B4DED4", VA = "0x1B4DED4")]
	private void SetAwardTipsDisplayedTodayIfShown()
	{
	}

	[Token(Token = "0x600AB31")]
	[Address(RVA = "0x1B4E174", Offset = "0x1B4E174", VA = "0x1B4E174")]
	private void SetCurrentFlashStoreActivityBubbleDisplayedIfShown()
	{
	}

	[Token(Token = "0x600AB32")]
	[Address(RVA = "0x1B4E3A8", Offset = "0x1B4E3A8", VA = "0x1B4E3A8")]
	private void StartHideIntroBubbleCoroutine(float duration)
	{
	}

	[Token(Token = "0x600AB33")]
	[Address(RVA = "0x1B4E448", Offset = "0x1B4E448", VA = "0x1B4E448")]
	private IEnumerator HideIntroBubbleCoroutine(float duration)
	{
		return null;
	}

	[Token(Token = "0x600AB34")]
	[Address(RVA = "0x1B4D214", Offset = "0x1B4D214", VA = "0x1B4D214")]
	private void SetupDefaultState()
	{
	}

	[Token(Token = "0x600AB35")]
	[Address(RVA = "0x1B4E54C", Offset = "0x1B4E54C", VA = "0x1B4E54C")]
	private void RefreshCountdownLabel()
	{
	}

	[Token(Token = "0x600AB36")]
	[Address(RVA = "0x1B4E770", Offset = "0x1B4E770", VA = "0x1B4E770")]
	public bool RefreshIntroBubble()
	{
		return default(bool);
	}

	[Token(Token = "0x600AB37")]
	[Address(RVA = "0x1B4ECF8", Offset = "0x1B4ECF8", VA = "0x1B4ECF8")]
	public GameObject GetIntoGroupObject()
	{
		return null;
	}

	[Token(Token = "0x600AB38")]
	[Address(RVA = "0x1B4ED68", Offset = "0x1B4ED68", VA = "0x1B4ED68")]
	private void RefreshTips()
	{
	}

	[Token(Token = "0x600AB39")]
	[Address(RVA = "0x1B4EFE4", Offset = "0x1B4EFE4", VA = "0x1B4EFE4")]
	private void RefreshDynamicContent()
	{
	}

	[Token(Token = "0x600AB3A")]
	[Address(RVA = "0x1B4F0E0", Offset = "0x1B4F0E0", VA = "0x1B4F0E0")]
	public void SetViewData(uint flashStoreActivityID)
	{
	}

	[Token(Token = "0x600AB3B")]
	[Address(RVA = "0x1B4F14C", Offset = "0x1B4F14C", VA = "0x1B4F14C")]
	public void RefreshContent()
	{
	}

	[Token(Token = "0x600AB3C")]
	[Address(RVA = "0x1B4F1AC", Offset = "0x1B4F1AC", VA = "0x1B4F1AC")]
	private void OnEntranceBtnClick()
	{
	}

	[Token(Token = "0x600AB3D")]
	[Address(RVA = "0x1B4D440", Offset = "0x1B4D440", VA = "0x1B4D440")]
	private void AddEventDelegate()
	{
	}

	[Token(Token = "0x600AB3E")]
	[Address(RVA = "0x1B4FC20", Offset = "0x1B4FC20", VA = "0x1B4FC20")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AB3F")]
	[Address(RVA = "0x1B4FC28", Offset = "0x1B4FC28", VA = "0x1B4FC28")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
