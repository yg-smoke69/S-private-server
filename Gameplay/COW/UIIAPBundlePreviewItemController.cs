using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028D8")]
public class UIIAPBundlePreviewItemController : UIBaseController
{
	[Token(Token = "0x400FB3E")]
	[FieldOffset(Offset = "0x28")]
	private UIIAPBundlePreviewItemView m_View;

	[Token(Token = "0x400FB3F")]
	[FieldOffset(Offset = "0x2C")]
	private IAPBundleStoreData m_Data;

	[Token(Token = "0x400FB40")]
	[FieldOffset(Offset = "0x30")]
	private Action<IAPBundleStoreData> m_Callback;

	[Token(Token = "0x60101C4")]
	[Address(RVA = "0xD3F88C", Offset = "0xD3F88C", VA = "0xD3F88C")]
	public UIIAPBundlePreviewItemController()
	{
	}

	[Token(Token = "0x60101C5")]
	[Address(RVA = "0xD3F910", Offset = "0xD3F910", VA = "0xD3F910")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60101C6")]
	[Address(RVA = "0xD3F9B8", Offset = "0xD3F9B8", VA = "0xD3F9B8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60101C7")]
	[Address(RVA = "0xD3FB14", Offset = "0xD3FB14", VA = "0xD3FB14", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60101C8")]
	[Address(RVA = "0xD3FC54", Offset = "0xD3FC54", VA = "0xD3FC54")]
	public void SetDragScrollView(UIScrollView scrollView)
	{
	}

	[Token(Token = "0x60101C9")]
	[Address(RVA = "0xD3FDF0", Offset = "0xD3FDF0", VA = "0xD3FDF0")]
	public void UpdateData(IAPBundleStoreData data)
	{
	}

	[Token(Token = "0x60101CA")]
	[Address(RVA = "0xD40428", Offset = "0xD40428", VA = "0xD40428")]
	public void SetCallback(Action<IAPBundleStoreData> callback)
	{
	}

	[Token(Token = "0x60101CB")]
	[Address(RVA = "0xD40488", Offset = "0xD40488", VA = "0xD40488")]
	private void OnItemClick()
	{
	}

	[Token(Token = "0x60101CC")]
	[Address(RVA = "0xD40540", Offset = "0xD40540", VA = "0xD40540")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60101CD")]
	[Address(RVA = "0xD40548", Offset = "0xD40548", VA = "0xD40548")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
