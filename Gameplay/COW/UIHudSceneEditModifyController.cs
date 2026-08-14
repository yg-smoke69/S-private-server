using System;
using System.Collections;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200233C")]
public class UIHudSceneEditModifyController : UIBaseController
{
	[Token(Token = "0x200233D")]
	private sealed class _003CPressCheckCoroutine_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400DB8B")]
		[FieldOffset(Offset = "0x8")]
		internal Player _003Cplayer_003E__0;

		[Token(Token = "0x400DB8C")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudSceneEditModifyController _0024this;

		[Token(Token = "0x400DB8D")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400DB8E")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400DB8F")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x170010C0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600C3D6")]
			[Address(RVA = "0x24E607C", Offset = "0x24E607C", VA = "0x24E607C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010C1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600C3D7")]
			[Address(RVA = "0x24E6084", Offset = "0x24E6084", VA = "0x24E6084", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600C3D4")]
		[Address(RVA = "0x24E5C78", Offset = "0x24E5C78", VA = "0x24E5C78")]
		public _003CPressCheckCoroutine_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600C3D5")]
		[Address(RVA = "0x24E5E38", Offset = "0x24E5E38", VA = "0x24E5E38", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600C3D8")]
		[Address(RVA = "0x24E608C", Offset = "0x24E608C", VA = "0x24E608C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600C3D9")]
		[Address(RVA = "0x24E60A0", Offset = "0x24E60A0", VA = "0x24E60A0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400DB85")]
	[FieldOffset(Offset = "0x28")]
	private UIHudSceneEditModifyView m_View;

	[Token(Token = "0x400DB86")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_pressState;

	[Token(Token = "0x400DB87")]
	[FieldOffset(Offset = "0x30")]
	private float m_pressTime;

	[Token(Token = "0x400DB88")]
	[FieldOffset(Offset = "0x34")]
	private bool m_longPressed;

	[Token(Token = "0x400DB89")]
	[FieldOffset(Offset = "0x38")]
	private float m_LastClickDeleteTime;

	[Token(Token = "0x400DB8A")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_NeedShowTutorial;

	[Token(Token = "0x600C3C5")]
	[Address(RVA = "0x24E4A58", Offset = "0x24E4A58", VA = "0x24E4A58")]
	public UIHudSceneEditModifyController()
	{
	}

	[Token(Token = "0x600C3C6")]
	[Address(RVA = "0x24E4ADC", Offset = "0x24E4ADC", VA = "0x24E4ADC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C3C7")]
	[Address(RVA = "0x24E4B80", Offset = "0x24E4B80", VA = "0x24E4B80", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C3C8")]
	[Address(RVA = "0x24E4EC4", Offset = "0x24E4EC4", VA = "0x24E4EC4", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600C3C9")]
	[Address(RVA = "0x24E505C", Offset = "0x24E505C", VA = "0x24E505C")]
	private void OnGroupModeChanged(object[] data)
	{
	}

	[Token(Token = "0x600C3CA")]
	[Address(RVA = "0x24E5158", Offset = "0x24E5158", VA = "0x24E5158", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600C3CB")]
	[Address(RVA = "0x24E528C", Offset = "0x24E528C", VA = "0x24E528C")]
	private void OnBtnMove()
	{
	}

	[Token(Token = "0x600C3CC")]
	[Address(RVA = "0x24E562C", Offset = "0x24E562C", VA = "0x24E562C")]
	private void OnBtnDuplicate()
	{
	}

	[Token(Token = "0x600C3CD")]
	[Address(RVA = "0x24E5758", Offset = "0x24E5758", VA = "0x24E5758")]
	private void OnBtnDelete()
	{
	}

	[Token(Token = "0x600C3CE")]
	[Address(RVA = "0x24E5958", Offset = "0x24E5958", VA = "0x24E5958")]
	private void OnBtnDeletePress(GameObject go, bool isPressed)
	{
	}

	[Token(Token = "0x600C3CF")]
	[Address(RVA = "0x24E5BAC", Offset = "0x24E5BAC", VA = "0x24E5BAC")]
	private IEnumerator PressCheckCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600C3D0")]
	[Address(RVA = "0x24E5C80", Offset = "0x24E5C80", VA = "0x24E5C80")]
	private void OnSceneEditPrefabChosen(object[] data)
	{
	}

	[Token(Token = "0x600C3D1")]
	[Address(RVA = "0x24E5E20", Offset = "0x24E5E20", VA = "0x24E5E20")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C3D2")]
	[Address(RVA = "0x24E5E28", Offset = "0x24E5E28", VA = "0x24E5E28")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600C3D3")]
	[Address(RVA = "0x24E5E30", Offset = "0x24E5E30", VA = "0x24E5E30")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
