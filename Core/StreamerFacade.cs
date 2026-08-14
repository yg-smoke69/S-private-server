using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;
using WorldStreamer;

[Token(Token = "0x2003D3C")]
public static class StreamerFacade
{
	[Token(Token = "0x2003D3D")]
	private class VisibleFunc
	{
		[Token(Token = "0x4019FBC")]
		[FieldOffset(Offset = "0x8")]
		public List<VisibleHandler> StaticHandler;

		[Token(Token = "0x4019FBD")]
		[FieldOffset(Offset = "0xC")]
		public List<VisibleHandler> DynamicHandler;

		[Token(Token = "0x601880B")]
		[Address(RVA = "0x21DACD8", Offset = "0x21DACD8", VA = "0x21DACD8")]
		public VisibleFunc()
		{
		}
	}

	[Token(Token = "0x2003D3E")]
	public delegate void VisibleHandler(Vector3 min, Vector3 max);

	[Token(Token = "0x4019FB8")]
	[FieldOffset(Offset = "0x0")]
	private static IStreamerFunc m_Impl;

	[Token(Token = "0x4019FB9")]
	[FieldOffset(Offset = "0x4")]
	private static Dictionary<int, VisibleFunc> m_Handler;

	[Token(Token = "0x4019FBA")]
	[FieldOffset(Offset = "0x8")]
	private static List<Streamer> m_streamerList;

	[Token(Token = "0x4019FBB")]
	[FieldOffset(Offset = "0xC")]
	private static bool mIsStreamingFinished;

	[Token(Token = "0x170019EC")]
	public static bool IsMainStreamFinished
	{
		[Token(Token = "0x6018802")]
		[Address(RVA = "0x21D9F0C", Offset = "0x21D9F0C", VA = "0x21D9F0C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6018801")]
		[Address(RVA = "0x21D9E7C", Offset = "0x21D9E7C", VA = "0x21D9E7C")]
		set
		{
		}
	}

	[Token(Token = "0x60187F9")]
	[Address(RVA = "0x21D95DC", Offset = "0x21D95DC", VA = "0x21D95DC")]
	public static void SetImpl(IStreamerFunc impl)
	{
	}

	[Token(Token = "0x60187FA")]
	[Address(RVA = "0x21D969C", Offset = "0x21D969C", VA = "0x21D969C")]
	public static Transform GetTargetPlayer()
	{
		return null;
	}

	[Token(Token = "0x60187FB")]
	[Address(RVA = "0x21D97B0", Offset = "0x21D97B0", VA = "0x21D97B0")]
	public static AsyncOperation LoadSceneAsync(string sourcePath, LoadSceneMode mode)
	{
		return null;
	}

	[Token(Token = "0x60187FC")]
	[Address(RVA = "0x21D98D4", Offset = "0x21D98D4", VA = "0x21D98D4")]
	public static AssetBundle GetStreamSceneAB()
	{
		return null;
	}

	[Token(Token = "0x60187FD")]
	[Address(RVA = "0x21D99E8", Offset = "0x21D99E8", VA = "0x21D99E8")]
	public static byte[] GetStreamSceneABTexRefInfo()
	{
		return null;
	}

	[Token(Token = "0x60187FE")]
	[Address(RVA = "0x21D9AFC", Offset = "0x21D9AFC", VA = "0x21D9AFC")]
	public static void OnLoadSceneFinish(string sourcePath, bool result)
	{
	}

	[Token(Token = "0x60187FF")]
	[Address(RVA = "0x21D9C20", Offset = "0x21D9C20", VA = "0x21D9C20")]
	public static void RepeatAction(float interval, Action action)
	{
	}

	[Token(Token = "0x6018800")]
	[Address(RVA = "0x21D9D44", Offset = "0x21D9D44", VA = "0x21D9D44")]
	public static void NotifySceneEvent(StreamerType type, string name, bool loaded)
	{
	}

	[Token(Token = "0x6018803")]
	[Address(RVA = "0x21D9F98", Offset = "0x21D9F98", VA = "0x21D9F98")]
	public static void RegistVisibleHandler(StreamerType type, VisibleHandler handler, bool isDynamic)
	{
	}

	[Token(Token = "0x6018804")]
	[Address(RVA = "0x21DA1B8", Offset = "0x21DA1B8", VA = "0x21DA1B8")]
	public static void UnRegistVisibleHandler(StreamerType type, VisibleHandler handler, bool isDynamic)
	{
	}

	[Token(Token = "0x6018805")]
	[Address(RVA = "0x21DA3D8", Offset = "0x21DA3D8", VA = "0x21DA3D8")]
	public static void DispatchVisibleEnvent(StreamerType type, bool isDynamic, Vector3 min, Vector3 max)
	{
	}

	[Token(Token = "0x6018806")]
	[Address(RVA = "0x21DAAC0", Offset = "0x21DAAC0", VA = "0x21DAAC0")]
	public static bool RegistStreamer(StreamerType type)
	{
		return default(bool);
	}

	[Token(Token = "0x6018807")]
	[Address(RVA = "0x21DAD7C", Offset = "0x21DAD7C", VA = "0x21DAD7C")]
	public static void UnRegistStreamer(StreamerType type)
	{
	}

	[Token(Token = "0x6018808")]
	[Address(RVA = "0x21DAF60", Offset = "0x21DAF60", VA = "0x21DAF60")]
	public static void AddStreamer(Streamer streamer)
	{
	}

	[Token(Token = "0x6018809")]
	[Address(RVA = "0x21DB01C", Offset = "0x21DB01C", VA = "0x21DB01C")]
	public static void StopAllStreamer()
	{
	}
}
