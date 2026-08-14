using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2001EBE")]
public class UIDigitaluniverseBDoorInfoController : UIBaseController
{
	[Token(Token = "0x2001EBF")]
	private sealed class _003CDelayClose_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C188")]
		[FieldOffset(Offset = "0x8")]
		internal UIDigitaluniverseBDoorInfoController _0024this;

		[Token(Token = "0x400C189")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400C18A")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400C18B")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17000F44")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6009560")]
			[Address(RVA = "0x2AE2828", Offset = "0x2AE2828", VA = "0x2AE2828", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F45")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009561")]
			[Address(RVA = "0x2AE2830", Offset = "0x2AE2830", VA = "0x2AE2830", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600955E")]
		[Address(RVA = "0x2AE272C", Offset = "0x2AE272C", VA = "0x2AE272C")]
		public _003CDelayClose_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600955F")]
		[Address(RVA = "0x2AE273C", Offset = "0x2AE273C", VA = "0x2AE273C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009562")]
		[Address(RVA = "0x2AE2838", Offset = "0x2AE2838", VA = "0x2AE2838", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6009563")]
		[Address(RVA = "0x2AE284C", Offset = "0x2AE284C", VA = "0x2AE284C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400C182")]
	[FieldOffset(Offset = "0x28")]
	private UIDigitaluniverseBDoorInfoView m_View;

	[Token(Token = "0x400C183")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelDigitaluniverseB m_ModelDigitaluniverseB;

	[Token(Token = "0x400C184")]
	[FieldOffset(Offset = "0x30")]
	private Camera ThreeDCamera;

	[Token(Token = "0x400C185")]
	[FieldOffset(Offset = "0x34")]
	private UIModelBigEvent m_ModelBigEvent;

	[Token(Token = "0x400C186")]
	private const float offsetX = 0.29f;

	[Token(Token = "0x400C187")]
	private const float offsetY = 0.35f;

	[Token(Token = "0x6009553")]
	[Address(RVA = "0x2AE15C0", Offset = "0x2AE15C0", VA = "0x2AE15C0")]
	public UIDigitaluniverseBDoorInfoController()
	{
	}

	[Token(Token = "0x6009554")]
	[Address(RVA = "0x2AE1644", Offset = "0x2AE1644", VA = "0x2AE1644")]
	private void Start()
	{
	}

	[Token(Token = "0x6009555")]
	[Address(RVA = "0x2AE16C0", Offset = "0x2AE16C0", VA = "0x2AE16C0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009556")]
	[Address(RVA = "0x2AE1768", Offset = "0x2AE1768", VA = "0x2AE1768", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009557")]
	[Address(RVA = "0x2AE18D8", Offset = "0x2AE18D8", VA = "0x2AE18D8")]
	public void ShowLabel()
	{
	}

	[Token(Token = "0x6009558")]
	[Address(RVA = "0x2AE1B6C", Offset = "0x2AE1B6C", VA = "0x2AE1B6C")]
	public void HideLabel()
	{
	}

	[Token(Token = "0x6009559")]
	[Address(RVA = "0x2AE1D54", Offset = "0x2AE1D54", VA = "0x2AE1D54")]
	public void UpdatePos(Vector3 pos)
	{
	}

	[Token(Token = "0x600955A")]
	[Address(RVA = "0x2AE207C", Offset = "0x2AE207C", VA = "0x2AE207C")]
	public ELimitedEvent.EventID GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x600955B")]
	[Address(RVA = "0x2AE20D4", Offset = "0x2AE20D4", VA = "0x2AE20D4")]
	public void SetViewData(string objName)
	{
	}

	[Token(Token = "0x600955C")]
	[Address(RVA = "0x2AE1AA0", Offset = "0x2AE1AA0", VA = "0x2AE1AA0")]
	private IEnumerator DelayClose()
	{
		return null;
	}

	[Token(Token = "0x600955D")]
	[Address(RVA = "0x2AE2734", Offset = "0x2AE2734", VA = "0x2AE2734")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
