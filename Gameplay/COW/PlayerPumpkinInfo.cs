using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200226C")]
public class PlayerPumpkinInfo : MonoBehaviour
{
	[Token(Token = "0x400D735")]
	[FieldOffset(Offset = "0xC")]
	public UILabel NumLabel;

	[Token(Token = "0x400D736")]
	[FieldOffset(Offset = "0x10")]
	private int m_CurNum;

	[Token(Token = "0x600BC00")]
	[Address(RVA = "0x1C0B160", Offset = "0x1C0B160", VA = "0x1C0B160")]
	public PlayerPumpkinInfo()
	{
	}

	[Token(Token = "0x600BC01")]
	[Address(RVA = "0x1C0B170", Offset = "0x1C0B170", VA = "0x1C0B170")]
	public void SetNum(int num)
	{
	}
}
