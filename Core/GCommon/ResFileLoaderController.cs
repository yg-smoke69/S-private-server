using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040C3")]
public class ResFileLoaderController
{
	[Token(Token = "0x401B34A")]
	[FieldOffset(Offset = "0x8")]
	private int m_MaxLoaderCountSimultaneously;

	[Token(Token = "0x401B34B")]
	[FieldOffset(Offset = "0xC")]
	private bool m_IsPause;

	[Token(Token = "0x401B34C")]
	[FieldOffset(Offset = "0x10")]
	private long m_SizeLoaded;

	[Token(Token = "0x401B34D")]
	[FieldOffset(Offset = "0x18")]
	private LinkedList<ResFileLoader> m_Loaders;

	[Token(Token = "0x401B34E")]
	[FieldOffset(Offset = "0x1C")]
	private LinkedList<ResFileLoader> m_RunningLoaders;

	[Token(Token = "0x401B34F")]
	[FieldOffset(Offset = "0x20")]
	private LinkedList<ResFileLoader> m_BackGroundLoaders;

	[Token(Token = "0x401B350")]
	[FieldOffset(Offset = "0x24")]
	private LinkedList<ResFileLoader> m_BackGroundRunningLoaders;

	[Token(Token = "0x401B351")]
	[FieldOffset(Offset = "0x28")]
	private HashSet<string> m_FinishedFilePath;

	[Token(Token = "0x401B352")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_BackgroundStarted;

	[Token(Token = "0x401B353")]
	[FieldOffset(Offset = "0x2D")]
	private bool m_NeedCheckWifi;

	[Token(Token = "0x401B354")]
	[FieldOffset(Offset = "0x30")]
	private string m_CachedNetworkType;

	[Token(Token = "0x401B355")]
	[FieldOffset(Offset = "0x34")]
	private Thread m_BackgroundThread;

	[Token(Token = "0x401B356")]
	[FieldOffset(Offset = "0x38")]
	private DateTime m_StartTime;

	[Token(Token = "0x401B357")]
	[FieldOffset(Offset = "0x48")]
	private Action m_BackgroundFinishedCallBack;

	[Token(Token = "0x401B358")]
	[FieldOffset(Offset = "0x4C")]
	private Action<ResVersionInfo.FileInfo> m_LoaderFinishedCallBack;

	[Token(Token = "0x401B359")]
	[FieldOffset(Offset = "0x50")]
	private List<ResFileLoader> m_FinishedLoader;

	[Token(Token = "0x601A5C0")]
	[Address(RVA = "0x3336B74", Offset = "0x3336B74", VA = "0x3336B74")]
	public ResFileLoaderController(int maxLoaderCountSimultaneously)
	{
	}

	[Token(Token = "0x601A5C1")]
	[Address(RVA = "0x3336D00", Offset = "0x3336D00", VA = "0x3336D00")]
	public void AddLoader(ResFileLoader loader, bool addToFirst = false)
	{
	}

	[Token(Token = "0x601A5C2")]
	[Address(RVA = "0x3336FA4", Offset = "0x3336FA4", VA = "0x3336FA4")]
	public void RemoveLoader(ResFileLoader loader)
	{
	}

	[Token(Token = "0x601A5C3")]
	[Address(RVA = "0x333710C", Offset = "0x333710C", VA = "0x333710C")]
	public void RemoveLoaderForDelete(ResFileLoader loader)
	{
	}

	[Token(Token = "0x601A5C4")]
	[Address(RVA = "0x3337274", Offset = "0x3337274", VA = "0x3337274")]
	public bool MoveToFirstLoader(List<ResFileLoader> loaders)
	{
		return default(bool);
	}

	[Token(Token = "0x601A5C5")]
	[Address(RVA = "0x333747C", Offset = "0x333747C", VA = "0x333747C")]
	public void Clear()
	{
	}

	[Token(Token = "0x601A5C6")]
	[Address(RVA = "0x33375CC", Offset = "0x33375CC", VA = "0x33375CC")]
	public float GetSizeLoaded()
	{
		return default(float);
	}

	[Token(Token = "0x601A5C7")]
	[Address(RVA = "0x33375E0", Offset = "0x33375E0", VA = "0x33375E0")]
	public static void ClearReusedMemMap()
	{
	}

	[Token(Token = "0x601A5C8")]
	[Address(RVA = "0x33378C0", Offset = "0x33378C0", VA = "0x33378C0")]
	public void PauseDownload(bool isPause, bool is_auto_pause)
	{
	}

	[Token(Token = "0x601A5C9")]
	[Address(RVA = "0x33379CC", Offset = "0x33379CC", VA = "0x33379CC")]
	public void AddFilelistFirst(List<ResVersionInfo.FileInfo> infolist)
	{
	}

	[Token(Token = "0x601A5CA")]
	[Address(RVA = "0x3337D80", Offset = "0x3337D80", VA = "0x3337D80")]
	public long Update(float time)
	{
		return default(long);
	}

	[Token(Token = "0x601A5CB")]
	[Address(RVA = "0x33385D4", Offset = "0x33385D4", VA = "0x33385D4")]
	public long UpdateInThread(float time)
	{
		return default(long);
	}

	[Token(Token = "0x601A5CC")]
	[Address(RVA = "0x3338F24", Offset = "0x3338F24", VA = "0x3338F24")]
	public bool IsFinished()
	{
		return default(bool);
	}

	[Token(Token = "0x601A5CD")]
	[Address(RVA = "0x333904C", Offset = "0x333904C", VA = "0x333904C")]
	public bool IsRuningUnZip()
	{
		return default(bool);
	}

	[Token(Token = "0x601A5CE")]
	[Address(RVA = "0x3339170", Offset = "0x3339170", VA = "0x3339170")]
	public ResVersionInfo.FileInfo CurrentDownloadFileInfo()
	{
		return null;
	}

	[Token(Token = "0x601A5CF")]
	[Address(RVA = "0x33392C8", Offset = "0x33392C8", VA = "0x33392C8")]
	public List<ResVersionInfo.FileInfo> GetFileInfoList()
	{
		return null;
	}

	[Token(Token = "0x601A5D0")]
	[Address(RVA = "0x33395AC", Offset = "0x33395AC", VA = "0x33395AC")]
	public bool MyRemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		return default(bool);
	}

