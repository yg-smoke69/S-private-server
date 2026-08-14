using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003F51")]
public class FPSCounter : MonoBehaviour
{
	[Token(Token = "0x401AB0A")]
	[FieldOffset(Offset = "0x0")]
	public static FPSCounter instance;

	[Token(Token = "0x401AB0B")]
	private const float fpsMeasurePeriod = 0.5f;

	[Token(Token = "0x401AB0C")]
	[FieldOffset(Offset = "0xC")]
	private int m_FpsAccumulator;

	[Token(Token = "0x401AB0D")]
	[FieldOffset(Offset = "0x10")]
	private float m_FpsNextPeriod;

	[Token(Token = "0x401AB0E")]
	[FieldOffset(Offset = "0x14")]
	private int m_CurrentFps;

	[Token(Token = "0x6019C81")]
	[Address(RVA = "0x32A7ED4", Offset = "0x32A7ED4", VA = "0x32A7ED4")]
	public FPSCounter()
	{
	}

	[Token(Token = "0x6019C82")]
	[Address(RVA = "0x32A7EDC", Offset = "0x32A7EDC", VA = "0x32A7EDC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6019C83")]
	[Address(RVA = "0x32A7F6C", Offset = "0x32A7F6C", VA = "0x32A7F6C")]
	private void Start()
	{
	}

	[Token(Token = "0x6019C84")]
	[Address(RVA = "0x32A7F94", Offset = "0x32A7F94", VA = "0x32A7F94")]
	private void Update()
	{
	}

	[Token(Token = "0x6019C85")]
	[Address(RVA = "0x32A7FF8", Offset = "0x32A7FF8", VA = "0x32A7FF8")]
	public int GetCurrentFPS()
	{
		return default(int);
	}
}
