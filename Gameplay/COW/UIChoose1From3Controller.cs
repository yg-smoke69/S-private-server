using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002521")]
public class UIChoose1From3Controller : UIPreviewPopUpWindowController, _Attribute
{
	[Token(Token = "0x400E63F")]
	[FieldOffset(Offset = "0x5C")]
	private UIModelIAPBundle m_ModelBundle;

	[Token(Token = "0x400E640")]
	[FieldOffset(Offset = "0x60")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x400E641")]
	[FieldOffset(Offset = "0x64")]
	private UIModelMall m_ModelMall;

	[Token(Token = "0x400E642")]
	[FieldOffset(Offset = "0x68")]
	private UIChoose1From3View m_View;

	[Token(Token = "0x400E643")]
	[FieldOffset(Offset = "0x6C")]
	private UIRoot m_UIRoot;

	[Token(Token = "0x400E644")]
	[FieldOffset(Offset = "0x70")]
	private uint m_ItemID;

	[Token(Token = "0x400E645")]
	[FieldOffset(Offset = "0x74")]
	private List<UIChoose1From3ItemController> m_Items;

	[Token(Token = "0x400E646")]
	[FieldOffset(Offset = "0x78")]
	private Transform[] m_ItemRoots;

	[Token(Token = "0x400E647")]
	[FieldOffset(Offset = "0x7C")]
	private OptionalBundleShowData m_CurData;

	[Token(Token = "0x400E648")]
	[FieldOffset(Offset = "0x80")]
	private uint m_BundleID;

	[Token(Token = "0x600D7CA")]
	[Address(RVA = "0x208ABB0", Offset = "0x208ABB0", VA = "0x208ABB0")]
	public UIChoose1From3Controller()
	{
	}

	[Token(Token = "0x600D7CB")]
	[Address(RVA = "0x208AC3C", Offset = "0x208AC3C", VA = "0x208AC3C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D7CC")]
	[Address(RVA = "0x208ACE0", Offset = "0x208ACE0", VA = "0x208ACE0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D7CD")]
	[Address(RVA = "0x208BC68", Offset = "0x208BC68", VA = "0x208BC68", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600D7CE")]
	[Address(RVA = "0x208BDF4", Offset = "0x208BDF4", VA = "0x208BDF4")]
	public void OnClickRecharge()
	{
	}

	[Token(Token = "0x600D7CF")]
	[Address(RVA = "0x208BEE8", Offset = "0x208BEE8", VA = "0x208BEE8")]
	public void OnClickClaim()
	{
	}

	[Token(Token = "0x600D7D0")]
	[Address(RVA = "0x208B2F4", Offset = "0x208B2F4", VA = "0x208B2F4")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x600D7D1")]
	[Address(RVA = "0x208C380", Offset = "0x208C380", VA = "0x208C380")]
	private void SetItemID(OptionalBundleShowData data)
	{
	}

	[Token(Token = "0x600D7D2")]
	[Address(RVA = "0x208C6A8", Offset = "0x208C6A8", VA = "0x208C6A8", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600D7D3")]
	[Address(RVA = "0x208C62C", Offset = "0x208C62C", VA = "0x208C62C")]
	private void ShowPreview()
	{
	}

	[Token(Token = "0x600D7D4")]
	[Address(RVA = "0x208C714", Offset = "0x208C714", VA = "0x208C714")]
	private void SetPreviewInfo()
	{
	}

	[Token(Token = "0x600D7D5")]
	[Address(RVA = "0x208C840", Offset = "0x208C840", VA = "0x208C840", Slot = "67")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D7D6")]
	[Address(RVA = "0x208CB28", Offset = "0x208CB28", VA = "0x208CB28", Slot = "68")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D7D7")]
	[Address(RVA = "0x208CBE0", Offset = "0x208CBE0", VA = "0x208CBE0")]
	private void OnCountDownEnd()
	{
	}

	[Token(Token = "0x600D7D8")]
	[Address(RVA = "0x208CCF8", Offset = "0x208CCF8", VA = "0x208CCF8", Slot = "46")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x600D7D9")]
	[Address(RVA = "0x208CD50", Offset = "0x208CD50", VA = "0x208CD50", Slot = "47")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x600D7DA")]
	[Address(RVA = "0x208CDC0", Offset = "0x208CDC0", VA = "0x208CDC0")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D7DB")]
	[Address(RVA = "0x208CDC8", Offset = "0x208CDC8", VA = "0x208CDC8")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600D7DC")]
	[Address(RVA = "0x208CDD0", Offset = "0x208CDD0", VA = "0x208CDD0")]
	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
