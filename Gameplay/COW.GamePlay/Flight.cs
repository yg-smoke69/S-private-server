using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20007B4")]
internal class Flight : MonoBehaviour
{
	[Token(Token = "0x4004F7C")]
	[FieldOffset(Offset = "0xC")]
	public GameObject m_HighSpeedEffect;

	[Token(Token = "0x4004F7D")]
	[FieldOffset(Offset = "0x10")]
	public GameObject m_MidSpeedEffect;

	[Token(Token = "0x4004F7E")]
	[FieldOffset(Offset = "0x14")]
	public GameObject m_LowSpeedEffect;

	[Token(Token = "0x4004F7F")]
	[FieldOffset(Offset = "0x18")]
	private BODBFOBLNBG ENBABBNDCJA;

	[Token(Token = "0x4004F80")]
	[FieldOffset(Offset = "0x1C")]
	private float ENINMMEHJIE;

	[Token(Token = "0x4004F81")]
	private const float KBGODMDGBCD = 0.1f;

	[Token(Token = "0x4004F82")]
	[FieldOffset(Offset = "0x20")]
	private bool GPONKLLPPHO;

	[Token(Token = "0x4004F83")]
	[FieldOffset(Offset = "0x24")]
	public Animator m_Animator;

	[Token(Token = "0x600310A")]
	[Address(RVA = "0x1DA32A4", Offset = "0x1DA32A4", VA = "0x1DA32A4")]
	public Flight()
	{
	}

	[Token(Token = "0x600310B")]
	[Address(RVA = "0x1DA32AC", Offset = "0x1DA32AC", VA = "0x1DA32AC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600310C")]
	[Address(RVA = "0x1DA33C4", Offset = "0x1DA33C4", VA = "0x1DA33C4")]
	public void SetHorizontalSpeed(float OJGNBJELDEM)
	{
	}

	[Token(Token = "0x600310D")]
	[Address(RVA = "0x1DA3688", Offset = "0x1DA3688", VA = "0x1DA3688")]
	public void SetSkyStatus(BODBFOBLNBG ALNGJKMKLGJ)
	{
	}

	[Token(Token = "0x600310E")]
	[Address(RVA = "0x1DA36F4", Offset = "0x1DA36F4", VA = "0x1DA36F4")]
	public void PlayStartFlightSkyDiving(bool GKDIBCKHHFC)
	{
	}

	[Token(Token = "0x600310F")]
	[Address(RVA = "0x1DA3828", Offset = "0x1DA3828", VA = "0x1DA3828")]
	public void PlayStartFlightParachuting(bool INMJCOKOMDP)
	{
	}

	[Token(Token = "0x6003110")]
	[Address(RVA = "0x1DA395C", Offset = "0x1DA395C", VA = "0x1DA395C")]
	public void PlayStartSkyDriving(bool INMJCOKOMDP)
	{
	}

	[Token(Token = "0x6003111")]
	[Address(RVA = "0x1DA3A90", Offset = "0x1DA3A90", VA = "0x1DA3A90")]
	public void SetSkydivingSpeed(float INEJHIDOPDE)
	{
	}

	[Token(Token = "0x6003112")]
	[Address(RVA = "0x1DA3BA8", Offset = "0x1DA3BA8", VA = "0x1DA3BA8")]
	public void SetSkysurfingSpeed(float INEJHIDOPDE)
	{
	}

	[Token(Token = "0x6003113")]
	[Address(RVA = "0x1DA3474", Offset = "0x1DA3474", VA = "0x1DA3474")]
	public void UpdateEffect()
	{
	}
}
