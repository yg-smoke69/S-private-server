using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E84")]
public class ActivityPreloginDescription : ActivityAwardDescription
{
	[Token(Token = "0x2001E85")]
	private enum OperateStatus
	{
		[Token(Token = "0x400BFF8")]
		None,
		[Token(Token = "0x400BFF9")]
		Book,
		[Token(Token = "0x400BFFA")]
		Booked,
		[Token(Token = "0x400BFFB")]
		Available,
		[Token(Token = "0x400BFFC")]
		Received
	}

	[Token(Token = "0x400BFF5")]
	[FieldOffset(Offset = "0x64")]
	private OperateStatus m_OperateStatus;

	[Token(Token = "0x400BFF6")]
	[FieldOffset(Offset = "0x0")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60092D5")]
	[Address(RVA = "0x14C1704", Offset = "0x14C1704", VA = "0x14C1704")]
	public ActivityPreloginDescription()
	{
	}

	[Token(Token = "0x60092D6")]
	[Address(RVA = "0x14C1708", Offset = "0x14C1708", VA = "0x14C1708", Slot = "31")]
	protected override void SetOperateButtonUI()
	{
	}

	[Token(Token = "0x60092D7")]
	[Address(RVA = "0x14C1F0C", Offset = "0x14C1F0C", VA = "0x14C1F0C", Slot = "32")]
	protected override void OnOperate()
	{
	}

	[Token(Token = "0x60092D8")]
	[Address(RVA = "0x14C228C", Offset = "0x14C228C", VA = "0x14C228C")]
	private static void _003COnOperate_003Em__0(HttpErrorCode errCode, object obj)
	{
	}

	[Token(Token = "0x60092D9")]
	[Address(RVA = "0x14C2290", Offset = "0x14C2290", VA = "0x14C2290")]
	public void _003C_003EiFixBaseProxy_SetOperateButtonUI()
	{
	}

	[Token(Token = "0x60092DA")]
	[Address(RVA = "0x14C2294", Offset = "0x14C2294", VA = "0x14C2294")]
	public void _003C_003EiFixBaseProxy_OnOperate()
	{
	}
}
