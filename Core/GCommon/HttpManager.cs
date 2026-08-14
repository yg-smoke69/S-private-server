using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using COW;
using Il2CppDummyDll;
using TsiU;

namespace GCommon;

[Token(Token = "0x2004058")]
public class HttpManager : TSingleton<HttpManager>
{
	[Token(Token = "0x2004059")]
	private class TimeoutTimer
	{
		[Token(Token = "0x401B14E")]
		[FieldOffset(Offset = "0x8")]
		private float m_EndTime;

		[Token(Token = "0x601A325")]
		[Address(RVA = "0x32BB41C", Offset = "0x32BB41C", VA = "0x32BB41C")]
		public TimeoutTimer()
		{
		}

		[Token(Token = "0x601A326")]
		[Address(RVA = "0x32BB70C", Offset = "0x32BB70C", VA = "0x32BB70C")]
		public void Start(float gameTime, float timeout)
		{
		}

		[Token(Token = "0x601A327")]
		[Address(RVA = "0x32BB720", Offset = "0x32BB720", VA = "0x32BB720")]
		public bool IsExpired(float gameTime)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200405A")]
	private class TokenInfo
	{
		[Token(Token = "0x401B14F")]
		[FieldOffset(Offset = "0x8")]
		public string Token;

		[Token(Token = "0x401B150")]
		[FieldOffset(Offset = "0xC")]
		public uint TTL;

		[Token(Token = "0x601A328")]
		[Address(RVA = "0x32B922C", Offset = "0x32B922C", VA = "0x32B922C")]
		public TokenInfo()
		{
		}
	}

	[Token(Token = "0x200405B")]
	public enum EHttpChannel
	{
		[Token(Token = "0x401B152")]
		Main,
		[Token(Token = "0x401B153")]
		Second
	}

	[Token(Token = "0x200405C")]
	public class HttpChannel
	{
		[Token(Token = "0x401B154")]
		[FieldOffset(Offset = "0x8")]
		public Queue<HttpRequest> m_Requests;

		[Token(Token = "0x401B155")]
		[FieldOffset(Offset = "0xC")]
		private TimeoutTimer m_TimeoutTimer;

		[Token(Token = "0x601A329")]
		[Address(RVA = "0x32B917C", Offset = "0x32B917C", VA = "0x32B917C")]
		public HttpChannel()
		{
		}

		[Token(Token = "0x601A32A")]
		[Address(RVA = "0x32B8950", Offset = "0x32B8950", VA = "0x32B8950")]
		public HttpRequest GetCurrentRequest()
		{
			return null;
		}

		[Token(Token = "0x601A32B")]
		[Address(RVA = "0x32BB424", Offset = "0x32BB424", VA = "0x32BB424")]
		public void Append(HttpRequest req)
		{
		}

		[Token(Token = "0x601A32C")]
		[Address(RVA = "0x32BA3E4", Offset = "0x32BA3E4", VA = "0x32BA3E4")]
		public void StartSend(string token, float gameTime, HttpRequest req)
		{
		}

		[Token(Token = "0x601A32D")]
		[Address(RVA = "0x32B97E8", Offset = "0x32B97E8", VA = "0x32B97E8")]
		public bool IsExpired(float gameTime, HttpRequest req)
		{
			return default(bool);
		}

		[Token(Token = "0x601A32E")]
		[Address(RVA = "0x32B9688", Offset = "0x32B9688", VA = "0x32B9688")]
		public void Done(HttpRequest req)
		{
		}

		[Token(Token = "0x601A32F")]
		[Address(RVA = "0x32B9758", Offset = "0x32B9758", VA = "0x32B9758")]
		public int ReuqestCount()
		{
			return default(int);
		}

		[Token(Token = "0x601A330")]
		[Address(RVA = "0x32B9560", Offset = "0x32B9560", VA = "0x32B9560")]
		public void Clear()
		{
		}
	}

	[Token(Token = "0x401B141")]
	[FieldOffset(Offset = "0x0")]
	public static readonly uint HTTPOPTION_DEFAULT;

	[Token(Token = "0x401B142")]
	[FieldOffset(Offset = "0x4")]
	public static readonly uint HTTPOPTION_SILENCE;

	[Token(Token = "0x401B143")]
	[FieldOffset(Offset = "0x8")]
	public static readonly uint HTTPOPTION_BLOCK;

	[Token(Token = "0x401B144")]
	private const float DEFAULT_TIMEOUT = 10f;

