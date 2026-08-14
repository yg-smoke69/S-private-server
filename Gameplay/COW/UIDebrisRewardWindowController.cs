using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20025C6")]
public class UIDebrisRewardWindowController : UIPopupWindowController
{
	[Token(Token = "0x400E9BC")]
	[FieldOffset(Offset = "0x48")]
	private UIDebrisRewardWindowView m_View;

	[Token(Token = "0x600DDF5")]
	[Address(RVA = "0x11F4350", Offset = "0x11F4350", VA = "0x11F4350")]
	public UIDebrisRewardWindowController()
	{
	}

	[Token(Token = "0x600DDF6")]
	[Address(RVA = "0x11F4358", Offset = "0x11F4358", VA = "0x11F4358")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DDF7")]
	[Address(RVA = "0x11F43FC", Offset = "0x11F43FC", VA = "0x11F43FC", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600DDF8")]
	[Address(RVA = "0x11F452C", Offset = "0x11F452C", VA = "0x11F452C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DDF9")]
	[Address(RVA = "0x11F4688", Offset = "0x11F4688", VA = "0x11F4688")]
	public void SetViewData(List<BaseItemInfo> infos)
	{
	}

	[Token(Token = "0x600DDFA")]
	[Address(RVA = "0x11F4930", Offset = "0x11F4930", VA = "0x11F4930")]
	private void OnOKBtnClick()
	{
	}

	[Token(Token = "0x600DDFB")]
	[Address(RVA = "0x11F4994", Offset = "0x11F4994", VA = "0x11F4994", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600DDFC")]
	[Address(RVA = "0x11F4AAC", Offset = "0x11F4AAC", VA = "0x11F4AAC", Slot = "42")]
	public override void EnterByReturn()
	{
	}

	[Token(Token = "0x600DDFD")]
	[Address(RVA = "0x11F4BB0", Offset = "0x11F4BB0", VA = "0x11F4BB0")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600DDFE")]
	[Address(RVA = "0x11F4BB8", Offset = "0x11F4BB8", VA = "0x11F4BB8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DDFF")]
	[Address(RVA = "0x11F4BC0", Offset = "0x11F4BC0", VA = "0x11F4BC0")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600DE00")]
	[Address(RVA = "0x11F4BC8", Offset = "0x11F4BC8", VA = "0x11F4BC8")]
	public void _003C_003EiFixBaseProxy_EnterByReturn()
	{
	}
}
