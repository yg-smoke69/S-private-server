using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200336C")]
public class UITimeLabelHelper
{
	[Token(Token = "0x4013948")]
	[FieldOffset(Offset = "0x8")]
	public UILabel Label;

	[Token(Token = "0x4013949")]
	[FieldOffset(Offset = "0xC")]
	public float RedLabelSeconds;

	[Token(Token = "0x401394A")]
	[FieldOffset(Offset = "0x10")]
	public Color TextNormalColor;

	[Token(Token = "0x401394B")]
	[FieldOffset(Offset = "0x20")]
	public bool Inited;

	[Token(Token = "0x401394C")]
	[FieldOffset(Offset = "0x24")]
	private StringBuilder m_Timer;

	[Token(Token = "0x401394D")]
	[FieldOffset(Offset = "0x28")]
	private int m_LastSeconds;

	[Token(Token = "0x401394E")]
	[FieldOffset(Offset = "0x2C")]
	private EUITimeUpdateType m_TimeUpdateMethod;

	[Token(Token = "0x401394F")]
	[FieldOffset(Offset = "0x30")]
	private float m_TimeBase;

	[Token(Token = "0x4013950")]
	[FieldOffset(Offset = "0x34")]
	private float m_TimeTarget;

	[Token(Token = "0x4013951")]
	[FieldOffset(Offset = "0x38")]
	private string m_ExtraString;

	[Token(Token = "0x4013952")]
	[FieldOffset(Offset = "0x3C")]
	private string m_Suffix;

	[Token(Token = "0x4013953")]
	[FieldOffset(Offset = "0x40")]
	private string m_LocKey;

	[Token(Token = "0x4013954")]
	[FieldOffset(Offset = "0x44")]
	public EUITimeUpdateStyle showSytle;

	[Token(Token = "0x170016D4")]
	public EUITimeUpdateType TimeUpdateMethod
	{
		[Token(Token = "0x6015DDC")]
		[Address(RVA = "0x201AF14", Offset = "0x201AF14", VA = "0x201AF14")]
		get
		{
			return default(EUITimeUpdateType);
		}
	}

	[Token(Token = "0x6015DDB")]
	[Address(RVA = "0x201AE00", Offset = "0x201AE00", VA = "0x201AE00")]
	public UITimeLabelHelper()
	{
	}

	[Token(Token = "0x6015DDD")]
	[Address(RVA = "0x201AF6C", Offset = "0x201AF6C", VA = "0x201AF6C")]
	public void Init(object[] data)
	{
	}

	[Token(Token = "0x6015DDE")]
	[Address(RVA = "0x201B1C0", Offset = "0x201B1C0", VA = "0x201B1C0")]
	public void Update()
	{
	}

	[Token(Token = "0x6015DDF")]
	[Address(RVA = "0x201B240", Offset = "0x201B240", VA = "0x201B240")]
	public float GetSeconds()
	{
		return default(float);
	}

	[Token(Token = "0x6015DE0")]
	[Address(RVA = "0x201B3E0", Offset = "0x201B3E0", VA = "0x201B3E0")]
	private void UpdateTimeSeconds(int seconds)
	{
	}

	[Token(Token = "0x6015DE1")]
	[Address(RVA = "0x201B958", Offset = "0x201B958", VA = "0x201B958")]
	public bool IsTimeout()
	{
		return default(bool);
	}

	[Token(Token = "0x6015DE2")]
	[Address(RVA = "0x201BA54", Offset = "0x201BA54", VA = "0x201BA54")]
	public void StopTicking()
	{
	}
}
