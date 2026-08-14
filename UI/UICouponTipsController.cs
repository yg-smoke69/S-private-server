using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

[Token(Token = "0x20020AE")]
public class UICouponTipsController : UIPopupWindowController
{
	[Token(Token = "0x20020AF")]
	private sealed class _003CSetPosition_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400CCBB")]
		[FieldOffset(Offset = "0x8")]
		internal Transform _003CcontentTr_003E__0;

		[Token(Token = "0x400CCBC")]
		[FieldOffset(Offset = "0xC")]
		internal Vector3 itemPos;

		[Token(Token = "0x400CCBD")]
		[FieldOffset(Offset = "0x18")]
		internal Vector3 _003Ccenter_003E__0;

		[Token(Token = "0x400CCBE")]
		[FieldOffset(Offset = "0x24")]
		internal Bounds _003Cbounds_003E__0;

		[Token(Token = "0x400CCBF")]
		[FieldOffset(Offset = "0x3C")]
		internal Vector3 _003CcontentLocalPos_003E__0;

		[Token(Token = "0x400CCC0")]
		[FieldOffset(Offset = "0x48")]
		internal UICouponTipsController _0024this;

		[Token(Token = "0x400CCC1")]
		[FieldOffset(Offset = "0x4C")]
		internal object _0024current;

		[Token(Token = "0x400CCC2")]
		[FieldOffset(Offset = "0x50")]
		internal bool _0024disposing;

		[Token(Token = "0x400CCC3")]
		[FieldOffset(Offset = "0x54")]
		internal int _0024PC;

		[Token(Token = "0x17000FDD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600A8A0")]
			[Address(RVA = "0x146AB60", Offset = "0x146AB60", VA = "0x146AB60", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FDE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600A8A1")]
			[Address(RVA = "0x146AB68", Offset = "0x146AB68", VA = "0x146AB68", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600A89E")]
		[Address(RVA = "0x146A8A4", Offset = "0x146A8A4", VA = "0x146A8A4")]
		public _003CSetPosition_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600A89F")]
		[Address(RVA = "0x146A8AC", Offset = "0x146A8AC", VA = "0x146A8AC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600A8A2")]
		[Address(RVA = "0x146AB70", Offset = "0x146AB70", VA = "0x146AB70", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600A8A3")]
		[Address(RVA = "0x146AB84", Offset = "0x146AB84", VA = "0x146AB84", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400CCB8")]
	[FieldOffset(Offset = "0x48")]
	private UICouponTipsView m_View;

	[Token(Token = "0x400CCB9")]
	[FieldOffset(Offset = "0x4C")]
	private List<Item> m_ItemList;

	[Token(Token = "0x400CCBA")]
	[FieldOffset(Offset = "0x50")]
	private List<GameObject> m_ItemContainers;

	[Token(Token = "0x600A895")]
	[Address(RVA = "0x146A120", Offset = "0x146A120", VA = "0x146A120")]
	public UICouponTipsController()
	{
	}

	[Token(Token = "0x600A896")]
	[Address(RVA = "0x146A1E0", Offset = "0x146A1E0", VA = "0x146A1E0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A897")]
	[Address(RVA = "0x146A248", Offset = "0x146A248", VA = "0x146A248", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A898")]
	[Address(RVA = "0x146A434", Offset = "0x146A434", VA = "0x146A434", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A899")]
	[Address(RVA = "0x146A43C", Offset = "0x146A43C", VA = "0x146A43C", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x600A89A")]
	[Address(RVA = "0x146A444", Offset = "0x146A444", VA = "0x146A444", Slot = "35")]
	public override int MinGroupDepth()
	{
		return default(int);
	}

	[Token(Token = "0x600A89B")]
	[Address(RVA = "0x146A45C", Offset = "0x146A45C", VA = "0x146A45C")]
	public void SetData(string title, string tips, Vector3 itemPos, [Optional] Item item1, [Optional] Item item2, [Optional] Item item3)
	{
	}

	[Token(Token = "0x600A89C")]
	[Address(RVA = "0x146A658", Offset = "0x146A658", VA = "0x146A658")]
	private void RefreshItem()
	{
	}

	[Token(Token = "0x600A89D")]
	[Address(RVA = "0x146A7F8", Offset = "0x146A7F8", VA = "0x146A7F8")]
	private IEnumerator SetPosition(Vector3 itemPos)
	{
		return null;
	}
}
