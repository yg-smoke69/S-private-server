using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001F57")]
public class UIActivityExchangeContentController : UIActivityContentController, _Attribute
{
	[Token(Token = "0x400C4EA")]
	[FieldOffset(Offset = "0x28")]
	private UIActivityExchangeContentView m_View;

	[Token(Token = "0x400C4EB")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x400C4EC")]
	[FieldOffset(Offset = "0x30")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x400C4ED")]
	[FieldOffset(Offset = "0x34")]
	private List<ClientActivityDesc> m_Descs;

	[Token(Token = "0x400C4EE")]
	[FieldOffset(Offset = "0x38")]
	private List<UIActivityExchangeItemController> m_ExchangeDescUIs;

	[Token(Token = "0x400C4EF")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<ClientActivityDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400C4F0")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<ClientActivityDesc> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400C4F1")]
	[FieldOffset(Offset = "0x8")]
	private static Comparison<ClientActivityDesc> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x6009B13")]
	[Address(RVA = "0x2A0EAC8", Offset = "0x2A0EAC8", VA = "0x2A0EAC8")]
	public UIActivityExchangeContentController()
	{
	}

	[Token(Token = "0x6009B14")]
	[Address(RVA = "0x2A0EB84", Offset = "0x2A0EB84", VA = "0x2A0EB84")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009B15")]
	[Address(RVA = "0x2A0EC28", Offset = "0x2A0EC28", VA = "0x2A0EC28", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009B16")]
	[Address(RVA = "0x2A0EDBC", Offset = "0x2A0EDBC", VA = "0x2A0EDBC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6009B17")]
	[Address(RVA = "0x2A0EE44", Offset = "0x2A0EE44", VA = "0x2A0EE44", Slot = "31")]
	public override void SetData(object data)
	{
	}

	[Token(Token = "0x6009B18")]
	[Address(RVA = "0x2A0F530", Offset = "0x2A0F530", VA = "0x2A0F530")]
	private void CreateEventDescList()
	{
	}

	[Token(Token = "0x6009B19")]
	[Address(RVA = "0x2A0FD94", Offset = "0x2A0FD94", VA = "0x2A0FD94")]
	private UIActivityExchangeItemController CreateEventDesc(ClientActivityDesc desc)
	{
		return null;
	}

	[Token(Token = "0x6009B1A")]
	[Address(RVA = "0x2A0FEEC", Offset = "0x2A0FEEC", VA = "0x2A0FEEC", Slot = "32")]
	public override void Reload()
	{
	}

	[Token(Token = "0x6009B1B")]
	[Address(RVA = "0x2A10098", Offset = "0x2A10098", VA = "0x2A10098", Slot = "36")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6009B1C")]
	[Address(RVA = "0x2A10170", Offset = "0x2A10170", VA = "0x2A10170", Slot = "37")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6009B1D")]
	[Address(RVA = "0x2A10204", Offset = "0x2A10204", VA = "0x2A10204")]
	private static int _003CCreateEventDescList_003Em__0(ClientActivityDesc x, ClientActivityDesc y)
	{
		return default(int);
	}

	[Token(Token = "0x6009B1E")]
	[Address(RVA = "0x2A10244", Offset = "0x2A10244", VA = "0x2A10244")]
	private static int _003CCreateEventDescList_003Em__1(ClientActivityDesc x, ClientActivityDesc y)
	{
		return default(int);
	}

	[Token(Token = "0x6009B1F")]
	[Address(RVA = "0x2A10284", Offset = "0x2A10284", VA = "0x2A10284")]
	private static int _003CCreateEventDescList_003Em__2(ClientActivityDesc x, ClientActivityDesc y)
	{
		return default(int);
	}

	[Token(Token = "0x6009B20")]
	[Address(RVA = "0x2A102C4", Offset = "0x2A102C4", VA = "0x2A102C4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009B21")]
	[Address(RVA = "0x2A102CC", Offset = "0x2A102CC", VA = "0x2A102CC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6009B22")]
	[Address(RVA = "0x2A102D4", Offset = "0x2A102D4", VA = "0x2A102D4")]
	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}

	[Token(Token = "0x6009B23")]
	[Address(RVA = "0x2A102D8", Offset = "0x2A102D8", VA = "0x2A102D8")]
	public void _003C_003EiFixBaseProxy_Reload()
	{
	}
}
