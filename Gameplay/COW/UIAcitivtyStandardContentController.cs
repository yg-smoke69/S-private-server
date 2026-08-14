using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001F78")]
public class UIAcitivtyStandardContentController : UIActivityContentController
{
	[Token(Token = "0x400C59C")]
	[FieldOffset(Offset = "0x28")]
	private UIActivityStandardContentView m_View;

	[Token(Token = "0x400C59D")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x400C59E")]
	[FieldOffset(Offset = "0x30")]
	private List<ClientActivityDesc> m_Descs;

	[Token(Token = "0x400C59F")]
	[FieldOffset(Offset = "0x34")]
	private List<ActivityAwardDescription> m_AwardDescUIs;

	[Token(Token = "0x400C5A0")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<ClientActivityDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400C5A1")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<ClientActivityDesc> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400C5A2")]
	[FieldOffset(Offset = "0x8")]
	private static Comparison<ClientActivityDesc> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x6009C43")]
	[Address(RVA = "0x2A013C4", Offset = "0x2A013C4", VA = "0x2A013C4")]
	public UIAcitivtyStandardContentController()
	{
	}

	[Token(Token = "0x6009C44")]
	[Address(RVA = "0x2A01480", Offset = "0x2A01480", VA = "0x2A01480")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009C45")]
	[Address(RVA = "0x2A01524", Offset = "0x2A01524", VA = "0x2A01524", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009C46")]
	[Address(RVA = "0x2A01650", Offset = "0x2A01650", VA = "0x2A01650", Slot = "31")]
	public override void SetData(object data)
	{
	}

	[Token(Token = "0x6009C47")]
	[Address(RVA = "0x2A01B6C", Offset = "0x2A01B6C", VA = "0x2A01B6C")]
	private void CreateEventDescList()
	{
	}

	[Token(Token = "0x6009C48")]
	[Address(RVA = "0x2A024C0", Offset = "0x2A024C0", VA = "0x2A024C0")]
	private ActivityAwardDescription CreateEventDesc(ClientActivityDesc desc)
	{
		return null;
	}

	[Token(Token = "0x6009C49")]
	[Address(RVA = "0x2A02684", Offset = "0x2A02684", VA = "0x2A02684", Slot = "32")]
	public override void Reload()
	{
	}

	[Token(Token = "0x6009C4A")]
	[Address(RVA = "0x2A02830", Offset = "0x2A02830", VA = "0x2A02830")]
	private static int _003CCreateEventDescList_003Em__0(ClientActivityDesc x, ClientActivityDesc y)
	{
		return default(int);
	}

	[Token(Token = "0x6009C4B")]
	[Address(RVA = "0x2A02870", Offset = "0x2A02870", VA = "0x2A02870")]
	private static int _003CCreateEventDescList_003Em__1(ClientActivityDesc x, ClientActivityDesc y)
	{
		return default(int);
	}

	[Token(Token = "0x6009C4C")]
	[Address(RVA = "0x2A028B0", Offset = "0x2A028B0", VA = "0x2A028B0")]
	private static int _003CCreateEventDescList_003Em__2(ClientActivityDesc x, ClientActivityDesc y)
	{
		return default(int);
	}

	[Token(Token = "0x6009C4D")]
	[Address(RVA = "0x2A028F0", Offset = "0x2A028F0", VA = "0x2A028F0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009C4E")]
	[Address(RVA = "0x2A028F8", Offset = "0x2A028F8", VA = "0x2A028F8")]
	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}

	[Token(Token = "0x6009C4F")]
	[Address(RVA = "0x2A028FC", Offset = "0x2A028FC", VA = "0x2A028FC")]
	public void _003C_003EiFixBaseProxy_Reload()
	{
	}
}
