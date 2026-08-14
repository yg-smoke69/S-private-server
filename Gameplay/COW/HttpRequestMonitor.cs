using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2000D5B")]
internal class HttpRequestMonitor : _Attribute
{
	[Token(Token = "0x4006B8B")]
	[FieldOffset(Offset = "0x8")]
	public ulong LoginTime;

	[Token(Token = "0x4006B8C")]
	[FieldOffset(Offset = "0x10")]
	private bool forceBlockUI;

	[Token(Token = "0x4006B8D")]
	[FieldOffset(Offset = "0x0")]
	private static HttpRequestMonitor instance;

	[Token(Token = "0x4006B8E")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4006B8F")]
	[FieldOffset(Offset = "0x8")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4006B90")]
	[FieldOffset(Offset = "0xC")]
	private static Action _003C_003Ef__am_0024cache2;

	[Token(Token = "0x170008A9")]
	public static HttpRequestMonitor Instance
	{
		[Token(Token = "0x6006647")]
		[Address(RVA = "0x190E970", Offset = "0x190E970", VA = "0x190E970")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006646")]
	[Address(RVA = "0x190E968", Offset = "0x190E968", VA = "0x190E968")]
	public HttpRequestMonitor()
	{
	}

	[Token(Token = "0x6006648")]
	[Address(RVA = "0x190EA54", Offset = "0x190EA54", VA = "0x190EA54")]
	public void SetForceBlockUI(bool block)
	{
	}

	[Token(Token = "0x6006649")]
	[Address(RVA = "0x190EBA4", Offset = "0x190EBA4", VA = "0x190EBA4")]
	public bool ForceBlockUI()
	{
		return default(bool);
	}

	[Token(Token = "0x600664A")]
	[Address(RVA = "0x190EBFC", Offset = "0x190EBFC", VA = "0x190EBFC", Slot = "4")]
	public void OnStartRequest(HttpManager.EHttpChannel channel, HttpRequest curHttpReq)
	{
	}

	[Token(Token = "0x600664B")]
	[Address(RVA = "0x190EE44", Offset = "0x190EE44", VA = "0x190EE44", Slot = "5")]
	public void OnEndRequest(HttpManager.EHttpChannel channel, string cmd, bool hasNext, HttpRequest curReq)
	{
	}

	[Token(Token = "0x600664C")]
	[Address(RVA = "0x190EFA4", Offset = "0x190EFA4", VA = "0x190EFA4", Slot = "6")]
	public void OnUnauthorized(HttpManager.EHttpChannel channel)
	{
	}

	[Token(Token = "0x600664D")]
	[Address(RVA = "0x190F350", Offset = "0x190F350", VA = "0x190F350", Slot = "7")]
	public void OnRetryFailed(HttpManager.EHttpChannel channel, HttpRequest curHttpReq)
	{
	}

	[Token(Token = "0x600664E")]
	[Address(RVA = "0x190F714", Offset = "0x190F714", VA = "0x190F714")]
	public bool IsQueueningHttpMessageType(ServiceMessageTypeHTTP httpMessgeType, ref HttpRequest httpReq)
	{
		return default(bool);
	}

	[Token(Token = "0x600664F")]
	[Address(RVA = "0x190F898", Offset = "0x190F898", VA = "0x190F898")]
	public void OnApplicationResume()
	{
	}

	[Token(Token = "0x6006650")]
	[Address(RVA = "0x190FCDC", Offset = "0x190FCDC", VA = "0x190FCDC", Slot = "8")]
	public void OnNewRequest(HttpRequest req)
	{
	}

	[Token(Token = "0x6006651")]
	[Address(RVA = "0x190FE50", Offset = "0x190FE50", VA = "0x190FE50", Slot = "9")]
	public void OnRemoveRequest(HttpRequest req)
	{
	}

	[Token(Token = "0x6006652")]
	[Address(RVA = "0x190FFC4", Offset = "0x190FFC4", VA = "0x190FFC4")]
	private static void _003COnUnauthorized_003Em__0()
	{
	}

	[Token(Token = "0x6006653")]
	[Address(RVA = "0x1910214", Offset = "0x1910214", VA = "0x1910214")]
	private static void _003COnRetryFailed_003Em__1()
	{
	}

	[Token(Token = "0x6006654")]
	[Address(RVA = "0x1910404", Offset = "0x1910404", VA = "0x1910404")]
	private static void _003COnApplicationResume_003Em__2()
	{
	}
}
