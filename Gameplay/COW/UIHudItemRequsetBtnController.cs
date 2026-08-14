using System;
using System.Collections;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x200278F")]
internal class UIHudItemRequsetBtnController : UIBaseController
{
	[Token(Token = "0x2002790")]
	private enum EExtraMarkType
	{
		[Token(Token = "0x400F450")]
		Normal,
		[Token(Token = "0x400F451")]
		Enemy,
		[Token(Token = "0x400F452")]
		Container
	}

	[Token(Token = "0x2002791")]
	private sealed class _003CTryOneClickCoroutine_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400F453")]
		[FieldOffset(Offset = "0x8")]
		internal UIHudItemRequsetBtnController _0024this;

		[Token(Token = "0x400F454")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400F455")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400F456")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170011CD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600F3AD")]
			[Address(RVA = "0x20B081C", Offset = "0x20B081C", VA = "0x20B081C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011CE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600F3AE")]
			[Address(RVA = "0x20B0824", Offset = "0x20B0824", VA = "0x20B0824", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600F3AB")]
		[Address(RVA = "0x20AEC94", Offset = "0x20AEC94", VA = "0x20AEC94")]
		public _003CTryOneClickCoroutine_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600F3AC")]
		[Address(RVA = "0x20B06B4", Offset = "0x20B06B4", VA = "0x20B06B4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600F3AF")]
		[Address(RVA = "0x20B082C", Offset = "0x20B082C", VA = "0x20B082C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600F3B0")]
		[Address(RVA = "0x20B0840", Offset = "0x20B0840", VA = "0x20B0840", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002792")]
	private sealed class _003CPressCheckCoroutine_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400F457")]
		[FieldOffset(Offset = "0x8")]
		internal Player _003Cplayer_003E__0;

		[Token(Token = "0x400F458")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudItemRequsetBtnController _0024this;

		[Token(Token = "0x400F459")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400F45A")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400F45B")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x170011CF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600F3B3")]
			[Address(RVA = "0x20B0608", Offset = "0x20B0608", VA = "0x20B0608", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011D0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600F3B4")]
			[Address(RVA = "0x20B0610", Offset = "0x20B0610", VA = "0x20B0610", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600F3B1")]
		[Address(RVA = "0x20B043C", Offset = "0x20B043C", VA = "0x20B043C")]
		public _003CPressCheckCoroutine_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600F3B2")]
		[Address(RVA = "0x20B0454", Offset = "0x20B0454", VA = "0x20B0454", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600F3B5")]
		[Address(RVA = "0x20B0618", Offset = "0x20B0618", VA = "0x20B0618", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600F3B6")]
		[Address(RVA = "0x20B062C", Offset = "0x20B062C", VA = "0x20B062C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400F441")]
	[FieldOffset(Offset = "0x28")]
	private UIHudItemMarkBtnView m_View;

	[Token(Token = "0x400F442")]
	[FieldOffset(Offset = "0x2C")]
	private LevelContainerBase m_CurrentTriggerContainer;

	[Token(Token = "0x400F443")]
	[FieldOffset(Offset = "0x30")]
	private bool m_pressState;

	[Token(Token = "0x400F444")]
	[FieldOffset(Offset = "0x34")]
	private float m_pressTime;

	[Token(Token = "0x400F445")]
	[FieldOffset(Offset = "0x38")]
	private bool m_BtnClickCanUse;

	[Token(Token = "0x400F446")]
	[FieldOffset(Offset = "0x3C")]
	private float m_currentCD;

	[Token(Token = "0x400F447")]
	[FieldOffset(Offset = "0x40")]
	private uint m_DelayCall;

	[Token(Token = "0x400F448")]
	[FieldOffset(Offset = "0x44")]
	private GameObject[] m_ExtraMarkBtnArray;

	[Token(Token = "0x400F449")]
	[FieldOffset(Offset = "0x48")]
	private float m_HitDistance;

	[Token(Token = "0x400F44A")]
	[FieldOffset(Offset = "0x4C")]
	private int m_HitLayerMask;

	[Token(Token = "0x400F44B")]
	[FieldOffset(Offset = "0x50")]
	private Camera m_Camera;

	[Token(Token = "0x400F44C")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 m_LastBtnPos;

	[Token(Token = "0x400F44D")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 m_LastBtnScale;

	[Token(Token = "0x400F44E")]
	[FieldOffset(Offset = "0x6C")]
	private Transform m_Transform;

	[Token(Token = "0x600F392")]
	[Address(RVA = "0x20ACDD0", Offset = "0x20ACDD0", VA = "0x20ACDD0")]
	public UIHudItemRequsetBtnController()
	{
	}

	[Token(Token = "0x600F393")]
	[Address(RVA = "0x20ACE5C", Offset = "0x20ACE5C", VA = "0x20ACE5C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F394")]
	[Address(RVA = "0x20ACF00", Offset = "0x20ACF00", VA = "0x20ACF00", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F395")]
	[Address(RVA = "0x20AD894", Offset = "0x20AD894", VA = "0x20AD894", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F396")]
	[Address(RVA = "0x20ADAD0", Offset = "0x20ADAD0", VA = "0x20ADAD0")]
	private void OnEnterMarkItemCDTime(object[] param)
	{
	}

	[Token(Token = "0x600F397")]
	[Address(RVA = "0x20ADB34", Offset = "0x20ADB34", VA = "0x20ADB34")]
	private void Update()
	{
	}

	[Token(Token = "0x600F398")]
	[Address(RVA = "0x20ADE04", Offset = "0x20ADE04", VA = "0x20ADE04")]
	private void OnPressHud(GameObject go, bool state)
	{
	}

	[Token(Token = "0x600F399")]
	[Address(RVA = "0x20AE044", Offset = "0x20AE044", VA = "0x20AE044")]
	private void OnDragOutHud(GameObject go)
	{
	}

	[Token(Token = "0x600F39A")]
	[Address(RVA = "0x20AE174", Offset = "0x20AE174", VA = "0x20AE174")]
	private void OnDragEnd(GameObject go)
	{
	}

	[Token(Token = "0x600F39B")]
	[Address(RVA = "0x20AE86C", Offset = "0x20AE86C", VA = "0x20AE86C")]
	private void OnDoubleClick(GameObject go)
	{
	}

	[Token(Token = "0x600F39C")]
	[Address(RVA = "0x20AEC1C", Offset = "0x20AEC1C", VA = "0x20AEC1C")]
	private void OnOneClick(GameObject go)
	{
	}

	[Token(Token = "0x600F39D")]
	[Address(RVA = "0x20AEB50", Offset = "0x20AEB50", VA = "0x20AEB50")]
	private IEnumerator TryOneClickCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600F39E")]
	[Address(RVA = "0x20AEC9C", Offset = "0x20AEC9C", VA = "0x20AEC9C")]
	private void CheckForGuideClick()
	{
	}

	[Token(Token = "0x600F39F")]
	[Address(RVA = "0x20AEE80", Offset = "0x20AEE80", VA = "0x20AEE80")]
	private void CheckForGuidePress()
	{
	}

	[Token(Token = "0x600F3A0")]
	[Address(RVA = "0x20AEFB8", Offset = "0x20AEFB8", VA = "0x20AEFB8")]
	private void TryRequestMarkItem()
	{
	}

	[Token(Token = "0x600F3A1")]
	[Address(RVA = "0x20AD3F0", Offset = "0x20AD3F0", VA = "0x20AD3F0")]
	private void CheckExtraGroupPos()
	{
	}

	[Token(Token = "0x600F3A2")]
	[Address(RVA = "0x20ADF44", Offset = "0x20ADF44", VA = "0x20ADF44")]
	private void ChangePressState(bool state)
	{
	}

	[Token(Token = "0x600F3A3")]
	[Address(RVA = "0x20AFA84", Offset = "0x20AFA84", VA = "0x20AFA84")]
	private void TryShowItemGridWindow(LevelContainerBase container)
	{
	}

	[Token(Token = "0x600F3A4")]
	[Address(RVA = "0x20AF73C", Offset = "0x20AF73C", VA = "0x20AF73C")]
	private void RequestMarkItem(DLPJLPIHNCL itemMarkType, uint itemMarkId, uint levelObjectId, Vector3 position)
	{
	}

	[Token(Token = "0x600F3A5")]
	[Address(RVA = "0x20B01E8", Offset = "0x20B01E8", VA = "0x20B01E8")]
	private void OnEnterPickupArea(object[] param)
	{
	}

	[Token(Token = "0x600F3A6")]
	[Address(RVA = "0x20B03D8", Offset = "0x20B03D8", VA = "0x20B03D8")]
	private void OnExitPickupArea(object[] param)
	{
	}

	[Token(Token = "0x600F3A7")]
	[Address(RVA = "0x20B011C", Offset = "0x20B011C", VA = "0x20B011C")]
	private IEnumerator PressCheckCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600F3A8")]
	[Address(RVA = "0x20AE5E8", Offset = "0x20AE5E8", VA = "0x20AE5E8")]
	private void OnBtnExtraMarkClick(EExtraMarkType markType)
	{
	}

	[Token(Token = "0x600F3A9")]
	[Address(RVA = "0x20B0444", Offset = "0x20B0444", VA = "0x20B0444")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F3AA")]
	[Address(RVA = "0x20B044C", Offset = "0x20B044C", VA = "0x20B044C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
