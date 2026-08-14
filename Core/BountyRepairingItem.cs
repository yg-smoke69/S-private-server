using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001FED")]
public class BountyRepairingItem : MonoBehaviour
{
	[Token(Token = "0x400C8C9")]
	[FieldOffset(Offset = "0xC")]
	public UILabel PlayerName;

	[Token(Token = "0x400C8CA")]
	[FieldOffset(Offset = "0x10")]
	public UILabel PlayerPoint;

	[Token(Token = "0x400C8CB")]
	[FieldOffset(Offset = "0x14")]
	public ParticleSystem Effec;

	[Token(Token = "0x600A111")]
	[Address(RVA = "0x2ED7544", Offset = "0x2ED7544", VA = "0x2ED7544")]
	public BountyRepairingItem()
	{
	}

	[Token(Token = "0x600A112")]
	[Address(RVA = "0x2ED754C", Offset = "0x2ED754C", VA = "0x2ED754C")]
	public void PlayEffect()
	{
	}
}
