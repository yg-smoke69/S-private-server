using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040B6")]
public class ResFileLoader
{
	[Token(Token = "0x401B2E5")]
	protected const long HTTP_OK = 200L;

	[Token(Token = "0x401B2E6")]
	protected const long HTTP_PartialOK = 206L;

	[Token(Token = "0x401B2E7")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string ERR_OK;

	[Token(Token = "0x401B2E8")]
	[FieldOffset(Offset = "0x4")]
	public static readonly string ERR_SAVE_TEMP_FAILED;

	[Token(Token = "0x401B2E9")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string ERR_TIME_OUT;

	[Token(Token = "0x401B2EA")]
	[FieldOffset(Offset = "0xC")]
	public static readonly string ERR_READ_FAILED;

	[Token(Token = "0x401B2EB")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string ERR_UNZIP_FAILED;

	[Token(Token = "0x401B2EC")]
	[FieldOffset(Offset = "0x14")]
	public static readonly string ERR_INSUFFICIENT_STORAGE;

	[Token(Token = "0x401B2ED")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string ERR_MULTIDOWNLOAD_NOTEMPFILECONFIG;

	[Token(Token = "0x401B2EE")]
	[FieldOffset(Offset = "0x1C")]
	public static readonly string ERR_DOWNLOAD_ERROR;

	[Token(Token = "0x401B2EF")]
	[FieldOffset(Offset = "0x20")]
	private static readonly Dictionary<string, int> ErrorMapping;

	[Token(Token = "0x401B2F0")]
	[FieldOffset(Offset = "0x8")]
	public ResFileLoaderState State;

	[Token(Token = "0x401B2F1")]
	[FieldOffset(Offset = "0xC")]
	public string FullPath;

	[Token(Token = "0x401B2F2")]
	[FieldOffset(Offset = "0x10")]
	public string RelativePath;

	[Token(Token = "0x401B2F3")]
	[FieldOffset(Offset = "0x14")]
	public int RetryCount;

	[Token(Token = "0x401B2F4")]
	[FieldOffset(Offset = "0x18")]
	public long TotalSize;

	[Token(Token = "0x401B2F5")]
	[FieldOffset(Offset = "0x20")]
	public string RequestError;

	[Token(Token = "0x401B2F6")]
	[FieldOffset(Offset = "0x24")]
	public ResVersionInfo.FileInfo FileInfo;

	[Token(Token = "0x401B2F7")]
	[FieldOffset(Offset = "0x28")]
	protected float m_LastProgress;

	[Token(Token = "0x601A548")]
	[Address(RVA = "0x333649C", Offset = "0x333649C", VA = "0x333649C")]
	public ResFileLoader()
	{
	}

	[Token(Token = "0x601A549")]
	[Address(RVA = "0x33364BC", Offset = "0x33364BC", VA = "0x33364BC")]
	public static ResErrorCode MapToErrorCode(string error)
	{
		return default(ResErrorCode);
	}

	[Token(Token = "0x601A54A")]
	[Address(RVA = "0x3333190", Offset = "0x3333190", VA = "0x3333190")]
	public static bool CheckHttpResposeCode(long response_code)
	{
		return default(bool);
	}

	[Token(Token = "0x601A54B")]
	[Address(RVA = "0x33318C4", Offset = "0x33318C4", VA = "0x33318C4")]
	public static bool IsDiskFull(ResFileLoader loader)
	{
		return default(bool);
	}

	[Token(Token = "0x601A54C")]
	[Address(RVA = "0x33365B8", Offset = "0x33365B8", VA = "0x33365B8")]
	public void Start(float time)
	{
	}

	[Token(Token = "0x601A54D")]
	[Address(RVA = "0x3336690", Offset = "0x3336690", VA = "0x3336690")]
	public void Notify()
	{
	}

	[Token(Token = "0x601A54E")]
	[Address(RVA = "0x3336484", Offset = "0x3336484", VA = "0x3336484")]
	public void Dispose()
	{
	}

	[Token(Token = "0x601A54F")]
	[Address(RVA = "0x33366A0", Offset = "0x33366A0", VA = "0x33366A0")]
	public float UpdateProgress(float time)
	{
		return default(float);
	}

	[Token(Token = "0x601A550")]
	[Address(RVA = "0x3336714", Offset = "0x3336714", VA = "0x3336714")]
	public float UpdateProgressInThread(float time)
	{
		return default(float);
	}

	[Token(Token = "0x601A551")]
	[Address(RVA = "0x3336788", Offset = "0x3336788", VA = "0x3336788", Slot = "4")]
	public virtual long GetDownloadingSize()
	{
		return default(long);
	}

	[Token(Token = "0x601A552")]
	[Address(RVA = "0x333196C", Offset = "0x333196C", VA = "0x333196C")]
	protected void SetRequestError(string error)
	{
	}

	[Token(Token = "0x601A553")]
	[Address(RVA = "0x3331404", Offset = "0x3331404", VA = "0x3331404")]
	public bool HaveError()
	{
		return default(bool);
	}

	[Token(Token = "0x601A554")]
	[Address(RVA = "0x33367B4", Offset = "0x33367B4", VA = "0x33367B4", Slot = "5")]
	public virtual bool IsTimeout(float time)
	{
		return default(bool);
	}

	[Token(Token = "0x601A555")]
	[Address(RVA = "0x33367BC", Offset = "0x33367BC", VA = "0x33367BC", Slot = "6")]
	public virtual bool IsFinished()
	{
		return default(bool);
	}

	[Token(Token = "0x601A556")]
	[Address(RVA = "0x33367C4", Offset = "0x33367C4", VA = "0x33367C4", Slot = "7")]
	protected virtual void OnStart(float time)
	{
	}

	[Token(Token = "0x601A557")]
	[Address(RVA = "0x3334EFC", Offset = "0x3334EFC", VA = "0x3334EFC", Slot = "8")]
	protected virtual void OnDispose()
	{
	}

	[Token(Token = "0x601A558")]
	[Address(RVA = "0x33367C8", Offset = "0x33367C8", VA = "0x33367C8", Slot = "9")]
	protected virtual void OnNotify()
	{
	}

	[Token(Token = "0x601A559")]
	[Address(RVA = "0x33367CC", Offset = "0x33367CC", VA = "0x33367CC", Slot = "10")]
	public virtual bool HasStarted()
	{
		return default(bool);
	}

	[Token(Token = "0x601A55A")]
	[Address(RVA = "0x33367D4", Offset = "0x33367D4", VA = "0x33367D4", Slot = "11")]
	protected virtual void OnUpdate(float time)
	{
	}

	[Token(Token = "0x601A55B")]
	[Address(RVA = "0x33367D8", Offset = "0x33367D8", VA = "0x33367D8", Slot = "12")]
	protected virtual void OnUpdateInThread(float time)
	{
	}

	[Token(Token = "0x601A55C")]
	[Address(RVA = "0x3336480", Offset = "0x3336480", VA = "0x3336480", Slot = "13")]
	public virtual void OnPause()
	{
	}

	[Token(Token = "0x601A55D")]
	[Address(RVA = "0x33367DC", Offset = "0x33367DC", VA = "0x33367DC", Slot = "14")]
	public virtual long NeedDownloadSize()
	{
		return default(long);
	}

	[Token(Token = "0x601A55E")]
	[Address(RVA = "0x33367E8", Offset = "0x33367E8", VA = "0x33367E8", Slot = "15")]
	public virtual bool IsSupportBackground()
	{
		return default(bool);
	}
}
