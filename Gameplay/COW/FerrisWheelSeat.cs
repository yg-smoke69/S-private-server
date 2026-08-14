using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20005C0")]
public class FerrisWheelSeat : MonoBehaviour
{
	[Token(Token = "0x40043B9")]
	[FieldOffset(Offset = "0x10")]
	public IHAAMHPPLMG CurHoldPlayer;

	[Token(Token = "0x40043BA")]
	[FieldOffset(Offset = "0x28")]
	public uint Index;

	[Token(Token = "0x60022E0")]
	[Address(RVA = "0xDE5384", Offset = "0xDE5384", VA = "0xDE5384")]
	public FerrisWheelSeat()
	{
	}

	[Token(Token = "0x60022E1")]
	[Address(RVA = "0xDE5430", Offset = "0xDE5430", VA = "0xDE5430")]
	public bool CanGetOn()
	{
		return default(bool);
	}

	[Token(Token = "0x60022E2")]
	[Address(RVA = "0xDE557C", Offset = "0xDE557C", VA = "0xDE557C")]
	public void SetPlayer(IHAAMHPPLMG p)
	{
	}
}
