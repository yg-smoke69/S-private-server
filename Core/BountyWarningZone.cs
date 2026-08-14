using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B1B")]
public class BountyWarningZone : MonoBehaviour
{
	[Token(Token = "0x4005FE0")]
	[FieldOffset(Offset = "0xC")]
	public GameObject RedZone;

	[Token(Token = "0x4005FE1")]
	[FieldOffset(Offset = "0x10")]
	public GameObject BlueZone;

	[Token(Token = "0x4005FE2")]
	[FieldOffset(Offset = "0x14")]
	private int m_RedZoneUseCount;

	[Token(Token = "0x4005FE3")]
	[FieldOffset(Offset = "0x18")]
	private int m_BlueZoneUseCount;

	[Token(Token = "0x600554C")]
	[Address(RVA = "0x14B70F4", Offset = "0x14B70F4", VA = "0x14B70F4")]
	public BountyWarningZone()
	{
	}

	[Token(Token = "0x600554D")]
	[Address(RVA = "0x14B70FC", Offset = "0x14B70FC", VA = "0x14B70FC")]
	public void ShowZone(bool isIceZone)
	{
	}

	[Token(Token = "0x600554E")]
	[Address(RVA = "0x14B715C", Offset = "0x14B715C", VA = "0x14B715C")]
	public void HideZone(bool isIceZone)
	{
	}
}