	[Token(Token = "0x601A5D1")]
	[Address(RVA = "0x33395B4", Offset = "0x33395B4", VA = "0x33395B4")]
	public void BackGroundThread()
	{
	}

	[Token(Token = "0x601A5D2")]
	[Address(RVA = "0x3339C2C", Offset = "0x3339C2C", VA = "0x3339C2C")]
	public void CacheNetwordInfo(float seconds)
	{
	}

	[Token(Token = "0x601A5D3")]
	[Address(RVA = "0x3339D50", Offset = "0x3339D50", VA = "0x3339D50")]
	public void SetBackgroundFinishedCallback(Action call_back)
	{
	}

	[Token(Token = "0x601A5D4")]
	[Address(RVA = "0x3339D58", Offset = "0x3339D58", VA = "0x3339D58")]
	public void SetLoaderFinishedCallBack([Optional] Action<ResVersionInfo.FileInfo> call_back)
	{
	}

	[Token(Token = "0x601A5D5")]
	[Address(RVA = "0x3338560", Offset = "0x3338560", VA = "0x3338560")]
	private void LoaderRemoveAction(ResVersionInfo.FileInfo fileinfo)
	{
	}

	[Token(Token = "0x601A5D6")]
	[Address(RVA = "0x3339D60", Offset = "0x3339D60", VA = "0x3339D60")]
	public void StartBackgroundThread()
	{
	}

	[Token(Token = "0x601A5D7")]
	[Address(RVA = "0x3339D74", Offset = "0x3339D74", VA = "0x3339D74")]
	public void ClearBackgroundThread()
	{
	}

	[Token(Token = "0x601A5D8")]
	[Address(RVA = "0x3339EE8", Offset = "0x3339EE8", VA = "0x3339EE8")]
	public void OnApplicationPaused(bool is_paused)
	{
	}
}
