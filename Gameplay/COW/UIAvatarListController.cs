using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20024B7")]
public class UIAvatarListController : UINavigationController, _Attribute
{
	[Token(Token = "0x20024B8")]
	private sealed class _003CRefresh_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E3B3")]
		[FieldOffset(Offset = "0x8")]
		internal UIModelAvatarProfile model;

		[Token(Token = "0x600D2A4")]
		[Address(RVA = "0x2A9D9A4", Offset = "0x2A9D9A4", VA = "0x2A9D9A4")]
		public _003CRefresh_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600D2A5")]
		[Address(RVA = "0x2A9DF24", Offset = "0x2A9DF24", VA = "0x2A9DF24")]
		internal bool _003C_003Em__0(AvatarProfile a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400E3AB")]
	[FieldOffset(Offset = "0x68")]
	private UIAvatarListView m_View;

	[Token(Token = "0x400E3AC")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelAvatarProfile m_Model;

	[Token(Token = "0x400E3AD")]
	[FieldOffset(Offset = "0x70")]
	private uint m_CurrentShowAvatarID;

	[Token(Token = "0x400E3AE")]
	private const float ITEM_WIDTH = 256f;

	[Token(Token = "0x400E3AF")]
	private const float ITEM_HEIGHT = 365f;

	[Token(Token = "0x400E3B0")]
	[FieldOffset(Offset = "0x74")]
	private UIGuideTipsController m_GuideTipsCtrl;

	[Token(Token = "0x400E3B1")]
	[FieldOffset(Offset = "0x78")]
	private bool m_ShowLatest;

	[Token(Token = "0x400E3B2")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<AvatarProfile> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x1700112F")]
	public uint CurrentShowAvatarID
	{
		[Token(Token = "0x600D291")]
		[Address(RVA = "0x2A9C800", Offset = "0x2A9C800", VA = "0x2A9C800")]
		set
		{
		}
	}

	[Token(Token = "0x17001130")]
	public bool ShowLatest
	{
		[Token(Token = "0x600D292")]
		[Address(RVA = "0x2A9D1A8", Offset = "0x2A9D1A8", VA = "0x2A9D1A8")]
		set
		{
		}
	}

	[Token(Token = "0x600D290")]
	[Address(RVA = "0x2A9C77C", Offset = "0x2A9C77C", VA = "0x2A9C77C")]
	public UIAvatarListController()
	{
	}

	[Token(Token = "0x600D293")]
	[Address(RVA = "0x2A9D214", Offset = "0x2A9D214", VA = "0x2A9D214")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D294")]
	[Address(RVA = "0x2A9D2B8", Offset = "0x2A9D2B8", VA = "0x2A9D2B8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D295")]
	[Address(RVA = "0x2A9D60C", Offset = "0x2A9D60C", VA = "0x2A9D60C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D296")]
	[Address(RVA = "0x2A9D740", Offset = "0x2A9D740", VA = "0x2A9D740")]
	private void StopNewbieGuide(object[] args)
	{
	}

	[Token(Token = "0x600D297")]
	[Address(RVA = "0x2A9D84C", Offset = "0x2A9D84C", VA = "0x2A9D84C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600D298")]
	[Address(RVA = "0x2A9D8B0", Offset = "0x2A9D8B0", VA = "0x2A9D8B0", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600D299")]
	[Address(RVA = "0x2A9D91C", Offset = "0x2A9D91C", VA = "0x2A9D91C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600D29A")]
	[Address(RVA = "0x2A9C86C", Offset = "0x2A9C86C", VA = "0x2A9C86C")]
	public void Refresh()
	{
	}

	[Token(Token = "0x600D29B")]
	[Address(RVA = "0x2A9DBB0", Offset = "0x2A9DBB0", VA = "0x2A9DBB0", Slot = "42")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600D29C")]
	[Address(RVA = "0x2A9DCA8", Offset = "0x2A9DCA8", VA = "0x2A9DCA8", Slot = "43")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600D29D")]
	[Address(RVA = "0x2A9DD24", Offset = "0x2A9DD24", VA = "0x2A9DD24")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600D29E")]
	[Address(RVA = "0x2A9DEC8", Offset = "0x2A9DEC8", VA = "0x2A9DEC8")]
	private static int _003CRefresh_003Em__1(AvatarProfile a, AvatarProfile b)
	{
		return default(int);
	}

	[Token(Token = "0x600D29F")]
	[Address(RVA = "0x2A9DEFC", Offset = "0x2A9DEFC", VA = "0x2A9DEFC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D2A0")]
	[Address(RVA = "0x2A9DF04", Offset = "0x2A9DF04", VA = "0x2A9DF04")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600D2A1")]
	[Address(RVA = "0x2A9DF0C", Offset = "0x2A9DF0C", VA = "0x2A9DF0C")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600D2A2")]
	[Address(RVA = "0x2A9DF14", Offset = "0x2A9DF14", VA = "0x2A9DF14")]
	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600D2A3")]
	[Address(RVA = "0x2A9DF1C", Offset = "0x2A9DF1C", VA = "0x2A9DF1C")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
