using System;
using System.IO;
using System.Security.Cryptography;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace GCommon;

[Token(Token = "0x20040BB")]
public class ResDownloadFileLoader : ResWithTempFileLoader
{
	[Token(Token = "0x401B301")]
	[FieldOffset(Offset = "0x3C")]
	public UnityWebRequest HttpReq;

	[Token(Token = "0x401B302")]
	[FieldOffset(Offset = "0x40")]
	public ResDownloadType DownloadType;

	[Token(Token = "0x401B303")]
	[FieldOffset(Offset = "0x44")]
	public Action<UnityWebRequest, ResWithTempFileLoader> OnLoaded;

	[Token(Token = "0x401B304")]
	[FieldOffset(Offset = "0x48")]
	private long m_DataIndex;

	[Token(Token = "0x401B305")]
	[FieldOffset(Offset = "0x50")]
	protected FileStream m_TempFileStream;

	[Token(Token = "0x401B306")]
	[FieldOffset(Offset = "0x58")]
	protected long m_TempFileLength;

	[Token(Token = "0x401B307")]
	[FieldOffset(Offset = "0x60")]
	protected SHA1CryptoServiceProvider m_HashWorker;

	[Token(Token = "0x401B308")]
	[FieldOffset(Offset = "0x64")]
	protected byte[] m_HashBuffer;

	[Token(Token = "0x401B309")]
	[FieldOffset(Offset = "0x68")]
	protected bool m_NeedHashTemp;

	[Token(Token = "0x401B30A")]
	protected const int GETDATA_TIKECOUNT = 5;

	[Token(Token = "0x401B30B")]
	[FieldOffset(Offset = "0x6C")]
	private int m_curTick;

	[Token(Token = "0x17001CD5")]
	public override long CELL_SIZE
	{
		[Token(Token = "0x601A573")]
		[Address(RVA = "0x333480C", Offset = "0x333480C", VA = "0x333480C", Slot = "16")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x601A572")]
	[Address(RVA = "0x3334804", Offset = "0x3334804", VA = "0x3334804")]
	public ResDownloadFileLoader()
	{
	}

	[Token(Token = "0x601A574")]
	[Address(RVA = "0x3334818", Offset = "0x3334818", VA = "0x3334818", Slot = "7")]
	protected override void OnStart(float time)
	{
	}

	[Token(Token = "0x601A575")]
	[Address(RVA = "0x3334E58", Offset = "0x3334E58", VA = "0x3334E58", Slot = "10")]
	public override bool HasStarted()
	{
		return default(bool);
	}

	[Token(Token = "0x601A576")]
	[Address(RVA = "0x3334E7C", Offset = "0x3334E7C", VA = "0x3334E7C", Slot = "6")]
	public override bool IsFinished()
	{
		return default(bool);
	}

	[Token(Token = "0x601A577")]
	[Address(RVA = "0x3334E94", Offset = "0x3334E94", VA = "0x3334E94", Slot = "4")]
	public override long GetDownloadingSize()
	{
		return default(long);
	}

	[Token(Token = "0x601A578")]
	[Address(RVA = "0x3334E9C", Offset = "0x3334E9C", VA = "0x3334E9C", Slot = "8")]
	protected override void OnDispose()
	{
	}

	[Token(Token = "0x601A579")]
	[Address(RVA = "0x3334F30", Offset = "0x3334F30", VA = "0x3334F30", Slot = "9")]
	protected override void OnNotify()
	{
	}

	[Token(Token = "0x601A57A")]
	[Address(RVA = "0x3335218", Offset = "0x3335218", VA = "0x3335218", Slot = "11")]
	protected override void OnUpdate(float time)
	{
	}

	[Token(Token = "0x601A57B")]
	[Address(RVA = "0x3334D20", Offset = "0x3334D20", VA = "0x3334D20")]
	private void GetFileByReq()
	{
	}

	[Token(Token = "0x601A57C")]
	[Address(RVA = "0x3335E50", Offset = "0x3335E50", VA = "0x3335E50", Slot = "17")]
	protected virtual void ClearFileStream()
	{
	}

	[Token(Token = "0x601A57D")]
	[Address(RVA = "0x3334F00", Offset = "0x3334F00", VA = "0x3334F00")]
	protected void ClearHashWorker()
	{
	}

	[Token(Token = "0x601A57E")]
	[Address(RVA = "0x3335FB8", Offset = "0x3335FB8", VA = "0x3335FB8", Slot = "18")]
	protected virtual void CollectDataAndClearFileStream()
	{
	}

	[Token(Token = "0x601A57F")]
	[Address(RVA = "0x333643C", Offset = "0x333643C", VA = "0x333643C", Slot = "13")]
	public override void OnPause()
	{
	}

	[Token(Token = "0x601A580")]
	[Address(RVA = "0x3336494", Offset = "0x3336494", VA = "0x3336494", Slot = "14")]
	public override long NeedDownloadSize()
	{
		return default(long);
	}
}
