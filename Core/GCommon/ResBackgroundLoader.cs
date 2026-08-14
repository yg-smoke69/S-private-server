using System;
using System.Collections.Generic;
using System.Net;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040C0")]
public class ResBackgroundLoader : ResMultiDownloadLoader
{
	[Token(Token = "0x20040C1")]
	private enum WebReqState
	{
		[Token(Token = "0x401B341")]
		Running,
		[Token(Token = "0x401B342")]
		Finished,
		[Token(Token = "0x401B343")]
		Error,
		[Token(Token = "0x401B344")]
		Cancled
	}

	[Token(Token = "0x20040C2")]
	private class RequestState
	{
		[Token(Token = "0x401B345")]
		[FieldOffset(Offset = "0x8")]
		public HttpWebRequest CurReq;

		[Token(Token = "0x401B346")]
		[FieldOffset(Offset = "0xC")]
		public uint DataIndex;

		[Token(Token = "0x401B347")]
		[FieldOffset(Offset = "0x10")]
		public WebReqState State;

		[Token(Token = "0x401B348")]
		[FieldOffset(Offset = "0x14")]
		public HttpStatusCode StateCode;

		[Token(Token = "0x401B349")]
		[FieldOffset(Offset = "0x18")]
		public string StateDescription;

		[Token(Token = "0x601A5BF")]
		[Address(RVA = "0x3330BCC", Offset = "0x3330BCC", VA = "0x3330BCC")]
		public RequestState()
		{
		}
	}

	[Token(Token = "0x401B33E")]
	[FieldOffset(Offset = "0xA4")]
	private List<RequestState> m_RunningReq;

	[Token(Token = "0x401B33F")]
	[FieldOffset(Offset = "0xA8")]
	private List<RequestState> m_FinishedReq;

	[Token(Token = "0x601A5B5")]
	[Address(RVA = "0x33305B0", Offset = "0x33305B0", VA = "0x33305B0")]
	public ResBackgroundLoader(int mex_req_count, bool should_reuse_mem = false, bool should_override_with_full = false, int gc_index = 0)
	{
	}

	[Token(Token = "0x601A5B6")]
	[Address(RVA = "0x33306AC", Offset = "0x33306AC", VA = "0x33306AC", Slot = "7")]
	protected override void OnStart(float time)
	{
	}

	[Token(Token = "0x601A5B7")]
	[Address(RVA = "0x3330758", Offset = "0x3330758", VA = "0x3330758", Slot = "18")]
	protected override void GetFileWithIndex(float time, uint cell_index)
	{
	}

	[Token(Token = "0x601A5B8")]
	[Address(RVA = "0x3330BD4", Offset = "0x3330BD4", VA = "0x3330BD4", Slot = "8")]
	protected override void OnDispose()
	{
	}

	[Token(Token = "0x601A5B9")]
	[Address(RVA = "0x3330E1C", Offset = "0x3330E1C", VA = "0x3330E1C", Slot = "6")]
	public override bool IsFinished()
	{
		return default(bool);
	}

	[Token(Token = "0x601A5BA")]
	[Address(RVA = "0x3330EBC", Offset = "0x3330EBC", VA = "0x3330EBC", Slot = "9")]
	protected override void OnNotify()
	{
	}

	[Token(Token = "0x601A5BB")]
	[Address(RVA = "0x3331974", Offset = "0x3331974", VA = "0x3331974", Slot = "11")]
	protected override void OnUpdate(float time)
	{
	}

	[Token(Token = "0x601A5BC")]
	[Address(RVA = "0x3331978", Offset = "0x3331978", VA = "0x3331978")]
	private void OnResponseAsync(IAsyncResult asyncResult)
	{
	}

	[Token(Token = "0x601A5BD")]
	[Address(RVA = "0x3332674", Offset = "0x3332674", VA = "0x3332674", Slot = "12")]
	protected override void OnUpdateInThread(float time)
	{
	}

	[Token(Token = "0x601A5BE")]
	[Address(RVA = "0x33331B4", Offset = "0x33331B4", VA = "0x33331B4", Slot = "15")]
	public override bool IsSupportBackground()
	{
		return default(bool);
	}
}
