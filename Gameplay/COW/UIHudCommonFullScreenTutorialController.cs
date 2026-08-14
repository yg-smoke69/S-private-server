using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200270F")]
internal class UIHudCommonFullScreenTutorialController : UIPopupWindowController
{
	[Token(Token = "0x2002710")]
	private sealed class _003CSetViewData_003Ec__AnonStorey0
	{
		[Token(Token = "0x400F116")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x400F117")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudCommonFullScreenTutorialController _0024this;

		[Token(Token = "0x600ED5D")]
		[Address(RVA = "0x135E6D0", Offset = "0x135E6D0", VA = "0x135E6D0")]
		public _003CSetViewData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600ED5E")]
		[Address(RVA = "0x135EA74", Offset = "0x135EA74", VA = "0x135EA74")]
		internal bool _003C_003Em__0(CommonFullScreenIntroData e)
		{
			return default(bool);
		}

		[Token(Token = "0x600ED5F")]
		[Address(RVA = "0x135EAAC", Offset = "0x135EAAC", VA = "0x135EAAC")]
		internal void _003C_003Em__1()
		{
		}

		[Token(Token = "0x600ED60")]
		[Address(RVA = "0x135EBA4", Offset = "0x135EBA4", VA = "0x135EBA4")]
		internal void _003C_003Em__2()
		{
		}

		[Token(Token = "0x600ED61")]
		[Address(RVA = "0x135EC9C", Offset = "0x135EC9C", VA = "0x135EC9C")]
		internal void _003C_003Em__3()
		{
		}
	}

	[Token(Token = "0x400F110")]
	[FieldOffset(Offset = "0x48")]
	private UIHudCommonFullScreenTutorialView m_View;

	[Token(Token = "0x400F111")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_BtnEnabledDelayCall;

	[Token(Token = "0x400F112")]
	[FieldOffset(Offset = "0x50")]
	private Action m_CloseCallBack;

	[Token(Token = "0x400F113")]
	[FieldOffset(Offset = "0x54")]
	private bool m_CloseEnabled;

	[Token(Token = "0x400F114")]
	[FieldOffset(Offset = "0x58")]
	private int m_StartCountDown;

	[Token(Token = "0x400F115")]
	private const int MASK_CLOSE_TIME = 3;

	[Token(Token = "0x600ED54")]
	[Address(RVA = "0x135DA6C", Offset = "0x135DA6C", VA = "0x135DA6C")]
	public UIHudCommonFullScreenTutorialController()
	{
	}

	[Token(Token = "0x600ED55")]
	[Address(RVA = "0x135DA74", Offset = "0x135DA74", VA = "0x135DA74")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600ED56")]
	[Address(RVA = "0x135DB1C", Offset = "0x135DB1C", VA = "0x135DB1C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600ED57")]
	[Address(RVA = "0x135DE88", Offset = "0x135DE88", VA = "0x135DE88", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600ED58")]
	[Address(RVA = "0x135DFA4", Offset = "0x135DFA4", VA = "0x135DFA4")]
	public void SetViewData(uint id, Action cb)
	{
	}

	[Token(Token = "0x600ED59")]
	[Address(RVA = "0x135E6D8", Offset = "0x135E6D8", VA = "0x135E6D8")]
	private void OnMaskBtnClick()
	{
	}

	[Token(Token = "0x600ED5A")]
	[Address(RVA = "0x135E764", Offset = "0x135E764", VA = "0x135E764")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600ED5B")]
	[Address(RVA = "0x135EA64", Offset = "0x135EA64", VA = "0x135EA64")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600ED5C")]
	[Address(RVA = "0x135EA6C", Offset = "0x135EA6C", VA = "0x135EA6C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