	[Token(Token = "0x401B145")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<int, HttpChannel> m_HttpChannels;

	[Token(Token = "0x401B146")]
	[FieldOffset(Offset = "0xC")]
	private TokenInfo m_TokenInfo;

	[Token(Token = "0x401B147")]
	[FieldOffset(Offset = "0x10")]
	private IHttpManagerMonitor m_Impl;

	[Token(Token = "0x401B148")]
	[FieldOffset(Offset = "0x14")]
	private EHttpDataType m_ReqDataType;

	[Token(Token = "0x401B149")]
	[FieldOffset(Offset = "0x18")]
	private EHttpDataType m_ResDataType;

	[Token(Token = "0x401B14A")]
	[FieldOffset(Offset = "0x1C")]
	private AesManaged m_aes;

	[Token(Token = "0x401B14B")]
	[FieldOffset(Offset = "0x20")]
	private bool m_EnableEncrypt;

	[Token(Token = "0x401B14C")]
	[FieldOffset(Offset = "0x21")]
	private bool OpenProxy;

	[Token(Token = "0x401B14D")]
	[FieldOffset(Offset = "0x24")]
	private float m_TimeDelay;

	[Token(Token = "0x17001CBA")]
	public string LastErrorMessage
	{
		[Token(Token = "0x601A315")]
		[Address(RVA = "0x32B8864", Offset = "0x32B8864", VA = "0x32B8864")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601A314")]
	[Address(RVA = "0x32B87CC", Offset = "0x32B87CC", VA = "0x32B87CC")]
	public HttpManager()
	{
	}

	[Token(Token = "0x601A316")]
	[Address(RVA = "0x32B8A0C", Offset = "0x32B8A0C", VA = "0x32B8A0C")]
	public void Init()
	{
	}

	[Token(Token = "0x601A317")]
	[Address(RVA = "0x32B92CC", Offset = "0x32B92CC", VA = "0x32B92CC")]
	public void SetImpl(IHttpManagerMonitor impl)
	{
	}

	[Token(Token = "0x601A318")]
	[Address(RVA = "0x32B92D4", Offset = "0x32B92D4", VA = "0x32B92D4")]
	public void UpdateTokenInfo(string token, uint ttl)
	{
	}

	[Token(Token = "0x601A319")]
	[Address(RVA = "0x32B931C", Offset = "0x32B931C", VA = "0x32B931C")]
	public string GetToken()
	{
		return null;
	}

	[Token(Token = "0x601A31A")]
	[Address(RVA = "0x32B9340", Offset = "0x32B9340", VA = "0x32B9340")]
	public void Clear()
	{
	}

	[Token(Token = "0x601A31B")]
	[Address(RVA = "0x32B95D8", Offset = "0x32B95D8", VA = "0x32B95D8")]
	public void SetProxyOpen(bool open)
	{
	}

	[Token(Token = "0x601A31C")]
	[Address(RVA = "0x32B0E70", Offset = "0x32B0E70", VA = "0x32B0E70")]
	public void Update(float gameTime)
	{
	}

	[Token(Token = "0x601A31D")]
	public HttpRequest RequestPost<T>(string url, string cmd, object data, [Optional] Action<HttpErrorCode, object> onFinished, float timeout = 0f, uint http_option = 0u, EHttpDataType reqDataType = EHttpDataType.None, EHttpDataType resDataType = EHttpDataType.None, EHttpChannel channel = EHttpChannel.Main, bool encrypt = true, LoadingType loadingType = LoadingType.CircleLoading)
	{
		return null;
	}

	[Token(Token = "0x601A31E")]
	public void RequestGet<T>(string url, string cmd, Action<HttpErrorCode, object> onFinished, float timeout, uint http_option = 0u, EHttpDataType resDataType = EHttpDataType.None, EHttpChannel channel = EHttpChannel.Main, LoadingType loadingType = LoadingType.CircleLoading, object[] args)
	{
	}

	[Token(Token = "0x601A31F")]
	[Address(RVA = "0x32BA434", Offset = "0x32BA434", VA = "0x32BA434")]
	private HttpRequest CreatePostReq(string url, string cmd, object data, EHttpDataType reqDataType = EHttpDataType.None, EHttpDataType resDataType = EHttpDataType.None)
	{
		return null;
	}

	[Token(Token = "0x601A320")]
	private HttpRequest CreatePostReq<T>(string url, string cmd, object data, Action<HttpErrorCode, object> onFinished, float timeout = 0f, uint http_option = 0u, EHttpDataType reqDataType = EHttpDataType.None, EHttpDataType resDataType = EHttpDataType.None, bool encrypt = true, LoadingType loadingType = LoadingType.CircleLoading)
	{
		return null;
	}

	[Token(Token = "0x601A321")]
	[Address(RVA = "0x32BAA5C", Offset = "0x32BAA5C", VA = "0x32BAA5C")]
	public byte[] Encrypt(byte[] data)
	{
		return null;
	}

	[Token(Token = "0x601A322")]
	[Address(RVA = "0x32BAE00", Offset = "0x32BAE00", VA = "0x32BAE00")]
	public byte[] Decrypt(byte[] data)
	{
		return null;
	}

	[Token(Token = "0x601A323")]
	[Address(RVA = "0x32BB1A4", Offset = "0x32BB1A4", VA = "0x32BB1A4")]
	public bool IsCmdInQueue(string cmd, ref HttpRequest httpReq)
	{
		return default(bool);
	}
}
