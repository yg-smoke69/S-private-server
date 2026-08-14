using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2001EA4")]
public class UIDigitaluniverseBActivityCardDetailController : UIPopupWindowController
{
	[Token(Token = "0x2001EA5")]
	private sealed class _003CPlayPassIconAni_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C0B0")]
		[FieldOffset(Offset = "0x8")]
		internal int index;

		[Token(Token = "0x400C0B1")]
		[FieldOffset(Offset = "0xC")]
		internal UIDigitaluniverseBActivityCardDetailController _0024this;

		[Token(Token = "0x400C0B2")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400C0B3")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400C0B4")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x17000F38")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60093FF")]
			[Address(RVA = "0x2D8DD90", Offset = "0x2D8DD90", VA = "0x2D8DD90", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F39")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009400")]
			[Address(RVA = "0x2D8DD98", Offset = "0x2D8DD98", VA = "0x2D8DD98", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60093FD")]
		[Address(RVA = "0x2D8CD1C", Offset = "0x2D8CD1C", VA = "0x2D8CD1C")]
		public _003CPlayPassIconAni_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x60093FE")]
		[Address(RVA = "0x2D8D760", Offset = "0x2D8D760", VA = "0x2D8D760", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009401")]
		[Address(RVA = "0x2D8DDA0", Offset = "0x2D8DDA0", VA = "0x2D8DDA0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6009402")]
		[Address(RVA = "0x2D8DDB4", Offset = "0x2D8DDB4", VA = "0x2D8DDB4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400C0A3")]
	[FieldOffset(Offset = "0x48")]
	private UIDigitaluniverseBActivityCardDetailView m_View;

	[Token(Token = "0x400C0A4")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelDigitaluniverseB m_ModelDigitaluniverseB;

	[Token(Token = "0x400C0A5")]
	[FieldOffset(Offset = "0x50")]
	private ulong m_AccountID;

	[Token(Token = "0x400C0A6")]
	[FieldOffset(Offset = "0x58")]
	private readonly List<UIDigitaluniverseBActivityCardItemController> m_CardItemList;

	[Token(Token = "0x400C0A7")]
	[FieldOffset(Offset = "0x5C")]
	private List<DigitaluniverseBPostcardDesc> m_CardDescList;

	[Token(Token = "0x400C0A8")]
	[FieldOffset(Offset = "0x60")]
	private Coroutine m_PassIconShowCoroutine;

	[Token(Token = "0x400C0A9")]
	[FieldOffset(Offset = "0x64")]
	private int m_LastSelectedIndex;

	[Token(Token = "0x400C0AA")]
	[FieldOffset(Offset = "0x68")]
	private int m_CardCount;

	[Token(Token = "0x400C0AB")]
	private const int TWO_CARD_NUM = 2;

	[Token(Token = "0x400C0AC")]
	private const float PASSICON_ANI_DELAY = 0.66f;

	[Token(Token = "0x400C0AD")]
	private const float PASSICON_ANI_AUDIO_DELAY = 0.66f;

	[Token(Token = "0x400C0AE")]
	private const string TYPEWRITER_PLAYERPREFS = "DigitaluniverseB_Typewriter_{0}_{1}";

	[Token(Token = "0x400C0AF")]
	private const string PASSICON_PLAYERPREFS = "DigitaluniverseB_PassIcon_{0}_{1}";

	[Token(Token = "0x60093EE")]
	[Address(RVA = "0x2D8B9E4", Offset = "0x2D8B9E4", VA = "0x2D8B9E4")]
	public UIDigitaluniverseBActivityCardDetailController()
	{
	}

	[Token(Token = "0x60093EF")]
	[Address(RVA = "0x2D8BAAC", Offset = "0x2D8BAAC", VA = "0x2D8BAAC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60093F0")]
	[Address(RVA = "0x2D8BB54", Offset = "0x2D8BB54", VA = "0x2D8BB54", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60093F1")]
	[Address(RVA = "0x2D8BE6C", Offset = "0x2D8BE6C", VA = "0x2D8BE6C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60093F2")]
	[Address(RVA = "0x2D8BEE4", Offset = "0x2D8BEE4", VA = "0x2D8BEE4")]
	public void SetViewData(int index)
	{
	}

	[Token(Token = "0x60093F3")]
	[Address(RVA = "0x2D8CB90", Offset = "0x2D8CB90", VA = "0x2D8CB90")]
	private void DelayShowPassIcon(int index)
	{
	}

	[Token(Token = "0x60093F4")]
	[Address(RVA = "0x2D8CC30", Offset = "0x2D8CC30", VA = "0x2D8CC30")]
	private IEnumerator PlayPassIconAni(int index)
	{
		return null;
	}

	[Token(Token = "0x60093F5")]
	[Address(RVA = "0x2D8CD24", Offset = "0x2D8CD24", VA = "0x2D8CD24")]
	private void SetScrollItem(bool moveRight)
	{
	}

	[Token(Token = "0x60093F6")]
	[Address(RVA = "0x2D8CF9C", Offset = "0x2D8CF9C", VA = "0x2D8CF9C")]
	private void GetCenterItem(GameObject centerGo)
	{
	}

	[Token(Token = "0x60093F7")]
	[Address(RVA = "0x2D8D368", Offset = "0x2D8D368", VA = "0x2D8D368")]
	private void OnLeftIconClick()
	{
	}

	[Token(Token = "0x60093F8")]
	[Address(RVA = "0x2D8D3CC", Offset = "0x2D8D3CC", VA = "0x2D8D3CC")]
	private void OnRightIconClick()
	{
	}

	[Token(Token = "0x60093F9")]
	[Address(RVA = "0x2D8D430", Offset = "0x2D8D430", VA = "0x2D8D430")]
	public void SetBtnCloseState(bool isShow)
	{
	}

	[Token(Token = "0x60093FA")]
	[Address(RVA = "0x2D8D544", Offset = "0x2D8D544", VA = "0x2D8D544")]
	public void HideAllBubble()
	{
	}

	[Token(Token = "0x60093FB")]
	[Address(RVA = "0x2D8D750", Offset = "0x2D8D750", VA = "0x2D8D750")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60093FC")]
	[Address(RVA = "0x2D8D758", Offset = "0x2D8D758", VA = "0x2D8D758")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
