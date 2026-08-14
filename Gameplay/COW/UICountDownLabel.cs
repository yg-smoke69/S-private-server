using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2004138")]
public class UICountDownLabel : MonoBehaviour
{
	[Token(Token = "0x401B603")]
	[FieldOffset(Offset = "0xC")]
	public UILabel m_Label;

	[Token(Token = "0x401B604")]
	[FieldOffset(Offset = "0x10")]
	private ulong endTime;

	[Token(Token = "0x401B605")]
	[FieldOffset(Offset = "0x18")]
	private string m_Prefix;

	[Token(Token = "0x401B606")]
	[FieldOffset(Offset = "0x1C")]
	private string m_Suffix;

	[Token(Token = "0x401B607")]
	[FieldOffset(Offset = "0x20")]
	private bool m_Formated;

	[Token(Token = "0x401B608")]
	[FieldOffset(Offset = "0x21")]
	private bool m_ShortDisplay;

	[Token(Token = "0x401B609")]
	[FieldOffset(Offset = "0x22")]
	private bool m_FuzzyDisplay;

	[Token(Token = "0x401B60A")]
	[FieldOffset(Offset = "0x24")]
	public OnStarted m_OnStarted;

	[Token(Token = "0x401B60B")]
	[FieldOffset(Offset = "0x28")]
	public OnFinished m_OnFinished;

	[Token(Token = "0x401B60C")]
	[FieldOffset(Offset = "0x2C")]
	public OnUpdate m_OnUpdate;

	[Token(Token = "0x401B60D")]
	[FieldOffset(Offset = "0x30")]
	private uint m_DelayCall;

	[Token(Token = "0x401B60E")]
	[FieldOffset(Offset = "0x34")]
	private string m_fmtStringIDStyle;

	[Token(Token = "0x601AA61")]
	[Address(RVA = "0x1EC2370", Offset = "0x1EC2370", VA = "0x1EC2370")]
	public UICountDownLabel()
	{
	}

	[Token(Token = "0x601AA62")]
	[Address(RVA = "0x1EC2424", Offset = "0x1EC2424", VA = "0x1EC2424")]
	public void SetCountDownEndTime(ulong end, bool shortDisplay)
	{
	}

	[Token(Token = "0x601AA63")]
	[Address(RVA = "0x1EC07E4", Offset = "0x1EC07E4", VA = "0x1EC07E4")]
	public void SetCountDownEndTime(ulong end, string prefix = "", string suffix = "", bool formated = true, [Optional] OnStarted onStarted, [Optional] OnFinished onFinished, bool shortDisplay = true, bool isStarted = true, bool fuzzyDisplay = false)
	{
	}

	[Token(Token = "0x601AA64")]
	[Address(RVA = "0x1EC2A18", Offset = "0x1EC2A18", VA = "0x1EC2A18")]
	public void SetCountDownEndTime(CountDownConfig config)
	{
	}

	[Token(Token = "0x601AA65")]
	[Address(RVA = "0x1EC2BA0", Offset = "0x1EC2BA0", VA = "0x1EC2BA0")]
	public void SetUpdateDelegate(OnUpdate callback)
	{
	}

	[Token(Token = "0x601AA66")]
	[Address(RVA = "0x1EC2C00", Offset = "0x1EC2C00", VA = "0x1EC2C00")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x601AA67")]
	[Address(RVA = "0x1EC2CF8", Offset = "0x1EC2CF8", VA = "0x1EC2CF8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x601AA68")]
	[Address(RVA = "0x1EC2554", Offset = "0x1EC2554", VA = "0x1EC2554")]
	private void CountDown()
	{
	}

	[Token(Token = "0x601AA69")]
	[Address(RVA = "0x1EC2D58", Offset = "0x1EC2D58", VA = "0x1EC2D58")]
	public bool IsDuringCountDown()
	{
		return default(bool);
	}

	[Token(Token = "0x601AA6A")]
	[Address(RVA = "0x1EC1DB0", Offset = "0x1EC1DB0", VA = "0x1EC1DB0")]
	public void Cancel()
	{
	}

	[Token(Token = "0x601AA6B")]
	[Address(RVA = "0x1EC2DBC", Offset = "0x1EC2DBC", VA = "0x1EC2DBC")]
	public void SetFormatStyle(string fmtStringID)
	{
	}
}
