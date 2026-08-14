using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002A35")]
public class UIPaymentShopController : UIPaymentController.PaymentTabContentController
{
	[Token(Token = "0x2002A36")]
	private sealed class _003COpenWebView_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x401039C")]
		[FieldOffset(Offset = "0x8")]
		internal int _003CframeCount_003E__1;

		[Token(Token = "0x401039D")]
		[FieldOffset(Offset = "0xC")]
		internal UIPaymentShopController _0024this;

		[Token(Token = "0x401039E")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x401039F")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x40103A0")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x17001284")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6011178")]
			[Address(RVA = "0x29DE0A0", Offset = "0x29DE0A0", VA = "0x29DE0A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001285")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6011179")]
			[Address(RVA = "0x29DE0A8", Offset = "0x29DE0A8", VA = "0x29DE0A8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6011176")]
		[Address(RVA = "0x29DD7BC", Offset = "0x29DD7BC", VA = "0x29DD7BC")]
		public _003COpenWebView_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6011177")]
		[Address(RVA = "0x29DD8B4", Offset = "0x29DD8B4", VA = "0x29DD8B4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601117A")]
		[Address(RVA = "0x29DE0B0", Offset = "0x29DE0B0", VA = "0x29DE0B0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601117B")]
		[Address(RVA = "0x29DE0C4", Offset = "0x29DE0C4", VA = "0x29DE0C4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4010394")]
	[FieldOffset(Offset = "0x28")]
	private UIPaymentShopView m_View;

	[Token(Token = "0x4010395")]
	private const uint MAXWAITFRAMECOUNT = 10u;

	[Token(Token = "0x4010396")]
	[FieldOffset(Offset = "0x2C")]
	private WebView m_WebView;

	[Token(Token = "0x4010397")]
	[FieldOffset(Offset = "0x30")]
	private WebView.Rect m_WebViewRect;

	[Token(Token = "0x4010398")]
	[FieldOffset(Offset = "0x34")]
	private UIModelPayment m_PaymentModel;

	[Token(Token = "0x4010399")]
	[FieldOffset(Offset = "0x38")]
	private float m_LastRectWidht;

	[Token(Token = "0x401039A")]
	[FieldOffset(Offset = "0x3C")]
	private Coroutine m_OpenWebViewCoroutine;

	[Token(Token = "0x401039B")]
	[FieldOffset(Offset = "0x40")]
	private List<AdvertDesc> _Ads;

	[Token(Token = "0x6011162")]
	[Address(RVA = "0x29DC844", Offset = "0x29DC844", VA = "0x29DC844")]
	public UIPaymentShopController()
	{
	}

	[Token(Token = "0x6011163")]
	[Address(RVA = "0x29DC84C", Offset = "0x29DC84C", VA = "0x29DC84C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011164")]
	[Address(RVA = "0x29DC8F4", Offset = "0x29DC8F4", VA = "0x29DC8F4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011165")]
	[Address(RVA = "0x29DCB34", Offset = "0x29DCB34", VA = "0x29DCB34", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011166")]
	[Address(RVA = "0x29DCD84", Offset = "0x29DCD84", VA = "0x29DCD84", Slot = "21")]
	public override void Show()
	{
	}

	[Token(Token = "0x6011167")]
	[Address(RVA = "0x29DCEF8", Offset = "0x29DCEF8", VA = "0x29DCEF8", Slot = "22")]
	public override void Hide()
	{
	}

	[Token(Token = "0x6011168")]
	[Address(RVA = "0x29DCF64", Offset = "0x29DCF64", VA = "0x29DCF64", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6011169")]
	[Address(RVA = "0x29DD034", Offset = "0x29DD034", VA = "0x29DD034", Slot = "32")]
	public override void RefreshContent()
	{
	}

	[Token(Token = "0x601116A")]
	[Address(RVA = "0x29DD688", Offset = "0x29DD688", VA = "0x29DD688")]
	private void OnButtonClick()
	{
	}

	[Token(Token = "0x601116B")]
	[Address(RVA = "0x29DD5DC", Offset = "0x29DD5DC", VA = "0x29DD5DC")]
	private void ApplyCdnUrlToNetworkTexture(UINetworkTextureExt networkTexture, string url)
	{
	}

	[Token(Token = "0x601116C")]
	[Address(RVA = "0x29DCE2C", Offset = "0x29DCE2C", VA = "0x29DCE2C")]
	private IEnumerator OpenWebView()
	{
		return null;
	}

	[Token(Token = "0x601116D")]
	[Address(RVA = "0x29DCCF0", Offset = "0x29DCCF0", VA = "0x29DCCF0")]
	private void CloseWebView()
	{
	}

	[Token(Token = "0x601116E")]
	[Address(RVA = "0x29DD7C4", Offset = "0x29DD7C4", VA = "0x29DD7C4", Slot = "33")]
	public override void OnPopUpWindowListChange(bool isCovered)
	{
	}

	[Token(Token = "0x601116F")]
	[Address(RVA = "0x29DD87C", Offset = "0x29DD87C", VA = "0x29DD87C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011170")]
	[Address(RVA = "0x29DD884", Offset = "0x29DD884", VA = "0x29DD884")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6011171")]
	[Address(RVA = "0x29DD88C", Offset = "0x29DD88C", VA = "0x29DD88C")]
	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	[Token(Token = "0x6011172")]
	[Address(RVA = "0x29DD894", Offset = "0x29DD894", VA = "0x29DD894")]
	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	[Token(Token = "0x6011173")]
	[Address(RVA = "0x29DD89C", Offset = "0x29DD89C", VA = "0x29DD89C")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6011174")]
	[Address(RVA = "0x29DD8A4", Offset = "0x29DD8A4", VA = "0x29DD8A4")]
	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}

	[Token(Token = "0x6011175")]
	[Address(RVA = "0x29DD8AC", Offset = "0x29DD8AC", VA = "0x29DD8AC")]
	public void _003C_003EiFixBaseProxy_OnPopUpWindowListChange(bool P0)
	{
	}
}
