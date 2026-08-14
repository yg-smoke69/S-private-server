using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000706")]
public class PickupTreasureBox : MonoBehaviour
{
	[Token(Token = "0x4004BE0")]
	[FieldOffset(Offset = "0xC")]
	public GameObject VFX_TreasureEffect;

	[Token(Token = "0x4004BE1")]
	[FieldOffset(Offset = "0x10")]
	public GameObject TreasureBoxModel;

	[Token(Token = "0x4004BE2")]
	[FieldOffset(Offset = "0x14")]
	public bool m_IsDiggedOut;

	[Token(Token = "0x6002CC8")]
	[Address(RVA = "0xBD139C", Offset = "0xBD139C", VA = "0xBD139C")]
	public PickupTreasureBox()
	{
	}

	[Token(Token = "0x6002CC9")]
	[Address(RVA = "0xBD13A4", Offset = "0xBD13A4", VA = "0xBD13A4")]
	private void Start()
	{
	}

	[Token(Token = "0x6002CCA")]
	[Address(RVA = "0xBD145C", Offset = "0xBD145C", VA = "0xBD145C")]
	public void SyncStatus(bool IMNKGOOFJFN = false)
	{
	}
}
