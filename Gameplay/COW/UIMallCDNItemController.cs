using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20021D3")]
public class UIMallCDNItemController : UIMallItemBaseController
{
	[Token(Token = "0x20021D4")]
	private sealed class _003CPriceTableReposition_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D375")]
		[FieldOffset(Offset = "0x8")]
		internal UITable table;

		[Token(Token = "0x400D376")]
		[FieldOffset(Offset = "0xC")]
		internal Bounds _003Cbounds_003E__0;

		[Token(Token = "0x400D377")]
		[FieldOffset(Offset = "0x24")]
		internal int _003Cwidth_003E__0;

		[Token(Token = "0x400D378")]
		[FieldOffset(Offset = "0x28")]
		internal UIWidget spriteBG;

		[Token(Token = "0x400D379")]
		[FieldOffset(Offset = "0x2C")]
		internal UIMallCDNItemController _0024this;

		[Token(Token = "0x400D37A")]
		[FieldOffset(Offset = "0x30")]
		internal object _0024current;

		[Token(Token = "0x400D37B")]
		[FieldOffset(Offset = "0x34")]
		internal bool _0024disposing;

		[Token(Token = "0x400D37C")]
		[FieldOffset(Offset = "0x38")]
		internal int _0024PC;

		[Token(Token = "0x1700102B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600B546")]
			[Address(RVA = "0x2399980", Offset = "0x2399980", VA = "0x2399980", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700102C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600B547")]
			[Address(RVA = "0x2399988", Offset = "0x2399988", VA = "0x2399988", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B544")]
		[Address(RVA = "0x23996F0", Offset = "0x23996F0", VA = "0x23996F0")]
		public _003CPriceTableReposition_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600B545")]
		[Address(RVA = "0x23997C8", Offset = "0x23997C8", VA = "0x23997C8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600B548")]
		[Address(RVA = "0x2399990", Offset = "0x2399990", VA = "0x2399990", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600B549")]
		[Address(RVA = "0x23999A4", Offset = "0x23999A4", VA = "0x23999A4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400D372")]
	[FieldOffset(Offset = "0x12C")]
	protected string m_URL;

	[Token(Token = "0x400D373")]
	[FieldOffset(Offset = "0x130")]
	private int PriceBGExtraWidth;

	[Token(Token = "0x400D374")]
	[FieldOffset(Offset = "0x134")]
	private int PriceBGMinWidth;

	[Token(Token = "0x600B533")]
	[Address(RVA = "0x2396CA8", Offset = "0x2396CA8", VA = "0x2396CA8")]
	public UIMallCDNItemController()
	{
	}

	[Token(Token = "0x600B534")]
	[Address(RVA = "0x2396FE8", Offset = "0x2396FE8", VA = "0x2396FE8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B535")]
	[Address(RVA = "0x23991EC", Offset = "0x23991EC", VA = "0x23991EC", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600B536")]
	[Address(RVA = "0x2399550", Offset = "0x2399550", VA = "0x2399550", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600B537")]
	[Address(RVA = "0x239821C", Offset = "0x239821C", VA = "0x239821C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600B538")]
	[Address(RVA = "0x2397608", Offset = "0x2397608", VA = "0x2397608")]
	protected void RefreshDiscountTag(UILabel discountLabel, StoreDesc m_Info)
	{
	}

	[Token(Token = "0x600B539")]
	[Address(RVA = "0x23973B0", Offset = "0x23973B0", VA = "0x23973B0", Slot = "42")]
	protected override void RefreshItemView()
	{
	}

	[Token(Token = "0x600B53A")]
	[Address(RVA = "0x2397FE8", Offset = "0x2397FE8", VA = "0x2397FE8", Slot = "43")]
	protected override void ResetState()
	{
	}

	[Token(Token = "0x600B53B")]
	[Address(RVA = "0x2397804", Offset = "0x2397804", VA = "0x2397804")]
	protected void SetPriceInfo(UITable priceContainer, GameObject diamondIcon, UILabel diamondPrice, GameObject goldIcon, GameObject slash, UILabel goldPrice, UILabel originalPrice, StoreDesc desc, UIWidget spriteBG)
	{
	}

	[Token(Token = "0x600B53C")]
	[Address(RVA = "0x23995D8", Offset = "0x23995D8", VA = "0x23995D8")]
	private IEnumerator PriceTableReposition(UITable table, UIWidget spriteBG)
	{
		return null;
	}

	[Token(Token = "0x600B53D")]
	[Address(RVA = "0x23996F8", Offset = "0x23996F8", VA = "0x23996F8")]
	protected Bounds CalcPriceContainerBounds(Transform priceContainer)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Bounds);
	}

	[Token(Token = "0x600B53E")]
	[Address(RVA = "0x2399798", Offset = "0x2399798", VA = "0x2399798")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B53F")]
	[Address(RVA = "0x23997A0", Offset = "0x23997A0", VA = "0x23997A0")]
	public void _003C_003EiFixBaseProxy_RefreshItemView()
	{
	}

	[Token(Token = "0x600B540")]
	[Address(RVA = "0x23997A8", Offset = "0x23997A8", VA = "0x23997A8")]
	public void _003C_003EiFixBaseProxy_ResetState()
	{
	}

	[Token(Token = "0x600B541")]
	[Address(RVA = "0x23997B0", Offset = "0x23997B0", VA = "0x23997B0")]
	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	[Token(Token = "0x600B542")]
	[Address(RVA = "0x23997B8", Offset = "0x23997B8", VA = "0x23997B8")]
	public new void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600B543")]
	[Address(RVA = "0x23997C0", Offset = "0x23997C0", VA = "0x23997C0")]
	public new void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
