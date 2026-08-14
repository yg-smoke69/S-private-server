using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

[Token(Token = "0x20020B7")]
public class UIRankCardTipsController : UIPopupWindowController
{
	[Token(Token = "0x20020B8")]
	private sealed class _003CSetPosition_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400CCE9")]
		[FieldOffset(Offset = "0x8")]
		internal Transform _003CcontentTr_003E__0;

		[Token(Token = "0x400CCEA")]
		[FieldOffset(Offset = "0xC")]
		internal Vector3 itemPos;

		[Token(Token = "0x400CCEB")]
		[FieldOffset(Offset = "0x18")]
		internal Vector3 _003Ccenter_003E__0;

		[Token(Token = "0x400CCEC")]
		[FieldOffset(Offset = "0x24")]
		internal Bounds _003Cbounds_003E__0;

		[Token(Token = "0x400CCED")]
		[FieldOffset(Offset = "0x3C")]
		internal Vector3 _003CcontentLocalPos_003E__0;

		[Token(Token = "0x400CCEE")]
		[FieldOffset(Offset = "0x48")]
		internal UIRankCardTipsController _0024this;

		[Token(Token = "0x400CCEF")]
		[FieldOffset(Offset = "0x4C")]
		internal object _0024current;

		[Token(Token = "0x400CCF0")]
		[FieldOffset(Offset = "0x50")]
		internal bool _0024disposing;

		[Token(Token = "0x400CCF1")]
		[FieldOffset(Offset = "0x54")]
		internal int _0024PC;

		[Token(Token = "0x17000FE1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600A8DE")]
			[Address(RVA = "0x2243C54", Offset = "0x2243C54", VA = "0x2243C54", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FE2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600A8DF")]
			[Address(RVA = "0x2243C5C", Offset = "0x2243C5C", VA = "0x2243C5C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600A8DC")]
		[Address(RVA = "0x2243998", Offset = "0x2243998", VA = "0x2243998")]
		public _003CSetPosition_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600A8DD")]
		[Address(RVA = "0x22439A0", Offset = "0x22439A0", VA = "0x22439A0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600A8E0")]
		[Address(RVA = "0x2243C64", Offset = "0x2243C64", VA = "0x2243C64", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600A8E1")]
		[Address(RVA = "0x2243C78", Offset = "0x2243C78", VA = "0x2243C78", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400CCE6")]
	[FieldOffset(Offset = "0x48")]
	private UICouponTipsView m_View;

	[Token(Token = "0x400CCE7")]
	[FieldOffset(Offset = "0x4C")]
	private List<Item> m_ItemList;

	[Token(Token = "0x400CCE8")]
	[FieldOffset(Offset = "0x50")]
	private List<GameObject> m_ItemContainers;

	[Token(Token = "0x600A8D3")]
	[Address(RVA = "0x2243174", Offset = "0x2243174", VA = "0x2243174")]
	public UIRankCardTipsController()
	{
	}

	[Token(Token = "0x600A8D4")]
	[Address(RVA = "0x2243234", Offset = "0x2243234", VA = "0x2243234")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A8D5")]
	[Address(RVA = "0x224329C", Offset = "0x224329C", VA = "0x224329C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A8D6")]
	[Address(RVA = "0x2243488", Offset = "0x2243488", VA = "0x2243488", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A8D7")]
	[Address(RVA = "0x2243490", Offset = "0x2243490", VA = "0x2243490", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x600A8D8")]
	[Address(RVA = "0x2243498", Offset = "0x2243498", VA = "0x2243498", Slot = "35")]
	public override int MinGroupDepth()
	{
		return default(int);
	}

	[Token(Token = "0x600A8D9")]
	[Address(RVA = "0x22434B0", Offset = "0x22434B0", VA = "0x22434B0")]
	public void SetData(string title, string tips, Vector3 itemPos, List<Item> list)
	{
	}

	[Token(Token = "0x600A8DA")]
	[Address(RVA = "0x224374C", Offset = "0x224374C", VA = "0x224374C")]
	private void RefreshItem()
	{
	}

	[Token(Token = "0x600A8DB")]
	[Address(RVA = "0x22438EC", Offset = "0x22438EC", VA = "0x22438EC")]
	private IEnumerator SetPosition(Vector3 itemPos)
	{
		return null;
	}
}
