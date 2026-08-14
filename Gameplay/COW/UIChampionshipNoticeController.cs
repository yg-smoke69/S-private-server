using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002010")]
public class UIChampionshipNoticeController : UIPopupWindowController
{
	[Token(Token = "0x2002011")]
	private sealed class _003CAutoScrollItem_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C975")]
		[FieldOffset(Offset = "0x8")]
		internal UIChampionshipNoticeController _0024this;

		[Token(Token = "0x400C976")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400C977")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400C978")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17000FCF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600A24A")]
			[Address(RVA = "0x2834824", Offset = "0x2834824", VA = "0x2834824", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FD0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600A24B")]
			[Address(RVA = "0x283482C", Offset = "0x283482C", VA = "0x283482C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600A248")]
		[Address(RVA = "0x28341C0", Offset = "0x28341C0", VA = "0x28341C0")]
		public _003CAutoScrollItem_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600A249")]
		[Address(RVA = "0x2834744", Offset = "0x2834744", VA = "0x2834744", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600A24C")]
		[Address(RVA = "0x2834834", Offset = "0x2834834", VA = "0x2834834", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600A24D")]
		[Address(RVA = "0x2834848", Offset = "0x2834848", VA = "0x2834848", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400C96D")]
	[FieldOffset(Offset = "0x48")]
	private UIChampionshipNoticePopupView m_View;

	[Token(Token = "0x400C96E")]
	[FieldOffset(Offset = "0x4C")]
	private ChampionshipSettingDesc m_SettingInfo;

	[Token(Token = "0x400C96F")]
	[FieldOffset(Offset = "0x50")]
	private List<string> m_CDNUrlList;

	[Token(Token = "0x400C970")]
	[FieldOffset(Offset = "0x54")]
	private List<uint> m_GoPosList;

	[Token(Token = "0x400C971")]
	[FieldOffset(Offset = "0x58")]
	private List<uint> m_SubGoPosList;

	[Token(Token = "0x400C972")]
	[FieldOffset(Offset = "0x5C")]
	private int m_selectedIndex;

	[Token(Token = "0x400C973")]
	[FieldOffset(Offset = "0x60")]
	private List<UIChampionshipNoticeDotController> m_DotCtrls;

	[Token(Token = "0x400C974")]
	[FieldOffset(Offset = "0x64")]
	private List<UIChampionshipNoticeItemController> m_NetworkTextures;

	[Token(Token = "0x600A239")]
	[Address(RVA = "0x283348C", Offset = "0x283348C", VA = "0x283348C")]
	public UIChampionshipNoticeController()
	{
	}

	[Token(Token = "0x600A23A")]
	[Address(RVA = "0x28335D4", Offset = "0x28335D4", VA = "0x28335D4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A23B")]
	[Address(RVA = "0x283367C", Offset = "0x283367C", VA = "0x283367C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A23C")]
	[Address(RVA = "0x2833924", Offset = "0x2833924", VA = "0x2833924", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600A23D")]
	[Address(RVA = "0x2833988", Offset = "0x2833988", VA = "0x2833988", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A23E")]
	[Address(RVA = "0x28339F8", Offset = "0x28339F8", VA = "0x28339F8")]
	public void SetData(List<string> CDNUrlList, List<uint> goPosList, List<uint> subGoPosList)
	{
	}

	[Token(Token = "0x600A23F")]
	[Address(RVA = "0x2833A88", Offset = "0x2833A88", VA = "0x2833A88")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600A240")]
	[Address(RVA = "0x28340F4", Offset = "0x28340F4", VA = "0x28340F4")]
	private IEnumerator AutoScrollItem()
	{
		return null;
	}

	[Token(Token = "0x600A241")]
	[Address(RVA = "0x28341C8", Offset = "0x28341C8", VA = "0x28341C8")]
	private void OnAutoScrollAdItem(int next = 1)
	{
	}

	[Token(Token = "0x600A242")]
	[Address(RVA = "0x28343F8", Offset = "0x28343F8", VA = "0x28343F8")]
	private void OnLeftBtnClick()
	{
	}

	[Token(Token = "0x600A243")]
	[Address(RVA = "0x283445C", Offset = "0x283445C", VA = "0x283445C")]
	private void OnRightBtnClick()
	{
	}

	[Token(Token = "0x600A244")]
	[Address(RVA = "0x28344C0", Offset = "0x28344C0", VA = "0x28344C0")]
	private void GetCenterItem(GameObject centeredObject)
	{
	}

	[Token(Token = "0x600A245")]
	[Address(RVA = "0x283472C", Offset = "0x283472C", VA = "0x283472C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A246")]
	[Address(RVA = "0x2834734", Offset = "0x2834734", VA = "0x2834734")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600A247")]
	[Address(RVA = "0x283473C", Offset = "0x283473C", VA = "0x283473C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
