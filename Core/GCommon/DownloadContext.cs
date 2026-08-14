using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040C9")]
public class DownloadContext
{
	[Token(Token = "0x401B389")]
	[FieldOffset(Offset = "0x8")]
	public ResDownloadType DownloadType;

	[Token(Token = "0x401B38A")]
	[FieldOffset(Offset = "0xC")]
	public Action<ResErrorCode, ResDownloadType> FinishedCallBack;

	[Token(Token = "0x401B38B")]
	[FieldOffset(Offset = "0x10")]
	public ResUpdaterProgressMonitor UpdateProgressMonitor;

	[Token(Token = "0x401B38C")]
	[FieldOffset(Offset = "0x14")]
	public ResFileLoaderController LoaderController;

	[Token(Token = "0x401B38D")]
	[FieldOffset(Offset = "0x18")]
	public ResErrorCode LastError;

	[Token(Token = "0x401B38E")]
	[FieldOffset(Offset = "0x1C")]
	private EDownloadContextState _003CState_003Ek__BackingField;

	[Token(Token = "0x401B38F")]
	[FieldOffset(Offset = "0x20")]
	public long TotalNeedDownloadSize;

	[Token(Token = "0x401B390")]
	[FieldOffset(Offset = "0x28")]
	public long TotalRequireSize;

	[Token(Token = "0x17001CD7")]
	public EDownloadContextState State
	{
		[Token(Token = "0x601A5DC")]
		[Address(RVA = "0x308E3D4", Offset = "0x308E3D4", VA = "0x308E3D4")]
		get
		{
			return default(EDownloadContextState);
		}
		[Token(Token = "0x601A5DD")]
		[Address(RVA = "0x308E3CC", Offset = "0x308E3CC", VA = "0x308E3CC")]
		protected set
		{
		}
	}

	[Token(Token = "0x17001CD8")]
	public bool IsPaused
	{
		[Token(Token = "0x601A5DE")]
		[Address(RVA = "0x308E3DC", Offset = "0x308E3DC", VA = "0x308E3DC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001CD9")]
	public bool IsFinished
	{
		[Token(Token = "0x601A5DF")]
		[Address(RVA = "0x308E3F0", Offset = "0x308E3F0", VA = "0x308E3F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001CDA")]
	public bool IsStarted
	{
		[Token(Token = "0x601A5E0")]
		[Address(RVA = "0x308E404", Offset = "0x308E404", VA = "0x308E404")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x601A5DB")]
	[Address(RVA = "0x308E308", Offset = "0x308E308", VA = "0x308E308")]
	public DownloadContext(ResDownloadType type, int maxLoaderCountSimultaneously)
	{
	}

	[Token(Token = "0x601A5E1")]
	[Address(RVA = "0x308E418", Offset = "0x308E418", VA = "0x308E418", Slot = "4")]
	public virtual void Clear()
	{
	}

	[Token(Token = "0x601A5E2")]
	[Address(RVA = "0x308E464", Offset = "0x308E464", VA = "0x308E464")]
	public void InitContext()
	{
	}

	[Token(Token = "0x601A5E3")]
	[Address(RVA = "0x308E474", Offset = "0x308E474", VA = "0x308E474")]
	public void AddLoader(ResFileLoader load, bool is_Retry = false, long progress_size = -1L)
	{
	}

	[Token(Token = "0x601A5E4")]
	[Address(RVA = "0x308E524", Offset = "0x308E524", VA = "0x308E524", Slot = "5")]
	public virtual void PauseDownload(bool isPause, bool is_auto_pause = false)
	{
	}

	[Token(Token = "0x601A5E5")]
	[Address(RVA = "0x308E588", Offset = "0x308E588", VA = "0x308E588", Slot = "6")]
	public virtual void StartDownload([Optional] Action<ResErrorCode, ResDownloadType> callback)
	{
	}

	[Token(Token = "0x601A5E6")]
	[Address(RVA = "0x308E66C", Offset = "0x308E66C", VA = "0x308E66C", Slot = "7")]
	public virtual void InvokeFinishCallBack()
	{
	}

	[Token(Token = "0x601A5E7")]
	[Address(RVA = "0x308E954", Offset = "0x308E954", VA = "0x308E954")]
	public void Update(float time)
	{
	}

	[Token(Token = "0x601A5E8")]
	[Address(RVA = "0x308E9D8", Offset = "0x308E9D8", VA = "0x308E9D8")]
	public bool HaveEnoughStorage()
	{
		return default(bool);
	}

	[Token(Token = "0x601A5E9")]
	[Address(RVA = "0x308EAA4", Offset = "0x308EAA4", VA = "0x308EAA4")]
	public bool IsUnZipping()
	{
		return default(bool);
	}

	[Token(Token = "0x601A5EA")]
	[Address(RVA = "0x308EAF8", Offset = "0x308EAF8", VA = "0x308EAF8")]
	public ResVersionInfo.FileInfo CurrentDownloadFileInfo()
	{
		return null;
	}
}
