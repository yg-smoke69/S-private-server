using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2000869")]
internal class PCGunTraceEffect : ReusableObject
{
	[Token(Token = "0x400528A")]
	[FieldOffset(Offset = "0x18")]
	public float GunTraceLength;

	[Token(Token = "0x400528B")]
	[FieldOffset(Offset = "0x1C")]
	public float GunTraceSpeed;

	[Token(Token = "0x400528C")]
	[FieldOffset(Offset = "0x20")]
	public float SniperGunTraceSpeed;

	[Token(Token = "0x400528D")]
	[FieldOffset(Offset = "0x24")]
	public float GunSmokeFadeTime;

	[Token(Token = "0x400528E")]
	[FieldOffset(Offset = "0x28")]
	public float SniperGunSmokeFadeTime;

	[Token(Token = "0x400528F")]
	[FieldOffset(Offset = "0x2C")]
	public float Mobile1PSniperGunSmokeFadeTime;

	[Token(Token = "0x4005290")]
	[FieldOffset(Offset = "0x30")]
	public LineRenderer TraceRenderer;

	[Token(Token = "0x4005291")]
	[FieldOffset(Offset = "0x34")]
	public LineRenderer SmokeRender;

	[Token(Token = "0x4005292")]
	[FieldOffset(Offset = "0x38")]
	private float m_TraceFlyTime;

	[Token(Token = "0x4005293")]
	[FieldOffset(Offset = "0x3C")]
	private float m_StartTime;

	[Token(Token = "0x4005294")]
	[FieldOffset(Offset = "0x40")]
	private float m_BlendFactor;

	[Token(Token = "0x4005295")]
	[FieldOffset(Offset = "0x44")]
	private Material m_TraceMat;

	[Token(Token = "0x4005296")]
	[FieldOffset(Offset = "0x48")]
	private Material m_SmokeMat;

	[Token(Token = "0x4005297")]
	[FieldOffset(Offset = "0x4C")]
	private Color m_SmokeStartColor;

	[Token(Token = "0x4005298")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 m_StartPos;

	[Token(Token = "0x4005299")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 m_Speed;

	[Token(Token = "0x400529A")]
	[FieldOffset(Offset = "0x74")]
	private float m_GunTraceAllShowTime;

	[Token(Token = "0x400529B")]
	[FieldOffset(Offset = "0x78")]
	private float m_GunSmokeFadeTime;

	[Token(Token = "0x400529C")]
	[FieldOffset(Offset = "0x7C")]
	private float m_GunTraceSpeed;

	[Token(Token = "0x6003ADA")]
	[Address(RVA = "0x2980220", Offset = "0x2980220", VA = "0x2980220")]
	public PCGunTraceEffect()
	{
	}

	[Token(Token = "0x6003ADB")]
	[Address(RVA = "0x2980268", Offset = "0x2980268", VA = "0x2980268")]
	private void Start()
	{
	}

	[Token(Token = "0x6003ADC")]
	[Address(RVA = "0x2980438", Offset = "0x2980438", VA = "0x2980438", Slot = "4")]
	public override void Prepare()
	{
	}

	[Token(Token = "0x6003ADD")]
	[Address(RVA = "0x2980700", Offset = "0x2980700", VA = "0x2980700")]
	public void StartSimulate(Vector3 start, Vector3 end, bool isSniper, bool mobile1P)
	{
	}

	[Token(Token = "0x6003ADE")]
	[Address(RVA = "0x2980A64", Offset = "0x2980A64", VA = "0x2980A64")]
	private void Update()
	{
	}
}
