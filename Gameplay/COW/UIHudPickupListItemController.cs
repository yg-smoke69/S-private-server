using System;
using System.Collections;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20027FA")]
internal class UIHudPickupListItemController : UIBaseController
{
	[Token(Token = "0x20027FB")]
	private sealed class _003CPressCheckCoroutine_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400F6BF")]
		[FieldOffset(Offset = "0x8")]
		internal Player _003Cplayer_003E__1;

		[Token(Token = "0x400F6C0")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudPickupListItemController _0024this;

		[Token(Token = "0x400F6C1")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400F6C2")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400F6C3")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x170011EB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600F86B")]
			[Address(RVA = "0x185BA08", Offset = "0x185BA08", VA = "0x185BA08", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011EC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600F86C")]
			[Address(RVA = "0x185BA10", Offset = "0x185BA10", VA = "0x185BA10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600F869")]
		[Address(RVA = "0x185B1F4", Offset = "0x185B1F4", VA = "0x185B1F4")]
		public _003CPressCheckCoroutine_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600F86A")]
		[Address(RVA = "0x185B5EC", Offset = "0x185B5EC", VA = "0x185B5EC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600F86D")]
		[Address(RVA = "0x185BA18", Offset = "0x185BA18", VA = "0x185BA18", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600F86E")]
		[Address(RVA = "0x185BA2C", Offset = "0x185BA2C", VA = "0x185BA2C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400F6AE")]
	private const string ITEM_STATE_BAN = "SG_icon_ban";

	[Token(Token = "0x400F6AF")]
	private const string ITEM_STATE_MAX = "SG_UI_icon_Max";

	[Token(Token = "0x400F6B0")]
	private const string ITEM_STATE_INC = "SG_UI_icon_up_arrow";

	[Token(Token = "0x400F6B1")]
	private const string ITEM_STATE_DEC = "SG_UI_icon_down_arrow";

	[Token(Token = "0x400F6B2")]
	private const string ITEM_STATE_REP = "SG_icon_replace";

	[Token(Token = "0x400F6B3")]
	[FieldOffset(Offset = "0x0")]
	private static Color ItemDisable;

	[Token(Token = "0x400F6B4")]
	[FieldOffset(Offset = "0x10")]
	private static Color ItemNameDisable;

	[Token(Token = "0x400F6B5")]
	[FieldOffset(Offset = "0x28")]
	private UIHudPickupListItemView m_View;

	[Token(Token = "0x400F6B6")]
	[FieldOffset(Offset = "0x2C")]
	private MNGBAPBBJDC m_CurrentItem;

	[Token(Token = "0x400F6B7")]
	[FieldOffset(Offset = "0x30")]
	private uint m_CurrentContainerID;

	[Token(Token = "0x400F6B8")]
	[FieldOffset(Offset = "0x34")]
	private bool m_pressState;

	[Token(Token = "0x400F6B9")]
	[FieldOffset(Offset = "0x38")]
	private float m_pressTime;

	[Token(Token = "0x400F6BA")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_longPressed;

	[Token(Token = "0x400F6BB")]
	[FieldOffset(Offset = "0x3D")]
	private bool m_BtnClickCanUse;

	[Token(Token = "0x400F6BC")]
	[FieldOffset(Offset = "0x40")]
	private float m_currentCD;

	[Token(Token = "0x400F6BD")]
	[FieldOffset(Offset = "0x44")]
	public BountyPickupStatus BountyStatus;

	[Token(Token = "0x400F6BE")]
	[FieldOffset(Offset = "0x48")]
	private UITweener[] tweenrs;

	[Token(Token = "0x170011EA")]
	public LGCOKIBHIJL CurrentItemData
	{
		[Token(Token = "0x600F85E")]
		[Address(RVA = "0x1857E28", Offset = "0x1857E28", VA = "0x1857E28")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600F855")]
	[Address(RVA = "0x185A9B4", Offset = "0x185A9B4", VA = "0x185A9B4")]
	public UIHudPickupListItemController()
	{
	}

	[Token(Token = "0x600F856")]
	[Address(RVA = "0x185AA48", Offset = "0x185AA48", VA = "0x185AA48")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F857")]
	[Address(RVA = "0x185AAEC", Offset = "0x185AAEC", VA = "0x185AAEC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F858")]
	[Address(RVA = "0x185ADEC", Offset = "0x185ADEC", VA = "0x185ADEC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F859")]
	[Address(RVA = "0x185AFF8", Offset = "0x185AFF8", VA = "0x185AFF8")]
	private void OnPressHud(GameObject go, bool state)
	{
	}

	[Token(Token = "0x600F85A")]
	[Address(RVA = "0x185B138", Offset = "0x185B138", VA = "0x185B138")]
	private void ChangePressState(bool state)
	{
	}

	[Token(Token = "0x600F85B")]
	[Address(RVA = "0x185AF2C", Offset = "0x185AF2C", VA = "0x185AF2C")]
	private IEnumerator PressCheckCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600F85C")]
	[Address(RVA = "0x185B1FC", Offset = "0x185B1FC", VA = "0x185B1FC")]
	private void Update()
	{
	}

	[Token(Token = "0x600F85D")]
	[Address(RVA = "0x185B434", Offset = "0x185B434", VA = "0x185B434")]
	private void OnEnterMarkItemCDTime(object[] param)
	{
	}

	[Token(Token = "0x600F85F")]
	[Address(RVA = "0x185551C", Offset = "0x185551C", VA = "0x185551C")]
	public void RefreshPickLevel()
	{
	}

	[Token(Token = "0x600F860")]
	[Address(RVA = "0x1857F54", Offset = "0x1857F54", VA = "0x1857F54")]
	public UIButton GetTutorialBtn()
	{
		return null;
	}

	[Token(Token = "0x600F861")]
	[Address(RVA = "0x1858024", Offset = "0x1858024", VA = "0x1858024")]
	public UIWidget GetTutorialWidget()
	{
		return null;
	}

	[Token(Token = "0x600F862")]
	[Address(RVA = "0x185B498", Offset = "0x185B498", VA = "0x185B498")]
	private void HideLightMask()
	{
	}

	[Token(Token = "0x600F863")]
	[Address(RVA = "0x18590A8", Offset = "0x18590A8", VA = "0x18590A8")]
	public void SetUIData(MNGBAPBBJDC item, uint containerID, bool showTween = true)
	{
	}

	[Token(Token = "0x600F864")]
	[Address(RVA = "0x1856468", Offset = "0x1856468", VA = "0x1856468")]
	public bool IsEqualPickUp(MNGBAPBBJDC pu)
	{
		return default(bool);
	}

	[Token(Token = "0x600F865")]
	[Address(RVA = "0x185653C", Offset = "0x185653C", VA = "0x185653C")]
	public void OnBtnItemActionClick()
	{
	}

	[Token(Token = "0x600F867")]
	[Address(RVA = "0x185B5DC", Offset = "0x185B5DC", VA = "0x185B5DC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F868")]
	[Address(RVA = "0x185B5E4", Offset = "0x185B5E4", VA = "0x185B5E4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
